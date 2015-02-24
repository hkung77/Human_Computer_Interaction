<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DirectoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.browse_button = New System.Windows.Forms.Button()
        Me.create_label = New System.Windows.Forms.Label()
        Me.ok_button = New System.Windows.Forms.Button()
        Me.cancel_button = New System.Windows.Forms.Button()
        Me.path_label = New System.Windows.Forms.Label()
        Me.copydir_label = New System.Windows.Forms.Label()
        Me.copyfile_label = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripCreate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripCopyDir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.subdirectory_label = New System.Windows.Forms.Label()
        Me.Name_textbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DirectoriesToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(528, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DirectoriesToolStripMenuItem
        '
        Me.DirectoriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDirectoryToolStripMenuItem, Me.CopyDirectoryToolStripMenuItem, Me.CopyFileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.DirectoriesToolStripMenuItem.Name = "DirectoriesToolStripMenuItem"
        Me.DirectoriesToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.DirectoriesToolStripMenuItem.Text = "Operations"
        '
        'NewDirectoryToolStripMenuItem
        '
        Me.NewDirectoryToolStripMenuItem.Name = "NewDirectoryToolStripMenuItem"
        Me.NewDirectoryToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NewDirectoryToolStripMenuItem.Text = "New Directory"
        '
        'CopyDirectoryToolStripMenuItem
        '
        Me.CopyDirectoryToolStripMenuItem.Name = "CopyDirectoryToolStripMenuItem"
        Me.CopyDirectoryToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CopyDirectoryToolStripMenuItem.Text = "Copy Directory"
        '
        'CopyFileToolStripMenuItem
        '
        Me.CopyFileToolStripMenuItem.Name = "CopyFileToolStripMenuItem"
        Me.CopyFileToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CopyFileToolStripMenuItem.Text = "Copy File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'browse_button
        '
        Me.browse_button.Location = New System.Drawing.Point(51, 137)
        Me.browse_button.Name = "browse_button"
        Me.browse_button.Size = New System.Drawing.Size(75, 23)
        Me.browse_button.TabIndex = 1
        Me.browse_button.Text = "Browse"
        Me.browse_button.UseVisualStyleBackColor = True
        Me.browse_button.Visible = False
        '
        'create_label
        '
        Me.create_label.AutoSize = True
        Me.create_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.create_label.Location = New System.Drawing.Point(130, 54)
        Me.create_label.Name = "create_label"
        Me.create_label.Size = New System.Drawing.Size(269, 25)
        Me.create_label.TabIndex = 2
        Me.create_label.Text = "Create in destination directory"
        Me.create_label.Visible = False
        '
        'ok_button
        '
        Me.ok_button.Enabled = False
        Me.ok_button.Location = New System.Drawing.Point(164, 322)
        Me.ok_button.Name = "ok_button"
        Me.ok_button.Size = New System.Drawing.Size(75, 23)
        Me.ok_button.TabIndex = 3
        Me.ok_button.Text = "OK"
        Me.ok_button.UseVisualStyleBackColor = True
        '
        'cancel_button
        '
        Me.cancel_button.Enabled = False
        Me.cancel_button.Location = New System.Drawing.Point(292, 322)
        Me.cancel_button.Name = "cancel_button"
        Me.cancel_button.Size = New System.Drawing.Size(75, 23)
        Me.cancel_button.TabIndex = 4
        Me.cancel_button.Text = "Cancel"
        Me.cancel_button.UseVisualStyleBackColor = True
        '
        'path_label
        '
        Me.path_label.AutoSize = True
        Me.path_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.path_label.Location = New System.Drawing.Point(132, 140)
        Me.path_label.Name = "path_label"
        Me.path_label.Size = New System.Drawing.Size(0, 20)
        Me.path_label.TabIndex = 5
        '
        'copydir_label
        '
        Me.copydir_label.AutoSize = True
        Me.copydir_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copydir_label.Location = New System.Drawing.Point(181, 54)
        Me.copydir_label.Name = "copydir_label"
        Me.copydir_label.Size = New System.Drawing.Size(173, 25)
        Me.copydir_label.TabIndex = 6
        Me.copydir_label.Text = "Copy this directory"
        Me.copydir_label.Visible = False
        '
        'copyfile_label
        '
        Me.copyfile_label.AutoSize = True
        Me.copyfile_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyfile_label.Location = New System.Drawing.Point(208, 54)
        Me.copyfile_label.Name = "copyfile_label"
        Me.copyfile_label.Size = New System.Drawing.Size(123, 25)
        Me.copyfile_label.TabIndex = 7
        Me.copyfile_label.Text = "Copy this file"
        Me.copyfile_label.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripCreate, Me.ToolStripCopyDir, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(528, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripCreate
        '
        Me.ToolStripCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripCreate.Image = CType(resources.GetObject("ToolStripCreate.Image"), System.Drawing.Image)
        Me.ToolStripCreate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCreate.Name = "ToolStripCreate"
        Me.ToolStripCreate.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripCreate.Text = "ToolStripButton1"
        '
        'ToolStripCopyDir
        '
        Me.ToolStripCopyDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripCopyDir.Image = CType(resources.GetObject("ToolStripCopyDir.Image"), System.Drawing.Image)
        Me.ToolStripCopyDir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCopyDir.Name = "ToolStripCopyDir"
        Me.ToolStripCopyDir.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripCopyDir.Text = "ToolStripButton2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 441)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(528, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'subdirectory_label
        '
        Me.subdirectory_label.AutoSize = True
        Me.subdirectory_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subdirectory_label.Location = New System.Drawing.Point(44, 248)
        Me.subdirectory_label.Name = "subdirectory_label"
        Me.subdirectory_label.Size = New System.Drawing.Size(210, 25)
        Me.subdirectory_label.TabIndex = 10
        Me.subdirectory_label.Text = "this new sub directory: "
        Me.subdirectory_label.Visible = False
        '
        'Name_textbox
        '
        Me.Name_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_textbox.Location = New System.Drawing.Point(306, 249)
        Me.Name_textbox.Name = "Name_textbox"
        Me.Name_textbox.Size = New System.Drawing.Size(191, 26)
        Me.Name_textbox.TabIndex = 11
        Me.Name_textbox.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "To:"
        Me.Label1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 463)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Name_textbox)
        Me.Controls.Add(Me.subdirectory_label)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.copyfile_label)
        Me.Controls.Add(Me.copydir_label)
        Me.Controls.Add(Me.path_label)
        Me.Controls.Add(Me.cancel_button)
        Me.Controls.Add(Me.ok_button)
        Me.Controls.Add(Me.create_label)
        Me.Controls.Add(Me.browse_button)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DirectoriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents browse_button As System.Windows.Forms.Button
    Friend WithEvents create_label As System.Windows.Forms.Label
    Friend WithEvents ok_button As System.Windows.Forms.Button
    Friend WithEvents cancel_button As System.Windows.Forms.Button
    Friend WithEvents path_label As System.Windows.Forms.Label
    Friend WithEvents copydir_label As System.Windows.Forms.Label
    Friend WithEvents copyfile_label As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripCreate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripCopyDir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents subdirectory_label As System.Windows.Forms.Label
    Friend WithEvents Name_textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
