Public Class AllRequests
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim requeststext As String = ""
        For Each rq As String In My.Settings.Requests
            requeststext += rq & vbCrLf
        Next
        RequestTextBox.Text = requeststext
    End Sub
End Class