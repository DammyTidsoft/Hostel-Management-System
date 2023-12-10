<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadmission
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnbrowse = New System.Windows.Forms.Button
        Me.studentpic = New System.Windows.Forms.PictureBox
        Me.dtpad_date = New System.Windows.Forms.DateTimePicker
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtid = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.combhighschool = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.combmtongue = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.dtpdob = New System.Windows.Forms.DateTimePicker
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtphoneno = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.combreligion = New System.Windows.Forms.ComboBox
        Me.combcaste = New System.Windows.Forms.ComboBox
        Me.combdistrict = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtpin = New System.Windows.Forms.TextBox
        Me.txtpost = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.moccupation = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.mname = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.foccupation = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtfname = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtclass = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtto = New System.Windows.Forms.TextBox
        Me.txtfrom = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btnadd = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.studentpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnbrowse)
        Me.Panel1.Controls.Add(Me.studentpic)
        Me.Panel1.Controls.Add(Me.dtpad_date)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.txtid)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.combhighschool)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.combmtongue)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.dtpdob)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.txtphoneno)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.combreligion)
        Me.Panel1.Controls.Add(Me.combcaste)
        Me.Panel1.Controls.Add(Me.combdistrict)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtpin)
        Me.Panel1.Controls.Add(Me.txtpost)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtaddress)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.moccupation)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.mname)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.foccupation)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtfname)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtclass)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtto)
        Me.Panel1.Controls.Add(Me.txtfrom)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(539, 546)
        Me.Panel1.TabIndex = 0
        '
        'btnbrowse
        '
        Me.btnbrowse.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbrowse.Location = New System.Drawing.Point(400, 313)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(82, 22)
        Me.btnbrowse.TabIndex = 47
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.UseVisualStyleBackColor = True
        '
        'studentpic
        '
        Me.studentpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.studentpic.Location = New System.Drawing.Point(363, 156)
        Me.studentpic.Name = "studentpic"
        Me.studentpic.Size = New System.Drawing.Size(156, 151)
        Me.studentpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.studentpic.TabIndex = 46
        Me.studentpic.TabStop = False
        '
        'dtpad_date
        '
        Me.dtpad_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpad_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpad_date.Location = New System.Drawing.Point(372, 105)
        Me.dtpad_date.Name = "dtpad_date"
        Me.dtpad_date.Size = New System.Drawing.Size(140, 22)
        Me.dtpad_date.TabIndex = 45
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(327, 110)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 17)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Date"
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Location = New System.Drawing.Point(98, 125)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(102, 20)
        Me.txtid.TabIndex = 43
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(15, 127)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 15)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Student ID No"
        '
        'combhighschool
        '
        Me.combhighschool.FormattingEnabled = True
        Me.combhighschool.Location = New System.Drawing.Point(191, 514)
        Me.combhighschool.Name = "combhighschool"
        Me.combhighschool.Size = New System.Drawing.Size(121, 21)
        Me.combhighschool.TabIndex = 41
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(15, 514)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(175, 15)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Medium of High School Studies"
        '
        'combmtongue
        '
        Me.combmtongue.FormattingEnabled = True
        Me.combmtongue.Location = New System.Drawing.Point(298, 480)
        Me.combmtongue.Name = "combmtongue"
        Me.combmtongue.Size = New System.Drawing.Size(121, 21)
        Me.combmtongue.TabIndex = 39
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(212, 484)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 15)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Mother Tongue"
        '
        'dtpdob
        '
        Me.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdob.Location = New System.Drawing.Point(98, 480)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.Size = New System.Drawing.Size(98, 20)
        Me.dtpdob.TabIndex = 37
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(17, 480)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 15)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Date Of Birth"
        '
        'txtphoneno
        '
        Me.txtphoneno.Location = New System.Drawing.Point(130, 448)
        Me.txtphoneno.Name = "txtphoneno"
        Me.txtphoneno.Size = New System.Drawing.Size(216, 20)
        Me.txtphoneno.TabIndex = 35
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 449)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 15)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Residence Phone No"
        '
        'combreligion
        '
        Me.combreligion.FormattingEnabled = True
        Me.combreligion.Location = New System.Drawing.Point(67, 417)
        Me.combreligion.Name = "combreligion"
        Me.combreligion.Size = New System.Drawing.Size(121, 21)
        Me.combreligion.TabIndex = 33
        '
        'combcaste
        '
        Me.combcaste.FormattingEnabled = True
        Me.combcaste.Location = New System.Drawing.Point(236, 422)
        Me.combcaste.Name = "combcaste"
        Me.combcaste.Size = New System.Drawing.Size(121, 21)
        Me.combcaste.TabIndex = 32
        '
        'combdistrict
        '
        Me.combdistrict.FormattingEnabled = True
        Me.combdistrict.Location = New System.Drawing.Point(281, 398)
        Me.combdistrict.Name = "combdistrict"
        Me.combdistrict.Size = New System.Drawing.Size(121, 21)
        Me.combdistrict.TabIndex = 31
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(200, 425)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 15)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Caste"
        '
        'Label16
        '
        Me.Label16.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 418)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 15)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Religion"
        '
        'txtpin
        '
        Me.txtpin.Location = New System.Drawing.Point(156, 394)
        Me.txtpin.Name = "txtpin"
        Me.txtpin.Size = New System.Drawing.Size(72, 20)
        Me.txtpin.TabIndex = 25
        '
        'txtpost
        '
        Me.txtpost.Location = New System.Drawing.Point(45, 393)
        Me.txtpost.Name = "txtpost"
        Me.txtpost.Size = New System.Drawing.Size(71, 20)
        Me.txtpost.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(234, 400)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 15)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "District"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(129, 395)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 15)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Pin"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 394)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 15)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Post"
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(69, 335)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(269, 52)
        Me.txtaddress.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 334)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 15)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Address"
        '
        'moccupation
        '
        Me.moccupation.Location = New System.Drawing.Point(132, 302)
        Me.moccupation.Name = "moccupation"
        Me.moccupation.Size = New System.Drawing.Size(214, 20)
        Me.moccupation.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 15)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Mother's Occupation"
        '
        'mname
        '
        Me.mname.Location = New System.Drawing.Point(111, 273)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(235, 20)
        Me.mname.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Mother's Name"
        '
        'foccupation
        '
        Me.foccupation.Location = New System.Drawing.Point(126, 244)
        Me.foccupation.Name = "foccupation"
        Me.foccupation.Size = New System.Drawing.Size(220, 20)
        Me.foccupation.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 245)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Father's Occupation"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(98, 215)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(248, 20)
        Me.txtfname.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Father's Name"
        '
        'txtclass
        '
        Me.txtclass.Location = New System.Drawing.Point(53, 185)
        Me.txtclass.Name = "txtclass"
        Me.txtclass.Size = New System.Drawing.Size(293, 20)
        Me.txtclass.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Class"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(130, 156)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(216, 20)
        Me.txtname.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Name of the student"
        '
        'txtto
        '
        Me.txtto.Enabled = False
        Me.txtto.Location = New System.Drawing.Point(336, 76)
        Me.txtto.Name = "txtto"
        Me.txtto.Size = New System.Drawing.Size(52, 20)
        Me.txtto.TabIndex = 6
        '
        'txtfrom
        '
        Me.txtfrom.Enabled = False
        Me.txtfrom.Location = New System.Drawing.Point(276, 76)
        Me.txtfrom.Name = "txtfrom"
        Me.txtfrom.Size = New System.Drawing.Size(51, 20)
        Me.txtfrom.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(327, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(203, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "For the year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(166, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "APPLICATION FOR ADMISSION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(131, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "KARKALA TALUK,UDUPI DISTRICT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SRI BHUVANENDRA  COLLEGE MEN'S HOSTEL"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(82, 564)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 1
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(173, 564)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(264, 565)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(66, 22)
        Me.btnupdate.TabIndex = 3
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(345, 565)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 48
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(470, 564)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 24)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "VIEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmadmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 597)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Name = "frmadmission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admission"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.studentpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtto As System.Windows.Forms.TextBox
    Friend WithEvents txtfrom As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents moccupation As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents mname As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents foccupation As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtclass As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtpin As System.Windows.Forms.TextBox
    Friend WithEvents txtpost As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents combdistrict As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents combreligion As System.Windows.Forms.ComboBox
    Friend WithEvents combcaste As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtphoneno As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents combhighschool As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents combmtongue As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtpdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnbrowse As System.Windows.Forms.Button
    Friend WithEvents studentpic As System.Windows.Forms.PictureBox
    Friend WithEvents dtpad_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
