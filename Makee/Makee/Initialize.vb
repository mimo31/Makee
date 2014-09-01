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
    Dim GameSlotSelected As Integer
    Class Paint
        Public Shared Sub Paint(e As PaintEventArgs)
            If Variables.StartScreen = True Then
                e.Graphics.FillRectangle(Brushes.Black, 400, 250, 400, 50)
                e.Graphics.DrawString("Play", Form1.Font3, Brushes.White, 570, 260)
                e.Graphics.DrawString("Makee", Form1.Font4, Brushes.Black, 485, 100)
            ElseIf Variables.PlayStarting Then
                e.Graphics.DrawString("Load The World", Form1.Font1, Brushes.Black, 420, 20)
                If World1Exist = True Then
                    e.Graphics.FillRectangle(Brushes.White, 200, 200, 100, 100)
                    e.Graphics.FillRectangle(Brushes.Yellow, 200, 240, 100, 20)
                    e.Graphics.FillRectangle(Brushes.Yellow, 240, 200, 20, 100)
                    e.Graphics.DrawRectangle(Form1.Pen1, 200, 200, 100, 100)
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game1\Name.txt"), Form1.Font5, Brushes.Blue, 210, 270)
                Else
                    e.Graphics.FillRectangle(Brushes.Black, 200, 200, 100, 100)
                    e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, 210, 260)
                End If
                If World2Exist = True Then
                    e.Graphics.FillRectangle(Brushes.White, 500, 200, 100, 100)
                    e.Graphics.FillRectangle(Brushes.Yellow, 500, 240, 100, 20)
                    e.Graphics.FillRectangle(Brushes.Yellow, 540, 200, 20, 100)
                    e.Graphics.DrawRectangle(Form1.Pen1, 500, 200, 100, 100)
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game2\Name.txt"), Form1.Font5, Brushes.Blue, 510, 270)
                Else
                    e.Graphics.FillRectangle(Brushes.Black, 500, 200, 100, 100)
                    e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, 510, 260)
                End If
                If World3Exist = True Then
                    e.Graphics.FillRectangle(Brushes.White, 800, 200, 100, 100)
                    e.Graphics.FillRectangle(Brushes.Yellow, 800, 240, 100, 20)
                    e.Graphics.FillRectangle(Brushes.Yellow, 840, 200, 20, 100)
                    e.Graphics.DrawRectangle(Form1.Pen1, 800, 200, 100, 100)
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game3\Name.txt"), Form1.Font5, Brushes.Blue, 810, 270)
                Else
                    e.Graphics.FillRectangle(Brushes.Black, 800, 200, 100, 100)
                    e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, 810, 260)
                End If
                If World4Exist = True Then
                    e.Graphics.FillRectangle(Brushes.White, 200, 400, 100, 100)
                    e.Graphics.FillRectangle(Brushes.Yellow, 200, 440, 100, 20)
                    e.Graphics.FillRectangle(Brushes.Yellow, 240, 400, 20, 100)
                    e.Graphics.DrawRectangle(Form1.Pen1, 200, 400, 100, 100)
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game4\Name.txt"), Form1.Font5, Brushes.Blue, 210, 470)
                Else
                    e.Graphics.FillRectangle(Brushes.Black, 200, 400, 100, 100)
                    e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, 210, 460)
                End If
                If World5Exist = True Then
                    e.Graphics.FillRectangle(Brushes.White, 500, 400, 100, 100)
                    e.Graphics.FillRectangle(Brushes.Yellow, 500, 440, 100, 20)
                    e.Graphics.FillRectangle(Brushes.Yellow, 540, 400, 20, 100)
                    e.Graphics.DrawRectangle(Form1.Pen1, 500, 400, 100, 100)
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game5\Name.txt"), Form1.Font5, Brushes.Blue, 510, 470)
                Else
                    e.Graphics.FillRectangle(Brushes.Black, 500, 400, 100, 100)
                    e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, 510, 460)
                End If
                If World6Exist = True Then
                    e.Graphics.FillRectangle(Brushes.White, 800, 400, 100, 100)
                    e.Graphics.FillRectangle(Brushes.Yellow, 800, 440, 100, 20)
                    e.Graphics.FillRectangle(Brushes.Yellow, 840, 400, 20, 100)
                    e.Graphics.DrawRectangle(Form1.Pen1, 800, 400, 100, 100)
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game6\Name.txt"), Form1.Font5, Brushes.Blue, 810, 470)
                Else
                    e.Graphics.FillRectangle(Brushes.Black, 800, 400, 100, 100)
                    e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, 810, 460)
                End If
                If World7Exist = True Then
                    e.Graphics.FillRectangle(Brushes.White, 200, 600, 100, 100)
                    e.Graphics.FillRectangle(Brushes.Yellow, 200, 640, 100, 20)
                    e.Graphics.FillRectangle(Brushes.Yellow, 240, 600, 20, 100)
                    e.Graphics.DrawRectangle(Form1.Pen1, 200, 600, 100, 100)
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game7\Name.txt"), Form1.Font5, Brushes.Blue, 210, 670)
                Else
                    e.Graphics.FillRectangle(Brushes.Black, 200, 600, 100, 100)
                    e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, 210, 660)
                End If
                If World8Exist = True Then
                    e.Graphics.FillRectangle(Brushes.White, 500, 600, 100, 100)
                    e.Graphics.FillRectangle(Brushes.Yellow, 500, 640, 100, 20)
                    e.Graphics.FillRectangle(Brushes.Yellow, 540, 600, 20, 100)
                    e.Graphics.DrawRectangle(Form1.Pen1, 500, 600, 100, 100)
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game8\Name.txt"), Form1.Font5, Brushes.Blue, 510, 670)
                Else
                    e.Graphics.FillRectangle(Brushes.Black, 500, 600, 100, 100)
                    e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, 510, 660)
                End If
                If World9Exist = True Then
                    e.Graphics.FillRectangle(Brushes.White, 800, 600, 100, 100)
                    e.Graphics.FillRectangle(Brushes.Yellow, 800, 640, 100, 20)
                    e.Graphics.FillRectangle(Brushes.Yellow, 840, 600, 20, 100)
                    e.Graphics.DrawRectangle(Form1.Pen1, 800, 600, 100, 100)
                    e.Graphics.DrawString(Functions.SuperRead("C:\Makee\SavedGames\Game9\Name.txt"), Form1.Font5, Brushes.Blue, 810, 670)
                Else
                    e.Graphics.FillRectangle(Brushes.Black, 800, 600, 100, 100)
                    e.Graphics.DrawString("Empty", Form1.Font3, Brushes.White, 810, 660)
                End If
            Else

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
    End Class

    Class Click
        Public Shared Sub Click(e As MouseEventArgs)
            If Variables.StartScreen = True Then
                If 800 > e.X And e.X > 400 And 300 > e.Y And e.Y > 250 Then
                    Variables.PlayStarting = True
                    Variables.StartScreen = False
                End If
            ElseIf Variables.PlayStarting = True Then
                If 508 > e.X And e.X > 408 And 380 > e.Y And e.Y > 280 Then
                    If World1Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GameSlotSelected = 1
                    End If
                End If
                If 808 > e.X And e.X > 708 And 380 > e.Y And e.Y > 280 Then
                    If World2Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GameSlotSelected = 2
                    End If
                End If
                If 1108 > e.X And e.X > 1008 And 380 > e.Y And e.Y > 280 Then
                    If World2Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GameSlotSelected = 3
                    End If
                End If
                If 508 > e.X And e.X > 408 And 580 > e.Y And e.Y > 480 Then
                    If World1Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GameSlotSelected = 4
                    End If
                End If
                If 808 > e.X And e.X > 708 And 580 > e.Y And e.Y > 480 Then
                    If World2Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GameSlotSelected = 5
                    End If
                End If
                If 1108 > e.X And e.X > 1008 And 580 > e.Y And e.Y > 480 Then
                    If World2Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GameSlotSelected = 6
                    End If
                End If
                If 508 > e.X And e.X > 408 And 780 > e.Y And e.Y > 680 Then
                    If World1Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GameSlotSelected = 7
                    End If
                End If
                If 808 > e.X And e.X > 708 And 780 > e.Y And e.Y > 680 Then
                    If World2Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GameSlotSelected = 8
                    End If
                End If
                If 1108 > e.X And e.X > 1008 And 780 > e.Y And e.Y > 680 Then
                    If World2Exist = True Then
                        Variables.PlayStarting = False
                        Variables.InHome = True
                    Else
                        Variables.PlayStarting = False
                        Variables.GettingWorldName = True
                        GameSlotSelected = 9
                    End If
                End If
            Else

            End If
        End Sub
    End Class
End Module
