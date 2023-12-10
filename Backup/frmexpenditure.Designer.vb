<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmexpenditure
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbmonth = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbyear = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtgro = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtveg = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtfruits = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtfish = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtchikku = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtmilk = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txticecream = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtgas = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtelectricity = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtautofare = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtgeneral = New System.Windows.Forms.TextBox
        Me.txtequipmentrepair = New System.Windows.Forms.TextBox
        Me.txtpetrol = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtcoconut = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtsportsmeterials = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtcatering = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txttelephonecharges = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtmedicine = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtrenumeration = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtpostage = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtprinting = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtcabletvaudio = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtfreshersday = New System.Windows.Forms.TextBox
        Me.BTNCALC = New System.Windows.Forms.Button
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtexp = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELECT MONTH"
        '
        'cmbmonth
        '
        Me.cmbmonth.FormattingEnabled = True
        Me.cmbmonth.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.cmbmonth.Location = New System.Drawing.Point(120, 16)
        Me.cmbmonth.Name = "cmbmonth"
        Me.cmbmonth.Size = New System.Drawing.Size(121, 21)
        Me.cmbmonth.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(348, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SELECT YEAR"
        '
        'cmbyear
        '
        Me.cmbyear.FormattingEnabled = True
        Me.cmbyear.Items.AddRange(New Object() {"2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021"})
        Me.cmbyear.Location = New System.Drawing.Point(452, 21)
        Me.cmbyear.Name = "cmbyear"
        Me.cmbyear.Size = New System.Drawing.Size(121, 21)
        Me.cmbyear.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "GROCERIES"
        '
        'txtgro
        '
        Me.txtgro.Location = New System.Drawing.Point(120, 47)
        Me.txtgro.Name = "txtgro"
        Me.txtgro.Size = New System.Drawing.Size(121, 20)
        Me.txtgro.TabIndex = 5
        Me.txtgro.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "VEGETABLES"
        '
        'txtveg
        '
        Me.txtveg.Location = New System.Drawing.Point(120, 89)
        Me.txtveg.Name = "txtveg"
        Me.txtveg.Size = New System.Drawing.Size(121, 20)
        Me.txtveg.TabIndex = 7
        Me.txtveg.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "FRUITS"
        '
        'txtfruits
        '
        Me.txtfruits.Location = New System.Drawing.Point(120, 130)
        Me.txtfruits.Name = "txtfruits"
        Me.txtfruits.Size = New System.Drawing.Size(121, 20)
        Me.txtfruits.TabIndex = 9
        Me.txtfruits.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "FISH"
        '
        'txtfish
        '
        Me.txtfish.Location = New System.Drawing.Point(120, 159)
        Me.txtfish.Name = "txtfish"
        Me.txtfish.Size = New System.Drawing.Size(121, 20)
        Me.txtfish.TabIndex = 11
        Me.txtfish.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "CHIKKU AND EGGS"
        '
        'txtchikku
        '
        Me.txtchikku.Location = New System.Drawing.Point(139, 182)
        Me.txtchikku.Name = "txtchikku"
        Me.txtchikku.Size = New System.Drawing.Size(102, 20)
        Me.txtchikku.TabIndex = 13
        Me.txtchikku.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "MILK"
        '
        'txtmilk
        '
        Me.txtmilk.Location = New System.Drawing.Point(120, 208)
        Me.txtmilk.Name = "txtmilk"
        Me.txtmilk.Size = New System.Drawing.Size(121, 20)
        Me.txtmilk.TabIndex = 15
        Me.txtmilk.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "SWEET ICECREAM AND BREAD"
        '
        'txticecream
        '
        Me.txticecream.Location = New System.Drawing.Point(203, 245)
        Me.txticecream.Name = "txticecream"
        Me.txticecream.Size = New System.Drawing.Size(100, 20)
        Me.txticecream.TabIndex = 17
        Me.txticecream.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 279)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "GAS"
        '
        'txtgas
        '
        Me.txtgas.Location = New System.Drawing.Point(120, 277)
        Me.txtgas.Name = "txtgas"
        Me.txtgas.Size = New System.Drawing.Size(121, 20)
        Me.txtgas.TabIndex = 19
        Me.txtgas.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 306)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "ELECTRIC CHARGE"
        '
        'txtelectricity
        '
        Me.txtelectricity.Location = New System.Drawing.Point(139, 303)
        Me.txtelectricity.Name = "txtelectricity"
        Me.txtelectricity.Size = New System.Drawing.Size(102, 20)
        Me.txtelectricity.TabIndex = 21
        Me.txtelectricity.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "AUTO FARE"
        '
        'txtautofare
        '
        Me.txtautofare.Location = New System.Drawing.Point(120, 333)
        Me.txtautofare.Name = "txtautofare"
        Me.txtautofare.Size = New System.Drawing.Size(121, 20)
        Me.txtautofare.TabIndex = 23
        Me.txtautofare.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 364)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "DESIL PETROL"
        '
        'txtgeneral
        '
        Me.txtgeneral.Location = New System.Drawing.Point(412, 102)
        Me.txtgeneral.Name = "txtgeneral"
        Me.txtgeneral.Size = New System.Drawing.Size(100, 20)
        Me.txtgeneral.TabIndex = 25
        Me.txtgeneral.Text = "0"
        '
        'txtequipmentrepair
        '
        Me.txtequipmentrepair.Location = New System.Drawing.Point(527, 68)
        Me.txtequipmentrepair.Name = "txtequipmentrepair"
        Me.txtequipmentrepair.Size = New System.Drawing.Size(84, 20)
        Me.txtequipmentrepair.TabIndex = 26
        Me.txtequipmentrepair.Text = "0"
        '
        'txtpetrol
        '
        Me.txtpetrol.Location = New System.Drawing.Point(120, 360)
        Me.txtpetrol.Name = "txtpetrol"
        Me.txtpetrol.Size = New System.Drawing.Size(121, 20)
        Me.txtpetrol.TabIndex = 28
        Me.txtpetrol.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(348, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(182, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "ELECTRICAL EQUIPMENT REPAIR"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(348, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "GENERAL"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(348, 140)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "COCONUT"
        '
        'txtcoconut
        '
        Me.txtcoconut.Location = New System.Drawing.Point(412, 137)
        Me.txtcoconut.Name = "txtcoconut"
        Me.txtcoconut.Size = New System.Drawing.Size(100, 20)
        Me.txtcoconut.TabIndex = 32
        Me.txtcoconut.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(348, 166)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "SPORTS MATERIALS"
        '
        'txtsportsmeterials
        '
        Me.txtsportsmeterials.Location = New System.Drawing.Point(469, 163)
        Me.txtsportsmeterials.Name = "txtsportsmeterials"
        Me.txtsportsmeterials.Size = New System.Drawing.Size(100, 20)
        Me.txtsportsmeterials.TabIndex = 34
        Me.txtsportsmeterials.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(348, 192)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "CATERING"
        '
        'txtcatering
        '
        Me.txtcatering.Location = New System.Drawing.Point(412, 189)
        Me.txtcatering.Name = "txtcatering"
        Me.txtcatering.Size = New System.Drawing.Size(100, 20)
        Me.txtcatering.TabIndex = 36
        Me.txtcatering.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(348, 217)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 13)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "TELEPHONE CHARGE"
        '
        'txttelephonecharges
        '
        Me.txttelephonecharges.Location = New System.Drawing.Point(469, 215)
        Me.txttelephonecharges.Name = "txttelephonecharges"
        Me.txttelephonecharges.Size = New System.Drawing.Size(100, 20)
        Me.txttelephonecharges.TabIndex = 38
        Me.txttelephonecharges.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(349, 249)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 13)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "MEDICINE"
        '
        'txtmedicine
        '
        Me.txtmedicine.Location = New System.Drawing.Point(414, 245)
        Me.txtmedicine.Name = "txtmedicine"
        Me.txtmedicine.Size = New System.Drawing.Size(119, 20)
        Me.txtmedicine.TabIndex = 40
        Me.txtmedicine.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(348, 272)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 13)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "RENUMERATION"
        '
        'txtrenumeration
        '
        Me.txtrenumeration.Location = New System.Drawing.Point(446, 269)
        Me.txtrenumeration.Name = "txtrenumeration"
        Me.txtrenumeration.Size = New System.Drawing.Size(100, 20)
        Me.txtrenumeration.TabIndex = 42
        Me.txtrenumeration.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(352, 333)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 13)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "POSTAGE"
        '
        'txtpostage
        '
        Me.txtpostage.Location = New System.Drawing.Point(421, 330)
        Me.txtpostage.Name = "txtpostage"
        Me.txtpostage.Size = New System.Drawing.Size(100, 20)
        Me.txtpostage.TabIndex = 44
        Me.txtpostage.Text = "0"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(348, 303)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(157, 13)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "PRINTING AND STATIONARY"
        '
        'txtprinting
        '
        Me.txtprinting.Location = New System.Drawing.Point(507, 298)
        Me.txtprinting.Name = "txtprinting"
        Me.txtprinting.Size = New System.Drawing.Size(100, 20)
        Me.txtprinting.TabIndex = 46
        Me.txtprinting.Text = "0"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(352, 371)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(95, 13)
        Me.Label24.TabIndex = 47
        Me.Label24.Text = "CABLE TV AUDIO"
        '
        'txtcabletvaudio
        '
        Me.txtcabletvaudio.Location = New System.Drawing.Point(452, 368)
        Me.txtcabletvaudio.Name = "txtcabletvaudio"
        Me.txtcabletvaudio.Size = New System.Drawing.Size(100, 20)
        Me.txtcabletvaudio.TabIndex = 48
        Me.txtcabletvaudio.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(353, 393)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(168, 13)
        Me.Label25.TabIndex = 49
        Me.Label25.Text = "FRESHERS DAY CELEBRATION"
        '
        'txtfreshersday
        '
        Me.txtfreshersday.Location = New System.Drawing.Point(527, 390)
        Me.txtfreshersday.Name = "txtfreshersday"
        Me.txtfreshersday.Size = New System.Drawing.Size(100, 20)
        Me.txtfreshersday.TabIndex = 50
        Me.txtfreshersday.Text = "0"
        '
        'BTNCALC
        '
        Me.BTNCALC.Location = New System.Drawing.Point(19, 388)
        Me.BTNCALC.Name = "BTNCALC"
        Me.BTNCALC.Size = New System.Drawing.Size(101, 23)
        Me.BTNCALC.TabIndex = 51
        Me.BTNCALC.Text = "CALCULATE"
        Me.BTNCALC.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(17, 422)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(90, 13)
        Me.Label26.TabIndex = 52
        Me.Label26.Text = "Total Expenditure"
        '
        'txtexp
        '
        Me.txtexp.Location = New System.Drawing.Point(113, 419)
        Me.txtexp.Name = "txtexp"
        Me.txtexp.Size = New System.Drawing.Size(100, 20)
        Me.txtexp.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 466)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(232, 466)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(340, 466)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 56
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(446, 466)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 57
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmexpenditure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 501)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtexp)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.BTNCALC)
        Me.Controls.Add(Me.txtfreshersday)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtcabletvaudio)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtprinting)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtpostage)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtrenumeration)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtmedicine)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txttelephonecharges)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtcatering)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtsportsmeterials)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtcoconut)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtpetrol)
        Me.Controls.Add(Me.txtequipmentrepair)
        Me.Controls.Add(Me.txtgeneral)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtautofare)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtelectricity)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtgas)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txticecream)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtmilk)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtchikku)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtfish)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtfruits)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtveg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtgro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbyear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbmonth)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmexpenditure"
        Me.Text = "frmexpenditure"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbmonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbyear As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtgro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtveg As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtfruits As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfish As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtchikku As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtmilk As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txticecream As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtgas As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtelectricity As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtautofare As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtgeneral As System.Windows.Forms.TextBox
    Friend WithEvents txtequipmentrepair As System.Windows.Forms.TextBox
    Friend WithEvents txtpetrol As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtcoconut As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtsportsmeterials As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtcatering As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txttelephonecharges As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtmedicine As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtrenumeration As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtpostage As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtprinting As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtcabletvaudio As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtfreshersday As System.Windows.Forms.TextBox
    Friend WithEvents BTNCALC As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtexp As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
