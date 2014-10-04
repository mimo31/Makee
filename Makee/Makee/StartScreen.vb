Public Class StartScreen
    Public Shared MovableObjectsX As Single
    Public Shared MovableObjectsY As Single
    Public Shared Sub Click(e As MouseEventArgs)
        If Functions.ButtonPressed(e.X, e.Y, Math.Round((Form1.ClientSize.Width - 400) / 2), Math.Round((Form1.ClientSize.Height - 50) / 3), 400, 50) = True Then
            Variables.PlayStarting = True
            Variables.StartScreen = False
            Form1.Refresh()
        End If
    End Sub

    Public Shared Sub Paint(e As PaintEventArgs)
        MovableObjectsX = Math.Round((Form1.ClientSize.Width - 400) / 2)
        MovableObjectsY = Math.Round((Form1.ClientSize.Height - 50) / 3)
        e.Graphics.FillRectangle(Brushes.Black, MovableObjectsX, MovableObjectsY, 400, 50)
        e.Graphics.DrawString("Play", Form1.Font3, Brushes.White, MovableObjectsX + 170, MovableObjectsY + 10)
        MovableObjectsX = Math.Round((Form1.ClientSize.Width - 230) / 2)
        MovableObjectsY = Math.Round((Form1.ClientSize.Height - 50) / 6)
        e.Graphics.DrawString("Makee", Form1.Font4, Brushes.Black, MovableObjectsX, MovableObjectsY)
    End Sub

    Public Shared Sub Load()
        Form1.MinimumSize = New Size(800, 700)
        Variables.StartScreen = True
    End Sub
End Class
