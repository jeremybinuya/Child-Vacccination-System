<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmaddchild
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmaddchild))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpbday = New System.Windows.Forms.DateTimePicker()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtcpurok = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtcmother = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcage = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcnumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbpurok = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpdatecompletion = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnamebrgy = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnameRHUBHS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnviewvaccine = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnsummary = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dtpbday)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.txtcpurok)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtcmother)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtcage)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtcname)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtcnumber)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 267)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(510, 273)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Child Information"
        '
        'dtpbday
        '
        Me.dtpbday.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar
        Me.dtpbday.CustomFormat = "mm/dd/yyyy"
        Me.dtpbday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpbday.Location = New System.Drawing.Point(190, 132)
        Me.dtpbday.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpbday.Name = "dtpbday"
        Me.dtpbday.Size = New System.Drawing.Size(118, 26)
        Me.dtpbday.TabIndex = 1
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(37, 619)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(148, 26)
        Me.TextBox4.TabIndex = 1
        '
        'txtcpurok
        '
        Me.txtcpurok.BackColor = System.Drawing.Color.Gainsboro
        Me.txtcpurok.Location = New System.Drawing.Point(190, 220)
        Me.txtcpurok.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcpurok.Name = "txtcpurok"
        Me.txtcpurok.Size = New System.Drawing.Size(271, 26)
        Me.txtcpurok.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 219)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(167, 38)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Detailed Address in purok" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Indicate Landmarks)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtcmother
        '
        Me.txtcmother.BackColor = System.Drawing.Color.Gainsboro
        Me.txtcmother.Location = New System.Drawing.Point(190, 176)
        Me.txtcmother.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcmother.Name = "txtcmother"
        Me.txtcmother.Size = New System.Drawing.Size(271, 26)
        Me.txtcmother.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 182)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 19)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Name of Mother:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 139)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 19)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Date of Birth:"
        '
        'txtcage
        '
        Me.txtcage.BackColor = System.Drawing.Color.Gainsboro
        Me.txtcage.Enabled = False
        Me.txtcage.Location = New System.Drawing.Point(190, 93)
        Me.txtcage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcage.Name = "txtcage"
        Me.txtcage.Size = New System.Drawing.Size(40, 26)
        Me.txtcage.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 96)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Child Age:"
        '
        'txtcname
        '
        Me.txtcname.BackColor = System.Drawing.Color.Gainsboro
        Me.txtcname.Location = New System.Drawing.Point(190, 57)
        Me.txtcname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(148, 26)
        Me.txtcname.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 60)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Name of Child:"
        '
        'txtcnumber
        '
        Me.txtcnumber.BackColor = System.Drawing.Color.Gainsboro
        Me.txtcnumber.Location = New System.Drawing.Point(87, 27)
        Me.txtcnumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcnumber.Name = "txtcnumber"
        Me.txtcnumber.ReadOnly = True
        Me.txtcnumber.Size = New System.Drawing.Size(37, 26)
        Me.txtcnumber.TabIndex = 1
        Me.txtcnumber.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 31)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Number"
        Me.Label7.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(35, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 19)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Name of Health Personnel:"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Location = New System.Drawing.Point(35, 52)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(51, 19)
        Me.lblname.TabIndex = 62
        Me.lblname.Text = "Label2"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbpurok)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpdatecompletion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtnamebrgy)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtnameRHUBHS)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 75)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(510, 184)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        '
        'cmbpurok
        '
        Me.cmbpurok.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbpurok.FormattingEnabled = True
        Me.cmbpurok.Items.AddRange(New Object() {"Purok 1", "Purok 2", "Purok 3", "Purok 4", "Purok 5", "Purok 6", "Purok 7", "Purok 8", "Purok 9", "Purok 10", "Purok 11"})
        Me.cmbpurok.Location = New System.Drawing.Point(174, 95)
        Me.cmbpurok.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbpurok.Name = "cmbpurok"
        Me.cmbpurok.Size = New System.Drawing.Size(179, 27)
        Me.cmbpurok.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 137)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Date Completion:"
        '
        'dtpdatecompletion
        '
        Me.dtpdatecompletion.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar
        Me.dtpdatecompletion.CustomFormat = "mm/dd/yyyy"
        Me.dtpdatecompletion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdatecompletion.Location = New System.Drawing.Point(174, 137)
        Me.dtpdatecompletion.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpdatecompletion.Name = "dtpdatecompletion"
        Me.dtpdatecompletion.Size = New System.Drawing.Size(118, 26)
        Me.dtpdatecompletion.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 99)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Name of Purok:"
        '
        'txtnamebrgy
        '
        Me.txtnamebrgy.BackColor = System.Drawing.Color.Gainsboro
        Me.txtnamebrgy.Location = New System.Drawing.Point(174, 57)
        Me.txtnamebrgy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnamebrgy.Name = "txtnamebrgy"
        Me.txtnamebrgy.Size = New System.Drawing.Size(319, 26)
        Me.txtnamebrgy.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 61)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Name of Barangay:"
        '
        'txtnameRHUBHS
        '
        Me.txtnameRHUBHS.BackColor = System.Drawing.Color.Gainsboro
        Me.txtnameRHUBHS.Location = New System.Drawing.Point(174, 19)
        Me.txtnameRHUBHS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnameRHUBHS.Name = "txtnameRHUBHS"
        Me.txtnameRHUBHS.Size = New System.Drawing.Size(319, 26)
        Me.txtnameRHUBHS.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name of RHU/BHS:"
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AllowUserToResizeColumns = False
        Me.dgvData.AllowUserToResizeRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.ColumnHeadersVisible = False
        Me.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvData.Location = New System.Drawing.Point(561, 114)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvData.MultiSelect = False
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(508, 352)
        Me.dgvData.TabIndex = 105
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtsearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(561, 474)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsearch.Multiline = True
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(361, 38)
        Me.txtsearch.TabIndex = 106
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(782, 91)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 19)
        Me.Label13.TabIndex = 111
        Me.Label13.Text = "Age"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(936, 91)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 19)
        Me.Label14.TabIndex = 109
        Me.Label14.Text = "Name of Mother"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(592, 91)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 19)
        Me.Label15.TabIndex = 110
        Me.Label15.Text = "Name of Child"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(566, 482)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(197, 21)
        Me.Label16.TabIndex = 112
        Me.Label16.Text = "Search Box (Enter name)"
        '
        'btnlogout
        '
        Me.btnlogout.BackgroundImage = Global.BarangayBalintawak.My.Resources.Resources.logout
        Me.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlogout.Location = New System.Drawing.Point(930, 20)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(139, 51)
        Me.btnlogout.TabIndex = 113
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.BackgroundImage = Global.BarangayBalintawak.My.Resources.Resources.delete
        Me.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndelete.Location = New System.Drawing.Point(930, 532)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(139, 46)
        Me.btndelete.TabIndex = 108
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnviewvaccine
        '
        Me.btnviewvaccine.BackgroundImage = Global.BarangayBalintawak.My.Resources.Resources.viewvaccine
        Me.btnviewvaccine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnviewvaccine.Enabled = False
        Me.btnviewvaccine.Location = New System.Drawing.Point(930, 473)
        Me.btnviewvaccine.Margin = New System.Windows.Forms.Padding(4)
        Me.btnviewvaccine.Name = "btnviewvaccine"
        Me.btnviewvaccine.Size = New System.Drawing.Size(139, 52)
        Me.btnviewvaccine.TabIndex = 107
        Me.btnviewvaccine.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.BackgroundImage = Global.BarangayBalintawak.My.Resources.Resources.savee
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.Location = New System.Drawing.Point(26, 548)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(139, 58)
        Me.btnsave.TabIndex = 64
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnsummary
        '
        Me.btnsummary.BackgroundImage = Global.BarangayBalintawak.My.Resources.Resources.Summary
        Me.btnsummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsummary.Location = New System.Drawing.Point(786, 532)
        Me.btnsummary.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsummary.Name = "btnsummary"
        Me.btnsummary.Size = New System.Drawing.Size(139, 46)
        Me.btnsummary.TabIndex = 108
        Me.btnsummary.UseVisualStyleBackColor = True
        '
        'frmaddchild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BarangayBalintawak.My.Resources.Resources.main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1089, 622)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnsummary)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnviewvaccine)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmaddchild"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Child Vaccination Monitoring System"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnameRHUBHS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnamebrgy As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpdatecompletion As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbpurok As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblname As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcnumber As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcage As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcmother As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtcpurok As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents dtpbday As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnsave As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnviewvaccine As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnsummary As Button
End Class
