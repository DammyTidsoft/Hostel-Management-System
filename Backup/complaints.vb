Public Class complaints

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        sql = "insert into tbl_complaints(Student_Name,Date,Complaints,Status)"
        sql = sql & "values('" & txtsname.Text & "',convert(date,'" & dtpad_date.Value & "',105),'" & txtcomplaints.Text & "','" & combstatus.Text & "')"
        conn.Execute(sql)
        MsgBox("Complaints added successfully")
        clear()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Sub clear()
        txtsname.Text = ""
        txtcomplaints.Text = ""
        combstatus.Text = ""
    End Sub

    Private Sub complaints_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        OpenDB()
        If complaint = True Then
            sql = "select * from tbl_complaints where Student_name='" & sname & "' "
        
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                txtsname.Text = rs(0).Value
                dtpad_date.Value = rs(1).Value
                txtcomplaints.Text = rs(2).Value
                combstatus.Text = rs(3).Value

            End If

            complaint = False

        End If
       

    End Sub

    
    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        frmviewcomplaints.MdiParent = Frmmaster
        frmviewcomplaints.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sql = "update tbl_complaints set status='" & combstatus.Text & "' where Student_Name='" & txtsname.Text & "'  "
        conn.Execute(sql)
        MsgBox("record updated")
        clear()

       
    End Sub
End Class