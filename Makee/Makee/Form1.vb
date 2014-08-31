Public Class Form1
    Dim StartScreen As Boolean = True
    Dim PlayStarting As Boolean
    Dim GettingWorldName As Boolean
    Dim InHome As Boolean
    Dim InMine As Boolean
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
    Dim Pen1 As New System.Drawing.Pen(Color.Black, 6)
    Dim Pen2 As New Pen(Color.Red, 3)
    Dim Font1 As New System.Drawing.Font(Font.Bold, 30)
    Dim Font2 As New System.Drawing.Font(Font.Bold, 10)
    Dim Font3 As New System.Drawing.Font(Font.Bold, 20)
    Dim Font4 As New System.Drawing.Font(Font.Bold, 50)
    Dim Font5 As New System.Drawing.Font(Font.Bold, 15)
    Dim ReadedText As String
    Dim World1Exist As Boolean
    Dim World2Exist As Boolean
    Dim World3Exist As Boolean
    Dim World4Exist As Boolean
    Dim World5Exist As Boolean
    Dim World6Exist As Boolean
    Dim World7Exist As Boolean
    Dim World8Exist As Boolean
    Dim World9Exist As Boolean

    Public Function SuperRead(FileAddress As String) As String
        Return My.Computer.FileSystem.ReadAllText(FileAddress)
    End Function

    Public Sub SuperWrite(FileAddress As String, TextToWrite As String, DeletePerious As Boolean)
        My.Computer.FileSystem.WriteAllText(FileAddress, TextToWrite, DeletePerious)
    End Sub

    Public Sub TransformToScreenAxises(Axises As Point)
        Dim PointToReturn As Point
        PointToReturn.X = 
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If InHome = True Then
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
        ElseIf InMine = True Then
            e.Graphics.DrawImage(My.Resources.Mine, 170, 100)
        ElseIf StartScreen = True Then
            e.Graphics.FillRectangle(Brushes.Black, 400, 250, 400, 50)
            e.Graphics.DrawString("Play", Font3, Brushes.White, 570, 260)
            e.Graphics.DrawString("Makee", Font4, Brushes.Black, 485, 100)
        ElseIf PlayStarting = True Then
            e.Graphics.DrawString("Load The World", Font1, Brushes.Black, 420, 20)
            If World1Exist = True Then
                e.Graphics.FillRectangle(Brushes.White, 200, 200, 100, 100)
                e.Graphics.FillRectangle(Brushes.Yellow, 200, 240, 100, 20)
                e.Graphics.FillRectangle(Brushes.Yellow, 240, 200, 20, 100)
                e.Graphics.DrawRectangle(Pen1, 200, 200, 100, 100)
                e.Graphics.DrawString(SuperRead("C:\Makee\SavedGames\Game1\Name.txt"), Font5, Brushes.Blue, 210, 270)
            Else
                e.Graphics.FillRectangle(Brushes.Black, 200, 200, 100, 100)
                e.Graphics.DrawString("Empty", Font3, Brushes.White, 210, 260)
            End If
            If World2Exist = True Then
                e.Graphics.FillRectangle(Brushes.White, 500, 200, 100, 100)
                e.Graphics.FillRectangle(Brushes.Yellow, 500, 240, 100, 20)
                e.Graphics.FillRectangle(Brushes.Yellow, 540, 200, 20, 100)
                e.Graphics.DrawRectangle(Pen1, 500, 200, 100, 100)
                e.Graphics.DrawString(SuperRead("C:\Makee\SavedGames\Game2\Name.txt"), Font5, Brushes.Blue, 510, 270)
            Else
                e.Graphics.FillRectangle(Brushes.Black, 500, 200, 100, 100)
                e.Graphics.DrawString("Empty", Font3, Brushes.White, 510, 260)
            End If
            If World3Exist = True Then
                e.Graphics.FillRectangle(Brushes.White, 800, 200, 100, 100)
                e.Graphics.FillRectangle(Brushes.Yellow, 800, 240, 100, 20)
                e.Graphics.FillRectangle(Brushes.Yellow, 840, 200, 20, 100)
                e.Graphics.DrawRectangle(Pen1, 800, 200, 100, 100)
                e.Graphics.DrawString(SuperRead("C:\Makee\SavedGames\Game3\Name.txt"), Font5, Brushes.Blue, 810, 270)
            Else
                e.Graphics.FillRectangle(Brushes.Black, 800, 200, 100, 100)
                e.Graphics.DrawString("Empty", Font3, Brushes.White, 810, 260)
            End If
            If World4Exist = True Then
                e.Graphics.FillRectangle(Brushes.White, 200, 400, 100, 100)
                e.Graphics.FillRectangle(Brushes.Yellow, 200, 440, 100, 20)
                e.Graphics.FillRectangle(Brushes.Yellow, 240, 400, 20, 100)
                e.Graphics.DrawRectangle(Pen1, 200, 400, 100, 100)
                e.Graphics.DrawString(SuperRead("C:\Makee\SavedGames\Game4\Name.txt"), Font5, Brushes.Blue, 210, 470)
            Else
                e.Graphics.FillRectangle(Brushes.Black, 200, 400, 100, 100)
                e.Graphics.DrawString("Empty", Font3, Brushes.White, 210, 460)
            End If
            If World5Exist = True Then
                e.Graphics.FillRectangle(Brushes.White, 500, 400, 100, 100)
                e.Graphics.FillRectangle(Brushes.Yellow, 500, 440, 100, 20)
                e.Graphics.FillRectangle(Brushes.Yellow, 540, 400, 20, 100)
                e.Graphics.DrawRectangle(Pen1, 500, 400, 100, 100)
                e.Graphics.DrawString(SuperRead("C:\Makee\SavedGames\Game5\Name.txt"), Font5, Brushes.Blue, 510, 470)
            Else
                e.Graphics.FillRectangle(Brushes.Black, 500, 400, 100, 100)
                e.Graphics.DrawString("Empty", Font3, Brushes.White, 510, 460)
            End If
            If World6Exist = True Then
                e.Graphics.FillRectangle(Brushes.White, 800, 400, 100, 100)
                e.Graphics.FillRectangle(Brushes.Yellow, 800, 440, 100, 20)
                e.Graphics.FillRectangle(Brushes.Yellow, 840, 400, 20, 100)
                e.Graphics.DrawRectangle(Pen1, 800, 400, 100, 100)
                e.Graphics.DrawString(SuperRead("C:\Makee\SavedGames\Game6\Name.txt"), Font5, Brushes.Blue, 810, 470)
            Else
                e.Graphics.FillRectangle(Brushes.Black, 800, 400, 100, 100)
                e.Graphics.DrawString("Empty", Font3, Brushes.White, 810, 460)
            End If
            If World7Exist = True Then
                e.Graphics.FillRectangle(Brushes.White, 200, 600, 100, 100)
                e.Graphics.FillRectangle(Brushes.Yellow, 200, 640, 100, 20)
                e.Graphics.FillRectangle(Brushes.Yellow, 240, 600, 20, 100)
                e.Graphics.DrawRectangle(Pen1, 200, 600, 100, 100)
                e.Graphics.DrawString(SuperRead("C:\Makee\SavedGames\Game7\Name.txt"), Font5, Brushes.Blue, 210, 670)
            Else
                e.Graphics.FillRectangle(Brushes.Black, 200, 600, 100, 100)
                e.Graphics.DrawString("Empty", Font3, Brushes.White, 210, 660)
            End If
            If World8Exist = True Then
                e.Graphics.FillRectangle(Brushes.White, 500, 600, 100, 100)
                e.Graphics.FillRectangle(Brushes.Yellow, 500, 640, 100, 20)
                e.Graphics.FillRectangle(Brushes.Yellow, 540, 600, 20, 100)
                e.Graphics.DrawRectangle(Pen1, 500, 600, 100, 100)
                e.Graphics.DrawString(SuperRead("C:\Makee\SavedGames\Game8\Name.txt"), Font5, Brushes.Blue, 510, 670)
            Else
                e.Graphics.FillRectangle(Brushes.Black, 500, 600, 100, 100)
                e.Graphics.DrawString("Empty", Font3, Brushes.White, 510, 660)
            End If
            If World9Exist = True Then
                e.Graphics.FillRectangle(Brushes.White, 800, 600, 100, 100)
                e.Graphics.FillRectangle(Brushes.Yellow, 800, 640, 100, 20)
                e.Graphics.FillRectangle(Brushes.Yellow, 840, 600, 20, 100)
                e.Graphics.DrawRectangle(Pen1, 800, 600, 100, 100)
                e.Graphics.DrawString(SuperRead("C:\Makee\SavedGames\Game9\Name.txt"), Font5, Brushes.Blue, 810, 670)
            Else
                e.Graphics.FillRectangle(Brushes.Black, 800, 600, 100, 100)
                e.Graphics.DrawString("Empty", Font3, Brushes.White, 810, 660)
            End If
        ElseIf GettingWorldName = True Then
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
        If My.Computer.FileSystem.DirectoryExists("C:\Makee") = False Then
            My.Computer.FileSystem.CreateDirectory("C:\Makee\SavedGames\Game1")
            My.Computer.FileSystem.CreateDirectory("C:\Makee\SavedGames\Game2")
            My.Computer.FileSystem.CreateDirectory("C:\Makee\SavedGames\Game3")
            My.Computer.FileSystem.CreateDirectory("C:\Makee\SavedGames\Game4")
            My.Computer.FileSystem.CreateDirectory("C:\Makee\SavedGames\Game5")
            My.Computer.FileSystem.CreateDirectory("C:\Makee\SavedGames\Game6")
            My.Computer.FileSystem.CreateDirectory("C:\Makee\SavedGames\Game7")
            My.Computer.FileSystem.CreateDirectory("C:\Makee\SavedGames\Game8")
            My.Computer.FileSystem.CreateDirectory("C:\Makee\SavedGames\Game9")
        Else
            World1Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game1\Name.txt")
            World2Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game2\Name.txt")
            World3Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game3\Name.txt")
            World4Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game4\Name.txt")
            World5Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game5\Name.txt")
            World6Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game6\Name.txt")
            World7Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game7\Name.txt")
            World8Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game8\Name.txt")
            World9Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game9\Name.txt")
        End If
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        MouseX = MousePosition.X
        MouseY = MousePosition.Y
        If InHome = True Then
            If ItemClicked = False Then
                If MouseOnSmallStones = True Then
                    If 910 > MouseX And MouseX > 860 And 835 > MouseY And MouseY > 785 Then
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
                    InHome = False
                    InMine = True
                    ItemClicked = False
                    Me.Refresh()
                End If
            End If
        ElseIf StartScreen = True Then
            If 1007 > MouseX And MouseX > 607 And 380 > MouseY And MouseY > 330 Then
                PlayStarting = True
                StartScreen = False
            End If
        ElseIf PlayStarting = True Then
            If 508 > MouseX And MouseX > 408 And 380 > MouseY And MouseY > 280 Then
                If World1Exist = True Then
                    PlayStarting = False
                    InHome = True
                Else
                    PlayStarting = False
                    GettingWorldName = True
                    GameSlotSelected = 1
                End If
            End If
            If 808 > MouseX And MouseX > 708 And 380 > MouseY And MouseY > 280 Then
                If World2Exist = True Then
                    PlayStarting = False
                    InHome = True
                Else
                    PlayStarting = False
                    GettingWorldName = True
                    GameSlotSelected = 2
                End If
            End If
            If 1108 > MouseX And MouseX > 1008 And 380 > MouseY And MouseY > 280 Then
                If World2Exist = True Then
                    PlayStarting = False
                    InHome = True
                Else
                    PlayStarting = False
                    GettingWorldName = True
                    GameSlotSelected = 3
                End If
            End If
            If 508 > MouseX And MouseX > 408 And 580 > MouseY And MouseY > 480 Then
                If World1Exist = True Then
                    PlayStarting = False
                    InHome = True
                Else
                    PlayStarting = False
                    GettingWorldName = True
                    GameSlotSelected = 4
                End If
            End If
            If 808 > MouseX And MouseX > 708 And 580 > MouseY And MouseY > 480 Then
                If World2Exist = True Then
                    PlayStarting = False
                    InHome = True
                Else
                    PlayStarting = False
                    GettingWorldName = True
                    GameSlotSelected = 5
                End If
            End If
            If 1108 > MouseX And MouseX > 1008 And 580 > MouseY And MouseY > 480 Then
                If World2Exist = True Then
                    PlayStarting = False
                    InHome = True
                Else
                    PlayStarting = False
                    GettingWorldName = True
                    GameSlotSelected = 6
                End If
            End If
            If 508 > MouseX And MouseX > 408 And 780 > MouseY And MouseY > 680 Then
                If World1Exist = True Then
                    PlayStarting = False
                    InHome = True
                Else
                    PlayStarting = False
                    GettingWorldName = True
                    GameSlotSelected = 7
                End If
            End If
            If 808 > MouseX And MouseX > 708 And 780 > MouseY And MouseY > 680 Then
                If World2Exist = True Then
                    PlayStarting = False
                    InHome = True
                Else
                    PlayStarting = False
                    GettingWorldName = True
                    GameSlotSelected = 8
                End If
            End If
            If 1108 > MouseX And MouseX > 1008 And 780 > MouseY And MouseY > 680 Then
                If World2Exist = True Then
                    PlayStarting = False
                    InHome = True
                Else
                    PlayStarting = False
                    GettingWorldName = True
                    GameSlotSelected = 9
                End If
            End If
        ElseIf GettingWorldName = True Then
            If 905 > MouseX And MouseX > 555 And 478 > MouseY And MouseY > 428 Then
                GettingWorldNameTextboxClicked = True
            ElseIf 955 > MouseX And MouseX > 855 And 547 > MouseY And MouseY > 497 Then
                If GettingWorldNameTextboxText = "" Then
                    GettingWorldNameTextboxEmpty = True
                Else
                    SuperWrite("C:\Makee\SavedGames\Game" & GameSlotSelected & "\Name.txt", GettingWorldNameTextboxText, True)
                    GettingWorldName = False
                    InHome = True
                End If
            Else
                GettingWorldNameTextboxClicked = False
            End If
        End If
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If GettingWorldNameTextboxClicked = True Then
            Dim AllowedChars As String = "aAbBcCdDeFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789 " & vbBack
            If AllowedChars.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            Else
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