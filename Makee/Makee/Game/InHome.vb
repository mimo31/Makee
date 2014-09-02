Public Class InHome
    Public Shared MovableObjectX As Integer
    Public Shared MovableObjectY As Integer

    Public Shared Sub Paint(e As PaintEventArgs)
        MovableObjectX = Math.Round(Form1.ClientSize.Width / 2)
        MovableObjectY = Math.Round(Form1.ClientSize.Height / 2)
        e.Graphics.FillRectangle(Brushes.Blue, 0, 0, MovableObjectX, MovableObjectY)
        e.Graphics.FillRectangle(Brushes.Green, MovableObjectX, 0, MovableObjectX, MovableObjectY)
        e.Graphics.FillRectangle(Brushes.Yellow, 0, MovableObjectY, MovableObjectX, MovableObjectY)
        e.Graphics.FillRectangle(Brushes.Red, MovableObjectX, MovableObjectY, MovableObjectX, MovableObjectY)
        Functions.DrawPause(e)
    End Sub
End Class
