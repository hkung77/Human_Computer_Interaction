Public Class Form1
    Private saveDestination As String
    Public Sub set_saveDestination(path As String)
        saveDestination = path

        'This option is for setting the active form title as filename instead of path
        'Dim name As String = Split(path, "\").Last
        'setTitle(name)

        setTitle(path)
    End Sub

    Public Function get_saveDestination()
        Return saveDestination
    End Function

    Public Function getText()
        Return RTB.Text
    End Function
    Public Sub setTitle(title As String)
        Me.Text = title
    End Sub
    Public Sub save_file()
        RTB.SaveFile(saveDestination, RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub Form1_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        MDIParent1.set_ActiveFile(Me)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        saveDestination = ""
    End Sub

End Class

