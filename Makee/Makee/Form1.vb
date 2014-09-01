Public Class Form1
    Dim MouseOnSmallStones As Boolean
    Dim ItemClicked As Boolean
    Dim ClickedItemName As String
    Dim GettingWorldNameTextboxFull As Boolean
    Dim GettingWorldNameTextboxEmpty As Boolean
    Dim GettingWorldNameTextboxClicked As Boolean
    Dim GettingWorldNameTextboxText As String
    Dim GameSlotSelected As Integer
    Dim MouseX As Integer
    Dim MouseY As Integer
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
        ElseIf Variables.GettingWorldName = True Then
            e.Graphics.DrawString("Write name for you world.", Font3, Brushes.Black, 300, 300)
            e.Graphics.DrawRectangle(Pen1, 350, 350, 350, 50)
            e.Graphics.DrawRectangle(Pen1, 650, 420, 100, 50)
            e.Graphics.DrawString("OK", Font1, Brushes.Black, 663, 423)
            If GettingWorldNameTextboxClicked = False Then
                e.Graphics.FillRectangle(Brushes.Gray, 350, 350, 350, 50)
                e.Graphics.DrawString(GettingWorldNameTextboxText, Font3, Brushes.Green, 360, 357)
            Else
                e.Graphics.DrawString(GettingWorldNameTextboxText, Font3, Brushes.Green, 360, 357)
            End If
            If GettingWorldNameTextboxFull = True Then
                e.Graphics.DrawString("Maximum legth is 10 symbols.", Font3, Brushes.Red, 500, 357)
            ElseIf GettingWorldNameTextboxEmpty = True Then
                e.Graphics.DrawString("You must type name for you world.", Font3, Brushes.Red, 500, 357)
            End If
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
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        MouseX = MousePosition.X
        MouseY = MousePosition.Y
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
                    If 900 > MouseX And MouseX > 870 And 825 > MouseY And MouseY > 795 Then
                        ItemClicked = True
                        ClickedItemName = "SmallStones"
                        Me.Refresh()
                    End If
                End If
            Else
                If 1010 > MouseX And MouseX > 990 And 400 > MouseY And MouseY > 380 Then
                    ItemClicked = False
                    Me.Refresh()
                ElseIf 988 > MouseX And MouseX > 928 And 560 > MouseY And MouseY > 530 Then
                    Variables.InHome = False
                    Variables.InMine = True
                    ItemClicked = False
                    Me.Refresh()
                End If
            End If
        ElseIf Variables.GettingWorldName = True Then
            If 905 > MouseX And MouseX > 555 And 478 > MouseY And MouseY > 428 Then
                GettingWorldNameTextboxClicked = True
            ElseIf 955 > MouseX And MouseX > 855 And 547 > MouseY And MouseY > 497 Then
                If GettingWorldNameTextboxText = "" Then
                    GettingWorldNameTextboxEmpty = True
                Else
                    Functions.SuperWrite("C:\Makee\SavedGames\Game" & GameSlotSelected & "\Name.txt", GettingWorldNameTextboxText, True)
                    Variables.GettingWorldName = False
                    Variables.InHome = True
                End If
            Else
                GettingWorldNameTextboxClicked = False
            End If
        End If
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If GettingWorldNameTextboxClicked = True Then
            Dim AllowedChars As String = "aAbBcCdDeFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789 " & vbBack
            If AllowedChars.ToArray.Contains(e.KeyChar) = True Then
                If GettingWorldNameTextboxText = "" Then
                    GettingWorldNameTextboxText = GettingWorldNameTextboxText & e.KeyChar
                Else
                    If GettingWorldNameTextboxText.Length = 10 Then
                        If e.KeyChar = vbBack Then
                            GettingWorldNameTextboxText = GettingWorldNameTextboxText.Remove(GettingWorldNameTextboxText.Length - 1)
                            GettingWorldNameTextboxFull = False
                        Else
                            GettingWorldNameTextboxFull = True
                        End If
                    Else
                        If e.KeyChar = vbBack Then
                            GettingWorldNameTextboxText = GettingWorldNameTextboxText.Remove(GettingWorldNameTextboxText.Length - 1)
                        Else
                            GettingWorldNameTextboxText = GettingWorldNameTextboxText & e.KeyChar
                        End If
                    End If
                End If
                Me.Refresh()
            End If
        End If
    End Sub
End Class