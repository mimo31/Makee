Module Initialize
    Dim World1Exist As Boolean
    Dim World2Exist As Boolean
    Dim World3Exist As Boolean
    Dim World4Exist As Boolean
    Dim World5Exist As Boolean
    Dim World6Exist As Boolean
    Dim World7Exist As Boolean
    Dim World8Exist As Boolean
    Dim World9Exist As Boolean
    Dim GettingWorldNameTextboxFull As Boolean
    Dim GettingWorldNameTextboxEmpty As Boolean
    Dim GettingWorldNameTextboxClicked As Boolean = True
    Dim GettingWorldNameTextboxText As String = ""
    Dim MovableObjectsX As Single
    Dim MovableObjectsY As Single

    Class Paint
        Public Shared Sub Paint(e As PaintEventArgs)
            If Variables.StartScreen = True Then
                Form1.MinimumSize = New Size(800, 700)
                MovableObjectsX = Math.Round((Form1.ClientSize.Width - 400) / 2)
                MovableObjectsY = Math.Round((Form1.ClientSize.Height - 50) / 3)
                e.Graphics.FillRectangle(Brushes.Black, MovableObjectsX, MovableObjectsY, 400, 50)
                e.Graphics.DrawString("Play", Form1.Font3, Brushes.White, MovableObjectsX + 170, MovableObjectsY + 10)
                MovableObjectsX = Math.Round((Form1.ClientSize.Width - 230) / 2)
                MovableObjectsY = Math.Round((Form1.ClientSize.Height - 50) / 6)
                e.Graphics.DrawString("Makee", Form1.Font4, Brushes.Black, MovableObjectsX, MovableObjectsY)
            ElseIf Variables.PlayStarting Then
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
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game1\Name.txt"), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
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
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game2\Name.txt"), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
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
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game3\Name.txt"), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
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
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game4\Name.txt"), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
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
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game5\Name.txt"), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
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
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game6\Name.txt"), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
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
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game7\Name.txt"), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
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
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game8\Name.txt"), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
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
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game9\Name.txt"), Form1.Font5, Brushes.Blue, MovableObjectsX + 10, MovableObjectsY + 70)
                Else
                    e.Graphics.FillRectangle(Brushes.Black, MovableObjectsX, MovableObjectsY, 100, 100)
                    e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, MovableObjectsX + 10, MovableObjectsY + 60)
                End If
            Else
                e.Graphics.DrawString("Write name for you world.", Form1.Font3, Brushes.Black, Math.Round(Form1.ClientSize.Width / 2) - 150, Math.Round(Form1.ClientSize.Height / 2) - 80)
                MovableObjectsX = Math.Round(Form1.ClientSize.Width / 2) - 175
                MovableObjectsY = Math.Round(Form1.ClientSize.Height / 2) - 30
                e.Graphics.DrawRectangle(Form1.Pen1, MovableObjectsX, MovableObjectsY, 350, 50)
                e.Graphics.DrawRectangle(Form1.Pen1, MovableObjectsX + 125, MovableObjectsY + 70, 100, 50)
                e.Graphics.DrawString("OK", Form1.Font1, Brushes.Black, MovableObjectsX + 135, MovableObjectsY + 73)
                If GettingWorldNameTextboxClicked = False Then
                    e.Graphics.FillRectangle(Brushes.Gray, MovableObjectsX, MovableObjectsY, 350, 50)
                    e.Graphics.DrawString(GettingWorldNameTextboxText, Form1.Font3, Brushes.Green, MovableObjectsX, MovableObjectsY + 15)
                Else
                    e.Graphics.DrawString(GettingWorldNameTextboxText, Form1.Font3, Brushes.Green, MovableObjectsX, MovableObjectsY + 15)
                End If
                If GettingWorldNameTextboxFull = True Then
                    e.Graphics.DrawString("Maximum legth is 10 symbols.", Form1.Font3, Brushes.Red, MovableObjectsX - 10, MovableObjectsY - 110)
                ElseIf GettingWorldNameTextboxEmpty = True Then
                    If GettingWorldNameTextboxText = "" Then
                        e.Graphics.DrawString("You must type name for you world.", Form1.Font3, Brushes.Red, MovableObjectsX - 30, MovableObjectsY - 110)
                    Else
                        GettingWorldNameTextboxEmpty = False
                    End If
                End If
            End If
        End Sub
    End Class
    Class Initialize
        Public Shared Sub Initialize()
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
            End If
        End Sub
    End Class

    Class Click
        Public Shared Sub CreateFirstDataStructures()
            Dim Counter As Integer
            My.Computer.FileSystem.CreateDirectory("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks")
            Data.GenChunk(0, 0)
            Do
                If Data.GetValue(Counter, 0) = 5 Then
                Else
                    Data.SetValue(Counter, 0, 6)
                    Exit Do
                End If
                Counter = Counter + 1
            Loop
        End Sub

        Public Shared Sub Click(e As MouseEventArgs)
            If Variables.StartScreen = True Then
                If Functions.ButtonPressed(e.X, e.Y, Math.Round((Form1.ClientSize.Width - 400) / 2), Math.Round((Form1.ClientSize.Height - 50) / 3), 400, 50) = True Then
                    Variables.PlayStarting = True
                    Variables.StartScreen = False
                    Form1.Refresh()
                End If
            ElseIf Variables.PlayStarting = True Then
                If Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2) + 50, Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2) + 100, 100, 100) = True Then
                    If World1Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GettingWorldNameTextboxText = ""
                    End If
                    Variables.GameSlotSelected = 1
                    Form1.Refresh()
                ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round((Form1.ClientSize.Width - 100) / 2), Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2) + 100, 100, 100) = True Then
                    If World2Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GettingWorldNameTextboxText = ""
                    End If
                    Variables.GameSlotSelected = 2
                    Form1.Refresh()
                ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Width - 200) / 2) + 150, Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2) + 100, 100, 100) = True Then
                    If World3Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GettingWorldNameTextboxText = ""
                    End If
                    Variables.GameSlotSelected = 3
                    Form1.Refresh()
                ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2) + 50, Math.Round((Form1.ClientSize.Height - 50) / 2), 100, 100) = True Then
                    If World4Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GettingWorldNameTextboxText = ""
                    End If
                    Variables.GameSlotSelected = 4
                    Form1.Refresh()
                ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round((Form1.ClientSize.Width - 100) / 2), Math.Round((Form1.ClientSize.Height - 50) / 2), 100, 100) = True Then
                    If World5Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GettingWorldNameTextboxText = ""
                    End If
                    Variables.GameSlotSelected = 5
                    Form1.Refresh()
                ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Width - 200) / 2) + 150, Math.Round((Form1.ClientSize.Height - 50) / 2), 100, 100) = True Then
                    If World6Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GettingWorldNameTextboxText = ""
                    End If
                    Variables.GameSlotSelected = 6
                    Form1.Refresh()
                ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2) + 50, Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Height - 250) / 2) + 200, 100, 100) = True Then
                    If World7Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GettingWorldNameTextboxText = ""
                    End If
                    Variables.GameSlotSelected = 7
                    Form1.Refresh()
                ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round((Form1.ClientSize.Width - 100) / 2), Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Height - 250) / 2) + 200, 100, 100) Then
                    If World8Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GettingWorldNameTextboxText = ""
                    End If
                    Variables.GameSlotSelected = 8
                    Form1.Refresh()
                ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(((Form1.ClientSize.Width - 200) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Width - 200) / 2) + 150, Math.Round(((Form1.ClientSize.Height - 250) / 2 - 50) / 2 - 50) + Math.Round((Form1.ClientSize.Height - 250) / 2) + 200, 100, 100) Then
                    If World9Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GettingWorldNameTextboxText = ""
                    End If
                    Variables.GameSlotSelected = 9
                    Form1.Refresh()
                ElseIf Functions.ButtonPressed(e.X, e.Y, 5, 5, 100, 40) Then
                    Variables.PlayStarting = False
                    Variables.StartScreen = True
                    Form1.Refresh()
                End If
            Else
                If Functions.ButtonPressed(e.X, e.Y, Math.Round(Form1.ClientSize.Width / 2) - 175, Math.Round(Form1.ClientSize.Height / 2) - 30, 350, 50) Then
                    GettingWorldNameTextboxClicked = True
                ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(Form1.ClientSize.Width / 2) - 50, Math.Round(Form1.ClientSize.Height / 2) + 40, 100, 50) Then
                    If GettingWorldNameTextboxText = "" Then
                        GettingWorldNameTextboxEmpty = True
                    Else
                        CreateFirstDataStructures()
                        Functions.SuperWrite("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Name.txt", GettingWorldNameTextboxText, True)
                        Variables.GettingWorldName = False
                        Variables.InHome = True
                    End If
                Else
                    GettingWorldNameTextboxClicked = False
                End If
                Form1.Refresh()
            End If
        End Sub
    End Class

    Class Keys
        Public Shared Sub KeyUp(e As KeyPressEventArgs)
            If GettingWorldNameTextboxClicked = True Then
                Dim AllowedChars As String = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789 " & vbBack
                If AllowedChars.ToArray.Contains(e.KeyChar) = True Then
                    If e.KeyChar = vbBack Then
                        If GettingWorldNameTextboxText.Length = 10 Then
                            GettingWorldNameTextboxFull = False
                        Else

                        End If
                        If GettingWorldNameTextboxText.Length > 0 Then
                            GettingWorldNameTextboxText = GettingWorldNameTextboxText.Remove(GettingWorldNameTextboxText.Length - 1)
                        End If
                    Else
                        If GettingWorldNameTextboxText.Length = 10 Then
                            GettingWorldNameTextboxFull = True
                        Else
                            GettingWorldNameTextboxText = GettingWorldNameTextboxText & e.KeyChar
                        End If
                    End If
                    Form1.Refresh()
                End If
            End If
        End Sub
    End Class
End Module
