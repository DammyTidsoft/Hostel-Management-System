Public Class frmrent
    
    Private Sub frmrent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        stuno()
        loadgrid()

    End Sub
    Sub stuno()
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sql = "insert into tbl_rent(StudentId,StudentName,Date,Rentalfee)"
        sql = sql & "values(' " & ComboBox1.Text & " ',' " & txtname.Text & " ',convert(date,'" & DateTimePicker1.Value & "',103),' " & txtfee.Text & " ') "
        conn.Execute(sql)
        MsgBox("inserted succesfully")
        loadgrid()

        clear()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sql = "delete from tbl_rent where  StudentId='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        conn.Execute(sql)
        MsgBox("deleted succesfully")
        loadgrid()

        clear()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        sql = "update tbl_rent set StudentId='" & ComboBox1.Text & "',StudentName='" & txtname.Text & "',Date=convert(date,'" & DateTimePicker1.Value & "',103),Rentalfee='" & txtfee.Text & "' where StudentId='" & DataGridView1.CurrentRow.Cells(0).Value & "' "
        conn.Execute(sql)
        MsgBox("record updated")
        loadgrid()

        clear()

    End Sub
    Sub clear()
        ComboBox1.Text = ""
        txtname.Text = ""
        txtfee.Text = ""

    End Sub
    Sub loadgrid()

        Dim i
        i = 0
        sql = " select * from tbl_rent order by StudentID "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)

        DataGridView1.Rows.Clear()
        Do While rs.EOF = False
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            DataGridView1.Item(3, i).Value = rs(3).Value

            rs.MoveNext()
            i = i + 1
        Loop

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtfee.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        clear()

    End Sub
End Class