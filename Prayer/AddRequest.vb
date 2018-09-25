Public Class AddRequest
    Dim cmsg As CustomMsgBox = New CustomMsgBox(True)
    Dim RI As RequestInterface = New RequestInterface
    Private Sub SubmitRequestButton_Click(sender As Object, e As EventArgs) Handles SubmitRequestButton.Click
        If NewRequestRichTextBox.Text.Trim.Equals("") = False Then
            Dim dr As DialogResult = cmsg.ShowBox(NewRequestRichTextBox.Text & vbCrLf & "This is your request. Do you wish to submit it?")
            If dr.Equals(DialogResult.OK) Then
                RI.AddRequest(NewRequestRichTextBox.Text.Trim)
            End If
            If My.Settings.HasRequests Then
                Me.Close()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim exformat As ExampleRequest = New ExampleRequest()
        exformat.Show()
    End Sub

    Private Sub AddRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        Dim f1 As Form1 = New Form1
        f1.Show()

    End Sub
End Class