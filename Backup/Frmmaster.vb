Public Class Frmmaster

    
    Private Sub YEARSETTINGSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmyear.MdiParent = Me
        frmyear.Show()
    End Sub

    Private Sub REGISTRATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmadmission.MdiParent = Me
        frmadmission.Show()
    End Sub

    Private Sub Frmmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FindStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindStudentsToolStripMenuItem.Click
        frmviewstudents.MdiParent = Me
        frmviewstudents.Show()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        If MsgBoxResult.No = MsgBox("do you want to exit?", MsgBoxStyle.YesNo) Then Exit Sub
        Me.Close()
    End Sub

    Private Sub ROOMDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ROOMDETAILSToolStripMenuItem.Click
        frmrooms.MdiParent = Me
        frmrooms.Show()
    End Sub

    Private Sub VISITORSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VISITORSToolStripMenuItem.Click
        frmvisitor.MdiParent = Me
        frmvisitor.Show()
    End Sub

    Private Sub COMPLAINTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPLAINTSToolStripMenuItem.Click
        complaints.MdiParent = Me
        complaints.Show()
    End Sub

    Private Sub EXPENDITUREToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXPENDITUREToolStripMenuItem.Click
        frmexpenditure.MdiParent = Me
        frmexpenditure.Show()
    End Sub

    Private Sub MESSBILLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MESSBILLToolStripMenuItem.Click
        frmmessbill.MdiParent = Me
        frmmessbill.Show()
    End Sub

    Private Sub ADMISSIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADMISSIONToolStripMenuItem.Click
        frmadmission.MdiParent = Me
        frmadmission.Show()
    End Sub

    Private Sub LEAVEREGISTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEAVEREGISTERToolStripMenuItem.Click
        frmleave.MdiParent = Me
        frmleave.Show()
    End Sub

    Private Sub OUTINGREGISTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OUTINGREGISTERToolStripMenuItem.Click
        frmouting.MdiParent = Me
        frmouting.Show()
    End Sub

    Private Sub STAFFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STAFFToolStripMenuItem.Click
        frmemployee.MdiParent = Me
        frmemployee.Show()
    End Sub

    Private Sub YEARSETTINGSToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YEARSETTINGSToolStripMenuItem1.Click
        frmyear.MdiParent = Me
        frmyear.Show()
    End Sub

    Private Sub VIEWCOMPLAINTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWCOMPLAINTSToolStripMenuItem.Click
        frmviewcomplaints.MdiParent = Me
        frmviewcomplaints.Show()
    End Sub

    Private Sub VIEWVISITORSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWVISITORSToolStripMenuItem.Click
        frmviewvistors.MdiParent = Me
        frmviewvistors.Show()
    End Sub

    Private Sub EMPLOYEESALARYToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMPLOYEESALARYToolStripMenuItem1.Click
        frmempsal.MdiParent = Me
        frmempsal.Show()
    End Sub

    Private Sub ROOMSETTINGSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ROOMSETTINGSToolStripMenuItem.Click
        frmroomallotment.MdiParent = Me
        frmroomallotment.Show()
    End Sub

    Private Sub RENTALFEESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RENTALFEESToolStripMenuItem.Click
        frmrent.MdiParent = Me
        frmrent.Show()
    End Sub

    Private Sub RECEIPTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECEIPTSToolStripMenuItem.Click
        frmreceipts.MdiParent = Me
        frmreceipts.Show()
    End Sub

    Private Sub OUTSTANDINGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OUTSTANDINGToolStripMenuItem.Click
        frmoutstanding.MdiParent = Me
        frmoutstanding.Show()
    End Sub
End Class