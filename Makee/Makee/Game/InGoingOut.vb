Public Class InGoingOut
    Public Shared OnUp As Boolean
    Public Shared OnDown As Boolean
    Public Shared OnRight As Boolean
    Public Shared OnLeft As Boolean
    Public Shared OnUpRight As Boolean
    Public Shared OnDownRight As Boolean
    Public Shared OnUpLeft As Boolean
    Public Shared OnDownLeft As Boolean
    Public Shared MousePositionX As Integer
    Public Shared MousePositionY As Integer
    Public Shared MouseX As Integer
    Public Shared MouseY As Integer
    Public Shared MovableObjectsX As Single
    Public Shared MovableObjectsY As Single
    Public Shared InfoDialog As Boolean
    Public Shared InfoScreenX As Single
    Public Shared InfoScreenY As Single
    Public Shared InfoMapX As Integer
    Public Shared InfoMapY As Integer
    Public Shared InfoTheoX As Integer
    Public Shared InfoTheoY As Integer

    Public Shared Sub Paint(e As PaintEventArgs)
        Dim Counter As Integer
        Dim Counter2 As Integer
        Do While Counter < (Form1.ClientSize.Width - 300) / Variables.ZoomFactor
            Do While Counter2 < (Form1.ClientSize.Height - 300) / Variables.ZoomFactor
                PaintPoint(e, Counter, Counter2)
                Counter2 = Counter2 + 1
            Loop
            Counter2 = 0
            Counter = Counter + 1
        Loop
        If InfoDialog = True Then
            e.Graphics.FillRectangle(Brushes.LightGray, InfoScreenX, InfoScreenY, 200, 150)
            e.Graphics.DrawRectangle(New Pen(Brushes.Black, 5), InfoScreenX, InfoScreenY, 200, 150)
            e.Graphics.FillRectangle(Brushes.Black, InfoScreenX, InfoScreenY + 120, 200, 30)
            e.Graphics.DrawString("Close", Form1.Font3, Brushes.White, InfoScreenX + 60, InfoScreenY + 120)
            Counter = 1
            If e.Graphics.MeasureString(Data.GetName(Data.GetValue(InfoMapX, InfoMapY)), Form1.Font3).Width < 200 Then
                e.Graphics.DrawString(Data.GetName(Data.GetValue(InfoMapX, InfoMapY)), Form1.Font3, Brushes.Black, InfoScreenX + (200 - e.Graphics.MeasureString(Data.GetName(Data.GetValue(InfoMapX, InfoMapY)), Form1.Font3).Width) / 2, InfoScreenY)
            Else
                Do While e.Graphics.MeasureString(Data.GetName(Data.GetValue(InfoMapX, InfoMapY)).Substring(0, Counter), Form1.Font3).Width + e.Graphics.MeasureString("...", Form1.Font3).Width < 200
                    Counter = Counter + 1
                Loop
                e.Graphics.DrawString(Data.GetName(Data.GetValue(InfoMapX, InfoMapY)).Substring(0, Counter - 1) & "...", Form1.Font3, Brushes.Black, InfoScreenX + (200 - e.Graphics.MeasureString(Data.GetName(Data.GetValue(InfoMapX, InfoMapY)).Substring(0, Counter - 1) & "...", Form1.Font3).Width) / 2, InfoScreenY)
            End If
            Counter = 1
            If e.Graphics.MeasureString("(" & InfoMapX & ", " & InfoMapY & ")", Form1.Font3).Width < 200 Then
                e.Graphics.DrawString("(" & InfoMapX & ", " & InfoMapY & ")", Form1.Font3, Brushes.Black, InfoScreenX + (200 - e.Graphics.MeasureString("(" & InfoMapX & ", " & InfoMapY & ")", Form1.Font3).Width) / 2, InfoScreenY + 30)
            Else
                Do While e.Graphics.MeasureString("(" & InfoMapX & ", " & InfoMapY & ")".Substring(0, Counter), Form1.Font3).Width + e.Graphics.MeasureString("...", Form1.Font3).Width < 200
                    Counter = Counter + 1
                Loop
                e.Graphics.DrawString("(" & InfoMapX & ", " & InfoMapY & ")".Substring(0, Counter - 1) & "...", Form1.Font3, Brushes.Black, InfoScreenX + (200 - e.Graphics.MeasureString("(" & InfoMapX & ", " & InfoMapY & ")".Substring(0, Counter - 1) & "...", Form1.Font3).Width) / 2, InfoScreenY)
            End If
            e.Graphics.DrawString("More...", Form1.Font3, Brushes.Black, InfoScreenX + 60, InfoScreenY + 90)
            e.Graphics.DrawLine(New Pen(Brushes.Black, 5), InfoScreenX, InfoScreenY + 90, InfoScreenX + 200, InfoScreenY + 90)
        End If
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
        e.Graphics.FillRectangle(New SolidBrush(Form1.BackColor), 0, Form1.ClientSize.Height - 100, Form1.ClientSize.Width, 100)
        e.Graphics.FillRectangle(New SolidBrush(Form1.BackColor), Form1.ClientSize.Width - 100, 0, 100, Form1.ClientSize.Height)
        Functions.DrawPause(e)
        Functions.DrawBack(e)
    End Sub

    Public Shared Sub PaintPoint(e As PaintEventArgs, x As Integer, y As Integer)
        Select Case Data.GetValue(x + Variables.MapPositionX, y + Variables.MapPositiony)
            Case 1
                e.Graphics.FillRectangle(Brushes.Gray, 150 + Variables.ZoomFactor * x, 150 + Variables.ZoomFactor * y, Variables.ZoomFactor, Variables.ZoomFactor)
            Case 2
                e.Graphics.FillRectangle(Brushes.DarkGreen, 150 + Variables.ZoomFactor * x, 150 + Variables.ZoomFactor * y, Variables.ZoomFactor, Variables.ZoomFactor)
            Case 3
                e.Graphics.FillRectangle(Brushes.Green, 150 + Variables.ZoomFactor * x, 150 + Variables.ZoomFactor * y, Variables.ZoomFactor, Variables.ZoomFactor)
            Case 4
                e.Graphics.FillRectangle(Brushes.LightGreen, 150 + Variables.ZoomFactor * x, 150 + Variables.ZoomFactor * y, Variables.ZoomFactor, Variables.ZoomFactor)
            Case 5
                e.Graphics.FillRectangle(Brushes.Blue, 150 + Variables.ZoomFactor * x, 150 + Variables.ZoomFactor * y, Variables.ZoomFactor, Variables.ZoomFactor)
            Case 6
                e.Graphics.DrawImage(New Bitmap(My.Resources.Base1, Variables.ZoomFactor, Variables.ZoomFactor), 150 + Variables.ZoomFactor * x, 150 + Variables.ZoomFactor * y)
        End Select
        If Variables.MapPositionX + x = Variables.PlayerPositionX And Variables.MapPositionY + y = Variables.PlayerPositionY Then
            MovableObjectsX = Math.Round(150 + Variables.ZoomFactor * (0.03125 + x))
            MovableObjectsY = Math.Round(150 + Variables.ZoomFactor * (0.03125 + y))
            e.Graphics.DrawImage(New Bitmap(My.Resources.Player1, Math.Round(Variables.ZoomFactor * 15 / 16), Math.Round(Variables.ZoomFactor * 15 / 16)), MovableObjectsX, MovableObjectsY)
        End If
    End Sub

    Public Shared Sub ZoomIn(e As MouseEventArgs)
        If Variables.ZoomFactor < 512 Then
            Variables.MapPositionX = Variables.MapPositionX + Math.Round(MousePositionX / 2)
            Variables.MapPositionY = Variables.MapPositionY + Math.Round(MousePositionY / 2)
            Variables.ZoomFactor = Variables.ZoomFactor * 2
            Form1.Timer1.Interval = Form1.Timer1.Interval * 2
            MousePositionX = MousePositionX / 2
        End If
    End Sub

    Public Shared Sub ZoomOut(e As MouseEventArgs)
        If Variables.ZoomFactor > 8 Then
            Variables.MapPositionX = Variables.MapPositionX - MousePositionX
            Variables.MapPositionY = Variables.MapPositionY - MousePositionY
            Variables.ZoomFactor = Variables.ZoomFactor / 2
            Form1.Timer1.Interval = Form1.Timer1.Interval / 2
            MousePositionX = MousePositionX * 2
        End If
    End Sub

    Public Shared Sub MouseWheel(e As MouseEventArgs)
        If InfoDialog = False Then
            Dim Counter As Integer
            If Functions.ButtonPressed(e.X, e.Y, 150, 150, Form1.ClientSize.Width - 300, Form1.ClientSize.Height - 300) = True Then
                Counter = Math.Abs(e.Delta) / SystemInformation.MouseWheelScrollDelta
                Do Until Counter = 0
                    If e.Delta < 0 Then
                        ZoomOut(e)
                    Else
                        ZoomIn(e)
                    End If
                    MousePositionX = (MouseX - 150) / Variables.ZoomFactor
                    MousePositionY = (MouseY - 150) / Variables.ZoomFactor
                    Counter = Counter - 1
                Loop
                Form1.Refresh()
            End If
        End If
    End Sub

    Public Shared Sub ShowMoreClass(Id As UShort)
        Select Case Id
            Case 1
                More1.Load(InfoMapX, InfoMapY)
        End Select
        InGoingOut.Close()
    End Sub

    Public Shared Sub CountPracticalCoordinates()
        If InfoTheoX > 150 And Form1.ClientSize.Width - 350 > InfoTheoX Then
            InfoScreenX = InfoTheoX
        ElseIf InfoTheoX > 150 Then
            InfoScreenX = Form1.ClientSize.Width - 350
        Else
            InfoScreenX = 150
        End If
        If InfoTheoY > 150 And Form1.ClientSize.Height - 300 > InfoTheoY Then
            InfoScreenY = InfoTheoY
        ElseIf InfoTheoY > 150 Then
            InfoScreenY = Form1.ClientSize.Height - 300
        Else
            InfoScreenY = 150
        End If
    End Sub

    Public Shared Sub Click(e As MouseEventArgs)
        If Functions.ButtonPressed(e.X, e.Y, InfoScreenX, InfoScreenY, 200, 150) = True And InfoDialog = True Then
            If Functions.ButtonPressed(e.X, e.Y, InfoScreenX, InfoScreenY + 120, 150, 30) = True Then
                InfoDialog = False
                Form1.Refresh()
            ElseIf Functions.ButtonPressed(e.X, e.Y, InfoScreenX, InfoScreenY + 90, 150, 30) = True Then
                ShowMoreClass(Data.GetValue(InfoMapX, InfoMapY))
            End If
        ElseIf Functions.ButtonPressed(e.X, e.Y, 5, 5, 100, 40) = True Then
            InGoingOut.Close()
            Variables.InHome = True
            Form1.Refresh()
        ElseIf Functions.ButtonPressed(e.X, e.Y, Form1.ClientSize.Width - 60, 0, 60, 60) = True Then
            Variables.Paused = True
            Form1.Refresh()
        ElseIf Functions.ButtonPressed(e.X, e.Y, 150, 150, Form1.ClientSize.Width - 300, Form1.ClientSize.Height - 300) = True Then
            InfoDialog = True
            InfoTheoX = e.X
            InfoTheoY = e.Y
            CountPracticalCoordinates()
            InfoMapX = Math.Floor((e.X - 150) / Variables.ZoomFactor) + Variables.MapPositionX
            InfoMapY = Math.Floor((e.Y - 150) / Variables.ZoomFactor) + Variables.MapPositionY
        End If
    End Sub

    Public Shared Sub TimerTick()
        If OnDown = True Then
            If InfoDialog = True Then
                InfoTheoY = InfoTheoY - Variables.ZoomFactor
            End If
            Variables.MapPositionY = Variables.MapPositionY + 1
        ElseIf OnUp = True Then
            If InfoDialog = True Then
                InfoTheoY = InfoTheoY + Variables.ZoomFactor
            End If
            Variables.MapPositionY = Variables.MapPositionY - 1
        ElseIf OnRight = True Then
            If InfoDialog = True Then
                InfoTheoX = InfoTheoX - Variables.ZoomFactor
            End If
            Variables.MapPositionX = Variables.MapPositionX + 1
        ElseIf OnLeft = True Then
            If InfoDialog = True Then
                InfoTheoX = InfoTheoX + Variables.ZoomFactor
            End If
            Variables.MapPositionX = Variables.MapPositionX - 1
        ElseIf OnUpLeft = True Then
            If InfoDialog = True Then
                InfoTheoY = InfoTheoY + Variables.ZoomFactor
                InfoTheoX = InfoTheoX + Variables.ZoomFactor
            End If
            Variables.MapPositionY = Variables.MapPositionY - 1
            Variables.MapPositionX = Variables.MapPositionX - 1
        ElseIf OnDownLeft = True Then
            If InfoDialog = True Then
                InfoTheoY = InfoTheoY - Variables.ZoomFactor
                InfoTheoX = InfoTheoX + Variables.ZoomFactor
            End If
            Variables.MapPositionY = Variables.MapPositionY + 1
            Variables.MapPositionX = Variables.MapPositionX - 1
        ElseIf OnUpRight = True Then
            If InfoDialog = True Then
                InfoTheoY = InfoTheoY + Variables.ZoomFactor
                InfoTheoX = InfoTheoX - Variables.ZoomFactor
            End If
            Variables.MapPositionY = Variables.MapPositionY - 1
            Variables.MapPositionX = Variables.MapPositionX + 1
        ElseIf OnDownRight = True Then
            If InfoDialog = True Then
                InfoTheoY = InfoTheoY - Variables.ZoomFactor
                InfoTheoX = InfoTheoX - Variables.ZoomFactor
            End If
            Variables.MapPositionY = Variables.MapPositionY + 1
            Variables.MapPositionX = Variables.MapPositionX + 1
        End If
        CountPracticalCoordinates()
        Form1.Refresh()
    End Sub

    Public Shared Sub MouseMove(e As MouseEventArgs)
        MousePositionX = (e.X - 150) / Variables.ZoomFactor
        MousePositionY = (e.Y - 150) / Variables.ZoomFactor
        MouseX = e.X
        MouseY = e.Y
        OnUp = False
        OnRight = False
        OnDown = False
        OnLeft = False
        OnDownLeft = False
        OnDownRight = False
        OnUpLeft = False
        OnUpRight = False
        If Functions.ButtonPressed(e.X, e.Y, InfoScreenX, InfoScreenY, 200, 150) = False Or InfoDialog = False Then
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
        End If
    End Sub

    Public Shared Sub Load()
        Form1.Timer1.Interval = 20 * Variables.ZoomFactor / 16
        Form1.Timer1.Start()
        Form1.MinimumSize = New Size(800, 800)
        Variables.InGoingOut = True
    End Sub

    Public Shared Sub Close()
        Form1.Timer1.Stop()
        Variables.InGoingOut = False
    End Sub
End Class
