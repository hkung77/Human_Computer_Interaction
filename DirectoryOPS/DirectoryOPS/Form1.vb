Public Class Form1
    Public state As String
    Public path_name As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        state = ""
        path_name = ""
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutbox As New AboutBox
        aboutbox.Show()
    End Sub


    Private Sub ToolStripCreate_Click(sender As Object, e As EventArgs) Handles ToolStripCreate.Click, NewDirectoryToolStripMenuItem.Click
        copydir_label.Visible = False
        copyfile_label.Visible = False
        cancel_button.Enabled = True
        create_label.Show()
        browse_button.Show()
        ok_button.Show()
        cancel_button.Show()
        path_label.Text = ""
        set_status("Creating new directory")
        state = "Create"
        reset()
    End Sub

    
    Private Sub ToolStripCopyDir_Click(sender As Object, e As EventArgs) Handles ToolStripCopyDir.Click, CopyDirectoryToolStripMenuItem.Click
        create_label.Visible = False
        copyfile_label.Visible = False
        cancel_button.Enabled = True
        copydir_label.Show()
        browse_button.Show()
        ok_button.Show()
        cancel_button.Show()
        path_label.Text = ""
        set_status("Copying directory")
        state = "Copydir"
        reset()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click, CopyFileToolStripMenuItem.Click
        create_label.Visible = False
        copydir_label.Visible = False
        cancel_button.Enabled = True
        copyfile_label.Show()
        browse_button.Show()
        ok_button.Show()
        cancel_button.Show()
        path_label.Text = ""
        set_status("Copying file")
        state = "Copyfile"
        reset()
    End Sub

    Private Sub set_status(status As String)
        StatusLabel.Text = status
    End Sub

    Private Sub browse_button_Click(sender As Object, e As EventArgs) Handles browse_button.Click
        If state.Equals("Copyfile") Then
            Dim OpenFileDialog As New OpenFileDialog
            OpenFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop
            If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
                path_name = OpenFileDialog.FileName
                handle_after_directorybrowse()
            End If
            path_label.Text = path_name
        Else
            Dim FolderFileDialog As New FolderBrowserDialog
            FolderFileDialog.RootFolder = Environment.SpecialFolder.Desktop
            FolderFileDialog.ShowNewFolderButton = False

            If FolderFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                path_name = FolderFileDialog.SelectedPath
                handle_after_directorybrowse()

            End If
            path_label.Text = path_name
        End If
    End Sub

    Private Sub handle_after_directorybrowse()
        If state.Equals("Create") Then
            subdirectory_label.Show()
            Name_textbox.Show()
        ElseIf state.Equals("Copydir") Then
            Label1.Show()
            subdirectory_label.Text = path_name.Substring(0, path_name.LastIndexOf("\") + 1)
            subdirectory_label.Show()
            Name_textbox.Show()
        ElseIf state.Equals("Copyfile") Then
            Label1.Show()
            subdirectory_label.Text = path_name.Substring(0, path_name.LastIndexOf("\") + 1)
            subdirectory_label.Show()
            Name_textbox.Show()
        End If
    End Sub

    Private Sub cancel_button_Click(sender As Object, e As EventArgs) Handles cancel_button.Click
        create_label.Visible = False
        cancel_button.Enabled = False
        copydir_label.Visible = False
        copyfile_label.Visible = False
        browse_button.Visible = False
        subdirectory_label.Visible = False
        Name_textbox.Visible = False
        set_status("")
        path_label.Text = ""
    End Sub


    Private Sub Name_label_KeyDown(sender As Object, e As KeyEventArgs) Handles Name_textbox.KeyUp
        If Name_textbox.Text.Equals("") Then
            ok_button.Enabled = False
        Else
            ok_button.Enabled = True
        End If
    End Sub

    Private Sub reset()
        subdirectory_label.Visible = False
        Name_textbox.Text = ""
        Name_textbox.Visible = False

    End Sub

    Private Sub create_folder()
        set_status("Created new directory " & path_label.Text & "/" & Name_textbox.Text)
        My.Computer.FileSystem.CreateDirectory(path_label.Text & "/" & Name_textbox.Text)
    End Sub
    Private Sub copy_folder()
        set_status("Copying directory " & path_name)
        My.Computer.FileSystem.CopyDirectory(path_name, subdirectory_label.Text & Name_textbox.Text, True)
    End Sub

    Private Sub copy_file()
        set_status("Copying file " & path_name)
        My.Computer.FileSystem.CopyFile(path_name, subdirectory_label.Text & Name_textbox.Text, True)
    End Sub

    Private Sub ok_button_Click(sender As Object, e As EventArgs) Handles ok_button.Click
        If state.Equals("Create") Then
            create_folder()
        ElseIf state.Equals("Copydir") Then
            copy_folder()
        ElseIf state.Equals("Copyfile") Then
            copy_file()
        End If
        ok_button.Enabled = False
    End Sub


End Class
