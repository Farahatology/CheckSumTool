Imports System.IO

Public Class Frm_Main

    Private Sub Btn_OpenFileDialog_Click(sender As Object, e As EventArgs) Handles Btn_OpenFileDialog.Click
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each i In Me.OpenFileDialog1.FileNames
                Dim drow As New DataGridViewRow
                drow.CreateCells(Me.Dgv_Files)
                With drow
                    .Cells(1).Value = My.Computer.FileSystem.GetFileInfo(i).Name
                    .Cells(2).Value = i
                    .Cells(3).Value = My.Computer.FileSystem.GetFileInfo(i).Extension
                End With
                Me.Dgv_Files.Rows.Add(drow)
            Next
        End If
    End Sub
    Function Calculate(FilePath As String, HashProvider As Encryption.Hash.Provider) As String
        Dim localFile As New FileStream(FilePath,
                      FileMode.Open,
                      FileAccess.Read)
        Dim hash As New Encryption.Hash(HashProvider)
        hash.Calculate(localFile)
        Return hash.Value.Hex
    End Function
 

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tab_Results.TabPages.Clear()
        Me.TabControl2.SelectedIndex = 1
        For Each i As DataGridViewRow In Me.Dgv_Files.Rows
            Dim dt As New DataTable
            dt.Columns.Add("Type")
            dt.Columns.Add("Result")

            If Rdo_All.Checked = True Then
                Dim drow As DataRow = dt.NewRow
                drow(0) = "SHA1"
                drow(1) = Calculate(i.Cells(2).Value, Encryption.Hash.Provider.SHA1)
                dt.Rows.Add(drow)

                drow = dt.NewRow
                drow(0) = "SHA256"
                drow(1) = Calculate(i.Cells(2).Value, Encryption.Hash.Provider.SHA256)
                dt.Rows.Add(drow)

                drow = dt.NewRow
                drow(0) = "SHA384"
                drow(1) = Calculate(i.Cells(2).Value, Encryption.Hash.Provider.SHA384)
                dt.Rows.Add(drow)

                drow = dt.NewRow
                drow(0) = "SHA512"
                drow(1) = Calculate(i.Cells(2).Value, Encryption.Hash.Provider.SHA512)
                dt.Rows.Add(drow)

                drow = dt.NewRow
                drow(0) = "MD5"
                drow(1) = Calculate(i.Cells(2).Value, Encryption.Hash.Provider.MD5)
                dt.Rows.Add(drow)

                drow = dt.NewRow
                drow(0) = "CRC32"
                drow(1) = Calculate(i.Cells(2).Value, Encryption.Hash.Provider.CRC32)
                dt.Rows.Add(drow)
                AddNewResult(i.Cells(1).Value, dt)
                Continue For
            End If
            If Rdo_Common.Checked = True Then

                Dim drow As DataRow = dt.NewRow
                drow(0) = "SHA1"
                drow(1) = Calculate(i.Cells(2).Value, Encryption.Hash.Provider.SHA1)
                dt.Rows.Add(drow)

                drow = dt.NewRow
                drow(0) = "MD5"
                drow(1) = Calculate(i.Cells(2).Value, Encryption.Hash.Provider.MD5)
                dt.Rows.Add(drow)

                drow = dt.NewRow
                drow(0) = "CRC32"
                drow(1) = Calculate(i.Cells(2).Value, Encryption.Hash.Provider.CRC32)
                dt.Rows.Add(drow)
                AddNewResult(i.Cells(1).Value, dt)
                Continue For
            End If
            If Ck_SHA1.Checked Then
                Dim drow As DataRow = dt.NewRow
                drow(0) = "SHA1"
                drow(1) = Calculate(i.Cells(2).Value, Encryption.Hash.Provider.SHA1)
                dt.Rows.Add(drow)

            End If
            If Ck_SHA256.Checked Then
                Dim drow As DataRow = dt.NewRow
                drow(0) = "SHA256"
                drow(1) = Calculate(i.Cells(2).Value, Encryption.Hash.Provider.SHA256)
                dt.Rows.Add(drow)
            End If
            If Ck_SHA512.Checked Then
                Dim drow As DataRow = dt.NewRow
                drow(0) = "SHA512"
                drow(1) = Calculate(i.Cells(2).Value, Encryption.Hash.Provider.SHA512)
                dt.Rows.Add(drow)
            End If
            If Ck_SHA384.Checked Then
                Dim drow As DataRow = dt.NewRow
                drow(0) = "SHA384"
                drow(1) = Calculate(i.Cells(2).Value, Encryption.Hash.Provider.SHA384)
                dt.Rows.Add(drow)

            End If
            If Ck_CRC32.Checked Then
                Dim drow As DataRow = dt.NewRow
                drow(0) = "CRC32"
                drow(1) = Calculate(i.Cells(2).Value, Encryption.Hash.Provider.CRC32)
                dt.Rows.Add(drow)
            End If
            If Ck_MD5.Checked Then
                Dim drow As DataRow = dt.NewRow
                drow(0) = "MD5"
                drow(1) = Calculate(i.Cells(2).Value, Encryption.Hash.Provider.MD5)
                dt.Rows.Add(drow)
            End If
            AddNewResult(i.Cells(1).Value, dt)
        Next




    End Sub
    Sub AddNewResult(FileName As String, dt As DataTable)
        Dim Dgv As New DataGridView
        Dim NewTab As New TabPage
        With Dgv
            .AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
            .AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            .ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            .Dock = System.Windows.Forms.DockStyle.Fill
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .Location = New System.Drawing.Point(3, 3)
            .Name = "DataGridView1"
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .TabIndex = 0
            .DataSource = dt
            AddHandler .CellDoubleClick, AddressOf CellDoubleClickHandle
        End With
        With NewTab
            .Controls.Add(Dgv)
            .Location = New System.Drawing.Point(4, 22)
            .Name = "TabPage1"
            .Padding = New System.Windows.Forms.Padding(3)
            .TabIndex = 0
            .Text = FileName
            .UseVisualStyleBackColor = True
        End With
        Tab_Results.TabPages.Add(NewTab)
    End Sub
    Private Sub Dgv_Files_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Files.CellClick
        If e.ColumnIndex = 0 Then
            Me.Dgv_Files.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub
    Private Sub Rdo_Common_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_Common.CheckedChanged
        If Rdo_All.Checked Then
            Ck_SHA1.Enabled = False
            Ck_SHA256.Enabled = False
            Ck_SHA384.Enabled = False
            Ck_SHA512.Enabled = False
            Ck_CRC32.Enabled = False
            Ck_MD5.Enabled = False

            Ck_SHA1.Checked = True
            Ck_SHA256.Checked = True
            Ck_SHA384.Checked = True
            Ck_SHA512.Checked = True
            Ck_CRC32.Checked = True
            Ck_MD5.Checked = True
        ElseIf Rdo_Common.Checked Then
            Ck_SHA1.Enabled = False
            Ck_SHA256.Enabled = False
            Ck_SHA384.Enabled = False
            Ck_SHA512.Enabled = False
            Ck_CRC32.Enabled = False
            Ck_MD5.Enabled = False

            Ck_SHA1.Checked = True
            Ck_SHA256.Checked = False
            Ck_SHA384.Checked = False
            Ck_SHA512.Checked = False
            Ck_CRC32.Checked = True
            Ck_MD5.Checked = True
        ElseIf Rdo_Custom.Checked Then
            Ck_SHA1.Checked = False
            Ck_SHA256.Checked = False
            Ck_SHA384.Checked = False
            Ck_SHA512.Checked = False
            Ck_CRC32.Checked = False
            Ck_MD5.Checked = False

            Ck_SHA1.Enabled = True
            Ck_SHA256.Enabled = True
            Ck_SHA384.Enabled = True
            Ck_SHA512.Enabled = True
            Ck_CRC32.Enabled = True
            Ck_MD5.Enabled = True
        End If
    End Sub

    Private Sub TabControl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl2.SelectedIndexChanged
        If TabControl2.SelectedIndex = 1 Then
            Lnk_RemoveAll.Enabled = False
        Else
            Lnk_RemoveAll.Enabled = True
        End If
    End Sub

    Private Sub TabControl2_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl2.Selecting
        If e.Action = TabControlAction.Selecting Then
            If Me.Dgv_Files.Rows.Count = 0 Then
                e.Cancel = True
            Else
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub Lnk_Export_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnk_Export.LinkClicked

    End Sub


    Private Sub Frm_Main_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each i In files
            Dim drow As New DataGridViewRow
            drow.CreateCells(Me.Dgv_Files)
            With drow
                .Cells(1).Value = My.Computer.FileSystem.GetFileInfo(i).Name
                .Cells(2).Value = i
                .Cells(3).Value = My.Computer.FileSystem.GetFileInfo(i).Extension
            End With
            Me.Dgv_Files.Rows.Add(drow)
        Next
    End Sub

    Private Sub Frm_Main_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Lnk_RemoveAll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnk_RemoveAll.LinkClicked
        Me.Dgv_Files.Rows.Clear()
    End Sub
    Private Sub CellDoubleClickHandle(sender As Object, e As DataGridViewCellEventArgs)
        My.Computer.Clipboard.SetText(DirectCast(sender, DataGridView).Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    End Sub

 
End Class
