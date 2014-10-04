Public Class GettingWorldName
    Public Shared GettingWorldNameTextboxFull As Boolean
    Public Shared GettingWorldNameTextboxEmpty As Boolean
    Public Shared GettingWorldNameTextboxClicked As Boolean = True
    Public Shared GettingWorldNameTextboxText As String = ""
    Public Shared MovableObjectsX As Single
    Public Shared MovableObjectsY As Single

    Public Shared Sub Load()
        Variables.GettingWorldName = True
        GettingWorldNameTextboxClicked = True
        GettingWorldNameTextboxEmpty = False
        GettingWorldNameTextboxFull = False
        GettingWorldNameTextboxText = ""
    End Sub

    Public Shared Sub Paint(e As PaintEventArgs)
        Functions.DrawBack(e)
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
    End Sub

    Public Shared Sub CreateFirstDataStructures()
        Dim Counter As Integer
        My.Computer.FileSystem.CreateDirectory("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks")
        Variables.ZoomFactor = 16
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
        If Functions.ButtonPressed(e.X, e.Y, Math.Round(Form1.ClientSize.Width / 2) - 175, Math.Round(Form1.ClientSize.Height / 2) - 30, 350, 50) = True Then
            GettingWorldNameTextboxClicked = True
        ElseIf Functions.ButtonPressed(e.X, e.Y, Math.Round(Form1.ClientSize.Width / 2) - 50, Math.Round(Form1.ClientSize.Height / 2) + 40, 100, 50) = True Then
            If GettingWorldNameTextboxText = "" Then
                GettingWorldNameTextboxEmpty = True
            Else
                CreateFirstDataStructures()
                Functions.SuperWrite("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Name.txt", GettingWorldNameTextboxText, True)
                Variables.GettingWorldName = False
                Variables.InHome = True
            End If
        ElseIf Functions.ButtonPressed(e.X, e.Y, 5, 5, 100, 40) = True Then
            Variables.PlayStarting = True
            Variables.GettingWorldName = False
        Else
            GettingWorldNameTextboxClicked = False
        End If
        Form1.Refresh()
    End Sub

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
