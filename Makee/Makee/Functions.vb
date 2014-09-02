Public Class Functions
    Public Shared Function SuperRead(FileAddress As String) As String
        Return My.Computer.FileSystem.ReadAllText(FileAddress)
    End Function

    Public Shared Sub SuperWrite(FileAddress As String, TextToWrite As String, DeletePerious As Boolean)
        My.Computer.FileSystem.WriteAllText(FileAddress, TextToWrite, DeletePerious)
    End Sub

    Public Shared Function ButtonPressed(MouseX As UInt16, MouseY As UInt16, ButtonX As UInt16, ButtonY As UInt16, ButtonWidth As UInt16, ButtonHeight As UInt16)
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
End Class
