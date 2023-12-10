Public Class frmreceipts
    Sub stuno()
        ComboBox1.Items.Clear()
        sql = "select distinct(StudentId) from tbl_MessBill"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While rs.EOF = False
            ComboBox1.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
   

    Private Sub frmreceipts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        stuno()
        recno()

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i = 0
        sql = "select * from tbl_MessBill where StudentId='" & ComboBox1.Text & "' and BMonth='" & ComboBox2.Text & "' and Byear='" & ComboBox3.Text & "' "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)


        If rs.EOF = False Then
            DataGridView1.Item(0, i).Value = rs(4).Value
            DataGridView1.Item(1, i).Value = rs(2).Value
            DataGridView1.Item(2, i).Value = rs(5).Value
            DataGridView1.Item(3, i).Value = rs(6).Value
            DataGridView1.Item(4, i).Value = rs(7).Value
            DataGridView1.Item(5, i).Value = rs(8).Value
        End If
    End Sub

  
    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
       
    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged
        Dim i = 0
        txtbalance.Text = Val(DataGridView1.Item(5, i).Value) - Val(txtamount.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i = 0
        sql = "insert into tbl_receipts(StudentID,StudentName,month,year,billno,actualamt,receiptno,receiptdate,amountpaid,blancedue)"
        sql = sql & "values('" & ComboBox1.Text & "','" & DataGridView1.Item(0, i).Value & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & DataGridView1.Item(1, i).Value & "','" & DataGridView1.Item(5, i).Value & "','" & txtrno.Text & "',convert(date,'" & DateTimePicker1.Value & "',103),'" & txtamount.Text & "','" & txtbalance.Text & "')"
        conn.Execute(sql)
        MsgBox("Added successfully")
    End Sub
    Sub recno()
        Dim j
        j = 100
        txtrno.Text = j
        sql = "select max(receiptno) from tbl_receipts"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)



        If rs.EOF = False Then
            j = rs(0).Value
            j = j + 1
            txtrno.Text = j
        End If

    End Sub
End Class