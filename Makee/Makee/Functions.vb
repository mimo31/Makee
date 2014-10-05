Public Class Functions
    Public Shared Function SuperRead(FileAddress As String) As String
        Return My.Computer.FileSystem.ReadAllText(FileAddress)
    End Function

    Public Shared Sub SuperWrite(FileAddress As String, TextToWrite As String, DeletePerious As Boolean)
        My.Computer.FileSystem.WriteAllText(FileAddress, TextToWrite, DeletePerious)
    End Sub

    Public Shared Function ButtonPressed(MouseX As UInt16, MouseY As UInt16, ButtonX As UInt16, ButtonY As UInt16, ButtonWidth As UInt16, ButtonHeight As UInt16) As Boolean
        If MouseX > ButtonX And MouseY > ButtonY And MouseX < ButtonX + ButtonWidth And MouseY < ButtonY + ButtonHeight Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Sub DrawPause(e As PaintEventArgs)
        e.Graphics.FillRectangle(Brushes.Black, Form1.ClientSize.Width - 60, 0, 60, 60)
        e.Graphics.FillRectangle(Brushes.LightGray, Form1.ClientSize.Width - 50, 0, 50, 50)
        e.Graphics.FillRectangle(Brushes.Red, Form1.ClientSize.Width - 40, 10, 10, 30)
        e.Graphics.FillRectangle(Brushes.Red, Form1.ClientSize.Width - 20, 10, 10, 30)
    End Sub

    Public Shared Sub DrawBack(e As PaintEventArgs)
        e.Graphics.FillRectangle(Brushes.Gray, 5, 5, 100, 40)
        e.Graphics.DrawString("< Back", Form1.Font3, Brushes.White, 7, 7)
    End Sub

    Public Shared Sub DrawMoreClassBasics(e As PaintEventArgs, Name As String, Building As Boolean, x As Integer, y As Integer, Enterable As Boolean)
        Dim Counter As Integer
        Functions.DrawBack(e)
        Functions.DrawPause(e)
        Counter = 1
        If e.Graphics.MeasureString(Name, Form1.Font4).Width < Form1.ClientSize.Width - 200 Then
            e.Graphics.DrawString(Name, Form1.Font4, Brushes.Black, 100 + (Form1.ClientSize.Width - 200 - e.Graphics.MeasureString(Name, Form1.Font4).Width) / 2, 0)
        Else
            Do While e.Graphics.MeasureString(Name.Substring(0, Counter), Form1.Font4).Width + e.Graphics.MeasureString("...", Form1.Font4).Width < Form1.ClientSize.Width - 200
                Counter = Counter + 1
            Loop
            e.Graphics.DrawString(Name.Substring(0, Counter - 1) & "...", Form1.Font4, Brushes.Black, 100 + (Form1.ClientSize.Width - 200 - e.Graphics.MeasureString(Name.Substring(0, Counter - 1) & "...", Form1.Font4).Width) / 2, 0)
        End If
        e.Graphics.DrawString("(" & x & ", " & y & ")", Form1.Font3, Brushes.Black, (Form1.ClientSize.Width - e.Graphics.MeasureString("(" & x & ", " & y & ")", Form1.Font3).Width) / 2, 70)
        If x = Variables.PlayerPositionX And y = Variables.PlayerPositionY Then
            If Building = True Then
                DrawMoreClassButton(e, 1, 200, 20, "Remove")
            Else
                DrawMoreClassButton(e, 1, 200, 25, "Build")
            End If
            DrawMoreClassButton(e, 3, 200, 2, "Change")
            If Enterable = True Then
                DrawMoreClassButton(e, 2, 270, 20, "Enter")
            End If
        Else
            DrawMoreClassButton(e, 1, 200, -2, "Go here")
            If Building = True Then
                DrawMoreClassButton(e, 3, 200, 20, "Remove")
            Else
                DrawMoreClassButton(e, 3, 200, 25, "Build")
            End If
            If Enterable = True Then
                DrawMoreClassButton(e, 1, 270, 2, "Change")
                DrawMoreClassButton(e, 3, 270, 20, "Enter")
            Else
                DrawMoreClassButton(e, 2, 270, 2, "Change")
            End If
        End If
    End Sub

    Public Shared Sub DrawMoreClassButton(e As PaintEventArgs, x As Byte, y As UShort, TextPadding As Short, Text As String)
        Dim MovableObjectsX As Single = Math.Round(Form1.ClientSize.Width / 4 * x) - 75
        e.Graphics.FillRectangle(Brushes.LightGray, MovableObjectsX, y, 150, 50)
        e.Graphics.DrawRectangle(New Pen(Brushes.Black, 5), MovableObjectsX, y, 150, 50)
        e.Graphics.DrawString(Text, Form1.Font1, Brushes.Black, MovableObjectsX + TextPadding, y + 2)
    End Sub
End Class
