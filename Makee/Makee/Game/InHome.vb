Public Class InHome
    Public Shared MovableObjectX As Integer
    Public Shared MovableObjectY As Integer

    Public Shared Sub Paint(e As PaintEventArgs)
        Form1.MinimumSize = New Size(700, 400)
        MovableObjectX = Math.Round(Form1.ClientSize.Width / 2)
        MovableObjectY = Math.Round(Form1.ClientSize.Height / 2)
        e.Graphics.FillRectangle(Brushes.Blue, 0, 0, MovableObjectX, MovableObjectY)
        e.Graphics.FillRectangle(Brushes.Green, MovableObjectX, 0, MovableObjectX, MovableObjectY)
        e.Graphics.FillRectangle(Brushes.Yellow, 0, MovableObjectY, MovableObjectX, MovableObjectY)
        e.Graphics.FillRectangle(Brushes.Red, MovableObjectX, MovableObjectY, MovableObjectX, MovableObjectY)
        Functions.DrawPause(e)
        e.Graphics.DrawString("MAKE", Form1.Font1, Brushes.White, Math.Round(MovableObjectX / 2) - 60, Math.Round(MovableObjectY / 2) - 20)
        e.Graphics.DrawString("GO OUTSIDE", Form1.Font1, Brushes.White, Math.Round(MovableObjectX * 1.5) - 125, Math.Round(MovableObjectY / 2) - 20)
        e.Graphics.DrawString("WAREHOUSE", Form1.Font1, Brushes.Black, Math.Round(MovableObjectX / 2) - 130, Math.Round(MovableObjectY * 1.5) - 20)
        e.Graphics.DrawString("MACHINES", Form1.Font1, Brushes.White, Math.Round(MovableObjectX * 1.5) - 115, Math.Round(MovableObjectY * 1.5) - 20)
    End Sub

    Public Shared Sub Click(e As MouseEventArgs)
        If Functions.ButtonPressed(e.X, e.Y, 0, 0, Math.Round(Form1.ClientSize.Width / 2), Math.Round(Form1.ClientSize.Height / 2)) = True Then
            Variables.InMake = True
            Variables.InHome = False
            Form1.Refresh()
        ElseIf Functions.ButtonPressed(e.X, e.Y, Form1.ClientSize.Width - 60, 0, 60, 60) = True Then
            Variables.Paused = True
            Form1.Refresh()
        ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(Form1.ClientSize.Width / 2), 0, Math.Round(Form1.ClientSize.Width / 2), Math.Round(Form1.ClientSize.Height / 2)) = True Then
            Variables.InGoingOut = True
            Variables.InHome = False
            Form1.Refresh()
        ElseIf Functions.ButtonPressed(e.X, e.Y, 0, Math.Round(Form1.ClientSize.Height / 2), Math.Round(Form1.ClientSize.Width / 2), Math.Round(Form1.ClientSize.Height / 2)) = True Then
            Variables.InWarehouse = True
            Variables.InHome = False
            Form1.Refresh()
        Else
            Variables.InMachines = True
            Variables.InHome = False
            Form1.Refresh()
        End If
    End Sub
End Class
