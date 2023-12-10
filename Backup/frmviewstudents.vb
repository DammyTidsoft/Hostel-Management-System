Public Class frmviewstudents
    Public i As Integer = 0
    Public search As String
    Private Sub frmviewstudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        students()
    End Sub
    Sub students()
        dgvstudent.Rows.Clear()

        sql = "select admission_no,student_name,st_class,father_name,address,phone_no from tbl_admission"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvstudent.Rows.Add()
            dgvstudent.Item(0, i).Value = rs(0).Value
            dgvstudent.Item(1, i).Value = rs(1).Value
            dgvstudent.Item(2, i).Value = rs(2).Value
            dgvstudent.Item(3, i).Value = rs(3).Value
            dgvstudent.Item(4, i).Value = rs(4).Value
            dgvstudent.Item(5, i).Value = rs(5).Value
            i = i + 1
            rs.MoveNext()
        Loop
    End Sub

    
    Private Sub txtvalue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvalue.TextChanged
        i = 0
        dgvstudent.Rows.Clear()
        sql = "select admission_no,student_name,st_class,father_name,address,phone_no from tbl_admission where " & search & " like '%" & txtvalue.Text & "%'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvstudent.Rows.Add()
            dgvstudent.Item(0, i).Value = rs(0).Value
            dgvstudent.Item(1, i).Value = rs(1).Value
            dgvstudent.Item(2, i).Value = rs(2).Value
            dgvstudent.Item(3, i).Value = rs(3).Value
            dgvstudent.Item(4, i).Value = rs(4).Value
            dgvstudent.Item(5, i).Value = rs(5).Value
            i = i + 1
            rs.MoveNext()
        Loop
    End Sub

    Private Sub cmbsearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsearch.SelectedIndexChanged
        If cmbsearch.Text = "Student ID" Then
            search = "Admission_no"
        ElseIf cmbsearch.Text = "Student Name" Then
            search = "Student_Name"
        ElseIf cmbsearch.Text = "Class" Then
            search = "St_class"
        End If
    End Sub

   

    Private Sub dgvstudent_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvstudent.DoubleClick
        admission_no = dgvstudent.CurrentRow.Cells(0).Value
        view_student = True
        frmadmission.MdiParent = Frmmaster
        frmadmission.Show()
        Me.Hide()
    End Sub

    Private Sub dgvstudent_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvstudent.CellContentClick

    End Sub
End Class