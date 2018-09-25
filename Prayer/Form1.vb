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
        My.Settings.HasRequests = My.Settings.Requests.Count > 0
        Timer1.Interval = My.Settings.Interval
    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.HasRequests Then
        Else
            Dim firsttime As Welcome = New Welcome
            firsttime.Show()
            My.Settings.RequestsIndex = 0
            Me.Close()
        End If
    End Sub
    Private Sub Form1_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        My.Settings.Save()
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



    Private Sub Button1_Click(sender As Object, e As EventArgs)

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

    Private Sub ExampleButton_Click(sender As Object, e As EventArgs)
        Dim exreq As ExampleRequest = New ExampleRequest
        exreq.Show()
    End Sub

    Private Sub FileSourceLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Try
            Process.Start(My.Settings.FileSource)
        Catch ex As Exception
            cmsg.ShowBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Dim addreq As AddRequest = New AddRequest
        addreq.Show()
        Me.Close()
    End Sub

    Dim col As Collections.Specialized.StringCollection
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        col = My.Settings.Requests
        ShowNext()
    End Sub
    Private Sub UpdateIndex()
        My.Settings.RequestsIndex = My.Settings.RequestsIndex Mod My.Settings.Requests.Count
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs)
        cmsg.ShowBox("This is the line in the Prayer Requests text file you submitted.")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        cmsg.ShowBox("This is the time interval in minutes that requests appear on screen.")
    End Sub

    Private Sub FirstTimeButton_Click(sender As Object, e As EventArgs)
        Dim FirstTime As Welcome = New Welcome()
        FirstTime.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        PushNextTime(1.0)
    End Sub


    Private Sub TimerEnabledButton_Click(sender As Object, e As EventArgs)
        If Timer1.Enabled Then
            Timer1.Enabled = False
            TimerEnabledButton.Text = "Resume"
            NextTimeLabel.Text = "Paused"
        Else
            Timer1.Enabled = True
            TimerEnabledButton.Text = "Pause"
            NextTimeLabel.Text = nextValidTime.ToLongTimeString
            PushNextTime(1.0)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim AR As AllRequests = New AllRequests
        AR.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        My.Settings.TestColor = Color.FromArgb(43, 65, 98)
    End Sub
End Class
