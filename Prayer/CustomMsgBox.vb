Public Class CustomMsgBox
    Shared newmsgbox As CustomMsgBox
    Dim ShowCancel As Boolean
    Public Sub New(_ShowCancel As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ShowCancel = _ShowCancel
        btncancel.Visible = ShowCancel
    End Sub

    Public Function ShowBox(textmessage As String) As DialogResult
        newmsgbox = New CustomMsgBox(ShowCancel)
        newmsgbox.lblmessage.Text = textmessage
        Return newmsgbox.ShowDialog()
    End Function

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class