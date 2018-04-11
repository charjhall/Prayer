Public Class AddRequest
    Dim cmsg As CustomMsgBox = New CustomMsgBox
    Private Sub SubmitRequestButton_Click(sender As Object, e As EventArgs) Handles SubmitRequestButton.Click
        Dim dr As DialogResult = cmsg.ShowBox(NewRequestRichTextBox.Text & vbCrLf & "This is your request. Do you wish to submit it?")
        If dr.Equals(DialogResult.OK) Then
            Form1.Requests.Add(NewRequestRichTextBox.Text)
            Form1.UpdateRequests()
            NewRequestRichTextBox.Text = ""
        End If
    End Sub
End Class