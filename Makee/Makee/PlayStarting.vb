Public Class PlayStarting
    Public Shared MovableObjectsX As Single
    Public Shared MovableObjectsY As Single
    Public Shared World1Exist As Boolean
    Public Shared World2Exist As Boolean
    Public Shared World3Exist As Boolean
    Public Shared World4Exist As Boolean
    Public Shared World5Exist As Boolean
    Public Shared World6Exist As Boolean
    Public Shared World7Exist As Boolean
    Public Shared World8Exist As Boolean
    Public Shared World9Exist As Boolean
    Public Shared DialogX As Single
    Public Shared DialogY As Single
    Public Shared RightClickDialog As Boolean
    Public Shared DialogWorld As Byte
    Public Shared AskForDelete As Boolean

    Public Shared Sub Paint(e As PaintEventArgs)
        World1Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game1\Name.txt")
        World2Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game2\Name.txt")
        World3Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game3\Name.txt")
        World4Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game4\Name.txt")
        World5Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game5\Name.txt")
        World6Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game6\Name.txt")
        World7Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game7\Name.txt")
        World8Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game8\Name.txt")
        World9Exist = My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game9\Name.txt")
        Functions.DrawBack(e)
        Form1.MinimumSize = New Size(500 + Form1.Width - Form1.ClientSize.Width, 550 + Form1.Height - Form1.ClientSize.Height)
        e.Graphics.DrawString("Load The World", Form1.Font1, Brushes.Black, Math.Round((Form1.ClientSize.Width - 300) / 2), 20)
        MovableObjectsX = Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2) + 50
        MovableObjectsY = Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2) + 100
        If World1Exist = True Then
            e.Graphics.FillRectangle(Brushes.White, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX, MovableObjectsY + 40, 100, 20)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX + 40, MovableObjectsY, 20, 100)
            e.Graphics.DrawRectangle(Form1.Pen1, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString(StringToWorldButton(e, Functions.SuperRead("C:\Makee\SavedGames\Game1\Name.txt")), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
        Else
            e.Graphics.FillRectangle(Brushes.Black, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, MovableObjectsX + 10, MovableObjectsY + 60)
        End If
        MovableObjectsX = Math.Round((Form1.ClientSize.Width - 100) / 2)
        MovableObjectsY = Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2) + 100
        If World2Exist = True Then
            e.Graphics.FillRectangle(Brushes.White, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX, MovableObjectsY + 40, 100, 20)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX + 40, MovableObjectsY, 20, 100)
            e.Graphics.DrawRectangle(Form1.Pen1, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString(StringToWorldButton(e, Functions.SuperRead("C:\Makee\SavedGames\Game2\Name.txt")), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
        Else
            e.Graphics.FillRectangle(Brushes.Black, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, MovableObjectsX + 10, MovableObjectsY + 60)
        End If
        MovableObjectsX = Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Width - 200) / 2) + 150
        MovableObjectsY = Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2) + 100
        If World3Exist = True Then
            e.Graphics.FillRectangle(Brushes.White, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX, MovableObjectsY + 40, 100, 20)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX + 40, MovableObjectsY, 20, 100)
            e.Graphics.DrawRectangle(Form1.Pen1, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString(StringToWorldButton(e, Functions.SuperRead("C:\Makee\SavedGames\Game3\Name.txt")), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
        Else
            e.Graphics.FillRectangle(Brushes.Black, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, MovableObjectsX + 10, MovableObjectsY + 60)
        End If
        MovableObjectsX = Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2) + 50
        MovableObjectsY = Math.Round((Form1.ClientSize.Height - 50) / 2)
        If World4Exist = True Then
            e.Graphics.FillRectangle(Brushes.White, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX, MovableObjectsY + 40, 100, 20)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX + 40, MovableObjectsY, 20, 100)
            e.Graphics.DrawRectangle(Form1.Pen1, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString(StringToWorldButton(e, Functions.SuperRead("C:\Makee\SavedGames\Game4\Name.txt")), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
        Else
            e.Graphics.FillRectangle(Brushes.Black, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, MovableObjectsX + 10, MovableObjectsY + 60)
        End If
        MovableObjectsX = Math.Round((Form1.ClientSize.Width - 100) / 2)
        MovableObjectsY = Math.Round((Form1.ClientSize.Height - 50) / 2)
        If World5Exist = True Then
            e.Graphics.FillRectangle(Brushes.White, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX, MovableObjectsY + 40, 100, 20)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX + 40, MovableObjectsY, 20, 100)
            e.Graphics.DrawRectangle(Form1.Pen1, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString(StringToWorldButton(e, Functions.SuperRead("C:\Makee\SavedGames\Game5\Name.txt")), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
        Else
            e.Graphics.FillRectangle(Brushes.Black, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, MovableObjectsX + 10, MovableObjectsY + 60)
        End If
        MovableObjectsX = Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Width - 200) / 2) + 150
        MovableObjectsY = Math.Round((Form1.ClientSize.Height - 50) / 2)
        If World6Exist = True Then
            e.Graphics.FillRectangle(Brushes.White, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX, MovableObjectsY + 40, 100, 20)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX + 40, MovableObjectsY, 20, 100)
            e.Graphics.DrawRectangle(Form1.Pen1, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString(StringToWorldButton(e, Functions.SuperRead("C:\Makee\SavedGames\Game6\Name.txt")), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
        Else
            e.Graphics.FillRectangle(Brushes.Black, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, MovableObjectsX + 10, MovableObjectsY + 60)
        End If
        MovableObjectsX = Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2) + 50
        MovableObjectsY = Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Height - 250) / 2) + 200
        If World7Exist = True Then
            e.Graphics.FillRectangle(Brushes.White, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX, MovableObjectsY + 40, 100, 20)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX + 40, MovableObjectsY, 20, 100)
            e.Graphics.DrawRectangle(Form1.Pen1, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString(StringToWorldButton(e, Functions.SuperRead("C:\Makee\SavedGames\Game7\Name.txt")), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
        Else
            e.Graphics.FillRectangle(Brushes.Black, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, MovableObjectsX + 10, MovableObjectsY + 60)
        End If
        MovableObjectsX = Math.Round((Form1.ClientSize.Width - 100) / 2)
        MovableObjectsY = Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Height - 250) / 2) + 200
        If World8Exist = True Then
            e.Graphics.FillRectangle(Brushes.White, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX, MovableObjectsY + 40, 100, 20)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX + 40, MovableObjectsY, 20, 100)
            e.Graphics.DrawRectangle(Form1.Pen1, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString(StringToWorldButton(e, Functions.SuperRead("C:\Makee\SavedGames\Game8\Name.txt")), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
        Else
            e.Graphics.FillRectangle(Brushes.Black, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, MovableObjectsX + 10, MovableObjectsY + 60)
        End If
        MovableObjectsX = Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Width - 200) / 2) + 150
        MovableObjectsY = Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Height - 250) / 2) + 200
        If World9Exist = True Then
            e.Graphics.FillRectangle(Brushes.White, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX, MovableObjectsY + 40, 100, 20)
            e.Graphics.FillRectangle(Brushes.Yellow, MovableObjectsX + 40, MovableObjectsY, 20, 100)
            e.Graphics.DrawRectangle(Form1.Pen1, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString(StringToWorldButton(e, Functions.SuperRead("C:\Makee\SavedGames\Game9\Name.txt")), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
        Else
            e.Graphics.FillRectangle(Brushes.Black, MovableObjectsX, MovableObjectsY, 100, 100)
            e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, MovableObjectsX + 10, MovableObjectsY + 60)
        End If
        If RightClickDialog = True Then
            e.Graphics.FillRectangle(Brushes.LightGray, DialogX, DialogY, 200, 100)
            e.Graphics.DrawRectangle(New Pen(Brushes.Black, 5), DialogX, DialogY, 200, 100)
            e.Graphics.DrawString(My.Computer.FileSystem.ReadAllText("C:\Makee\SavedGames\Game" & DialogWorld & "\Name.txt"), Form1.Font5, Brushes.Black, DialogX + (200 - e.Graphics.MeasureString(My.Computer.FileSystem.ReadAllText("C:\Makee\SavedGames\Game" & DialogWorld & "\Name.txt"), Form1.Font5).Width) / 2, DialogY + 2)
            e.Graphics.DrawLine(New Pen(Brushes.Black, 5), DialogX, DialogY + 30, DialogX + 200, DialogY + 30)
            e.Graphics.DrawString("Delete", Form1.Font5, Brushes.Black, DialogX + 65, DialogY + 32)
            e.Graphics.DrawLine(New Pen(Brushes.Black, 5), DialogX, DialogY + 60, DialogX + 200, DialogY + 60)
        End If
        If AskForDelete = True Then
            MovableObjectsX = Math.Round((Form1.ClientSize.Width - 500) / 2)
            MovableObjectsY = Math.Round((Form1.ClientSize.Height - 250) / 2)
            e.Graphics.FillRectangle(Brushes.LightGray, MovableObjectsX, MovableObjectsY, 500, 250)
            e.Graphics.DrawRectangle(New Pen(Brushes.Black, 5), MovableObjectsX, MovableObjectsY, 500, 250)
            e.Graphics.DrawString("Do you really want to delete " & vbCrLf & "the world " & My.Computer.FileSystem.ReadAllText("C:\Makee\SavedGames\Game" & DialogWorld & "\Name.txt") & "?", Form1.Font3, Brushes.Black, MovableObjectsX + 10, MovableObjectsY + 3)
            e.Graphics.FillRectangle(Brushes.Black, MovableObjectsX + 20, MovableObjectsY + 170, 100, 50)
            e.Graphics.FillRectangle(Brushes.Black, MovableObjectsX + 380, MovableObjectsY + 170, 100, 50)
            e.Graphics.DrawString("Yes", Form1.Font1, Brushes.White, MovableObjectsX + 25, MovableObjectsY + 173)
            e.Graphics.DrawString("No", Form1.Font1, Brushes.White, MovableObjectsX + 397, MovableObjectsY + 173)
        End If
    End Sub

    Public Shared Function StringToWorldButton(e As PaintEventArgs, InputString As String) As String
        Dim Counter As Integer = 1
        If e.Graphics.MeasureString(InputString, Form1.Font5).Width < 100 Then
            Return InputString
        Else
            Do While e.Graphics.MeasureString(InputString.Substring(0, Counter) & "...", Form1.Font5).Width < 100
                Counter = Counter + 1
            Loop
            Return InputString.Substring(0, Counter - 1) & "..."
        End If
    End Function

    Public Shared Sub Click(e As MouseEventArgs)
        If AskForDelete = True Then
            If Functions.ButtonPressed(e.X, e.Y, (Form1.ClientSize.Width - 460) / 2, (Form1.ClientSize.Height + 90) / 2, 100, 50) = True Then
                Data.DeleteWorld(DialogWorld)
                AskForDelete = False
                Form1.Refresh()
            ElseIf Functions.ButtonPressed(e.X, e.Y, (Form1.ClientSize.Width + 260) / 2, (Form1.ClientSize.Height + 90) / 2, 100, 50) = True Then
                AskForDelete = False
                Form1.Refresh()
            End If
        Else
            If RightClickDialog = True And Functions.ButtonPressed(e.X, e.Y, DialogX, DialogY + 30, 200, 30) = True Then
                AskForDelete = True
                Form1.Refresh()
            ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2) + 50, Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2) + 100, 100, 100) = True Then
                Variables.GameSlotSelected = 1
                If World1Exist = True Then
                    Data.LoadGame()
                    Variables.PlayStarting = False
                    Variables.InHome = True
                Else
                    Variables.PlayStarting = False
                    GettingWorldName.Load()
                End If
                Form1.Refresh()
            ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round((Form1.ClientSize.Width - 100) / 2), Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2) + 100, 100, 100) = True Then
                Variables.GameSlotSelected = 2
                If World2Exist = True Then
                    Data.LoadGame()
                    Variables.PlayStarting = False
                    Variables.InHome = True
                Else
                    Variables.PlayStarting = False
                    GettingWorldName.Load()
                End If
                Form1.Refresh()
            ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Width - 200) / 2) + 150, Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2) + 100, 100, 100) = True Then
                Variables.GameSlotSelected = 3
                If World3Exist = True Then
                    Data.LoadGame()
                    Variables.PlayStarting = False
                    Variables.InHome = True
                Else
                    Variables.PlayStarting = False
                    GettingWorldName.Load()
                End If
                Form1.Refresh()
            ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2) + 50, Math.Round((Form1.ClientSize.Height - 50) / 2), 100, 100) = True Then
                Variables.GameSlotSelected = 4
                If World4Exist = True Then
                    Data.LoadGame()
                    Variables.PlayStarting = False
                    Variables.InHome = True
                Else
                    Variables.PlayStarting = False
                    GettingWorldName.Load()
                End If
                Form1.Refresh()
            ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round((Form1.ClientSize.Width - 100) / 2), Math.Round((Form1.ClientSize.Height - 50) / 2), 100, 100) = True Then
                Variables.GameSlotSelected = 5
                If World5Exist = True Then
                    Data.LoadGame()
                    Variables.PlayStarting = False
                    Variables.InHome = True
                Else
                    Variables.PlayStarting = False
                    GettingWorldName.Load()
                End If
                Form1.Refresh()
            ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Width - 200) / 2) + 150, Math.Round((Form1.ClientSize.Height - 50) / 2), 100, 100) = True Then
                Variables.GameSlotSelected = 6
                If World6Exist = True Then
                    Data.LoadGame()
                    Variables.PlayStarting = False
                    Variables.InHome = True
                Else
                    Variables.PlayStarting = False
                    GettingWorldName.Load()
                End If
                Form1.Refresh()
            ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2) + 50, Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Height - 250) / 2) + 200, 100, 100) = True Then
                Variables.GameSlotSelected = 7
                If World7Exist = True Then
                    Data.LoadGame()
                    Variables.PlayStarting = False
                    Variables.InHome = True
                Else
                    Variables.PlayStarting = False
                    GettingWorldName.Load()
                End If
                Form1.Refresh()
            ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round((Form1.ClientSize.Width - 100) / 2), Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Height - 250) / 2) + 200, 100, 100) Then
                Variables.GameSlotSelected = 8
                If World8Exist = True Then
                    Data.LoadGame()
                    Variables.PlayStarting = False
                    Variables.InHome = True
                Else
                    Variables.PlayStarting = False
                    GettingWorldName.Load()
                End If
                Form1.Refresh()
            ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Width - 200) / 2) + 150, Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Height - 250) / 2) + 200, 100, 100) Then
                Variables.GameSlotSelected = 9
                If World9Exist = True Then
                    Data.LoadGame()
                    Variables.PlayStarting = False
                    Variables.InHome = True
                Else
                    Variables.PlayStarting = False
                    GettingWorldName.Load()
                End If
                Form1.Refresh()
            ElseIf Functions.ButtonPressed(e.X, e.Y, 5, 5, 100, 40) Then
                Variables.PlayStarting = False
                StartScreen.Load()
                Form1.Refresh()
            End If
        End If
    End Sub

    Public Shared Sub CreateDialog(World As Integer, e As MouseEventArgs)
        If e.X + 200 > Form1.ClientSize.Width Then
            DialogX = Form1.ClientSize.Width - 200
        Else
            DialogX = e.X
        End If
        If e.Y + 100 > Form1.ClientSize.Height Then
            DialogY = Form1.ClientSize.Height - 100
        Else
            DialogY = e.Y
        End If
        DialogWorld = World
        RightClickDialog = True
        Form1.Refresh()
    End Sub

    Public Shared Sub RightClick(e As MouseEventArgs)
        If Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2) + 50, Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2) + 100, 100, 100) = True Then
            If World1Exist = True Then
                CreateDialog(1, e)
            End If
        ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round((Form1.ClientSize.Width - 100) / 2), Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2) + 100, 100, 100) = True Then
            If World2Exist = True Then
                CreateDialog(2, e)
            End If
        ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Width - 200) / 2) + 150, Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2) + 100, 100, 100) = True Then
            If World3Exist = True Then
                CreateDialog(3, e)
            End If
        ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2) + 50, Math.Round((Form1.ClientSize.Height - 50) / 2), 100, 100) = True Then
            If World4Exist = True Then
                CreateDialog(4, e)
            End If
        ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round((Form1.ClientSize.Width - 100) / 2), Math.Round((Form1.ClientSize.Height - 50) / 2), 100, 100) = True Then
            If World5Exist = True Then
                CreateDialog(5, e)
            End If
        ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Width - 200) / 2) + 150, Math.Round((Form1.ClientSize.Height - 50) / 2), 100, 100) = True Then
            If World6Exist = True Then
                CreateDialog(6, e)
            End If
        ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2) + 50, Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Height - 250) / 2) + 200, 100, 100) = True Then
            If World7Exist = True Then
                CreateDialog(7, e)
            End If
        ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round((Form1.ClientSize.Width - 100) / 2), Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Height - 250) / 2) + 200, 100, 100) Then
            If World8Exist = True Then
                CreateDialog(8, e)
            End If
        ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Width - 200) / 2) + 150, Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Height - 250) / 2) + 200, 100, 100) Then
            If World9Exist = True Then
                CreateDialog(9, e)
            End If
        End If
    End Sub

    Public Shared Sub MouseMove(e As MouseEventArgs)
        If RightClickDialog = True Then
            If Functions.ButtonPressed(e.X, e.Y, DialogX - 5, DialogY - 5, 210, 110) = False And AskForDelete = False Then
                RightClickDialog = False
                Form1.Refresh()
            End If
        End If
    End Sub
End Class
