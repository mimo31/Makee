Public Class Functions
    Public Shared Function SuperRead(FileAddress As String) As String
        Return My.Computer.FileSystem.ReadAllText(FileAddress)
    End Function

    Public Shared Sub SuperWrite(FileAddress As String, TextToWrite As String, DeletePerious As Boolean)
        My.Computer.FileSystem.WriteAllText(FileAddress, TextToWrite, DeletePerious)
    End Sub
End Class
