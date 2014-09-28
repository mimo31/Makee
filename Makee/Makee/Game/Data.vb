Public Class Data
    Public Shared Sub GenChunk(x As Integer, y As Integer)
        ReDim Preserve Variables.ChunksDirectory(Variables.ChunksDirectory.Length)
        ReDim Preserve Variables.ChunksValues(Variables.ChunksDirectory.Length - 1, 63, 63)
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
                    Chunk(Counter2, 1) = Variables.ChunksValues(Counter, Counter2 - 1, 0)
                    Counter2 = Counter2 + 1
                Loop
            End If
            If Variables.ChunksDirectory(Counter) = x - 1 & "," & y Then
                FriendsChunksDetected(1) = True
                Counter2 = 1
                Do While Counter2 < 65
                    Chunk(1, Counter) = Variables.ChunksValues(Counter, Counter2 - 1, 0)
                    Counter2 = Counter2 + 1
                Loop
            End If
            If Variables.ChunksDirectory(Counter) = x & "," & y + 1 Then
                FriendsChunksDetected(2) = True
                Counter2 = 1
                Do While Counter2 < 65
                    Chunk(Counter2, 65) = Variables.ChunksValues(Counter, Counter2 - 1, 0)
                    Counter2 = Counter2 + 1
                Loop
            End If
            If Variables.ChunksDirectory(Counter) = x + 1 & "," & y Then
                FriendsChunksDetected(3) = True
                Counter2 = 1
                Do While Counter2 < 65
                    Chunk(65, Counter) = Variables.ChunksValues(Counter, Counter2 - 1, 0)
                    Counter2 = Counter2 + 1
                Loop
            End If
            If Variables.ChunksDirectory(Counter) = x + 1 & "," & y - 1 Then
                FriendsChunksDetected(4) = True
                Chunk(65, 0) = Variables.ChunksValues(Counter, Counter2 - 1, 0)
            End If
            If Variables.ChunksDirectory(Counter) = x - 1 & "," & y + 1 Then
                FriendsChunksDetected(5) = True
                Chunk(0, 65) = Variables.ChunksValues(Counter, Counter2 - 1, 0)
            End If
            If Variables.ChunksDirectory(Counter) = x - 1 & "," & y - 1 Then
                FriendsChunksDetected(6) = True
                Chunk(0, 0) = Variables.ChunksValues(Counter, Counter2 - 1, 0)
            End If
            If Variables.ChunksDirectory(Counter) = x + 1 & "," & y + 1 Then
                FriendsChunksDetected(7) = True
                Chunk(65, 65) = Variables.ChunksValues(Counter, Counter2 - 1, 0)
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
    End Sub

    Public Shared Sub ChunkInRAM()

    End Sub

    Public Shared Sub GenPoint(x As Byte, y As Byte, Chunk As Integer)

    End Sub

    Public Shared Sub SetValue(x As Integer, y As Integer, Value As UShort)

    End Sub

    Public Shared Function GetValue(x As Integer, y As Integer) As UShort
        Dim Counter As Integer
        Dim Counter2 As Byte
        Dim ChunkValueSearching As String
        If x > -1 And y > -1 Then
            ChunkValueSearching = Math.Floor(x / 64) & "," & Math.Floor(y / 64)
        ElseIf x > -1 Then
            ChunkValueSearching = Math.Floor(x / 64) & "," & Math.Floor((y - 1) / 64) - 1
        ElseIf y > -1 Then
            ChunkValueSearching = Math.Floor((x - 1) / 64) - 1 & "," & Math.Floor(y / 64)
        Else
            ChunkValueSearching = Math.Floor((x - 1) / 64) - 1 & "," & Math.Floor((y - 1) / 64) - 1
        End If
        Dim XInChunk As Byte
        If x > -1 Then
            XInChunk = x Mod 64
        Else
            XInChunk = 64 + (x Mod 64)
        End If
        Dim YInChunk As Byte
        If y > -1 Then
            YInChunk = y Mod 64
        Else
            YInChunk = 64 + (y Mod 64)
        End If

        Do While Counter < Variables.ChunksDirectory.Length
            If Variables.ChunksDirectory(Counter) = ChunkValueSearching Then
                Return Variables.ChunksValues(Counter, x, y)
            End If
            Counter = Counter + 1
        Loop
        Counter = 0

        If My.Computer.FileSystem.FileExists("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & ChunkValueSearching & ".chunk") = True Then
            Dim ReadedChunk As Byte() = My.Computer.FileSystem.ReadAllBytes("C:\Makee\SavedGames\Game" & Variables.GameSlotSelected & "\Map\Chunks\" & ChunkValueSearching & ".chunk")
            ReDim Preserve Variables.ChunksDirectory(Variables.ChunksDirectory.Length)
            ReDim Preserve Variables.ChunksValues(Variables.ChunksDirectory.Length - 1, 63, 63)
            Variables.ChunksDirectory(Variables.ChunksDirectory.Length - 1) = ChunkValueSearching
            Do While Counter < 64
                Do While Counter2 < 64
                    Variables.ChunksValues(Variables.ChunksDirectory.Length - 1, Counter2, Counter) = ReadedChunk(0) * 256 + ReadedChunk(1)
                    Counter2 = Counter2 + 1
                Loop
                Counter2 = 0
                Counter = Counter + 1
            Loop
            Counter = 0
            Counter2 = 0
            Return Variables.ChunksValues(Variables.ChunksDirectory.Length - 1, XInChunk, YInChunk)
        End If

        If x > -1 And y > -1 Then
            GenChunk(Math.Floor(x / 64), Math.Floor(y / 64))
        ElseIf x > -1 Then
            GenChunk(Math.Floor(x / 64), Math.Floor((y - 1) / 64) - 1)
        ElseIf y > -1 Then
            GenChunk(Math.Floor((x - 1) / 64) - 1, Math.Floor(y / 64))
        Else
            GenChunk(Math.Floor((x - 1) / 64) - 1, Math.Floor((y - 1) / 64) - 1)
        End If
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
