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
        Me.Female_Box = New System.Windows.Forms.PictureBox()
        Me.Male_Box = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.Female_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Male_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Female_Box
        '
        Me.Female_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Female_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Female_Box.Image = CType(resources.GetObject("Female_Box.Image"), System.Drawing.Image)
        Me.Female_Box.Location = New System.Drawing.Point(88, 96)
        Me.Female_Box.Name = "Female_Box"
        Me.Female_Box.Size = New System.Drawing.Size(77, 93)
        Me.Female_Box.TabIndex = 0
        Me.Female_Box.TabStop = False
        '
        'Male_Box
        '
        Me.Male_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Male_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Male_Box.Image = CType(resources.GetObject("Male_Box.Image"), System.Drawing.Image)
        Me.Male_Box.InitialImage = CType(resources.GetObject("Male_Box.InitialImage"), System.Drawing.Image)
        Me.Male_Box.Location = New System.Drawing.Point(301, 120)
        Me.Male_Box.Name = "Male_Box"
        Me.Male_Box.Size = New System.Drawing.Size(73, 80)
        Me.Male_Box.TabIndex = 1
        Me.Male_Box.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 306)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(462, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 328)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Male_Box)
        Me.Controls.Add(Me.Female_Box)
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.Female_Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Male_Box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Female_Box As System.Windows.Forms.PictureBox
    Friend WithEvents Male_Box As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel

End Class
