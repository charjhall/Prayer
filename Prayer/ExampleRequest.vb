Public Class ExampleRequest
    Private Sub YColonButton_Click(sender As Object, e As EventArgs) Handles YColonButton.Click
        Dim p As Prayer = New Prayer(2000, YColonRequest.Text)
        p.Show()
    End Sub

    Private Sub NColonButton_Click(sender As Object, e As EventArgs) Handles NColonButton.Click
        Dim p As Prayer = New Prayer(2000, NColonText.Text)
        p.Show()
    End Sub
End Class