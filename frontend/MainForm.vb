Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class MainForm
    Private ReadOnly pingTimer As New Timer()
    Private ReadOnly httpClient As New HttpClient()

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enable the form to receive key events before the focused control does
        Me.KeyPreview = True

    End Sub




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
