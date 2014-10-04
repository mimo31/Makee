Public Class Form1
    Public Font1 As New System.Drawing.Font(Font.Bold, 30)
    Public Font2 As New System.Drawing.Font(Font.Bold, 10)
    Public Font3 As New System.Drawing.Font(Font.Bold, 20)
    Public Font4 As New System.Drawing.Font(Font.Bold, 50)
    Public Font5 As New System.Drawing.Font(Font.Bold, 15)
    Public Pen1 As New System.Drawing.Pen(Color.Black, 6)
    Public Pen2 As New Pen(Color.Red, 3)
    Dim ReadedText As String

    Private Sub Form1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If Variables.InGoingOut = True Then
            InGoingOut.MouseWheel(e)
        End If
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If Variables.StartScreen = True Then
            StartScreen.Paint(e)
        ElseIf Variables.PlayStarting = True Then
            PlayStarting.Paint(e)
        ElseIf Variables.GettingWorldName = True Then
            GettingWorldName.Paint(e)
        ElseIf Variables.Paused = True Then
            Paused.Paint(e)
        ElseIf Variables.InHome = True Then
            InHome.Paint(e)
        ElseIf Variables.InGoingOut = True Then
            InGoingOut.Paint(e)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize.Initialize()
        DoubleBuffered = True
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Variables.StartScreen = True Then
                StartScreen.Click(e)
            ElseIf Variables.PlayStarting = True Then
                PlayStarting.Click(e)
            ElseIf Variables.GettingWorldName = True Then
                GettingWorldName.Click(e)
            ElseIf Variables.Paused = True Then
                Paused.Click(e)
            ElseIf Variables.InHome = True Then
                InHome.Click(e)
            ElseIf Variables.InGoingOut = True Then
                InGoingOut.Click(e)
            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            If Variables.PlayStarting = True Then
                PlayStarting.RightClick(e)
            End If
        End If
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If Variables.GettingWorldName = True Then
            GettingWorldName.KeyUp(e)
        End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Width = My.Computer.Screen.Bounds.Width
        Me.Height = My.Computer.Screen.Bounds.Height
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.Refresh()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Variables.InGoingOut = True Then
            InGoingOut.TimerTick()
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Variables.InGoingOut = True Then
            InGoingOut.MouseMove(e)
        ElseIf Variables.PlayStarting = True Then
            PlayStarting.MouseMove(e)
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Variables.StartScreen = False And Variables.PlayStarting = False And Variables.GettingWorldName = False Then
            Data.SaveGame()
        End If
    End Sub
End Class