Public Class Form1
    Dim request As String
    Dim nextValidTime As DateTime
    Dim sr As IO.StreamReader
    Dim _requests As ArrayList = New ArrayList()
    Dim debugdest As String
    Dim HasSourceFile As Boolean
    Dim saved As Boolean
    Dim cmsg As CustomMsgBox = New CustomMsgBox()
    Public Property Requests As ArrayList
        Get
            Return _requests
        End Get
        Set(value As ArrayList)
            _requests = value
        End Set
    End Property
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PushNextTime(2.0)
        Randomize()
        IndexNum.Text = My.Settings.RequestsIndex
        IntervalNum.Text = My.Settings.Interval
        LoadRequests()
        Timer1.Enabled = True
        NextRequestLabel.Text = Requests.Item(My.Settings.RequestsIndex)
    End Sub

    Public Sub PushNextTime(increment As Double)
        nextValidTime = DateTime.Now
        nextValidTime = nextValidTime.AddMinutes(increment)
    End Sub

    Private Sub SetNextTime()
        nextValidTime = nextValidTime.AddMinutes(My.Settings.Interval)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DateTime.Now.ToString.Equals(nextValidTime.ToString) Then
            request = _requests(My.Settings.RequestsIndex)
            While request.Equals("")
                My.Settings.RequestsIndex += 1
                request = _requests(My.Settings.RequestsIndex)
            End While
            Dim f2 As Prayer = New Prayer(My.Settings.RequestsIndex, request)
            SetNextTime()
            My.Settings.RequestsIndex += 1
            NextRequestLabel.Text = Requests.Item(My.Settings.RequestsIndex)
            IndexNum.Text = My.Settings.RequestsIndex
            f2.Show()
            'SaveSourceAndIndex(infosource)
        End If
        UpdateIndexAndNR()
    End Sub

    Public Sub LoadRequests()

        sr = IO.File.OpenText(My.Settings.FileSource)
        Dim request As String = sr.ReadLine()
        While request IsNot Nothing
            _requests.Add(request)
            request = sr.ReadLine
        End While
        sr.Dispose()
    End Sub

    Private Sub SetIntervalButton_Click_1(sender As Object, e As EventArgs) Handles SetIntervalButton.Click
        If My.Settings.FileSource.Equals("") Then
            cmsg.ShowBox("Please select a source file first.")
        Else
            My.Settings.Interval = CType(IntervalTextBox.Text, Integer)
            'RequestsIndex = CType(IndexTextBox.Text, Integer)
            Timer1.Interval = My.Settings.Interval
            PushNextTime(1.0)
            IntervalNum.Text = My.Settings.Interval
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SetSourceFile.Click
        cmsg.ShowBox("Select a file with requests in the format of Name/Organization: prayer request. This will allow for the optimal functioning of the program, but is not requirement. The program will treat each seperate line as a new request, but the program only treats the line as a new line if you press enter at the end of the line.")
        Dim result As DialogResult = OpenFileDialogRequests.ShowDialog()
        Dim filename As String
        If result = DialogResult.OK Then
            filename = OpenFileDialogRequests.FileName
            My.Settings.FileSource = filename
        End If
    End Sub
    Public Sub UpdateRequests()
        System.IO.File.WriteAllText(My.Settings.FileSource, "")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(My.Settings.FileSource, True)

        For index As Integer = 0 To Requests.Count - 1
            If index = Requests.Count - 1 Then
                file.Write(Requests(index))
            Else
                file.WriteLine(Requests(index))
            End If
        Next
        file.Close()
    End Sub


    Private Sub DebugButton_Click(sender As Object, e As EventArgs) Handles DebugButton.Click
        cmsg.ShowBox(My.Settings.FileSource)
        cmsg.ShowBox(My.Settings.Interval)
    End Sub

    Private Sub ExampleButton_Click(sender As Object, e As EventArgs) Handles ExampleButton.Click
        ExReqTitle.Show()
        YColonRequest.Show()
        YColonLabel.Show()
        NColonLabel.Show()
        NColonText.Show()
        YColonButton.Show()
        NColonButton.Show()
    End Sub

    Private Sub ViewPopupButton_Click(sender As Object, e As EventArgs) Handles YColonButton.Click
        Dim p As Prayer = New Prayer(2000, YColonRequest.Text)
        p.Show()
    End Sub

    Private Sub NColonButton_Click(sender As Object, e As EventArgs) Handles NColonButton.Click
        Dim p As Prayer = New Prayer(2000, NColonText.Text)
        p.Show()
    End Sub

    Private Sub ChangeIndexButton_Click(sender As Object, e As EventArgs) Handles ChangeIndexButton.Click
        Try
            My.Settings.RequestsIndex = CType(IndexTextBox.Text, Integer)
            IndexNum.Text = My.Settings.RequestsIndex
            PushNextTime(1.0)
        Catch ex As InvalidCastException
            cmsg.ShowBox("Please put a number in the index box.")
        End Try
    End Sub

    Private Sub FileSourceLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FileSourceLinkLabel.LinkClicked
        Try
            Process.Start(My.Settings.FileSource)
        Catch ex As Exception
            cmsg.ShowBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        NewRequestRichTextBox.Show()
        SubmitRequestButton.Show()
    End Sub

    Private Sub SubmitRequestButton_Click(sender As Object, e As EventArgs) Handles SubmitRequestButton.Click
        Dim dr As DialogResult = cmsg.ShowBox(NewRequestRichTextBox.Text & vbCrLf & "This is your request. Do you wish to submit it?")
        If dr.Equals(DialogResult.OK) Then
            Requests.Add(NewRequestRichTextBox.Text)
            UpdateRequests()
            NewRequestRichTextBox.Text = ""
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Closed
        UpdateRequests()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        request = _requests(My.Settings.RequestsIndex)
        While request.Equals("")
            My.Settings.RequestsIndex += 1
            request = _requests(My.Settings.RequestsIndex)
        End While
        Dim f2 As Prayer = New Prayer(My.Settings.RequestsIndex, request)
        SetNextTime()
        My.Settings.RequestsIndex += 1
        UpdateIndexAndNR()
        f2.Show()
    End Sub
    Private Sub UpdateIndexAndNR()
        IndexNum.Text = My.Settings.RequestsIndex
        NextRequestLabel.Text = Requests.Item(My.Settings.RequestsIndex)
    End Sub
End Class
