Public Class Form1
    Private selected As PictureBox
    Private isDragging As Boolean
    Public position_X As Integer
    Public position_Y As Integer
    Public hmove As Cursor

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim ms As New System.IO.MemoryStream(My.Resources.H_MOVE)
        hmove = New Cursor(ms)
    End Sub

    Private Sub Box_MouseDown(sender As Object, e As MouseEventArgs) Handles Female_Box.MouseDown, Male_Box.MouseDown
        position_X = MousePosition.X
        position_Y = MousePosition.Y
        set_status("Position: " & position_X & ", " & position_Y)
        isDragging = True
        selected = sender
        selected.BringToFront()
        Cursor = hmove
    End Sub

    Private Sub Box_MouseHover(sender As Object, e As EventArgs) Handles Male_Box.MouseEnter, Female_Box.MouseEnter
        Cursor = Cursors.SizeAll
    End Sub

    Private Sub Box_MouseLeave(sender As Object, e As EventArgs) Handles Male_Box.MouseLeave, Female_Box.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Box_MouseMove(sender As Object, e As MouseEventArgs) Handles Female_Box.MouseMove, Male_Box.MouseMove
        If isDragging Then
            Console.WriteLine(selected.ToString & "TOP: " & selected.Top)
            Console.WriteLine(selected.ToString & "LEFT: " & selected.Left)
            If position_Y < MousePosition.Y Then
                selected.Top = selected.Top + (MousePosition.Y - position_Y)
            ElseIf position_Y > MousePosition.Y Then
                selected.Top = selected.Top - (position_Y - MousePosition.Y)
            End If
            position_Y = MousePosition.Y
            If position_X < MousePosition.X Then
                selected.Left = selected.Left + (MousePosition.X - position_X)
            ElseIf position_X > MousePosition.X Then
                selected.Left = selected.Left - (position_X - MousePosition.X)
            End If
            position_X = MousePosition.X
            set_status("Position: " & position_X & ", " & position_Y)
        End If
    End Sub

    Private Sub Box_MouseUp(sender As Object, e As MouseEventArgs) Handles Female_Box.MouseUp, Male_Box.MouseUp
        isDragging = False
        set_status("")
        Box_MouseHover(sender, e)
    End Sub

    Private Sub set_status(status As String)
        StatusLabel.Text = status
    End Sub
End Class
