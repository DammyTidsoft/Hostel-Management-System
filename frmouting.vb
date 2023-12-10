Public Class frmouting

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        sql = "insert into tbl_outing_register(Admission_No,StudentName,date,out_time,reason,in_time)"
        sql = sql & "values(' " & ComboBox1.Text & " ','" & txtname.Text & "',convert(date,'" & DateTimePicker1.Value & "',103),convert(time(7),'" & DateTime.Now.ToLongTimeString() & "',105), '" & txtreason.Text & "',convert(time(7),'" & DateTime.Now.ToLongTimeString() & "',105))"
        conn.Execute(sql)
        MsgBox("inserted succesfully")
        loadgrid()
        clear()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "update tbl_outing_register set Admission_No='" & ComboBox1.Text & "',StudentName='" & txtname.Text & "',date=convert(date,'" & DateTimePicker1.Value & "',103),out_time=convert(time(7),'" & DateTime.Now.ToLongTimeString() & "',105),reason='" & txtreason.Text & "',in_time=convert(time(7),'" & DateTime.Now.ToLongTimeString() & "',105)where Admission_No='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        conn.Execute(sql)
        MsgBox("record updated")
        loadgrid()
        clear()

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "delete from tbl_outing_register where  Admission_No='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        conn.Execute(sql)
        MsgBox("deleted succesfully")
        loadgrid()
        clear()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clear()

    End Sub
    Sub clear()
        ComboBox1.Text = " "
        txtname.Text = ""

        txtreason.Text = ""


    End Sub

    Private Sub frmouting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        loadgrid()
        outid()

    End Sub
    Sub loadgrid()

        Dim i
        i = 0
        sql = " select * from tbl_outing_register "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)

        DataGridView1.Rows.Clear()
        Do While rs.EOF = False
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            DataGridView1.Item(3, i).Value = rs(3).Value
            DataGridView1.Item(4, i).Value = rs(4).Value
            DataGridView1.Item(5, i).Value = rs(5).Value

            rs.MoveNext()
            i = i + 1
        Loop

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtname.Text = DataGridView1.CurrentRow.Cells(1).Value
        DateTimePicker1.Text = DataGridView1.CurrentRow.Cells(2).Value
        DateTimePicker2.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtreason.Text = DataGridView1.CurrentRow.Cells(4).Value


    End Sub
    Sub outid()
        ComboBox1.Items.Clear()
        sql = "select Admission_no from tbl_admission"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While rs.EOF = False
            ComboBox1.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        sql = " Select Student_Name from tbl_admission where Admission_no='" & ComboBox1.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtname.Text = rs(0).Value
        End If
    End Sub
End Class