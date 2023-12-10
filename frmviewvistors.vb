Public Class frmviewvistors
    Public i As Integer
    Public search As String
    Private Sub frmviewvistors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        load_visitors()
    End Sub
    Sub load_visitors()
        sql = "select visitors_name,date,student_name,address,phone_no from tbl_visitors where date=convert(date,'" & Now.Date & "',105)"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvvisitors.Rows.Add()
            dgvvisitors.Item(0, i).Value = rs(0).Value
            dgvvisitors.Item(1, i).Value = rs(1).Value
            dgvvisitors.Item(2, i).Value = rs(2).Value
            dgvvisitors.Item(3, i).Value = rs(3).Value
            dgvvisitors.Item(4, i).Value = rs(4).Value
            i = i + 1
            rs.MoveNext()
        Loop
    End Sub

    Private Sub cmbsearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsearch.SelectedIndexChanged
        If cmbsearch.Text = "Visitors Name" Then
            search = "Visitors_Name"
            txtsearch.Visible = True
            dtpsearch.Visible = False
        ElseIf cmbsearch.Text = "Student Name" Then
            search = "Student_Name"
            txtsearch.Visible = True
            dtpsearch.Visible = False
        ElseIf cmbsearch.Text = "Date" Then
            search = "date"
            txtsearch.Visible = False
            dtpsearch.Visible = True
        End If
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        i = 0
        dgvvisitors.Rows.Clear()
        sql = "select visitors_Name,date, student_Name,Address,Phone_no from tbl_visitors where " & search & " like '%" & txtsearch.Text & "%'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvvisitors.Rows.Add()
            dgvvisitors.Item(0, i).Value = rs(0).Value
            dgvvisitors.Item(1, i).Value = rs(1).Value
            dgvvisitors.Item(2, i).Value = rs(2).Value
            dgvvisitors.Item(3, i).Value = rs(3).Value
            dgvvisitors.Item(4, i).Value = rs(4).Value
            i = i + 1
            rs.MoveNext()
        Loop
    End Sub

    Private Sub dtpsearch_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpsearch.ValueChanged
        i = 0
        dgvvisitors.Rows.Clear()
        sql = "select visitors_Name,date, student_Name,Address,Phone_no from tbl_visitors where " & search & " =convert(char,'" & dtpsearch.Value & "',105)"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvvisitors.Rows.Add()
            dgvvisitors.Item(0, i).Value = rs(0).Value
            dgvvisitors.Item(1, i).Value = rs(1).Value
            dgvvisitors.Item(2, i).Value = rs(2).Value
            dgvvisitors.Item(3, i).Value = rs(3).Value
            dgvvisitors.Item(4, i).Value = rs(4).Value
            i = i + 1
            rs.MoveNext()
        Loop
    End Sub

    Private Sub dgvvisitors_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvvisitors.DoubleClick
        visitor_name = dgvvisitors.CurrentRow.Cells(0).Value
        vdate = dgvvisitors.CurrentRow.Cells(1).Value
        visitor = True
        frmvisitor.MdiParent = Frmmaster
        frmvisitor.Show()
        Me.Close()
    End Sub
End Class