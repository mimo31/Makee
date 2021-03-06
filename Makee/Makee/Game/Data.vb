﻿Public Class Data
    Public Shared Sub GenChunk(x As Integer, y As Integer)
        If Variables.ChunksDirectory Is Nothing Then
            ReDim Preserve Variables.ChunksDirectory(0)
            ReDim Preserve Variables.ChunksValues(63, 63, 0)
        Else
            ReDim Preserve Variables.ChunksDirectory(Variables.ChunksDirectory.Length)
            ReDim Preserve Variables.ChunksValues(63, 63, Variables.ChunksDirectory.Length - 1)
        End If
        Dim Chunk(65, 65) As UShort
        Dim Counter As Integer
        Dim Counter2 As Integer
        Dim FriendsChunksDetected(7) As Boolean
        Variables.ChunksDirectory(Variables.ChunksDirectory.Length - 1) = x & "," & y
        Do While Counter < Variables.ChunksDirectory.Length
            If Variables.ChunksDirectory(Counter) = x & "," & y - 1 Then
                FriendsChunksDetected(0) = True
                Counter2 = 1
                Do While Counter2 < 65
                    Chunk(Counter2, 0) = Variables.ChunksValues(Counter2 - 1, 63, Counter)
                    Counter2 = Counter2 + 1
                Loop
            End If
            If Variables.ChunksDirectory(Counter) = x - 1 & "," & y Then
                FriendsChunksDetected(1) = True
                Counter2 = 1
                Do While Counter2 < 65
                    Chunk(0, Counter2) = Variables.ChunksValues(63, Counter2 - 1, Counter)
                    Counter2 = Counter2 + 1
                Loop
            End If
            If Variables.ChunksDirectory(Counter) = x & "," & y + 1 Then
                FriendsChunksDetected(2) = True
                Counter2 = 1
                Do While Counter2 < 65
                    Chunk(Counter2, 65) = Variables.ChunksValues(Counter2 - 1, 0, Counter)
                    Counter2 = Counter2 + 1
                Loop
            End If
            If Variables.ChunksDirectory(Counter) = x + 1 & "," & y Then
                FriendsChunksDetected(3) = True
                Counter2 = 1
                Do While Counter2 < 65
                    Chunk(65, Counter2) = Variables.ChunksValues(0, Counter2 - 1, Counter)
                    Counter2 = Counter2 + 1
                Loop
            End If
            If Variables.ChunksDirectory(Counter) = x + 1 & "," & y - 1 Then
                FriendsChunksDetected(4) = True
                Chunk(65, 0) = Variables.ChunksValues(0, 63, Counter)
            End If
            If Variables.ChunksDirectory(Counter) = x - 1 & "," & y + 1 Then
                FriendsChunksDetected(5) = True
                Chunk(0, 65) = Variables.ChunksValues(63, 0, Counter)
            End If
            If Variables.ChunksDirectory(Counter) = x - 1 & "," & y - 1 Then
                FriendsChunksDetected(6) = True
                Chunk(0, 0) = Variables.ChunksValues(63, 63, Counter)
            End If
            If Variables.ChunksDirectory(Counter) = x + 1 & "," & y + 1 Then
                FriendsChunksDetected(7) = True
                Chunk(65, 65) = Variables.ChunksValues(0, 0, Counter)
            End If
            Counter = Counter + 1
        Loop
        Dim ReadedChunk() As Byte
        If FriendsChunksDetected(0) = False Then
            If My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x & "," & y - 1) = True Then
                ReadedChunk = My.Computer.FileSystem.ReadAllBytes("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x & "," & y - 1)
                FriendsChunksDetected(0) = True
                Counter2 = 0
                Do While Counter2 < 64
                    Chunk(Counter2 + 1, 0) = ReadedChunk(8064 + 2 * Counter2) * 256 + ReadedChunk(8065 + 2 * Counter2)
                    Counter2 = Counter2 + 1
                Loop
            End If
        End If
        If FriendsChunksDetected(1) = False Then
            If My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x - 1 & "," & y) = True Then
                ReadedChunk = My.Computer.FileSystem.ReadAllBytes("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x - 1 & "," & y)
                FriendsChunksDetected(1) = True
                Counter2 = 0
                Do While Counter2 < 64
                    Chunk(0, Counter2 + 1) = ReadedChunk(126 + 128 * Counter2) * 256 + ReadedChunk(127 + 128 * Counter2)
                    Counter2 = Counter2 + 1
                Loop
            End If
        End If
        If FriendsChunksDetected(2) = False Then
            If My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x & "," & y + 1) = True Then
                ReadedChunk = My.Computer.FileSystem.ReadAllBytes("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x & "," & y + 1)
                FriendsChunksDetected(2) = True
                Counter2 = 0
                Do While Counter2 < 64
                    Chunk(Counter2 + 1, 65) = ReadedChunk(2 * Counter2) * 256 + ReadedChunk(1 + 2 * Counter2)
                    Counter2 = Counter2 + 1
                Loop
            End If
        End If
        If FriendsChunksDetected(3) = False Then
            If My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x + 1 & "," & y) = True Then
                ReadedChunk = My.Computer.FileSystem.ReadAllBytes("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x + 1 & "," & y)
                FriendsChunksDetected(3) = True
                Counter2 = 0
                Do While Counter2 < 64
                    Chunk(65, Counter2 + 1) = ReadedChunk(128 * Counter2) * 256 + ReadedChunk(1 + 128 * Counter2)
                    Counter2 = Counter2 + 1
                Loop
            End If
        End If
        If FriendsChunksDetected(4) = False Then
            If My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x + 1 & "," & y - 1) = True Then
                ReadedChunk = My.Computer.FileSystem.ReadAllBytes("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x + 1 & "," & y - 1)
                FriendsChunksDetected(4) = True
                Chunk(65, 0) = ReadedChunk(8064) * 256 + ReadedChunk(8065)
            End If
        End If
        If FriendsChunksDetected(5) = False Then
            If My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x - 1 & "," & y + 1) = True Then
                ReadedChunk = My.Computer.FileSystem.ReadAllBytes("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x - 1 & "," & y + 1)
                FriendsChunksDetected(5) = True
                Chunk(0, 65) = ReadedChunk(126) * 256 + ReadedChunk(127)
            End If
        End If
        If FriendsChunksDetected(6) = False Then
            If My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x - 1 & "," & y - 1) = True Then
                ReadedChunk = My.Computer.FileSystem.ReadAllBytes("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x - 1 & "," & y - 1)
                FriendsChunksDetected(6) = True
                Chunk(0, 0) = ReadedChunk(8190) * 256 + ReadedChunk(8191)
            End If
        End If
        If FriendsChunksDetected(7) = False Then
            If My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x + 1 & "," & y + 1) = True Then
                ReadedChunk = My.Computer.FileSystem.ReadAllBytes("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x + 1 & "," & y + 1)
                FriendsChunksDetected(7) = True
                Chunk(65, 65) = ReadedChunk(0) * 256 + ReadedChunk(1)
            End If
        End If
        Dim ChunkToWrite(8191) As Byte
        If FriendsChunksDetected(6) = True Or FriendsChunksDetected(0) = True Or FriendsChunksDetected(1) = True Then
            Counter = 1
            Counter2 = 1
            Do While Counter < 65
                Do While Counter2 < 65
                    Chunk(Counter2, Counter) = ChooseValue(Chunk(Counter2, Counter - 1), Chunk(Counter2 - 1, Counter), Chunk(Counter2 - 1, Counter - 1), Chunk(Counter2 + 1, Counter - 1), Chunk(Counter2, Counter + 1), Chunk(Counter2 + 1, Counter + 1), Chunk(Counter2 - 1, Counter + 1), Chunk(Counter2 + 1, Counter))
                    Variables.ChunksValues(Counter2 - 1, Counter - 1, Variables.ChunksDirectory.Length - 1) = Chunk(Counter2, Counter)
                    ChunkToWrite(((Counter - 1) * 64 + Counter2 - 1) * 2) = Math.Floor(Chunk(Counter2, Counter) / 256)
                    ChunkToWrite(((Counter - 1) * 64 + Counter2 - 1) * 2 + 1) = Chunk(Counter2, Counter) Mod 256
                    Counter2 = Counter2 + 1
                Loop
                Counter2 = 1
                Counter = Counter + 1
            Loop
        ElseIf FriendsChunksDetected(2) = True Or FriendsChunksDetected(7) = True Or FriendsChunksDetected(3) = True Then
            Counter = 64
            Counter2 = 64
            Do While Counter > 0
                Do While Counter2 > 0
                    Chunk(Counter2, Counter) = ChooseValue(Chunk(Counter2, Counter - 1), Chunk(Counter2 - 1, Counter), Chunk(Counter2 - 1, Counter - 1), Chunk(Counter2 + 1, Counter - 1), Chunk(Counter2, Counter + 1), Chunk(Counter2 + 1, Counter + 1), Chunk(Counter2 - 1, Counter + 1), Chunk(Counter2 + 1, Counter))
                    Variables.ChunksValues(Counter2 - 1, Counter - 1, Variables.ChunksDirectory.Length - 1) = Chunk(Counter2, Counter)
                    ChunkToWrite(((Counter - 1) * 64 + Counter2 - 1) * 2) = Math.Floor(Chunk(Counter2, Counter) / 256)
                    ChunkToWrite(((Counter - 1) * 64 + Counter2 - 1) * 2 + 1) = Chunk(Counter2, Counter) Mod 256
                    Counter2 = Counter2 - 1
                Loop
                Counter2 = 64
                Counter = Counter - 1
            Loop
        ElseIf FriendsChunksDetected(4) = True Then
            Counter = 64
            Counter2 = 1
            Do While Counter > 0
                Do While Counter2 < 65
                    Chunk(Counter2, Counter) = ChooseValue(Chunk(Counter2, Counter - 1), Chunk(Counter2 - 1, Counter), Chunk(Counter2 - 1, Counter - 1), Chunk(Counter2 + 1, Counter - 1), Chunk(Counter2, Counter + 1), Chunk(Counter2 + 1, Counter + 1), Chunk(Counter2 - 1, Counter + 1), Chunk(Counter2 + 1, Counter))
                    Variables.ChunksValues(Counter2 - 1, Counter - 1, Variables.ChunksDirectory.Length - 1) = Chunk(Counter2, Counter)
                    ChunkToWrite(((Counter - 1) * 64 + Counter2 - 1) * 2) = Math.Floor(Chunk(Counter2, Counter) / 256)
                    ChunkToWrite(((Counter - 1) * 64 + Counter2 - 1) * 2 + 1) = Chunk(Counter2, Counter) Mod 256
                    Counter2 = Counter2 + 1
                Loop
                Counter2 = 1
                Counter = Counter - 1
            Loop
        Else
            Counter = 1
            Counter2 = 64
            Do While Counter < 65
                Do While Counter2 > 0
                    Chunk(Counter2, Counter) = ChooseValue(Chunk(Counter2, Counter - 1), Chunk(Counter2 - 1, Counter), Chunk(Counter2 - 1, Counter - 1), Chunk(Counter2 + 1, Counter - 1), Chunk(Counter2, Counter + 1), Chunk(Counter2 + 1, Counter + 1), Chunk(Counter2 - 1, Counter + 1), Chunk(Counter2 + 1, Counter))
                    Variables.ChunksValues(Counter2 - 1, Counter - 1, Variables.ChunksDirectory.Length - 1) = Chunk(Counter2, Counter)
                    ChunkToWrite(((Counter - 1) * 64 + Counter2 - 1) * 2) = Math.Floor(Chunk(Counter2, Counter) / 256)
                    ChunkToWrite(((Counter - 1) * 64 + Counter2 - 1) * 2 + 1) = Chunk(Counter2, Counter) Mod 256
                    Counter2 = Counter2 - 1
                Loop
                Counter2 = 64
                Counter = Counter + 1
            Loop
        End If
        My.Computer.FileSystem.WriteAllBytes("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & x & "," & y & ".chunk", ChunkToWrite, False)
    End Sub

    Public Shared Sub SetValue(x As Integer, y As Integer, Value As UShort)
        Dim Counter As Integer
        Dim ChunkValueSearching As String
        Dim XInChunk As Integer
        Dim YInChunk As Integer
        If x > -1 And y > -1 Then
            ChunkValueSearching = Math.Floor(x / 64) & "," & Math.Floor(y / 64)
        ElseIf x > -1 Then
            ChunkValueSearching = Math.Floor(x / 64) & "," & Math.Ceiling((y + 1) / 64) - 1
        ElseIf y > -1 Then
            ChunkValueSearching = Math.Ceiling((x + 1) / 64) - 1 & "," & Math.Floor(y / 64)
        Else
            ChunkValueSearching = Math.Ceiling((x + 1) / 64) - 1 & "," & Math.Ceiling((y + 1) / 64) - 1
        End If
        If x > -1 Then
            XInChunk = x Mod 64
        Else
            XInChunk = x
            Do Until XInChunk > -1
                XInChunk = XInChunk + 64
            Loop
        End If
        If y > -1 Then
            YInChunk = y Mod 64
        Else
            YInChunk = y
            Do Until YInChunk > -1
                YInChunk = YInChunk + 64
            Loop
        End If
        If Variables.ChunksDirectory IsNot Nothing Then
            Do While Counter < Variables.ChunksDirectory.Length
                If Variables.ChunksDirectory(Counter) = ChunkValueSearching Then
                    Variables.ChunksValues(XInChunk, YInChunk, Counter) = Value
                End If
                Counter = Counter + 1
            Loop
        End If
        If My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & ChunkValueSearching & ".chunk") = True Then
            Dim ReadedChunk As Byte() = My.Computer.FileSystem.ReadAllBytes("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & ChunkValueSearching & ".chunk")
            ReadedChunk((64 * YInChunk + XInChunk) * 2) = Math.Floor(Value / 256)
            ReadedChunk((64 * YInChunk + XInChunk) * 2 + 1) = Value Mod 256
            My.Computer.FileSystem.WriteAllBytes("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & ChunkValueSearching & ".chunk", ReadedChunk, False)
        End If
    End Sub

    Public Shared Sub DeleteWorld(World As Byte)
        My.Computer.FileSystem.DeleteDirectory("C:\Makee\SavedGames\Game" & World, FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Computer.FileSystem.CreateDirectory("C:\Makee\SavedGames\Game" & World)
    End Sub

    Public Shared Sub SaveGame()
        My.Computer.FileSystem.WriteAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\MapX.txt", Variables.MapPositionX, False)
        My.Computer.FileSystem.WriteAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\MapY.txt", Variables.MapPositionY, False)
        My.Computer.FileSystem.WriteAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\PlayerX.txt", Variables.PlayerPositionX, False)
        My.Computer.FileSystem.WriteAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\PlayerY.txt", Variables.PlayerPositionY, False)
        My.Computer.FileSystem.WriteAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Zoom.txt", Variables.ZoomFactor, False)
    End Sub

    Public Shared Sub LoadGame()
        Variables.MapPositionX = My.Computer.FileSystem.ReadAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\MapX.txt")
        Variables.MapPositionY = My.Computer.FileSystem.ReadAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\MapY.txt")
        Variables.PlayerPositionX = My.Computer.FileSystem.ReadAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\PlayerX.txt")
        Variables.PlayerPositionY = My.Computer.FileSystem.ReadAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\PlayerY.txt")
        Variables.ZoomFactor = My.Computer.FileSystem.ReadAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Zoom.txt")
    End Sub

    Public Shared Function GetName(Id As UShort) As String
        Select Case Id
            Case 1
                Return "Rock"
            Case 2
                Return "Forest"
            Case 3
                Return "Meadow"
            Case 4
                Return "Plain"
            Case 5
                Return "Water"
            Case 6
                Return "Base lvl.1"
            Case Else
                Return "Unknown"
        End Select
    End Function

    Public Shared Sub CreateWorld(Name As String)
        Dim Counter As Integer
        My.Computer.FileSystem.CreateDirectory("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks")
        My.Computer.FileSystem.WriteAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Name.txt", Name, False)
        My.Computer.FileSystem.WriteAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\MapX.txt", 0, False)
        My.Computer.FileSystem.WriteAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\MapY.txt", 0, False)
        My.Computer.FileSystem.WriteAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\PlayerX.txt", 0, False)
        My.Computer.FileSystem.WriteAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\PlayerY.txt", 0, False)
        My.Computer.FileSystem.WriteAllText("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Zoom.txt", 16, False)
        Variables.ZoomFactor = 16
        Data.GenChunk(0, 0)
        Do
            If Data.GetValue(Counter, 0) = 5 Then
            Else
                Variables.MapPositionX = Counter - 10
                Variables.MapPositionY = -10
                Variables.PlayerPositionX = Counter
                Variables.PlayerPositionY = 0
                Data.SetValue(Counter, 0, 6)
                Exit Do
            End If
            Counter = Counter + 1
        Loop
    End Sub

    Public Shared Sub QuitGame()
        Variables.ChunksDirectory = Nothing
        Variables.ChunksValues = Nothing
        Variables.StartScreen = True
    End Sub

    Public Shared Function GetValue(x As Integer, y As Integer) As UShort
        Dim Counter As Integer
        Dim Counter2 As Byte
        Dim ChunkValueSearching As String
        If x > -1 And y > -1 Then
            ChunkValueSearching = Math.Floor(x / 64) & "," & Math.Floor(y / 64)
        ElseIf x > -1 Then
            ChunkValueSearching = Math.Floor(x / 64) & "," & Math.Ceiling((y + 1) / 64) - 1
        ElseIf y > -1 Then
            ChunkValueSearching = Math.Ceiling((x + 1) / 64) - 1 & "," & Math.Floor(y / 64)
        Else
            ChunkValueSearching = Math.Ceiling((x + 1) / 64) - 1 & "," & Math.Ceiling((y + 1) / 64) - 1
        End If
        Dim XInChunk As Integer
        If x > -1 Then
            XInChunk = x Mod 64
        Else
            XInChunk = x
            Do Until XInChunk > -1
                XInChunk = XInChunk + 64
            Loop
        End If
        Dim YInChunk As Integer
        If y > -1 Then
            YInChunk = y Mod 64
        Else
            YInChunk = y
            Do Until YInChunk > -1
                YInChunk = YInChunk + 64
            Loop
        End If

        If Variables.ChunksDirectory IsNot Nothing Then
            Do While Counter < Variables.ChunksDirectory.Length
                If Variables.ChunksDirectory(Counter) = ChunkValueSearching Then
                    Return Variables.ChunksValues(XInChunk, YInChunk, Counter)
                End If
                Counter = Counter + 1
            Loop
            Counter = 0
        End If

        If My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & ChunkValueSearching & ".chunk") = True Then
            Dim ReadedChunk As Byte() = My.Computer.FileSystem.ReadAllBytes("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & ChunkValueSearching & ".chunk")
            If Variables.ChunksDirectory Is Nothing Then
                ReDim Preserve Variables.ChunksDirectory(0)
                ReDim Preserve Variables.ChunksValues(63, 63, 0)
            Else
                ReDim Preserve Variables.ChunksDirectory(Variables.ChunksDirectory.Length)
                ReDim Preserve Variables.ChunksValues(63, 63, Variables.ChunksDirectory.Length - 1)
            End If
            Variables.ChunksDirectory(Variables.ChunksDirectory.Length - 1) = ChunkValueSearching
            Do While Counter < 64
                Do While Counter2 < 64
                    Variables.ChunksValues(Counter2, Counter, Variables.ChunksDirectory.Length - 1) = ReadedChunk((Counter * 64 + Counter2) * 2) * 256 + ReadedChunk((Counter * 64 + Counter2) * 2 + 1)
                    Counter2 = Counter2 + 1
                Loop
                Counter2 = 0
                Counter = Counter + 1
            Loop
            Counter = 0
            Counter2 = 0
            Return Variables.ChunksValues(XInChunk, YInChunk, Variables.ChunksDirectory.Length - 1)
        End If

        If x > -1 And y > -1 Then
            GenChunk(Math.Floor(x / 64), Math.Floor(y / 64))
        ElseIf x > -1 Then
            GenChunk(Math.Floor(x / 64), Math.Ceiling((y + 1) / 64) - 1)
        ElseIf y > -1 Then
            GenChunk(Math.Ceiling((x + 1) / 64) - 1, Math.Floor(y / 64))
        Else
            GenChunk(Math.Ceiling((x + 1) / 64) - 1, Math.Ceiling((y + 1) / 64) - 1)
        End If
        Return Variables.ChunksValues(XInChunk, YInChunk, Variables.ChunksDirectory.Length - 1)
    End Function

    Public Shared Function ChooseValue(a As UShort, b As UShort, c As UShort, d As UShort, e As UShort, f As UShort, g As UShort, h As UShort) As UShort
        Dim TotalFriends As Byte
        Dim Rocks As Byte
        Dim Forests As Byte
        Dim Meadows As Byte
        Dim Plains As Byte
        Dim Waters As Byte
        Dim NumberChoiced As Byte
        If Variables.R.Next(0, 100) = 0 Then
            Return Variables.R.Next(1, 6)
        Else
            If a > 0 Then
                TotalFriends = 1
                Select Case a
                    Case 1
                        Rocks = 1
                    Case 2
                        Forests = 1
                    Case 3
                        Meadows = 1
                    Case 4
                        Plains = 1
                    Case 5
                        Waters = 1
                End Select
            End If
            If b > 0 Then
                TotalFriends = TotalFriends + 1
                Select Case b
                    Case 1
                        Rocks = Rocks + 1
                    Case 2
                        Forests = Forests + 1
                    Case 3
                        Meadows = Meadows + 1
                    Case 4
                        Plains = Plains + 1
                    Case 5
                        Waters = Waters + 1
                End Select
            End If
            If c > 0 Then
                TotalFriends = TotalFriends + 1
                Select Case c
                    Case 1
                        Rocks = Rocks + 1
                    Case 2
                        Forests = Forests + 1
                    Case 3
                        Meadows = Meadows + 1
                    Case 4
                        Plains = Plains + 1
                    Case 5
                        Waters = Waters + 1
                End Select
            End If
            If d > 0 Then
                TotalFriends = TotalFriends + 1
                Select Case d
                    Case 1
                        Rocks = Rocks + 1
                    Case 2
                        Forests = Forests + 1
                    Case 3
                        Meadows = Meadows + 1
                    Case 4
                        Plains = Plains + 1
                    Case 5
                        Waters = Waters + 1
                End Select
            End If
            If e > 0 Then
                TotalFriends = TotalFriends + 1
                Select Case e
                    Case 1
                        Rocks = Rocks + 1
                    Case 2
                        Forests = Forests + 1
                    Case 3
                        Meadows = Meadows + 1
                    Case 4
                        Plains = Plains + 1
                    Case 5
                        Waters = Waters + 1
                End Select
            End If
            If f > 0 Then
                TotalFriends = TotalFriends + 1
                Select Case f
                    Case 1
                        Rocks = Rocks + 1
                    Case 2
                        Forests = Forests + 1
                    Case 3
                        Meadows = Meadows + 1
                    Case 4
                        Plains = Plains + 1
                    Case 5
                        Waters = Waters + 1
                End Select
            End If
            If g > 0 Then
                TotalFriends = TotalFriends + 1
                Select Case g
                    Case 1
                        Rocks = Rocks + 1
                    Case 2
                        Forests = Forests + 1
                    Case 3
                        Meadows = Meadows + 1
                    Case 4
                        Plains = Plains + 1
                    Case 5
                        Waters = Waters + 1
                End Select
            End If
            If h > 0 Then
                TotalFriends = TotalFriends + 1
                Select Case h
                    Case 1
                        Rocks = Rocks + 1
                    Case 2
                        Forests = Forests + 1
                    Case 3
                        Meadows = Meadows + 1
                    Case 4
                        Plains = Plains + 1
                    Case 5
                        Waters = Waters + 1
                End Select
            End If
            If TotalFriends = 0 Then
                Return Variables.R.Next(1, 6)
            End If
            NumberChoiced = Variables.R.Next(0, TotalFriends)
            If NumberChoiced < Rocks Then
                Return 1
            Else
                NumberChoiced = NumberChoiced - Rocks
            End If
            If NumberChoiced < Forests Then
                Return 2
            Else
                NumberChoiced = NumberChoiced - Forests
            End If
            If NumberChoiced < Meadows Then
                Return 3
            Else
                NumberChoiced = NumberChoiced - Meadows
            End If
            If NumberChoiced < Plains Then
                Return 4
            Else
                NumberChoiced = NumberChoiced - Plains
            End If
            Return 5
        End If
    End Function
End Class
