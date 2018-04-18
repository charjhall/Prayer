Public Class RequestInterface
    Dim sr As IO.StreamReader
    Public Function LoadRequests(clear As Boolean) As Boolean
        Try
            If My.Settings.FileSource.Equals("") Then
                Return False
            Else
                If My.Settings.FileSource.EndsWith("txt") Then
                    sr = IO.File.OpenText(My.Settings.FileSource)
                    Dim request As String = sr.ReadLine()
                    If clear Then
                        My.Settings.Requests.Clear()
                    End If
                    While request IsNot Nothing
                        My.Settings.Requests.Add(request)
                        request = sr.ReadLine
                    End While
                    sr.Dispose()
                    If My.Settings.Requests.Count > 0 Then
                        My.Settings.HasRequests = True
                    Else
                        My.Settings.HasRequests = False
                    End If
                    Return True
                    Else
                        Return False
                End If
            End If
        Catch ex As IO.FileNotFoundException
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub UpdateRequest(index As Integer, text As String)
        My.Settings.Requests.Item(index) = text
    End Sub

    Public Function GetRequestInfo(index As Integer) As ArrayList
        Return GetRequestInfo(My.Settings.Requests.Item(index))
    End Function
    Public Function GetRequestInfo(req As String) As ArrayList
        Dim NameAndText() As String = req.Split(":")
        Dim items As ArrayList = New ArrayList
        If NameAndText.Count = 2 Then
            items.Add(NameAndText(0).Trim)
            items.Add(NameAndText(1).Trim)
        ElseIf NameAndText.Count > 2 Then
            items.Add(NameAndText(0).Trim)
            Dim sb As Text.StringBuilder = New System.Text.StringBuilder
            For i As Integer = 1 To NameAndText.Count - 1
                sb.Append(NameAndText(i))
            Next
            items.Add(sb.ToString)
        Else
            items.Add("Prayer Request")
            items.Add(NameAndText(0).Trim)
        End If
        Return items
    End Function
    Public Sub AddRequest(request As String)
        My.Settings.Requests.Add(request)
        My.Settings.HasRequests = True
    End Sub
End Class
