Imports System.Drawing.Font
Public Class Variables
    Public Shared StartScreen As Boolean = True
    Public Shared PlayStarting As Boolean
    Public Shared GettingWorldName As Boolean
    Public Shared InHome As Boolean
    Public Shared InMine As Boolean
    Public Shared GameSlotSelected As Integer
    Public Shared Paused As Boolean
    Public Shared InMake As Boolean
    Public Shared InGoingOut As Boolean
    Public Shared InWarehouse As Boolean
    Public Shared InMachines As Boolean
    Public Shared Achievements As Boolean
    Public Shared ChunksDirectory() As String
    Public Shared ChunksValues(,,) As UShort
    Public Shared R As New Random
End Class
