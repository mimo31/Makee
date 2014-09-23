﻿Public Class Data
    Public Shared Sub SaveGame()

    End Sub

    Public Shared Sub LoadGame()

    End Sub

    Public Shared Sub GenChunk(x As Integer, y As Integer)

    End Sub

    Public Shared Sub SetValue(x As Integer, y As Integer, Value As Byte)

    End Sub

    Public Shared Function GetValue(x As Integer, y As Integer) As Byte

    End Function

    Public Shared Sub SetValueFor(x As Integer, y As Integer)
        Dim TotalFriends As Byte
        Dim Rocks As Byte
        Dim Forests As Byte
        Dim Meadows As Byte
        Dim Plains As Byte
        Dim Waters As Byte
        Dim NumberChoiced As Byte
        If Variables.R.Next(0, 100) = 0 Then
            SetValue(x, y, Variables.R.Next(1, 6))
        Else
            If GetValue(x - 1, y) > 0 Then
                TotalFriends = 1
                Select Case GetValue(x - 1, y)
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
            If GetValue(x - 1, y - 1) > 0 Then
                TotalFriends = TotalFriends + 1
                Select Case GetValue(x - 1, y - 1)
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
            If GetValue(x - 1, y + 1) > 0 Then
                TotalFriends = TotalFriends + 1
                Select Case GetValue(x - 1, y + 1)
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
            If GetValue(x, y - 1) > 0 Then
                TotalFriends = TotalFriends + 1
                Select Case GetValue(x, y - 1)
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
            If GetValue(x, y + 1) > 0 Then
                TotalFriends = TotalFriends + 1
                Select Case GetValue(x, y + 1)
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
            If GetValue(x + 1, y - 1) > 0 Then
                TotalFriends = TotalFriends + 1
                Select Case GetValue(x + 1, y - 1)
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
            If GetValue(x + 1, y + 1) > 0 Then
                TotalFriends = TotalFriends + 1
                Select Case GetValue(x + 1, y + 1)
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
            If GetValue(x + 1, y) > 0 Then
                TotalFriends = TotalFriends + 1
                Select Case GetValue(x + 1, y)
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
                SetValue(x, y, Variables.R.Next(1, 6))
            End If
            NumberChoiced = Variables.R.Next(0, TotalFriends)
            If NumberChoiced < Rocks Then
                SetValue(x, y, 1)
                Exit Sub
            Else
                NumberChoiced = NumberChoiced - Rocks
            End If
            If NumberChoiced < Forests Then
                SetValue(x, y, 2)
                Exit Sub
            Else
                NumberChoiced = NumberChoiced - Forests
            End If
            If NumberChoiced < Meadows Then
                SetValue(x, y, 3)
                Exit Sub
            Else
                NumberChoiced = NumberChoiced - Meadows
            End If
            If NumberChoiced < Plains Then
                SetValue(x, y, 4)
                Exit Sub
            Else
                NumberChoiced = NumberChoiced - Plains
            End If
            If NumberChoiced < Waters Then
                SetValue(x, y, 5)
                Exit Sub
            Else
                NumberChoiced = NumberChoiced - Waters
            End If
        End If
    End Sub
End Class