Public Class CustomMsgBox
    Shared newmsgbox As CustomMsgBox

    Public Function ShowBox(textmessage As String) As DialogResult
        newmsgbox = New CustomMsgBox()
        newmsgbox.lblmessage.Text = textmessage
        Return newmsgbox.ShowDialog()
    End Function

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class