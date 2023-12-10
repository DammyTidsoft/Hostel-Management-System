Public Class frmmessbill

    Public billno, expenditure, no_of_students, messbill, no_of_days, perday
    Public month, year, count, days_month, additionalCharge, a, i, deduction As Integer
    Private Sub btngenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerate.Click
        count = 0
        a = 0
        additionalCharge = 0
        Dim lastdate As New DateTime(year, month, 1)
        lastdate = lastdate.AddMonths(1)
        lastdate = lastdate.AddDays(-(lastdate.Day))
        days_month = lastdate.Day

        sql = "select * from tbl_MessBill where Bmonth='" & cmbmonth.Text & "' and Byear='" & cmbyear.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            MsgBox("Mess Bill Already generated for this Month", MsgBoxStyle.Information)
        Else
            sql = "select max(BillNo)+1 from tbl_MessBill"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                If IsDBNull(rs(0).Value) = True Then
                    billno = "1"
                Else
                    billno = rs(0).Value
                End If
            End If
            sql = "select total_exp from tbl_expenditure where Month='" & cmbmonth.Text & "' and Year='" & cmbyear.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                expenditure = rs(0).Value
            End If
            sql = "select count(*) from tbl_admission"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                no_of_students = rs(0).Value
            End If
            messbill = Math.Round(Val(expenditure) / Val(no_of_students))
            perday = Math.Round(Val(messbill) / Val(days_month))
            sql = "select month(todate),datediff(day,fromdate,todate) from tbl_leave where month(fromdate)='" & month & "' and datediff(day,fromdate,todate)>7"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            Do While Not rs.EOF
                'when fromdate and todate months are different
                If rs(0).Value <> month Then
                    no_of_days = DateDiff(DateInterval.Day, rs(0).Value, lastdate)
                    If no_of_days < 7 Then
                        GoTo l1
                    Else
                        a = Math.Round(Val(perday) * Val(no_of_days))
                        additionalCharge = additionalCharge + a
                        count = count + 1
                    End If
                Else
                    'when fromdate and todate month are equal
                    no_of_days = rs(1).Value
                    a = Math.Round(Val(perday) * Val(no_of_days))
                    additionalCharge = additionalCharge + a
                    count = count + 1
                End If
                rs.MoveNext()
