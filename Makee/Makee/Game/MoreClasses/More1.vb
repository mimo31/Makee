Public Class More1
    Public Shared SenderXPos As Integer
    Public Shared SenderYPos As Integer

    Public Shared Sub Load(SenderX As Integer, SenderY As Integer)
        SenderXPos = SenderX
        SenderYPos = SenderY
        Variables.MoreClass = 1
        Form1.MinimumSize = New Size(400, 400)
        Form1.Refresh()
    End Sub

    Public Shared Sub Paint(e As PaintEventArgs)
        Functions.DrawMoreClassBasics(e, "Rock", False, SenderXPos, SenderYPos, False)
    End Sub

    Public Shared Sub Click(e As MouseEventArgs)
        If Functions.ButtonPressed(e.X, e.Y, 5, 5, 100, 40) = True Then
            Variables.MoreClass = 0
            InGoingOut.Load()
            Form1.Refresh()
        ElseIf Functions.ButtonPressed(e.X, e.Y, Form1.ClientSize.Width - 60, 0, 60, 60) Then
            Variables.Paused = True
            Form1.Refresh()
        End If
    End Sub
End Class
