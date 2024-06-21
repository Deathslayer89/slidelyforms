Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatchStartTime As DateTime
    Private elapsedBeforeStop As TimeSpan = TimeSpan.Zero

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            stopwatchRunning = False
            elapsedBeforeStop += DateTime.Now - stopwatchStartTime
            btnToggleStopwatch.Text = "START STOPWATCH"
            Timer1.Stop()
        Else
            stopwatchRunning = True
            stopwatchStartTime = DateTime.Now
            btnToggleStopwatch.Text = "STOP STOPWATCH"
            Timer1.Start()
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If stopwatchRunning Then
            elapsedBeforeStop += DateTime.Now - stopwatchStartTime
            stopwatchRunning = False
            Timer1.Stop()
            btnToggleStopwatch.Text = "START STOPWATCH"
        End If

        Dim submission = New With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhoneNum.Text,
            .github_link = txtGithubLink.Text,
            .stopwatch_time = lblStopwatch.Text
        }

        Dim json = JsonConvert.SerializeObject(submission)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Try
            Using client As New HttpClient()
                Dim response = Await client.PostAsync("https://slidely-backend.onrender.com/api/submit", content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission Successful!")
                    Me.Close() ' Close the form after a successful submission
                Else
                    MessageBox.Show($"Submission Failed! Status Code: {response.StatusCode}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Submission Failed! Error: {ex.Message}")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If stopwatchRunning Then
            Dim elapsed = DateTime.Now - stopwatchStartTime + elapsedBeforeStop
            lblStopwatch.Text = elapsed.ToString("hh\:mm\:ss")
        End If
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
End Class
