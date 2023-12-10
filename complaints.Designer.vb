<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class complaints
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(complaints))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.txtcomplaints = New System.Windows.Forms.TextBox()
        Me.combstatus = New System.Windows.Forms.ComboBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.dtpad_date = New System.Windows.Forms.DateTimePicker()
        Me.btnview = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "complaint"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status"
        '
        'txtsname
        '
        Me.txtsname.Location = New System.Drawing.Point(132, 51)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(100, 20)
        Me.txtsname.TabIndex = 4
        '
        'txtcomplaints
        '
        Me.txtcomplaints.Location = New System.Drawing.Point(132, 141)
        Me.txtcomplaints.Multiline = True
        Me.txtcomplaints.Name = "txtcomplaints"
        Me.txtcomplaints.Size = New System.Drawing.Size(359, 32)
        Me.txtcomplaints.TabIndex = 6
        '
        'combstatus
        '
        Me.combstatus.FormattingEnabled = True
        Me.combstatus.Items.AddRange(New Object() {"Solved", "Not solved"})
        Me.combstatus.Location = New System.Drawing.Point(132, 187)
        Me.combstatus.Name = "combstatus"
        Me.combstatus.Size = New System.Drawing.Size(121, 21)
        Me.combstatus.TabIndex = 7
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(73, 231)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 8
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(160, 231)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 9
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'dtpad_date
        '
        Me.dtpad_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpad_date.Location = New System.Drawing.Point(132, 92)
        Me.dtpad_date.Name = "dtpad_date"
        Me.dtpad_date.Size = New System.Drawing.Size(103, 20)
        Me.dtpad_date.TabIndex = 10
        '
        'btnview
        '
        Me.btnview.Location = New System.Drawing.Point(253, 231)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(75, 23)
        Me.btnview.TabIndex = 11
        Me.btnview.Text = "View"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(346, 231)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(441, 231)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'complaints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.Hostel_Management_System.My.Resources.Resources.Chrysanthemum
        Me.ClientSize = New System.Drawing.Size(561, 276)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.dtpad_date)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.combstatus)
        Me.Controls.Add(Me.txtcomplaints)
        Me.Controls.Add(Me.txtsname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "complaints"
        Me.Text = "complaints"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents txtcomplaints As System.Windows.Forms.TextBox
    Friend WithEvents combstatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents dtpad_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
