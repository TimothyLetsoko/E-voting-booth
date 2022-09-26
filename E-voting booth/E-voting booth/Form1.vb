Public Class Form1
    Dim anc As Integer = 0
    Dim da As Integer = 0
    Dim eff As Integer = 0
    Dim errors As Integer = 0
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        lblanswer.Text = "ANC had " & anc & " Votes, DA had " & da & " Votes, EFF had " & eff & " Votes, and there were " & errors & " Error votes"
    End Sub

    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click
        Dim choice As String = txtparty.Text

        If choice = "ANC" Then
            anc += 1
        ElseIf choice = "DA" Then
            da += 1
        ElseIf choice = "EFF" Then
            eff += 1
        Else
            errors += 1
        End If
    End Sub
End Class
