Public Class frmyear

    Private Sub frmyear_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        sql = "select * from tbl_year"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtfrom.Text = rs(0).Value
            txtto.Text = rs(1).Value
        End If
    End Sub

    Private Sub btnapply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnapply.Click
        If MsgBoxResult.No = MsgBox("Do you want to Apply the Current Year Settings", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") Then Exit Sub
        If txtfrom.Text = "" Or txtto.Text = "" Then
            MsgBox("Please enter the values", MsgBoxStyle.Exclamation, "warning")
        Else
            sql = "select * from tbl_year"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = True Then
                sql = "insert into tbl_year(From_Year,To_Year)values('" & txtfrom.Text & "','" & txtto.Text & "')"
                conn.Execute(sql)
                MsgBox("Current year settings are applied", MsgBoxStyle.Information)
            Else
                sql = "update tbl_year set from_year='" & txtfrom.Text & "',to_year='" & txtto.Text & "'"
                conn.Execute(sql)
                MsgBox("Current year settings are applied", MsgBoxStyle.Information)
            End If
        End If
    End Sub

   
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class