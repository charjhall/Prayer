Public Class Prayer
    Dim request As String
    Dim index As Integer
    Dim cmsg As CustomMsgBox = New CustomMsgBox
    Public Sub New(_index As Integer, _request As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim NameAndText() As String = _request.Split(":")
        If NameAndText.Count > 1 Then
            PrayerRequestTitle.Text = NameAndText(0).Trim
            prayer_request_label.Text = NameAndText(1).Trim
        Else
            prayer_request_label.Text = NameAndText(0).Trim
        End If
        request = _request
        index = _index
        UpdateRequestText.Text = request
        'Dim di As Runtime.InteropServices.DllImportAttribute = New Runtime.InteropServices.DllImportAttribute("WinWordControl.dll")
        'di.
    End Sub

    Private Sub ChangeIntervalButton_Click(sender As Object, e As EventArgs)
        Dim newparent As Form1 = New Form1()
        newparent.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles EditRequestButton.Click
        UpdateButton.Visible = True
        UpdateRequestText.Show()
        'Process.Start(My.Resources.source)
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            Form1.Requests.Item(index) = UpdateRequestText.Text
            Dim p As Prayer = New Prayer(index, UpdateRequestText.Text)
            p.Show()
            Me.Close()
        Catch ex As Exception
            cmsg.ShowBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim sb As Text.StringBuilder = New System.Text.StringBuilder
        For Each r As String In Form1.Requests
            sb.Append(r & vbCrLf)
        Next
        cmsg.ShowBox(sb.ToString)
    End Sub


End Class