l1:         Loop
            deduction = Val(additionalCharge)
            additionalCharge = Math.Round(Val(additionalCharge) / (Val(no_of_students) - Val(count)))
            i = 0
            sql = "select * from tbl_admission"
            If rss.State = 1 Then rss.Close()
            rss.Open(sql, conn)
            Do While Not rss.EOF
                dgvmessbill.Rows.Add()
                dgvmessbill.Item(0, i).Value = billno
                dgvmessbill.Item(1, i).Value = rss(0).Value
                dgvmessbill.Item(2, i).Value = rss(2).Value
                dgvmessbill.Item(3, i).Value = messbill
                sql = "select month(todate),datediff(day,fromdate,todate) from tbl_leave where month(fromdate)='" & month & "' and datediff(day,fromdate,todate)<7 and Admission_No='" & rss(0).Value & "'"
                If rs.State = 1 Then rs.Close()
                rs.Open(sql, conn)
                If rs.EOF = False Then
                    'when fromdate and todate months are different
                    'If rs(0).Value <> month Then
                    '    no_of_days = DateDiff(DateInterval.Day, rs(0).Value, lastdate)
                    '    If no_of_days < 7 Then
                    dgvmessbill.Item(4, i).Value = Val(additionalCharge)
                    dgvmessbill.Item(5, i).Value = 0
                    dgvmessbill.Item(6, i).Value = Val(dgvmessbill.Item(3, i).Value) + Val(dgvmessbill.Item(4, i).Value) - Val(dgvmessbill.Item(5, i).Value)
                Else
                    sql = "select month(todate),datediff(day,fromdate,todate) from tbl_leave where month(fromdate)='" & month & "' and datediff(day,fromdate,todate)>7 and Admission_No='" & rss(0).Value & "'"
                    If rs.State = 1 Then rs.Close()
                    rs.Open(sql, conn)
                    If rs.EOF = False Then
                        'when fromdate and todate months are different
                        If rs(0).Value <> month Then
                            no_of_days = DateDiff(DateInterval.Day, rs(0).Value, lastdate)
                            If no_of_days < 7 Then
                                dgvmessbill.Item(4, i).Value = Val(additionalCharge)
                                dgvmessbill.Item(5, i).Value = 0
                                dgvmessbill.Item(6, i).Value = Val(dgvmessbill.Item(3, i).Value) + Val(dgvmessbill.Item(4, i).Value) - Val(dgvmessbill.Item(5, i).Value)

                            Else
                                a = Val(perday) * Val(no_of_days)
                                dgvmessbill.Item(4, i).Value = 0
                                dgvmessbill.Item(5, i).Value = Val(deduction)
                                dgvmessbill.Item(6, i).Value = Val(dgvmessbill.Item(3, i).Value) + Val(dgvmessbill.Item(4, i).Value) - Val(dgvmessbill.Item(5, i).Value)

                            End If
                        Else
                            dgvmessbill.Item(4, i).Value = 0
                            dgvmessbill.Item(5, i).Value = Val(deduction)
                            dgvmessbill.Item(6, i).Value = Val(dgvmessbill.Item(3, i).Value) + Val(dgvmessbill.Item(4, i).Value) - Val(dgvmessbill.Item(5, i).Value)

                        End If
                    Else
                        dgvmessbill.Item(4, i).Value = Val(additionalCharge)
                        dgvmessbill.Item(5, i).Value = 0
                        dgvmessbill.Item(6, i).Value = Val(dgvmessbill.Item(3, i).Value) + Val(dgvmessbill.Item(4, i).Value) - Val(dgvmessbill.Item(5, i).Value)
                    End If
                End If
                rss.MoveNext()
                i = i + 1
                billno = billno + 1
            Loop
        End If
    End Sub

    Private Sub cmbmonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmonth.SelectedIndexChanged
        If cmbmonth.Text = "JANUARY" Then
            month = 1
        ElseIf cmbmonth.Text = "FEBRUARY" Then
            month = 2
     ElseIf cmbmonth.Text = "MARCH" Then
            month = 3
        ElseIf cmbmonth.Text = "APRIL" Then
            month = 4
        ElseIf cmbmonth.Text = "MAY" Then
            month = 5
        ElseIf cmbmonth.Text = "JUNE" Then
            month = 6
        ElseIf cmbmonth.Text = "JULY" Then
            month = 7
        ElseIf cmbmonth.Text = "AUGUST" Then
            month = 8
        ElseIf cmbmonth.Text = "SEPTEMBER" Then
            month = 9
        ElseIf cmbmonth.Text = "OCTOBER" Then
            month = 10
        ElseIf cmbmonth.Text = "NOVEMBER" Then
            month = 11
        ElseIf cmbmonth.Text = "DECEMBER" Then
            month = 12
        End If
    End Sub

    Private Sub cmbyear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbyear.SelectedIndexChanged
        year = cmbyear.Text
    End Sub

    Private Sub frmmessbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i = 0
        Do While i < dgvmessbill.RowCount - 1
            sql = "insert into tbl_MessBill(BMonth,Byear,BillNo,StudentId,StudentName,MessBill,AdditionalCharge,Deduction,AmounttobePaid)"
            sql = sql & "values('" & cmbmonth.Text & "','" & cmbyear.Text & "','" & dgvmessbill.Item(0, i).Value & "','" & dgvmessbill.Item(1, i).Value & "','" & dgvmessbill.Item(2, i).Value & "','" & dgvmessbill.Item(3, i).Value & "','" & dgvmessbill.Item(4, i).Value & "','" & dgvmessbill.Item(5, i).Value & "','" & dgvmessbill.Item(6, i).Value & "')"
            i = i + 1
            conn.Execute(sql)
        Loop
       
        MsgBox("Saved successfully")
    End Sub
End Class