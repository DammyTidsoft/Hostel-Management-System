Public Class frmlogin

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If cmbusertype.Text = "" Then
            MsgBox("enter user type")
        ElseIf txtusername.Text = "" Then
            MsgBox("enter user name")
        ElseIf txtpassword.Text = "" Then
            MsgBox("enterpassword")

        Else

            sql = "select * from tbl_login where User_Type='" & cmbusertype.Text & "' and User_name='" & txtusername.Text & "' and Password='" & txtpassword.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                MsgBox("login successfull", MsgBoxStyle.Information)
                Frmmaster.Show()
                Me.Hide()

            Else
                MsgBox("invalid user ", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class
