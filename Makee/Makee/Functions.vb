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
End Class
