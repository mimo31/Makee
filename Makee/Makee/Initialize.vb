Public Class Initialize
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
        StartScreen.Load()
    End Sub
End Class
