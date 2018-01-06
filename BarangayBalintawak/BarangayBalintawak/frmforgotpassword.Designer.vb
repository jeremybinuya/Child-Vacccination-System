<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmforgotpassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmforgotpassword))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsecretcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnewpass = New System.Windows.Forms.TextBox()
        Me.btnchangepass = New System.Windows.Forms.Button()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(77, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your Username:"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(252, 61)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(176, 25)
        Me.txtusername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(77, 99)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter Your Secret Code:"
        '
        'txtsecretcode
        '
        Me.txtsecretcode.Location = New System.Drawing.Point(252, 95)
        Me.txtsecretcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsecretcode.Name = "txtsecretcode"
        Me.txtsecretcode.Size = New System.Drawing.Size(176, 25)
        Me.txtsecretcode.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(165, 247)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter Your New Password:"
        Me.Label3.Visible = False
        '
        'txtnewpass
        '
        Me.txtnewpass.Location = New System.Drawing.Point(165, 280)
        Me.txtnewpass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpass.Size = New System.Drawing.Size(176, 25)
        Me.txtnewpass.TabIndex = 1
        Me.txtnewpass.Visible = False
        '
        'btnchangepass
        '
        Me.btnchangepass.BackgroundImage = Global.BarangayBalintawak.My.Resources.Resources.changepass
        Me.btnchangepass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnchangepass.Location = New System.Drawing.Point(165, 314)
        Me.btnchangepass.Margin = New System.Windows.Forms.Padding(4)
        Me.btnchangepass.Name = "btnchangepass"
        Me.btnchangepass.Size = New System.Drawing.Size(177, 60)
        Me.btnchangepass.TabIndex = 3
        Me.btnchangepass.UseVisualStyleBackColor = True
        Me.btnchangepass.Visible = False
        '
        'btnconfirm
        '
        Me.btnconfirm.BackgroundImage = Global.BarangayBalintawak.My.Resources.Resources.confirm
        Me.btnconfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnconfirm.Location = New System.Drawing.Point(257, 147)
        Me.btnconfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(117, 43)
        Me.btnconfirm.TabIndex = 3
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.BarangayBalintawak.My.Resources.Resources.back
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(136, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 43)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmforgotpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BarangayBalintawak.My.Resources.Resources.buttonBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(512, 390)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnchangepass)
        Me.Controls.Add(Me.btnconfirm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnewpass)
        Me.Controls.Add(Me.txtsecretcode)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmforgotpassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsecretcode As TextBox
    Friend WithEvents btnconfirm As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnewpass As TextBox
    Friend WithEvents btnchangepass As Button
    Friend WithEvents Button1 As Button
End Class
