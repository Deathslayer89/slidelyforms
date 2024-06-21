Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class MainForm
    Private ReadOnly pingTimer As New Timer()
    Private ReadOnly httpClient As New HttpClient()

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enable the form to receive key events before the focused control does
        Me.KeyPreview = True

        ' Initialize and start the ping timer
        AddHandler pingTimer.Tick, AddressOf PingTimer_Tick
        pingTimer.Interval = 300000 ' 5 minutes in milliseconds
        pingTimer.Start()
    End Sub

    Private Async Sub PingTimer_Tick(sender As Object, e As EventArgs)
        Try
            Await PingBackend()
        Catch ex As Exception
            ' Handle any errors, e.g., log or display an error message
            Debug.WriteLine($"Error pinging backend: {ex.Message}")
        End Try
    End Sub

    Private Async Function PingBackend() As Task
        Dim pingUrl As String = "https://your-backend-url/api/ping" ' Replace with your actual ping endpoint
        Dim response As HttpResponseMessage = Await httpClient.GetAsync(pingUrl)

        If response.IsSuccessStatusCode Then
            Dim responseContent As String = Await response.Content.ReadAsStringAsync()
            Debug.WriteLine($"Ping successful at {DateTime.Now}: {responseContent}")
        Else
            Debug.WriteLine($"Ping failed with status code: {response.StatusCode}")
        End If
    End Function

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.ShowDialog()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createSubmissionForm As New CreateSubmissionForm()
        createSubmissionForm.ShowDialog()
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
        End If
    End Sub
End Class
