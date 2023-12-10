Public Class frmexpenditure

    Private Sub frmexpenditure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()

    End Sub

    Private Sub BTNCALC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCALC.Click
        txtexp.Text = Val(txtautofare.Text) + Val(txtcabletvaudio.Text) + Val(txtcatering.Text) + Val(txtchikku.Text) + Val(txtcoconut.Text) + Val(txtelectricity.Text) + Val(txtequipmentrepair.Text) + Val(txtfish.Text) + Val(txtfreshersday.Text) + Val(txtfruits.Text) + Val(txtgas.Text) + Val(txtgeneral.Text) + Val(txtgro.Text) + Val(txticecream.Text) + Val(txtmedicine.Text) + Val(txtmilk.Text) + Val(txtpetrol.Text) + Val(txtpostage.Text) + Val(txtprinting.Text) + Val(txtrenumeration.Text) + Val(txtsportsmeterials.Text) + Val(txttelephonecharges.Text) + Val(txtveg.Text)
    End Sub

    Private Sub txtautofare_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtautofare.MouseClick
        txtautofare.Clear()
    End Sub
    Private Sub txtcabletvaudio_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtcabletvaudio.MouseClick
        txtcabletvaudio.Clear()
    End Sub

    Private Sub txtcatering_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtcatering.MouseClick
        txtcatering.Clear()
    End Sub

    Private Sub txtchikku_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtchikku.MouseClick
        txtchikku.Clear()
    End Sub

   

    
    Private Sub txtcoconut_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtcoconut.MouseClick
        txtcoconut.Clear()
    End Sub

    Private Sub txtelectricity_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtelectricity.MouseClick
        txtelectricity.Clear()
    End Sub

    Private Sub txtequipmentrepair_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtequipmentrepair.MouseClick
        txtequipmentrepair.Clear()
    End Sub

    Private Sub txtfish_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtfish.MouseClick
        txtfish.Clear()
    End Sub

    Private Sub txtfreshersday_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtfreshersday.MouseClick
        txtfreshersday.Clear()
    End Sub

    Private Sub txtfruits_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtfruits.MouseClick
        txtfruits.Clear()
    End Sub

    Private Sub txtgas_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtgas.MouseClick
        txtgas.Clear()
    End Sub

    Private Sub txtgeneral_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtgeneral.MouseClick
        txtgeneral.Clear()
    End Sub

    Private Sub txtgro_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtgro.MouseClick
        txtgro.Clear()
    End Sub

    Private Sub txticecream_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txticecream.MouseClick
        txticecream.Clear()
    End Sub

    Private Sub txtmedicine_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtmedicine.MouseClick
        txtmedicine.Clear()
    End Sub

    Private Sub txtmilk_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtmilk.MouseClick
        txtmilk.Clear()
    End Sub

    Private Sub txtpetrol_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtpetrol.MouseClick
        txtpetrol.Clear()
    End Sub

    Private Sub txtpostage_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtpostage.MouseClick
        txtpostage.Clear()
    End Sub

    
    Private Sub txtprinting_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtprinting.MouseClick
        txtpostage.Clear()
    End Sub

    Private Sub txtrenumeration_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtrenumeration.MouseClick
        txtrenumeration.Clear()
    End Sub

    Private Sub txtsportsmeterials_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtsportsmeterials.MouseClick
        txtsportsmeterials.Clear()
    End Sub

    Private Sub txttelephonecharges_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txttelephonecharges.MouseClick
        txttelephonecharges.Clear()
    End Sub

    Private Sub txtveg_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtveg.MouseClick
        txtveg.Clear()
    End Sub

    
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        cmbyear.Text = ""
        cmbmonth.Text = ""
        txtexp.Clear()
        txtautofare.Text = "0"
        txtcabletvaudio.Text = "0"
        txtcatering.Text = "0"
        txtchikku.Text = "0"
        txtcoconut.Text = "0"
        txtelectricity.Text = "0"
        txtequipmentrepair.Text = "0"
        txtfish.Text = "0"
        txtfreshersday.Text = "0"
        txtfruits.Text = "0"
        txtgas.Text = "0"
        txtgeneral.Text = "0"
        txtgro.Text = "0"
        txticecream.Text = "0"
        txtmedicine.Text = "0"
        txtmilk.Text = "0"
        txtpetrol.Text = "0"
        txtprinting.Text = "0"
        txtpostage.Text = "0"
        txtrenumeration.Text = "0"
        txtsportsmeterials.Text = "0"
        txttelephonecharges.Text = "0"
        txtveg.Text = "0"

    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sql = "insert into tbl_expenditure(month,year,groc,vegetables,Fruits,Fish,eggs,Milk,Icecream,Gas,Electricity,autofare,petrol,equip_repair,general,coconut,sports,catering,telephone,medicine,renumeration,postage,printing,cable,freshers_day,total_exp)"
        sql = sql & "values('" & cmbmonth.Text & " ','" & cmbyear.Text & "', '" & txtgro.Text & "','" & txtveg.Text & "','" & txtfruits.Text & "','" & txtfish.Text & "','" & txtchikku.Text & "','" & txtmilk.Text & "','" & txticecream.Text & "','" & txtgas.Text & "','" & txtelectricity.Text & "','" & txtautofare.Text & "','" & txtpetrol.Text & "','" & txtequipmentrepair.Text & "','" & txtgeneral.Text & "','" & txtcoconut.Text & "','" & txtsportsmeterials.Text & "','" & txtcatering.Text & "','" & txttelephonecharges.Text & "','" & txtmedicine.Text & "','" & txtrenumeration.Text & "','" & txtpostage.Text & "','" & txtprinting.Text & "','" & txtcabletvaudio.Text & "','" & txtfreshersday.Text & "','" & txtexp.Text & "')"
        conn.Execute(sql)
        MsgBox("inserted succesfully")
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sql = "delete from tbl_expenditure where month ='" & cmbmonth.Text & "' and year='" & cmbyear.Text & "'"
        conn.Execute(sql)
        MsgBox("deleted succesfully")
        
    End Sub
End Class