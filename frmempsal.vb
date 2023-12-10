Public Class frmempsal

    Private Sub frmempsal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        empno()
        loadgrid()

    End Sub
    Sub empno()
        cmbid.Items.Clear()
        sql = "select emp_id from tbl_employee"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While rs.EOF = False
            cmbid.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub cmbid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbid.SelectedIndexChanged
        sql = " Select emp_name from tbl_employee where emp_id='" & cmbid.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtname.Text = rs(0).Value
        End If
        sql = " Select basicsal from tbl_employee where emp_id='" & cmbid.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtsalary.Text = rs(0).Value
        End If
    End Sub

    Private Sub btninsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninsert.Click
        sql = "insert into tbl_empsalary(emp_id,emp_name,emp_sal,date)"
        sql = sql & "values(' " & cmbid.Text & " ',' " & txtname.Text & " ',' " & txtsalary.Text & " ',convert(date,'" & DateTimePicker1.Value & "',103)) "
        conn.Execute(sql)
        MsgBox("inserted succesfully")
        loadgrid()
        clear()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "delete from tbl_empsalary where  emp_id='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        conn.Execute(sql)
        MsgBox("deleted succesfully")
        loadgrid()
        clear()
    End Sub
    Sub loadgrid()

        Dim i
        i = 0
        sql = " select * from tbl_empsalary "
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
    Sub clear()
        cmbid.Text = " "
        txtname.Text = ""

        txtsalary.Text = ""


    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clear()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cmbid.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtsalary.Text = DataGridView1.CurrentRow.Cells(2).Value
    End Sub
End Class