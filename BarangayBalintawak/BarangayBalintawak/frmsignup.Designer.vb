<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnsignup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frnsignup))
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BdayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtpword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtscode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbposition = New System.Windows.Forms.ComboBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtfname
        '
        Me.txtfname.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtfname.Location = New System.Drawing.Point(135, 39)
        Me.txtfname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(148, 26)
        Me.txtfname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(18, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Firstname:"
        '
        'txtmname
        '
        Me.txtmname.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtmname.Location = New System.Drawing.Point(135, 77)
        Me.txtmname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(148, 26)
        Me.txtmname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(18, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Middle Name:"
        '
        'txtlname
        '
        Me.txtlname.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtlname.Location = New System.Drawing.Point(135, 115)
        Me.txtlname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(148, 26)
        Me.txtlname.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(18, 120)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(18, 158)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Gender:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(18, 196)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Birthday:"
        '
        'txtuname
        '
        Me.txtuname.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtuname.Location = New System.Drawing.Point(466, 75)
        Me.txtuname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(148, 26)
        Me.txtuname.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(349, 79)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Username:"
        '
        'BdayDateTimePicker
        '
        Me.BdayDateTimePicker.CustomFormat = "mm/dd/yyyy"
        Me.BdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BdayDateTimePicker.Location = New System.Drawing.Point(135, 191)
        Me.BdayDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.BdayDateTimePicker.Name = "BdayDateTimePicker"
        Me.BdayDateTimePicker.Size = New System.Drawing.Size(118, 26)
        Me.BdayDateTimePicker.TabIndex = 4
        '
        'txtpword
        '
        Me.txtpword.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtpword.Location = New System.Drawing.Point(466, 113)
        Me.txtpword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpword.Name = "txtpword"
        Me.txtpword.Size = New System.Drawing.Size(148, 26)
        Me.txtpword.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(349, 117)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Password:"
        '
        'txtscode
        '
        Me.txtscode.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtscode.Location = New System.Drawing.Point(466, 151)
        Me.txtscode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtscode.Name = "txtscode"
        Me.txtscode.Size = New System.Drawing.Size(148, 26)
        Me.txtscode.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(349, 155)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Security Code:"
        '
        'btnregister
        '
        Me.btnregister.BackgroundImage = Global.BarangayBalintawak.My.Resources.Resources.register
        Me.btnregister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnregister.Location = New System.Drawing.Point(502, 196)
        Me.btnregister.Margin = New System.Windows.Forms.Padding(4)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(112, 52)
        Me.btnregister.TabIndex = 6
        Me.btnregister.UseVisualStyleBackColor = True
        '
        'cmbgender
        '
        Me.cmbgender.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(135, 153)
        Me.cmbgender.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(148, 27)
        Me.cmbgender.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(349, 41)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Position:"
        '
        'cmbposition
        '
        Me.cmbposition.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmbposition.FormattingEnabled = True
        Me.cmbposition.Location = New System.Drawing.Point(466, 36)
        Me.cmbposition.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbposition.Name = "cmbposition"
        Me.cmbposition.Size = New System.Drawing.Size(148, 27)
        Me.cmbposition.TabIndex = 8
        '
        'btnback
        '
        Me.btnback.BackgroundImage = Global.BarangayBalintawak.My.Resources.Resources.back
        Me.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnback.Location = New System.Drawing.Point(359, 196)
        Me.btnback.Margin = New System.Windows.Forms.Padding(4)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(112, 52)
        Me.btnback.TabIndex = 9
        Me.btnback.UseVisualStyleBackColor = True
        '
        'frnsignup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BarangayBalintawak.My.Resources.Resources.buttonBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(635, 266)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.cmbposition)
        Me.Controls.Add(Me.cmbgender)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.BdayDateTimePicker)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtscode)
        Me.Controls.Add(Me.txtpword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.txtfname)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frnsignup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtmname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtlname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtuname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BdayDateTimePicker As DateTimePicker
    Friend WithEvents txtpword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtscode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnregister As Button
    Friend WithEvents cmbgender As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbposition As ComboBox
    Friend WithEvents btnback As Button
End Class
