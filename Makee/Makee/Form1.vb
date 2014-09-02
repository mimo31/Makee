Public Class Form1
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
        Else
            If Variables.Paused = True Then
                Paused.Paint(e)
            Else
                If Variables.InHome = True Then
                    InHome.Paint(e)
                End If
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize.Initialize.Initialize()
        DoubleBuffered = True
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If Variables.StartScreen = True Or Variables.PlayStarting = True Or Variables.GettingWorldName = True Then
            Initialize.Click.Click(e)
        Else
            If Variables.Paused = True Then
                Paused.Click(e)
            Else
                If Variables.InHome = True Then
                    InHome.Click(e)
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

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.Refresh()
    End Sub
End Class