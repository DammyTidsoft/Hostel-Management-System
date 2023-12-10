Public Class frmvisitor

    Private Sub frmvisitor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear()
    End Sub

    Private Sub frmvisitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        If visitor = True Then
            sql = "select * from tbl_visitors where Visitors_Name='" & visitor_name & "' and date=convert(char,'" & vdate & "',105)"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                txtvname.Text = rs(0).Value
                dtpad_date.Value = rs(1).Value
                txtvaddress.Text = rs(3).Value
                txtvphoneno.Text = rs(4).Value
                txtsname.Text = rs(2).Value
            End If
            lstname.Visible = False
            visitor = False
        End If
        End Sub
    Sub clear()
        txtvname.Clear()
        txtsname.Clear()
        txtvaddress.Clear()
        txtvphoneno.Clear()
        dtpad_date.Value = Today.Date
        lstname.Items.Clear()
        lstname.Visible = False
    End Sub
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clear()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtvname.Text = "" Then
            MsgBox("enter visitor name")
        ElseIf txtsname.Text = "" Then
            MsgBox("enter student name")
       
        ElseIf txtvphoneno.Text = "" Then
            MsgBox("enter phone number")
        Else

sql = "insert into tbl_visitors(Visitors_Name,Date,Student_Name,Address,Phone_no)"
            sql = sql & "values('" & txtvname.Text & "',convert(date,'" & dtpad_date.Value & "',105),'" & txtsname.Text & "','" & txtvaddress.Text & "','" & txtvphoneno.Text & "')"
            conn.Execute(sql)
            MsgBox("Visitors Details Added successfully")
            clear()
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub txtsname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsname.TextChanged
        If txtsname.Text = "" Then
            lstname.Visible = False
        End If
        lstname.Items.Clear()
        lstname.Visible = False
        sql = "select student_Name from tbl_admission where Student_Name like '%" & txtsname.Text & "%'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            lstname.Visible = True
            lstname.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub lstname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstname.SelectedIndexChanged
        txtsname.Text = lstname.SelectedItem.ToString
        lstname.Visible = False
    End Sub

    Private Sub BTNVIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNVIEW.Click
        frmviewvistors.MdiParent = Frmmaster
        frmviewvistors.Show()
        Me.Close()
    End Sub

    Private Sub txtvname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvname.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtvname.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
End Class