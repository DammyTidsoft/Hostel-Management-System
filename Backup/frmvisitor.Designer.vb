<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvisitor
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtvname = New System.Windows.Forms.TextBox
        Me.txtsname = New System.Windows.Forms.TextBox
        Me.txtvaddress = New System.Windows.Forms.TextBox
        Me.txtvphoneno = New System.Windows.Forms.TextBox
        Me.btnadd = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.dtpad_date = New System.Windows.Forms.DateTimePicker
        Me.lstname = New System.Windows.Forms.ListBox
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher
        Me.BTNVIEW = New System.Windows.Forms.Button
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Visitors Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mobile No"
        '
        'txtvname
        '
        Me.txtvname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvname.Location = New System.Drawing.Point(98, 12)
        Me.txtvname.Name = "txtvname"
        Me.txtvname.Size = New System.Drawing.Size(178, 22)
        Me.txtvname.TabIndex = 5
        '
        'txtsname
        '
        Me.txtsname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsname.Location = New System.Drawing.Point(98, 63)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(178, 22)
        Me.txtsname.TabIndex = 7
        '
        'txtvaddress
        '
        Me.txtvaddress.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvaddress.Location = New System.Drawing.Point(98, 94)
        Me.txtvaddress.Multiline = True
        Me.txtvaddress.Name = "txtvaddress"
        Me.txtvaddress.Size = New System.Drawing.Size(178, 57)
        Me.txtvaddress.TabIndex = 8
        '
        'txtvphoneno
        '
        Me.txtvphoneno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvphoneno.Location = New System.Drawing.Point(98, 154)
        Me.txtvphoneno.MaxLength = 10
        Me.txtvphoneno.Name = "txtvphoneno"
        Me.txtvphoneno.Size = New System.Drawing.Size(178, 22)
        Me.txtvphoneno.TabIndex = 9
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(95, 183)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(52, 28)
        Me.btnadd.TabIndex = 10
        Me.btnadd.Text = "Save"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(149, 183)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(48, 28)
        Me.btnclear.TabIndex = 11
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(199, 183)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(53, 28)
        Me.btncancel.TabIndex = 12
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'dtpad_date
        '
        Me.dtpad_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpad_date.Location = New System.Drawing.Point(98, 39)
        Me.dtpad_date.Name = "dtpad_date"
        Me.dtpad_date.Size = New System.Drawing.Size(101, 20)
        Me.dtpad_date.TabIndex = 13
        '
        'lstname
        '
        Me.lstname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstname.FormattingEnabled = True
        Me.lstname.ItemHeight = 15
        Me.lstname.Location = New System.Drawing.Point(98, 84)
        Me.lstname.Name = "lstname"
        Me.lstname.Size = New System.Drawing.Size(178, 64)
        Me.lstname.TabIndex = 14
        Me.lstname.Visible = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'BTNVIEW
        '
        Me.BTNVIEW.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNVIEW.Location = New System.Drawing.Point(254, 183)
        Me.BTNVIEW.Name = "BTNVIEW"
        Me.BTNVIEW.Size = New System.Drawing.Size(46, 28)
        Me.BTNVIEW.TabIndex = 16
        Me.BTNVIEW.Text = "View"
        Me.BTNVIEW.UseVisualStyleBackColor = True
        '
        'frmvisitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 218)
        Me.Controls.Add(Me.BTNVIEW)
        Me.Controls.Add(Me.lstname)
        Me.Controls.Add(Me.dtpad_date)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtvphoneno)
        Me.Controls.Add(Me.txtvaddress)
        Me.Controls.Add(Me.txtsname)
        Me.Controls.Add(Me.txtvname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmvisitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "St.Philomena Hostel-Visitors Details"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtvname As System.Windows.Forms.TextBox
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents txtvaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtvphoneno As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents dtpad_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lstname As System.Windows.Forms.ListBox
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents BTNVIEW As System.Windows.Forms.Button
End Class
