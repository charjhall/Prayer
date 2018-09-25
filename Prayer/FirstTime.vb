Public Class Welcome
    Dim RFI As RequestInterface = New RequestInterface
    Dim cmsg As CustomMsgBox = New CustomMsgBox(True)
    Private Sub SetSourceFile_Click(sender As Object, e As EventArgs) Handles AddRequestButton.Click
        Dim addreqform As AddRequest = New AddRequest
        addreqform.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UploadFileButton.Click
        Dim result As DialogResult = cmsg.ShowBox("Select a file with requests in the format of Name/Organization: prayer request. This will allow for the optimal functioning of the program, but is not requirement. The program will treat each seperate line as a new request, but the program only treats the line as a new line if you press enter at the end of the line.")
        If result = DialogResult.OK Then
            result = OpenFileDialogRequests.ShowDialog()
            Dim filename As String
            If result = DialogResult.OK Then
                filename = OpenFileDialogRequests.FileName
                My.Settings.FileSource = filename
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If
        If Not RFI.LoadRequests(False) Then
            MsgBox("Please upload a .txt file")
        Else
            MsgBox("Requests Loaded")
        End If
        If My.Settings.HasRequests Then
            Dim f1 As Form1 = New Form1()
            f1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim ER As ExampleRequest = New ExampleRequest
        ER.Show()
    End Sub
End Class