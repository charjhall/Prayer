Public Class Form1
    Dim request As String
    Dim nextValidTime As DateTime
    Dim sr As IO.StreamReader
    Dim debugdest As String
    Dim HasSourceFile As Boolean
    Dim saved As Boolean
    Dim cmsg As CustomMsgBox = New CustomMsgBox(True)
    Dim RFI As RequestInterface = New RequestInterface

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PushNextTime(2.0)
        Randomize()
        IndexNum.Text = My.Settings.RequestsIndex + 1
        IntervalNum.Text = My.Settings.Interval
        'My.Settings.FileSource = ""
        'SetSourceFile.Visible = 'True 'My.Settings.FileSource.Equals("")
        'If RFI.LoadRequests() Then
        'Else
        'My.Settings.Requests.Clear()
        My.Settings.HasRequests = My.Settings.Requests.Count > 0
    End Sub
    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.HasRequests Then
        Else
            Dim firsttime As FirstTime = New FirstTime
            firsttime.Show()
            My.Settings.RequestsIndex = 0
            Me.Close()
        End If
    End Sub
    Public Sub PushNextTime(increment As Double)
        nextValidTime = DateTime.Now
        nextValidTime = nextValidTime.AddMinutes(increment)
        NextTimeLabel.Text = nextValidTime.ToLongTimeString
    End Sub

    Private Sub SetNextTime()
        nextValidTime = nextValidTime.AddMinutes(My.Settings.Interval)
        NextTimeLabel.Text = nextValidTime.ToLongTimeString
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DateTime.Now.ToString.Equals(nextValidTime.ToString) Then
            ShowNext()
        End If
    End Sub
    Private Sub ShowNext()
        If My.Settings.RequestsIndex > (My.Settings.Requests.Count - 1) Then
            My.Settings.RequestsIndex = 0
            UpdateIndex()
        End If
        'MsgBox(My.Settings.RequestsIndex)
        request = My.Settings.Requests.Item(My.Settings.RequestsIndex)
        While request.Equals("")
            My.Settings.RequestsIndex += 1
            request = My.Settings.Requests(My.Settings.RequestsIndex)
        End While
        Dim f2 As Prayer = New Prayer(My.Settings.RequestsIndex)
        My.Settings.RequestsIndex += 1
        Try
            UpdateIndex()
        Catch ex As ArgumentOutOfRangeException
            My.Settings.RequestsIndex = 0
            UpdateIndex()
            SetNextTime()
        End Try
        SetNextTime()
        f2.Show()
    End Sub

    Private Sub SetIntervalButton_Click_1(sender As Object, e As EventArgs) Handles SetIntervalButton.Click
        If My.Settings.FileSource.Equals("") Then
            cmsg.ShowBox("Please select a source file first.")
        Else
            My.Settings.Interval = CType(IntervalTextBox.Text, Integer)
            Timer1.Interval = My.Settings.Interval
            PushNextTime(1.0)
            IntervalNum.Text = My.Settings.Interval
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SetSourceFile.Click

        Dim result As DialogResult = cmsg.ShowBox("Click ok to have this file replace your current set of requests, cancel to add the requests in the file to the already existing requests.")
        Dim clear As Boolean
        If result.Equals(DialogResult.OK) Then
            clear = True
        End If
        result = cmsg.ShowBox("Select a file with requests in the format of Name/Organization: prayer request. This will allow for the optimal functioning of the program, but is not requirement. The program will treat each seperate line as a new request, but the program only treats the line as a new line if you press enter at the end of the line.")
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
        If Not RFI.LoadRequests(clear) Then
            MsgBox("Please upload a .txt file")
        Else
            MsgBox("Requests Loaded")
        End If
        Dim formone As Form1 = New Form1
        formone.Show()
        Me.Close()
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
            Dim newIndex As Integer = CType(IndexTextBox.Text, Integer) - 1
            newIndex = newIndex Mod (My.Settings.Requests.Count)
            My.Settings.RequestsIndex = newIndex
            UpdateIndex()
            PushNextTime(1.0)
            IndexTextBox.Text = ""
        Catch ex As OverflowException
            MsgBox("Please put a reasonably sized number in the box.")
        Catch ex As InvalidCastException
            cmsg.ShowBox("Please put a number in the index box.")
        Catch ex As ArgumentOutOfRangeException
            My.Settings.RequestsIndex = 0
            IndexNum.Text = My.Settings.RequestsIndex + 1
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
        'UpdateRequests()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim col As Collections.Specialized.StringCollection = My.Settings.Requests
        ShowNext()
    End Sub
    Private Sub UpdateIndex()
        My.Settings.RequestsIndex = My.Settings.RequestsIndex Mod My.Settings.Requests.Count
        IndexNum.Text = My.Settings.RequestsIndex + 1
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        cmsg.ShowBox("This is the line in the Prayer Requests text file you submitted.")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        cmsg.ShowBox("This is the time interval in minutes that requests appear on screen.")

    End Sub

    Private Sub FirstTimeButton_Click(sender As Object, e As EventArgs)
        Dim FirstTime As FirstTime = New FirstTime()
        FirstTime.Show()
        Me.Close()
    End Sub
End Class
