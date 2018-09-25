Public Class Settings
    Dim nextValidTime As DateTime
    Dim cmsg As CustomMsgBox = New CustomMsgBox(True)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PushNextTime(2.0)
        IndexTextBox.Text = My.Settings.RequestsIndex + 1
        IntervalTextBox.Text = My.Settings.Interval
    End Sub
    Private Sub IndexTextBox_Lost_Focus(sender As Object, e As EventArgs) Handles IndexTextBox.LostFocus
        setIndex(CType(IndexTextBox.Text, Integer))
    End Sub

    Private Sub UpdateIndex()
        My.Settings.RequestsIndex = My.Settings.RequestsIndex Mod My.Settings.Requests.Count
        IndexTextBox.Text = My.Settings.RequestsIndex + 1
    End Sub

    Public Sub PushNextTime(increment As Double)
        nextValidTime = DateTime.Now
        nextValidTime = nextValidTime.AddMinutes(increment)
    End Sub

    Private Sub IntervalTextBox_Lost_Focus(sender As Object, e As EventArgs) Handles IntervalTextBox.LostFocus
        setInterval(CType(IntervalTextBox.Text, Integer))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim AR As AllRequests = New AllRequests
        AR.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        setInterval(CType(IntervalTextBox.Text, Integer))
        setIndex(CType(IndexTextBox.Text, Integer))
        Dim f1 As Form1 = New Form1
        f1.Show()
        Me.Close()
    End Sub

    Private Function setInterval(interval As Integer) As Boolean
        Try
            My.Settings.Interval = interval
            PushNextTime(1.0)
        Catch ex As ArgumentNullException
            cmsg.ShowBox(ex.Message)
        Catch ex As FormatException
            cmsg.ShowBox("Please enter a number.")
        Catch ex As OverflowException
            cmsg.ShowBox("Please enter a reasonable number")
        End Try
    End Function
    Private Function setIndex(newIndex As Integer) As Boolean
        Try
            newIndex = newIndex Mod (My.Settings.Requests.Count)
            My.Settings.RequestsIndex = newIndex
            UpdateIndex()
            Return True
        Catch ex As OverflowException
            MsgBox("Please put a reasonably sized number in the box.")
        Catch ex As InvalidCastException
            cmsg.ShowBox("Please put a number in the index box.")
        Catch ex As ArgumentOutOfRangeException
            My.Settings.RequestsIndex = 0
            IndexTextBox.Text = My.Settings.RequestsIndex + 1
        End Try
        Return False
    End Function
End Class