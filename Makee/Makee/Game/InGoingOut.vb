Public Class InGoingOut
    Public Shared MapPositionX As Integer
    Public Shared MapPositionY As Integer
    Public Shared OnUp As Boolean
    Public Shared OnDown As Boolean
    Public Shared OnRight As Boolean
    Public Shared OnLeft As Boolean
    Public Shared OnUpRight As Boolean
    Public Shared OnDownRight As Boolean
    Public Shared OnUpLeft As Boolean
    Public Shared OnDownLeft As Boolean
    Dim Zoom As Byte

    Public Shared Sub Paint(e As PaintEventArgs)
        Functions.DrawPause(e)
        Functions.DrawBack(e)
        Dim Counter As Integer
        Dim Counter2 As Integer
        Do While Counter < (Form1.ClientSize.Width - 300) / 16
            Do While Counter2 < (Form1.ClientSize.Height - 300) / 16
                PaintPoint(e, Counter, Counter2)
                Counter2 = Counter2 + 1
            Loop
            Counter2 = 0
            Counter = Counter + 1
        Loop
        Variables.ChunksValues(0, 0, 0) = 6
        e.Graphics.FillRectangle(Brushes.DarkRed, 100, 100, 50, 50)
        e.Graphics.FillRectangle(Brushes.Red, 150, 100, Form1.ClientSize.Width - 300, 50)
        e.Graphics.FillRectangle(Brushes.DarkRed, Form1.ClientSize.Width - 150, 100, 50, 50)
        e.Graphics.FillRectangle(Brushes.Red, Form1.ClientSize.Width - 150, 150, 50, Form1.ClientSize.Height - 300)
        e.Graphics.FillRectangle(Brushes.DarkRed, Form1.ClientSize.Width - 150, Form1.ClientSize.Height - 150, 50, 50)
        e.Graphics.FillRectangle(Brushes.Red, 150, Form1.ClientSize.Height - 150, Form1.ClientSize.Width - 300, 50)
        e.Graphics.FillRectangle(Brushes.DarkRed, 100, Form1.ClientSize.Height - 150, 50, 50)
        e.Graphics.FillRectangle(Brushes.Red, 100, 150, 50, Form1.ClientSize.Height - 300)
        e.Graphics.FillPolygon(Brushes.White, {New PointF(Form1.ClientSize.Width / 2 - 50, 140), New PointF(Form1.ClientSize.Width / 2, 120), New PointF(Form1.ClientSize.Width / 2 + 50, 140), New PointF(Form1.ClientSize.Width / 2 + 65, 140), New PointF(Form1.ClientSize.Width / 2, 110), New PointF(Form1.ClientSize.Width / 2 - 65, 140)})
        e.Graphics.FillPolygon(Brushes.White, {New PointF(Form1.ClientSize.Width / 2 - 50, Form1.ClientSize.Height - 140), New PointF(Form1.ClientSize.Width / 2, Form1.ClientSize.Height - 120), New PointF(Form1.ClientSize.Width / 2 + 50, Form1.ClientSize.Height - 140), New PointF(Form1.ClientSize.Width / 2 + 65, Form1.ClientSize.Height - 140), New PointF(Form1.ClientSize.Width / 2, Form1.ClientSize.Height - 110), New PointF(Form1.ClientSize.Width / 2 - 65, Form1.ClientSize.Height - 140)})
        e.Graphics.FillPolygon(Brushes.White, {New PointF(140, Form1.ClientSize.Height / 2 - 65), New PointF(110, Form1.ClientSize.Height / 2), New PointF(140, Form1.ClientSize.Height / 2 + 65), New PointF(140, Form1.ClientSize.Height / 2 + 50), New PointF(120, Form1.ClientSize.Height / 2), New PointF(140, Form1.ClientSize.Height / 2 - 50)})
        e.Graphics.FillPolygon(Brushes.White, {New PointF(Form1.ClientSize.Width - 140, Form1.ClientSize.Height / 2 - 65), New PointF(Form1.ClientSize.Width - 110, Form1.ClientSize.Height / 2), New PointF(Form1.ClientSize.Width - 140, Form1.ClientSize.Height / 2 + 65), New PointF(Form1.ClientSize.Width - 140, Form1.ClientSize.Height / 2 + 50), New PointF(Form1.ClientSize.Width - 120, Form1.ClientSize.Height / 2), New PointF(Form1.ClientSize.Width - 140, Form1.ClientSize.Height / 2 - 50)})
        e.Graphics.FillRectangle(Brushes.White, 110, 110, 5, 30)
        e.Graphics.FillRectangle(Brushes.White, 115, 110, 25, 5)
        e.Graphics.FillRectangle(Brushes.White, Form1.ClientSize.Width - 115, 110, 5, 30)
        e.Graphics.FillRectangle(Brushes.White, Form1.ClientSize.Width - 140, 110, 25, 5)
        e.Graphics.FillRectangle(Brushes.White, 110, Form1.ClientSize.Height - 140, 5, 30)
        e.Graphics.FillRectangle(Brushes.White, 115, Form1.ClientSize.Height - 115, 25, 5)
        e.Graphics.FillRectangle(Brushes.White, Form1.ClientSize.Width - 115, Form1.ClientSize.Height - 140, 5, 30)
        e.Graphics.FillRectangle(Brushes.White, Form1.ClientSize.Width - 140, Form1.ClientSize.Height - 115, 25, 5)
    End Sub

    Public Shared Sub PaintPoint(e As PaintEventArgs, x As Integer, y As Integer)
        Select Case Data.GetValue(x + MapPositionX, y + MapPositionY)
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
            Case 6
                e.Graphics.DrawImage(New Bitmap(My.Resources.Base1, 16, 16), 150 + 16 * x, 150 + 16 * y)
        End Select
    End Sub

    Public Shared Sub Click(e As MouseEventArgs)
        If Functions.ButtonPressed(e.X, e.Y, 5, 5, 100, 40) Then
            Variables.InGoingOut = False
            Variables.InHome = True
            Form1.Refresh()
        End If
    End Sub

    Public Shared Sub TimerTick()
        If OnDown = True Then
            MapPositionY = MapPositionY + 1
        ElseIf OnUp = True Then
            MapPositionY = MapPositionY - 1
        ElseIf OnRight = True Then
            MapPositionX = MapPositionX + 1
        ElseIf OnLeft = True Then
            MapPositionX = MapPositionX - 1
        ElseIf OnUpLeft = True Then
            MapPositionY = MapPositionY - 1
            MapPositionX = MapPositionX - 1
        ElseIf OnDownLeft = True Then
            MapPositionY = MapPositionY + 1
            MapPositionX = MapPositionX - 1
        ElseIf OnUpRight = True Then
            MapPositionY = MapPositionY - 1
            MapPositionX = MapPositionX + 1
        ElseIf OnDownRight = True Then
            MapPositionY = MapPositionY + 1
            MapPositionX = MapPositionX + 1
        End If
        Form1.Refresh()
    End Sub

    Public Shared Sub MouseMove(e As MouseEventArgs)
        OnUp = False
        OnRight = False
        OnDown = False
        OnLeft = False
        OnDownLeft = False
        OnDownRight = False
        OnUpLeft = False
        OnUpRight = False
        If Functions.ButtonPressed(e.X, e.Y, 150, 100, Form1.ClientSize.Width - 300, 50) = True Then
            OnUp = True
        ElseIf Functions.ButtonPressed(e.X, e.Y, Form1.ClientSize.Width - 150, 150, 50, Form1.ClientSize.Height - 300) = True Then
            OnRight = True
        ElseIf Functions.ButtonPressed(e.X, e.Y, 150, Form1.ClientSize.Height - 150, Form1.ClientSize.Width - 300, 50) = True Then
            OnDown = True
        ElseIf Functions.ButtonPressed(e.X, e.Y, 100, 150, 50, Form1.ClientSize.Height - 300) = True Then
            OnLeft = True
        ElseIf Functions.ButtonPressed(e.X, e.Y, 100, 100, 50, 50) = True Then
            OnUpLeft = True
        ElseIf Functions.ButtonPressed(e.X, e.Y, 100, Form1.ClientSize.Height - 150, 50, 50) = True Then
            OnDownLeft = True
        ElseIf Functions.ButtonPressed(e.X, e.Y, Form1.ClientSize.Width - 150, 100, 50, 50) = True Then
            OnUpRight = True
        ElseIf Functions.ButtonPressed(e.X, e.Y, Form1.ClientSize.Width - 150, Form1.ClientSize.Height - 150, 50, 50) = True Then
            OnDownRight = True
        End If
    End Sub

    Public Shared Sub Load()
        Form1.Timer1.Interval = 40
        Form1.Timer1.Start()
        Form1.MinimumSize = New Size(800, 800)
        Variables.InGoingOut = True
    End Sub

    Public Shared Sub Close()
        Form1.Timer1.Stop()
        Variables.InGoingOut = False
    End Sub
End Class
