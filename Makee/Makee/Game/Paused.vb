Public Class Paused
    Public Shared MovableObjectX As Single
    Public Shared MovableObjectY As Single

    Public Shared Sub Paint(e As PaintEventArgs)
        Form1.MinimumSize = New Size(700, 800)
        Functions.DrawBack(e)
        MovableObjectX = Math.Round(Form1.ClientSize.Width / 2) - 200
        MovableObjectY = Math.Round(Form1.ClientSize.Height / 2) - 200
        e.Graphics.FillRectangle(Brushes.Gray, MovableObjectX, MovableObjectY, 400, 50)
        e.Graphics.FillRectangle(Brushes.Gray, MovableObjectX, MovableObjectY + 70, 400, 50)
        e.Graphics.FillRectangle(Brushes.Gray, MovableObjectX, MovableObjectY + 140, 400, 50)
        e.Graphics.FillRectangle(Brushes.Gray, MovableObjectX, MovableObjectY + 210, 400, 50)
        e.Graphics.DrawString("Back", Form1.Font1, Brushes.White, MovableObjectX + 150, MovableObjectY + 2)
        e.Graphics.DrawString("Achievements", Form1.Font1, Brushes.White, MovableObjectX + 70, MovableObjectY + 72)
        e.Graphics.DrawString("Save", Form1.Font1, Brushes.White, MovableObjectX + 150, MovableObjectY + 142)
        e.Graphics.DrawString("Save & Quit", Form1.Font1, Brushes.White, MovableObjectX + 90, MovableObjectY + 212)
    End Sub

    Public Shared Sub Click(e As MouseEventArgs)
        If Functions.ButtonPressed(e.X, e.Y, 5, 5, 100, 40) = True Or Functions.ButtonPressed(e.X, e.Y, Math.Round(Form1.ClientSize.Width / 2) - 200, Math.Round(Form1.ClientSize.Height / 2) - 200, 400, 50) = True Then
            Variables.Paused = False
            Form1.Refresh()
        ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(Form1.ClientSize.Width / 2) - 200, Math.Round(Form1.ClientSize.Height / 2) - 130, 400, 50) = True Then
            Variables.Achievements = True
            Form1.Refresh()
        ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(Form1.ClientSize.Width / 2) - 200, Math.Round(Form1.ClientSize.Height / 2) - 60, 400, 50) = True Then
            Data.SaveGame()
        ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(Form1.ClientSize.Width / 2) - 200, Math.Round(Form1.ClientSize.Height / 2) + 10, 400, 50) = True Then
            Variables.Paused = False
            Variables.InHome = False
            Variables.InGoingOut = False
            Data.SaveGame()
            Data.QuitGame()
            Form1.Refresh()
        End If
    End Sub
End Class
