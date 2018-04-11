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
            ShowNext()
        End If
    End Sub
    Private Sub ShowNext()
        If My.Settings.RequestsIndex > Requests.Count Then
            My.Settings.RequestsIndex = 0
        End If
        request = _requests(My.Settings.RequestsIndex)
        While request.Equals("")
            My.Settings.RequestsIndex += 1
            request = _requests(My.Settings.RequestsIndex)
        End While
        My.Settings.RequestsIndex += 1
        Try
            IndexNum.Text = My.Settings.RequestsIndex
            UpdateIndexAndNR()
        Catch ex As ArgumentOutOfRangeException
            My.Settings.RequestsIndex = 0
            UpdateIndexAndNR()
        End Try
        Dim f2 As Prayer = New Prayer(My.Settings.RequestsIndex, request)
        SetNextTime()
        f2.Show()
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
        Dim result As DialogResult = cmsg.ShowBox("Select a file with requests in the format of Name/Organization: prayer request. This will allow for the optimal functioning of the program, but is not requirement. The program will treat each seperate line as a new request, but the program only treats the line as a new line if you press enter at the end of the line.")
        If result = DialogResult.OK Then
            result = OpenFileDialogRequests.ShowDialog()
            Dim filename As String
            If result = DialogResult.OK Then
                filename = OpenFileDialogRequests.FileName
                My.Settings.FileSource = filename
            End If
        End If
    End Sub
    Public Sub UpdateRequests()
        System.IO.File.WriteAllText(My.Settings.FileSource, "")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(My.Settings.FileSource, True, New System.Text.UTF8Encoding)
        For index As Integer = 0 To Requests.Count - 1
            If index = Requests.Count - 1 Then
                file.Write(Requests(index))
            Else
                file.WriteLine(Requests(index))
            End If
        Next
        file.Close()
    End Sub


    Private Sub DebugButton_Click(sender As Object, e As EventArgs)
        cmsg.ShowBox(My.Settings.FileSource)
        cmsg.ShowBox(My.Settings.Interval)
    End Sub

    Private Sub ExampleButton_Click(sender As Object, e As EventArgs) Handles ExampleButton.Click
        Dim exreq As ExampleRequest = New ExampleRequest
        exreq.Show()
    End Sub


    Private Sub ChangeIndexButton_Click(sender As Object, e As EventArgs) Handles ChangeIndexButton.Click
        Try
            My.Settings.RequestsIndex = CType(IndexTextBox.Text, Integer)
            IndexNum.Text = My.Settings.RequestsIndex
            PushNextTime(1.0)
        Catch ex As InvalidCastException
            cmsg.ShowBox("Please put a number in the index box.")
        Catch ex As ArgumentOutOfRangeException
            My.Settings.RequestsIndex = 0
            IndexNum.Text = My.Settings.RequestsIndex
        End Try
    End Sub

    Private Sub FileSourceLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Try
            Process.Start(My.Settings.FileSource)
        Catch ex As Exception
            cmsg.ShowBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addreq As AddRequest = New AddRequest
        addreq.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Closed
        UpdateRequests()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShowNext()
    End Sub
    Private Sub UpdateIndexAndNR()
        IndexNum.Text = My.Settings.RequestsIndex
    End Sub
End Class
