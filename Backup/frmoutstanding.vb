Public Class frmoutstanding
    Sub stuno()
        ComboBox1.Items.Clear()
        sql = "select StudentId from tbl_receipts where blancedue>0"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While rs.EOF = False
            ComboBox1.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    Sub loadgrid()

        Dim i
        i = 0
        sql = " select * from tbl_receipts where blancedue>0 "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)

        DataGridView1.Rows.Clear()
        Do While rs.EOF = False
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(1).Value
            DataGridView1.Item(1, i).Value = rs(4).Value
            DataGridView1.Item(2, i).Value = rs(5).Value
            DataGridView1.Item(3, i).Value = rs(8).Value
            DataGridView1.Item(4, i).Value = rs(9).Value
          


            rs.MoveNext()
            i = i + 1
        Loop

    End Sub

    Private Sub frmoutstanding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        stuno()
        loadgrid()

    End Sub
    Dim i = 0
    Sub xyz()

        sql = "select * from tbl_receipts where StudentId='" & ComboBox1.Text & "' and month='" & ComboBox2.Text & "' and year='" & ComboBox3.Text & "'  "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()

        If rs.EOF = False Then
            DataGridView1.Item(0, i).Value = rs(1).Value
            DataGridView1.Item(1, i).Value = rs(4).Value
            DataGridView1.Item(2, i).Value = rs(5).Value
            DataGridView1.Item(3, i).Value = rs(8).Value
            DataGridView1.Item(4, i).Value = rs(9).Value
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        xyz()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a
        a = (DataGridView1.Item(4, i).Value) - Val(txtamount.Text)
        sql = " update tbl_receipts set blancedue='" & a & "',amountpaid=amountpaid+ '" & txtamount.Text & "' where StudentId='" & ComboBox1.Text & "' and month='" & ComboBox2.Text & "' and year='" & ComboBox3.Text & "'"
        conn.Execute(sql)
        MsgBox("paid")
        xyz()
    End Sub
End Class