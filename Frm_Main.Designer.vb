<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
        Me.Tab_Results = New System.Windows.Forms.TabControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Dgv_Files = New System.Windows.Forms.DataGridView()
        Me.DgvLnk_Delete = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DgvTxt_FileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvTxt_FilePath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvTxt_Extension = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lnk_Export = New System.Windows.Forms.LinkLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rdo_Custom = New System.Windows.Forms.RadioButton()
        Me.Rdo_Common = New System.Windows.Forms.RadioButton()
        Me.Rdo_All = New System.Windows.Forms.RadioButton()
        Me.Ck_CRC32 = New System.Windows.Forms.CheckBox()
        Me.Ck_SHA384 = New System.Windows.Forms.CheckBox()
        Me.Ck_MD5 = New System.Windows.Forms.CheckBox()
        Me.Ck_SHA256 = New System.Windows.Forms.CheckBox()
        Me.Ck_SHA512 = New System.Windows.Forms.CheckBox()
        Me.Ck_SHA1 = New System.Windows.Forms.CheckBox()
        Me.Gp_DropZone = New System.Windows.Forms.GroupBox()
        Me.Btn_OpenFileDialog = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Lnk_RemoveAll = New System.Windows.Forms.LinkLabel()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Dgv_Files, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Gp_DropZone.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Results
        '
        Me.Tab_Results.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Results.Location = New System.Drawing.Point(0, 5)
        Me.Tab_Results.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tab_Results.Name = "Tab_Results"
        Me.Tab_Results.SelectedIndex = 0
        Me.Tab_Results.Size = New System.Drawing.Size(929, 474)
        Me.Tab_Results.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(814, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 45)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(2, 108)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(945, 629)
        Me.TabControl2.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Dgv_Files)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Size = New System.Drawing.Size(937, 596)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Files"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Dgv_Files
        '
        Me.Dgv_Files.AllowUserToAddRows = False
        Me.Dgv_Files.AllowUserToDeleteRows = False
        Me.Dgv_Files.AllowUserToOrderColumns = True
        Me.Dgv_Files.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_Files.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_Files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Files.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvLnk_Delete, Me.DgvTxt_FileName, Me.DgvTxt_FilePath, Me.DgvTxt_Extension})
        Me.Dgv_Files.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Files.Location = New System.Drawing.Point(4, 5)
        Me.Dgv_Files.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dgv_Files.Name = "Dgv_Files"
        Me.Dgv_Files.ReadOnly = True
        Me.Dgv_Files.RowHeadersWidth = 25
        Me.Dgv_Files.Size = New System.Drawing.Size(929, 586)
        Me.Dgv_Files.TabIndex = 1
        '
        'DgvLnk_Delete
        '
        Me.DgvLnk_Delete.HeaderText = ""
        Me.DgvLnk_Delete.MinimumWidth = 8
        Me.DgvLnk_Delete.Name = "DgvLnk_Delete"
        Me.DgvLnk_Delete.ReadOnly = True
        Me.DgvLnk_Delete.Text = "Remove"
        Me.DgvLnk_Delete.UseColumnTextForLinkValue = True
        Me.DgvLnk_Delete.Width = 8
        '
        'DgvTxt_FileName
        '
        Me.DgvTxt_FileName.HeaderText = "File Name"
        Me.DgvTxt_FileName.MinimumWidth = 8
        Me.DgvTxt_FileName.Name = "DgvTxt_FileName"
        Me.DgvTxt_FileName.ReadOnly = True
        Me.DgvTxt_FileName.Width = 116
        '
        'DgvTxt_FilePath
        '
        Me.DgvTxt_FilePath.HeaderText = "File Path"
        Me.DgvTxt_FilePath.MinimumWidth = 8
        Me.DgvTxt_FilePath.Name = "DgvTxt_FilePath"
        Me.DgvTxt_FilePath.ReadOnly = True
        Me.DgvTxt_FilePath.Width = 107
        '
        'DgvTxt_Extension
        '
        Me.DgvTxt_Extension.HeaderText = "Extension"
        Me.DgvTxt_Extension.MinimumWidth = 8
        Me.DgvTxt_Extension.Name = "DgvTxt_Extension"
        Me.DgvTxt_Extension.ReadOnly = True
        Me.DgvTxt_Extension.Width = 115
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel2)
        Me.TabPage4.Controls.Add(Me.Panel1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage4.Size = New System.Drawing.Size(937, 596)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Settings"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Tab_Results)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(4, 112)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(929, 479)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Lnk_Export)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Ck_CRC32)
        Me.Panel1.Controls.Add(Me.Ck_SHA384)
        Me.Panel1.Controls.Add(Me.Ck_MD5)
        Me.Panel1.Controls.Add(Me.Ck_SHA256)
        Me.Panel1.Controls.Add(Me.Ck_SHA512)
        Me.Panel1.Controls.Add(Me.Ck_SHA1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(4, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(929, 107)
        Me.Panel1.TabIndex = 2
        '
        'Lnk_Export
        '
        Me.Lnk_Export.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lnk_Export.AutoSize = True
        Me.Lnk_Export.Location = New System.Drawing.Point(861, 77)
        Me.Lnk_Export.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lnk_Export.Name = "Lnk_Export"
        Me.Lnk_Export.Size = New System.Drawing.Size(55, 20)
        Me.Lnk_Export.TabIndex = 5
        Me.Lnk_Export.TabStop = True
        Me.Lnk_Export.Text = "Export"
        Me.Lnk_Export.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rdo_Custom)
        Me.GroupBox2.Controls.Add(Me.Rdo_Common)
        Me.GroupBox2.Controls.Add(Me.Rdo_All)
        Me.GroupBox2.Location = New System.Drawing.Point(220, 37)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(273, 58)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'Rdo_Custom
        '
        Me.Rdo_Custom.AutoSize = True
        Me.Rdo_Custom.Location = New System.Drawing.Point(172, 23)
        Me.Rdo_Custom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Rdo_Custom.Name = "Rdo_Custom"
        Me.Rdo_Custom.Size = New System.Drawing.Size(89, 24)
        Me.Rdo_Custom.TabIndex = 5
        Me.Rdo_Custom.Text = "Custom"
        Me.Rdo_Custom.UseVisualStyleBackColor = True
        '
        'Rdo_Common
        '
        Me.Rdo_Common.AutoSize = True
        Me.Rdo_Common.Checked = True
        Me.Rdo_Common.Location = New System.Drawing.Point(72, 23)
        Me.Rdo_Common.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Rdo_Common.Name = "Rdo_Common"
        Me.Rdo_Common.Size = New System.Drawing.Size(98, 24)
        Me.Rdo_Common.TabIndex = 5
        Me.Rdo_Common.TabStop = True
        Me.Rdo_Common.Text = "Common"
        Me.Rdo_Common.UseVisualStyleBackColor = True
        '
        'Rdo_All
        '
        Me.Rdo_All.AutoSize = True
        Me.Rdo_All.Location = New System.Drawing.Point(9, 23)
        Me.Rdo_All.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Rdo_All.Name = "Rdo_All"
        Me.Rdo_All.Size = New System.Drawing.Size(51, 24)
        Me.Rdo_All.TabIndex = 5
        Me.Rdo_All.Text = "All"
        Me.Rdo_All.UseVisualStyleBackColor = True
        '
        'Ck_CRC32
        '
        Me.Ck_CRC32.AutoSize = True
        Me.Ck_CRC32.Checked = True
        Me.Ck_CRC32.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Ck_CRC32.Location = New System.Drawing.Point(9, 71)
        Me.Ck_CRC32.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ck_CRC32.Name = "Ck_CRC32"
        Me.Ck_CRC32.Size = New System.Drawing.Size(87, 24)
        Me.Ck_CRC32.TabIndex = 1
        Me.Ck_CRC32.Text = "CRC32"
        Me.Ck_CRC32.UseVisualStyleBackColor = True
        '
        'Ck_SHA384
        '
        Me.Ck_SHA384.AutoSize = True
        Me.Ck_SHA384.Location = New System.Drawing.Point(201, 6)
        Me.Ck_SHA384.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ck_SHA384.Name = "Ck_SHA384"
        Me.Ck_SHA384.Size = New System.Drawing.Size(96, 24)
        Me.Ck_SHA384.TabIndex = 0
        Me.Ck_SHA384.Text = "SHA384"
        Me.Ck_SHA384.UseVisualStyleBackColor = True
        '
        'Ck_MD5
        '
        Me.Ck_MD5.AutoSize = True
        Me.Ck_MD5.Checked = True
        Me.Ck_MD5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Ck_MD5.Location = New System.Drawing.Point(9, 38)
        Me.Ck_MD5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ck_MD5.Name = "Ck_MD5"
        Me.Ck_MD5.Size = New System.Drawing.Size(69, 24)
        Me.Ck_MD5.TabIndex = 0
        Me.Ck_MD5.Text = "MD5"
        Me.Ck_MD5.UseVisualStyleBackColor = True
        '
        'Ck_SHA256
        '
        Me.Ck_SHA256.AutoSize = True
        Me.Ck_SHA256.Location = New System.Drawing.Point(96, 6)
        Me.Ck_SHA256.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ck_SHA256.Name = "Ck_SHA256"
        Me.Ck_SHA256.Size = New System.Drawing.Size(96, 24)
        Me.Ck_SHA256.TabIndex = 0
        Me.Ck_SHA256.Text = "SHA256"
        Me.Ck_SHA256.UseVisualStyleBackColor = True
        '
        'Ck_SHA512
        '
        Me.Ck_SHA512.AutoSize = True
        Me.Ck_SHA512.Location = New System.Drawing.Point(306, 6)
        Me.Ck_SHA512.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ck_SHA512.Name = "Ck_SHA512"
        Me.Ck_SHA512.Size = New System.Drawing.Size(96, 24)
        Me.Ck_SHA512.TabIndex = 0
        Me.Ck_SHA512.Text = "SHA512"
        Me.Ck_SHA512.UseVisualStyleBackColor = True
        '
        'Ck_SHA1
        '
        Me.Ck_SHA1.AutoSize = True
        Me.Ck_SHA1.Checked = True
        Me.Ck_SHA1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Ck_SHA1.Location = New System.Drawing.Point(9, 6)
        Me.Ck_SHA1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ck_SHA1.Name = "Ck_SHA1"
        Me.Ck_SHA1.Size = New System.Drawing.Size(78, 24)
        Me.Ck_SHA1.TabIndex = 0
        Me.Ck_SHA1.Text = "SHA1"
        Me.Ck_SHA1.UseVisualStyleBackColor = True
        '
        'Gp_DropZone
        '
        Me.Gp_DropZone.Controls.Add(Me.Btn_OpenFileDialog)
        Me.Gp_DropZone.Location = New System.Drawing.Point(8, 9)
        Me.Gp_DropZone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Gp_DropZone.Name = "Gp_DropZone"
        Me.Gp_DropZone.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Gp_DropZone.Size = New System.Drawing.Size(798, 88)
        Me.Gp_DropZone.TabIndex = 6
        Me.Gp_DropZone.TabStop = False
        Me.Gp_DropZone.Text = "Drop Files Here"
        '
        'Btn_OpenFileDialog
        '
        Me.Btn_OpenFileDialog.Location = New System.Drawing.Point(748, 18)
        Me.Btn_OpenFileDialog.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_OpenFileDialog.Name = "Btn_OpenFileDialog"
        Me.Btn_OpenFileDialog.Size = New System.Drawing.Size(40, 60)
        Me.Btn_OpenFileDialog.TabIndex = 0
        Me.Btn_OpenFileDialog.Text = "..."
        Me.Btn_OpenFileDialog.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "All Files|*.*"
        Me.OpenFileDialog1.Multiselect = True
        '
        'Lnk_RemoveAll
        '
        Me.Lnk_RemoveAll.AutoSize = True
        Me.Lnk_RemoveAll.Location = New System.Drawing.Point(824, 68)
        Me.Lnk_RemoveAll.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lnk_RemoveAll.Name = "Lnk_RemoveAll"
        Me.Lnk_RemoveAll.Size = New System.Drawing.Size(89, 20)
        Me.Lnk_RemoveAll.TabIndex = 1
        Me.Lnk_RemoveAll.TabStop = True
        Me.Lnk_RemoveAll.Text = "Remove All"
        '
        'Frm_Main
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 737)
        Me.Controls.Add(Me.Lnk_RemoveAll)
        Me.Controls.Add(Me.Gp_DropZone)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Main"
        Me.Text = "CheckSum Tool"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Dgv_Files, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Gp_DropZone.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tab_Results As System.Windows.Forms.TabControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Dgv_Files As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Gp_DropZone As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_OpenFileDialog As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DgvLnk_Delete As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents DgvTxt_FileName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DgvTxt_FilePath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DgvTxt_Extension As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Ck_SHA384 As System.Windows.Forms.CheckBox
    Friend WithEvents Ck_MD5 As System.Windows.Forms.CheckBox
    Friend WithEvents Ck_SHA256 As System.Windows.Forms.CheckBox
    Friend WithEvents Ck_SHA512 As System.Windows.Forms.CheckBox
    Friend WithEvents Ck_SHA1 As System.Windows.Forms.CheckBox
    Friend WithEvents Ck_CRC32 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Rdo_Common As System.Windows.Forms.RadioButton
    Friend WithEvents Rdo_All As System.Windows.Forms.RadioButton
    Friend WithEvents Rdo_Custom As System.Windows.Forms.RadioButton
    Friend WithEvents Lnk_Export As System.Windows.Forms.LinkLabel
    Friend WithEvents Lnk_RemoveAll As System.Windows.Forms.LinkLabel

End Class
