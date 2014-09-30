Public Class InGoingOut
    Public Shared MapPositionX As Integer
    Public Shared MapPositionY As Integer
    Public Shared OnUp As Boolean
    Public Shared OnDown As Boolean
    Public Shared OnRight As Boolean
    Public Shared OnLeft As Boolean
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
        e.Graphics.FillRectangle(Brushes.DarkRed, 100, 100, 50, 50)
        e.Graphics.FillRectangle(Brushes.Red, 150, 100, Form1.ClientSize.Width - 300, 50)
        e.Graphics.FillRectangle(Brushes.DarkRed, Form1.ClientSize.Width - 150, 100, 50, 50)
        e.Graphics.FillRectangle(Brushes.Red, Form1.ClientSize.Width - 150, 150, 50, Form1.ClientSize.Height - 300)
        e.Graphics.FillRectangle(Brushes.DarkRed, Form1.ClientSize.Width - 150, Form1.ClientSize.Height - 150, 50, 50)
        e.Graphics.FillRectangle(Brushes.Red, 150, Form1.ClientSize.Height - 150, Form1.ClientSize.Width - 300, 50)
        e.Graphics.FillRectangle(Brushes.DarkRed, 100, Form1.ClientSize.Height - 150, 50, 50)
        e.Graphics.FillRectangle(Brushes.Red, 100, 150, 50, Form1.ClientSize.Height - 300)
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
        End If
        Form1.Refresh()
    End Sub

    Public Shared Sub MouseMove(e As MouseEventArgs)
        OnUp = False
        OnRight = False
        OnDown = False
        OnLeft = False
        If Functions.ButtonPressed(e.X, e.Y, 150, 100, Form1.ClientSize.Width - 300, 50) = True Then
            OnUp = True
        ElseIf Functions.ButtonPressed(e.X, e.Y, Form1.ClientSize.Width - 150, 150, 50, Form1.ClientSize.Height - 300) = True Then
            OnRight = True
        ElseIf Functions.ButtonPressed(e.X, e.Y, 150, Form1.ClientSize.Height - 150, Form1.ClientSize.Width - 300, 50) = True Then
            OnDown = True
        ElseIf Functions.ButtonPressed(e.X, e.Y, 100, 150, 50, Form1.ClientSize.Height - 300) = True Then
            OnLeft = True
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
