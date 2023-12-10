Public Class frmemployee

   
    Private Sub frmemployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        loadgrid()
        empID()

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        sql = "insert into tbl_employee(emp_id,emp_name,address,qualification,cont_no,email_id,desig,basicsal)"
        sql = sql & "values(' " & txtid.Text & " ',' " & txtname.Text & " ',' " & txtaddress.Text & " ',' " & txtqualification.Text & " ',' " & txtcont.Text & " ',' " & txteid.Text & " ',' " & txtdesig.Text & " ',' " & txtsalary.Text & " ') "
        conn.Execute(sql)
        MsgBox("inserted succesfully")
        loadgrid()
        clear()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "update tbl_employee set emp_id='" & txtid.Text & "',emp_name='" & txtname.Text & "',address='" & txtaddress.Text & "',qualification='" & txtqualification.Text & "',cont_no='" & txtcont.Text & "',email_id='" & txteid.Text & "',desig='" & txtdesig.Text & "',basicsal='" & txtsalary.Text & "' where emp_id='" & DataGridView1.CurrentRow.Cells(0).Value & "' "
        conn.Execute(sql)
        MsgBox("record updated")
        loadgrid()
        clear()

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "delete from tbl_employee where  emp_id='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        conn.Execute(sql)
        MsgBox("deleted succesfully")
        loadgrid()
        clear()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clear()

    End Sub
    Sub clear()
        txtid.Text = " "
        txtname.Text = ""
        txtaddress.Text = ""
        txtqualification.Text = ""
        txtcont.Text = ""
        txteid.Text = ""
        txtdesig.Text = ""
        txtsalary.Text = ""

    End Sub
    Sub loadgrid()

        Dim i
        i = 0
        sql = " select * from tbl_employee "
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
            DataGridView1.Item(6, i).Value = rs(6).Value
            DataGridView1.Item(7, i).Value = rs(7).Value


            rs.MoveNext()
            i = i + 1
        Loop

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtid.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtaddress.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtqualification.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtcont.Text = DataGridView1.CurrentRow.Cells(4).Value
        txteid.Text = DataGridView1.CurrentRow.Cells(5).Value
        txtdesig.Text = DataGridView1.CurrentRow.Cells(6).Value
        txtsalary.Text = DataGridView1.CurrentRow.Cells(7).Value
    End Sub
    Sub empID()
        Dim j
        j = 100
        txtid.Text = j
        sql = "select max(emp_id) from tbl_employee"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)



        If rs.EOF = False Then
            j = rs(0).Value
            j = j + 1
            txtid.Text = j
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class