Public Class frmviewcomplaints
    Public i As Integer
    Private Sub frmviewcomplaints_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        load_complaints()
    End Sub
    Sub load_complaints()
        i = 0
        sql = "select Student_name,date,complaints,status from tbl_Complaints where date=convert(date,'" & Now.Date & "',103)"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            dgvcomplaint.Rows.Add()
            dgvcomplaint.Item(0, i).Value = rs(0).Value
            dgvcomplaint.Item(1, i).Value = rs(1).Value
            dgvcomplaint.Item(2, i).Value = rs(2).Value
            dgvcomplaint.Item(3, i).Value = rs(3).Value
            rs.MoveNext()
            i = i + 1
        End While
    End Sub

   
    Private Sub cmbstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstatus.SelectedIndexChanged
        dgvcomplaint.Rows.Clear()
        i = 0
        sql = "select Student_name,date,complaints,status from tbl_Complaints where status='" & cmbstatus.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            dgvcomplaint.Rows.Add()
            dgvcomplaint.Item(0, i).Value = rs(0).Value
            dgvcomplaint.Item(1, i).Value = rs(1).Value
            dgvcomplaint.Item(2, i).Value = rs(2).Value
            dgvcomplaint.Item(3, i).Value = rs(3).Value
            rs.MoveNext()
            i = i + 1
        End While
    End Sub

   
   
    Private Sub dgvcomplaint_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvcomplaint.CellDoubleClick
        
    End Sub

    Private Sub dgvcomplaint_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvcomplaint.CellContentClick

    End Sub

    Private Sub dgvcomplaint_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvcomplaint.DoubleClick
        sname = dgvcomplaint.CurrentRow.Cells(0).Value
        dat = dgvcomplaint.CurrentRow.Cells(1).Value
        comp = dgvcomplaint.CurrentRow.Cells(2).Value
        stat = dgvcomplaint.CurrentRow.Cells(3).Value
        complaint = True
        complaints.MdiParent = Frmmaster
        complaints.Show()
        Me.Close()
    End Sub
End Class