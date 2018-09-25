Public Class Prayer
    Dim request As String
    Dim requestInfo As ArrayList
    Dim index As Integer
    Dim RI As RequestInterface = New RequestInterface
    Public Sub New(_index As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        index = _index
        requestInfo = RI.GetRequestInfo(index)
        PrayerRequestTitle.Text = requestInfo.Item(0)
        request = requestInfo.Item(1)
        prayer_request_label.Text = request
        UpdateRequestText.Text = requestInfo(0) & ": " & request
    End Sub
    Public Sub New(request As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        requestInfo = RI.GetRequestInfo(request)
        PrayerRequestTitle.Text = requestInfo.Item(0)
        request = requestInfo.Item(1)
        prayer_request_label.Text = request
        UpdateRequestText.Text = requestInfo.Item(0) & requestInfo.Item(1)
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles EditRequestButton.Click
        UpdateButton.Visible = True
        UpdateRequestText.Show()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        RI.UpdateRequest(index, UpdateRequestText.Text)
        Dim p As Prayer = New Prayer(index)
        p.Show()
        Me.Close()
    End Sub
End Class