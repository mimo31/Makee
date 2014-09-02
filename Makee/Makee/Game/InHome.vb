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
        e.Graphics.DrawString("MACHINES", Form1.Font1, Brushes.Black, Math.Round(MovableObjectX * 1.5) - 115, Math.Round(MovableObjectY * 1.5) - 20)
    End Sub
End Class
