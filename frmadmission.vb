Public Class frmadmission
    Public ID As Integer
    Private Sub frmadmission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        If view_student = True Then
            sql = "select * from tbl_admission where Admission_no='" & admission_no & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                txtid.Text = rs(0).Value
                dtpad_date.Value = rs(1).Value
                txtname.Text = rs(2).Value
                txtclass.Text = rs(3).Value
                txtfname.Text = rs(4).Value
                foccupation.Text = rs(5).Value
                mname.Text = rs(6).Value
                moccupation.Text = rs(7).Value
                txtaddress.Text = rs(8).Value
                txtpost.Text = rs(9).Value
                txtpin.Text = rs(10).Value
                combdistrict.Text = rs(11).Value
                combreligion.Text = rs(12).Value
                combcaste.Text = rs(13).Value
                txtphoneno.Text = rs(14).Value
                dtpdob.Value = rs(15).Value
                combmtongue.Text = rs(16).Value
                combhighschool.Text = rs(17).Value
                studentpic.ImageLocation = rs(18).Value
                txtfrom.Text = rs(19).Value
                txtto.Text = rs(20).Value
            End If
            view_student = False
        Else
            sql = "select * from tbl_year"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                txtfrom.Text = rs(0).Value
                ID = rs(0).Value
                txtto.Text = rs(1).Value
            End If
            load_district()
            load_caste()
            load_medium()
            load_mtongue()
            load_Religion()
            sql = "select max(Admission_no)+1 from tbl_admission"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                If IsDBNull(rs(0).Value) = False Then
                    txtid.Text = rs(0).Value
                Else
                    txtid.Text = "11100"
                End If
            End If
        End If
    End Sub
    Sub load_district()
        sql = "select distinct(District) from tbl_admission"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            combdistrict.Items.Add(rs(0).Value)
           rs.MoveNext()
        End While
    End Sub
    Sub load_Religion()
        sql = "select distinct(Religion) from tbl_admission"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            combreligion.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
    End Sub
    Sub load_caste()
        sql = "select distinct(caste) from tbl_admission"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            combcaste.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
    End Sub
    Sub load_mtongue()
        sql = "select distinct(Mother_tongue) from tbl_admission"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            combmtongue.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
    End Sub
    Sub load_medium()
        sql = "select distinct(Medium) from tbl_admission"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            combhighschool.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
    End Sub
    Private Sub btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowse.Click
        With Me.OpenFileDialog1
            .Filter = "all files | *.*"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                studentpic.ImageLocation = .FileName
            End If
        End With
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtid.Text = "" Or txtaddress.Text = "" Or txtclass.Text = "" Or txtfname.Text = "" Or txtname.Text = "" Or txtphoneno.Text = "" Or txtpin.Text = "" Or txtpost.Text = "" Or mname.Text = "" Or foccupation.Text = "" Or moccupation.Text = "" Or combcaste.Text = "" Or combdistrict.Text = "" Or combhighschool.Text = "" Or combmtongue.Text = "" Or combreligion.Text = "" Or studentpic.ImageLocation = "" Then
            MsgBox("Please enter the values", MsgBoxStyle.Exclamation, "Warning")
        Else
            sql = "insert into tbl_admission(admission_no,Ad_date,Student_name,St_Class,Father_Name,Father_occup,Mother_name,Mother_occup,Address,Postal,Pincode,District,Religion,Caste,Phone_no,D_O_B,Mother_tongue,Medium,photo,From_year,To_year)values('" & txtid.Text & "',convert(date,'" & dtpad_date.Value & "',105),'" & txtname.Text & "','" & txtclass.Text & "','" & txtfname.Text & "','" & foccupation.Text & "','" & mname.Text & "','" & moccupation.Text & "','" & txtaddress.Text & "','" & txtpost.Text & "','" & txtpin.Text & "','" & combdistrict.Text & "','" & combreligion.Text & "','" & combcaste.Text & "','" & txtphoneno.Text & "',convert(date,'" & dtpdob.Value & "',105),'" & combmtongue.Text & "','" & combhighschool.Text & "','" & studentpic.ImageLocation & "','" & txtfrom.Text & "','" & txtto.Text & "')"
            conn.Execute(sql)
            MsgBox("admission done successfully", MsgBoxStyle.Information)

        End If
    End Sub

   
    Private Sub txtphoneno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphoneno.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpin.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Sub clear()
        txtaddress.Clear()
        txtclass.Clear()
        txtfname.Clear()
        txtfrom.Clear()
        txtid.Clear()
        txtname.Clear()
        txtphoneno.Clear()
        txtpin.Clear()
        txtpost.Clear()
        txtto.Clear()
        studentpic.ImageLocation = ""
        combcaste.Text = ""
        combdistrict.Text = ""
        combhighschool.Text = ""
        combmtongue.Text = ""
        combreligion.Text = ""

    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "update tbl_admission set student_name='" & txtname.Text & "',st_class='" & txtclass.Text & "',father_name='" & txtfname.Text & "',father_occup='" & foccupation.Text & "',mother_name='" & mname.Text & "',mother_occup='" & moccupation.Text & "',address='" & txtaddress.Text & "',postal='" & txtpost.Text & "',pincode='" & txtpin.Text & "',district='" & combdistrict.Text & "',religion='" & combreligion.Text & "',caste='" & combcaste.Text & "',phone_no='" & txtphoneno.Text & "',D_O_B=convert(char,'" & dtpdob.Value & "',105),mother_tongue='" & combmtongue.Text & "',medium='" & combhighschool.Text & "',photo='" & studentpic.ImageLocation & "' where admission_no='" & txtid.Text & "'"
        conn.Execute(sql)
        MsgBox("student record updated successfully", MsgBoxStyle.Information)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBoxResult.No = MsgBox("do you want to delete the student record?", MsgBoxStyle.YesNo) Then Exit Sub
        sql = "delete from tbl_admission where admission_no='" & txtid.Text & "'"
        conn.Execute(sql)
        MsgBox("student record deleted successfully", MsgBoxStyle.Information)
        '  frmviewstudents.students()
        clear()



    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmviewstudents.Show()

    End Sub
End Class