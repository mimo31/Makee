Public Class Form1
    Dim MouseOnSmallStones As Boolean
    Dim ItemClicked As Boolean
    Dim ClickedItemName As String
    Public Font1 As New System.Drawing.Font(Font.Bold, 30)
    Public Font2 As New System.Drawing.Font(Font.Bold, 10)
    Public Font3 As New System.Drawing.Font(Font.Bold, 20)
    Public Font4 As New System.Drawing.Font(Font.Bold, 50)
    Public Font5 As New System.Drawing.Font(Font.Bold, 15)
    Public Pen1 As New System.Drawing.Pen(Color.Black, 6)
    Public Pen2 As New Pen(Color.Red, 3)
    Dim ReadedText As String

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If Variables.StartScreen = True Or Variables.GettingWorldName = True Or Variables.PlayStarting Then
            Initialize.Paint.Paint(e)
        End If
        If Variables.InHome = True Then
            If MouseOnSmallStones = True Then
                e.Graphics.DrawRectangle(Pen1, 650, 710, 50, 50)
                e.Graphics.DrawImage(My.Resources.SmallStonesG50, 650, 710)
            Else
                e.Graphics.DrawRectangle(Pen1, 660, 720, 30, 30)
                e.Graphics.DrawImage(My.Resources.SmallStonesW30, 660, 720)
            End If
            If ItemClicked = True Then
                If ClickedItemName = "SmallStones" Then
                    e.Graphics.DrawRectangle(Pen1, 400, 300, 400, 200)
                    e.Graphics.FillRectangle(Brushes.LightGray, 400, 300, 400, 200)
                    e.Graphics.DrawString("Small Stones", Font1, Brushes.Black, 450, 320)
                    e.Graphics.FillRectangle(Brushes.Black, 720, 450, 60, 30)
                    e.Graphics.FillRectangle(Brushes.Orange, 780, 300, 20, 20)
                    e.Graphics.DrawLine(Pen2, 785, 305, 795, 315)
                    e.Graphics.DrawLine(Pen2, 795, 305, 785, 315)
                    e.Graphics.DrawString("Go To", Font2, Brushes.White, 722, 450)
                    e.Graphics.DrawString("Mine", Font2, Brushes.White, 722, 462)
                End If
            End If
        ElseIf Variables.InMine = True Then
            e.Graphics.DrawImage(My.Resources.Mine, 170, 100)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ItemClicked = False Then
            If MouseOnSmallStones = True Then
                If 910 > MousePosition.X And MousePosition.X > 860 And 835 > MousePosition.Y And MousePosition.Y > 785 Then
                    MouseOnSmallStones = True
                    Me.Refresh()
                Else
                    MouseOnSmallStones = False
                    Me.Refresh()
                End If
            Else
                If 900 > MousePosition.X And MousePosition.X > 870 And 825 > MousePosition.Y And MousePosition.Y > 795 Then
                    MouseOnSmallStones = True
                    Me.Refresh()
                Else
                    MouseOnSmallStones = False
                    Me.Refresh()
                End If
            End If
        Else
            MouseOnSmallStones = False
            Me.Refresh()
        End If
        Label1.Text = "X = " & MousePosition.X
        Label2.Text = "Y = " & MousePosition.Y
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize.Initialize.Initialize()
        DoubleBuffered = True
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If Variables.StartScreen = True Or Variables.PlayStarting = True Or Variables.GettingWorldName = True Then
            Initialize.Click.Click(e)
        End If

        If Variables.InHome = True Then
            If ItemClicked = False Then
                If MouseOnSmallStones = True Then
                    If 910 > e.X And e.X > 860 And 835 > e.Y And e.Y > 785 Then
                        ItemClicked = True
                        ClickedItemName = "SmallStones"
                        Me.Refresh()
                    End If
                Else
                    If 900 > e.X And e.X > 870 And 825 > e.Y And e.Y > 795 Then
                        ItemClicked = True
                        ClickedItemName = "SmallStones"
                        Me.Refresh()
                    End If
                End If
            Else
                If 1010 > e.X And e.X > 990 And 400 > e.Y And e.Y > 380 Then
                    ItemClicked = False
                    Me.Refresh()
                ElseIf 988 > e.X And e.X > 928 And 560 > e.Y And e.Y > 530 Then
                    Variables.InHome = False
                    Variables.InMine = True
                    ItemClicked = False
                    Me.Refresh()
                End If
            End If
        End If
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If Variables.GettingWorldName = True Then
            Initialize.Keys.KeyUp(e)
        End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Width = My.Computer.Screen.Bounds.Width
        Me.Height = My.Computer.Screen.Bounds.Height
    End Sub
End Class