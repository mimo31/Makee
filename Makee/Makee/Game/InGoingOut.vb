Public Class InGoingOut
    Public Shared MapPositionX As Integer
    Public Shared MapPositionY As Integer
    Dim Zoom As Byte

    Public Shared Sub Paint(e As PaintEventArgs)
        Functions.DrawPause(e)
        Functions.DrawBack(e)
        Dim Counter As Integer
        Dim Counter2 As Integer
        Do While Counter < 101
            Do While Counter2 < 51
                PaintPoint(e, Counter, Counter2)
                Counter2 = Counter2 + 1
            Loop
            Counter2 = 0
            Counter = Counter + 1
        Loop
    End Sub

    Public Shared Sub PaintPoint(e As PaintEventArgs, x As Integer, y As Integer)
        Select Data.GetValue(x + MapPositionX, y + MapPositionY)
            Case 1
                e.Graphics.FillRectangle(Brushes.Gray, 150 + 16 * x, 150 + 16 * y, 16, 16)
            Case 2
                e.Graphics.FillRectangle(Brushes.DarkGreen, 150 + 16 * x, 150 + 16 * y, 16, 16)
            Case 3
                e.Graphics.FillRectangle(Brushes.Green, 150 + 16 * x, 150 + 16 * y, 16, 16)
            Case 4
                e.Graphics.FillRectangle(Brushes.LightGreen, 150 + 16 * x, 150 + 16 * y, 16, 16)
            Case 5
                e.Graphics.FillRectangle(Brushes.Blue, 150 + 16 * x, 150 + 16 * y, 16, 16)
        End Select
    End Sub

    Public Shared Sub Click(e As MouseEventArgs)

    End Sub
End Class
