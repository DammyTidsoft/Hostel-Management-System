Public Class frmleave

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        sql = "insert into tbl_leave(Admission_No,StudentName,Fromdate,Todate,Reason)"
        sql = sql & "values( ' " & ComboBox1.Text & " ','" & txtname.Text & "',convert(date,'" & DateTimePicker1.Value & "',103), convert(date,'" & DateTimePicker2.Value & "',103),'" & txtremarks.Text & "')"
        conn.Execute(sql)
        MsgBox("inserted succesfully")
        loadgrid()
        clear()

    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "update tbl_leave set Admission_No='" & ComboBox1.Text & "',StudentName='" & txtname.Text & "',Fromdate=convert(date,'" & DateTimePicker1.Value & "',103),Todate=convert(date,'" & DateTimePicker1.Value & "',103),Reason='" & txtremarks.Text & "'where Admission_No='" & DataGridView1.CurrentRow.Cells(0).Value & "' "
        conn.Execute(sql)
        MsgBox("record updated")
        loadgrid()
        clear()


    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "delete from tbl_leave where  Admission_No='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        conn.Execute(sql)
        MsgBox("deleted succesfully")
        loadgrid()
        clear()


    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clear()

    End Sub
    Sub clear()
        ComboBox1.Text = ""
        txtname.Text = ""
        txtremarks.Text = ""
        cmbsearch.Text = ""

    End Sub
    Sub loadgrid()

        Dim i
        i = 0
        sql = " select * from tbl_leave order by Admission_No "
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
          
            rs.MoveNext()
            i = i + 1
        Loop

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        ComboBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtname.Text = DataGridView1.CurrentRow.Cells(1).Value


        DateTimePicker1.Text = DataGridView1.CurrentRow.Cells(2).Value
        DateTimePicker2.Text = DataGridView1.CurrentRow.Cells(3).Value

        txtremarks.Text = DataGridView1.CurrentRow.Cells(4).Value
    End Sub

    Private Sub frmleave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        loadgrid()
        leaveid()

    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If cmbsearch.Text = "Admission_No" Then
            Dim i
            i = 0

            sql = "select * from tbl_leave where Admission_No='" & txtsearch.Text & "'"
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
                


                rs.MoveNext()


            Loop
        ElseIf cmbsearch.Text = "StudentName" Then
            Dim i
            i = 0
            sql = "select * from tbl_leave where StudentName='" & txtsearch.Text & "'"
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


                rs.MoveNext()


            Loop

        End If
    End Sub
    Sub leaveid()
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