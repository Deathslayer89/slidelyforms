Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Diagnostics

Public Class ViewSubmissionsForm
    ' Define class variables
    Private currentIndex As Integer = 0
    Private submissions As New List(Of JObject)
    Private totalSubmissions As Integer = 0
    Private editingEmail As String = String.Empty

    ' Form load event handler
    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure the form receives key events first
        Me.KeyPreview = True
        Try
            Await LoadSubmissions(currentIndex)
            DisplaySubmission()
            ' Set focus to the form after loading data
            SetFormFocus()
        Catch ex As Exception
            MessageBox.Show($"Error loading submissions: {ex.Message}")
        End Try
    End Sub

    ' Method to set focus to the form and ensure it can receive keyboard events
    Private Sub SetFormFocus()
        Me.Focus()
        Me.Select()
        Me.ActiveControl = Nothing
    End Sub

    ' Handle keyboard shortcuts
    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.P
                    If btnPrevious.Enabled AndAlso btnPrevious.Visible Then
                        btnPrevious.PerformClick()
                    End If
                Case Keys.N
                    If btnNext.Enabled AndAlso btnNext.Visible Then
                        btnNext.PerformClick()
                    End If
                Case Keys.D
                    If btnDelete.Enabled AndAlso btnDelete.Visible Then
                        btnDelete.PerformClick()
                    End If
                Case Keys.E
                    If btnEdit.Enabled AndAlso btnEdit.Visible Then
                        btnEdit.PerformClick()
                    End If
                Case Keys.S
                    If btnSave.Enabled AndAlso btnSave.Visible Then
                        btnSave.PerformClick()
                    End If
                Case Keys.F
                    If btnSearch.Enabled AndAlso btnSearch.Visible Then
                        btnSearch.PerformClick()
                    End If
            End Select
        End If
    End Sub

    ' Load submission from server asynchronously
    Private Async Function LoadSubmissions(index As Integer) As Task(Of Boolean)
        Using client As New HttpClient()
            Try
                Debug.WriteLine($"Fetching submission at index {index}...")
                Dim response = Await client.GetStringAsync($"https://slidely-backend.onrender.com/api/read?index={index}")
                Debug.WriteLine($"Response from server: {response}")

                Dim parsedResponse = JToken.Parse(response)
                Debug.WriteLine($"Parsed response: {parsedResponse.ToString()}")

                If TypeOf parsedResponse Is JObject Then
                    ' Check if the current submission already exists in the list
                    If index < submissions.Count Then
                        submissions(index) = parsedResponse.ToObject(Of JObject)()
                    Else
                        submissions.Add(parsedResponse.ToObject(Of JObject)())
                    End If
                    Return True
                Else
                    Debug.WriteLine("Parsed response is not a valid submission.")
                End If
            Catch ex As Exception
                Debug.WriteLine($"Error retrieving submission: {ex.Message}")
            End Try
        End Using
        Return False
    End Function

    ' Display current submission data
    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 AndAlso currentIndex < submissions.Count Then
            Dim submission = submissions(currentIndex)
            txtName.Text = If(submission("name")?.ToString(), String.Empty)
            txtEmail.Text = If(submission("email")?.ToString(), String.Empty)
            txtPhoneNum.Text = If(submission("phone")?.ToString(), String.Empty)
            txtGithubLink.Text = If(submission("github_link")?.ToString(), String.Empty)
            txtStopwatchTime.Text = If(submission("stopwatch_time")?.ToString(), String.Empty)
        Else
            ClearFields()
        End If
    End Sub

    ' Clear all text fields
    Private Sub ClearFields()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhoneNum.Text = ""
        txtGithubLink.Text = ""
        txtStopwatchTime.Text = ""
    End Sub

    ' Go to previous submission
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
        SetFormFocus()
    End Sub

    ' Go to next submission
    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        Else
            If Await LoadNextSubmission() Then
                currentIndex += 1
                DisplaySubmission()
            Else
                MessageBox.Show("No more submissions available or error fetching the next submission.")
            End If
        End If
        SetFormFocus()
    End Sub

    ' Load the next submission from server
    Private Async Function LoadNextSubmission() As Task(Of Boolean)
        Return Await LoadSubmissions(currentIndex + 1)
    End Function


    ' Search for submission by email
    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchEmail As String = txtSearchEmail.Text.Trim()
        If String.IsNullOrEmpty(searchEmail) Then
            MessageBox.Show("Please enter an email to search.")
            Return
        End If

        Try
            Dim client As New HttpClient()
            Dim response = Await client.GetStringAsync($"https://slidely-backend.onrender.com/api/search?email={searchEmail}")
            Dim parsedResponse = JToken.Parse(response)

            If TypeOf parsedResponse Is JObject Then
                Dim foundSubmission = parsedResponse.ToObject(Of JObject)()

                ' Display submission details in a message box
                Dim message As String = $"Name: {foundSubmission("name")}{vbCrLf}"
                message &= $"Email: {foundSubmission("email")}{vbCrLf}"
                message &= $"Phone Number: {foundSubmission("phone")}{vbCrLf}"
                message &= $"Github Link: {foundSubmission("github_link")}{vbCrLf}"
                message &= $"Stopwatch Time: {foundSubmission("stopwatch_time")}{vbCrLf}"
                MessageBox.Show(message, "Submission Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Submission not found.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error searching submission: {ex.Message}")
        End Try
    End Sub

    ' Delete current submission
    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                ' Ensure currentIndex is within the valid range and the submissions list is not empty
                If currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
                    Dim currentSubmission = submissions(currentIndex)

                    ' Ensure current submission is valid and contains an ID
                    If currentSubmission IsNot Nothing AndAlso currentSubmission("email") IsNot Nothing Then
                        Dim client As New HttpClient()
                        Dim EmailId As String = currentSubmission("email").ToString()
                        Dim response = Await client.DeleteAsync($"https://slidely-backend.onrender.com/api/delete/{EmailId}")
                        Dim deleted = Await response.Content.ReadAsStringAsync()

                        If deleted.Contains("success") Then
                            MessageBox.Show("Submission deleted successfully.")
                            submissions.RemoveAt(currentIndex)

                            ' Adjust currentIndex after deletion
                            If currentIndex >= submissions.Count AndAlso currentIndex > 0 Then
                                currentIndex -= 1
                            End If

                            Await ReloadAllSubmissions() ' Reload all submissions
                            DisplaySubmission()
                        Else
                            MessageBox.Show("Failed to delete submission.")
                        End If
                    Else
                        MessageBox.Show("Invalid submission data.")
                    End If
                Else
                    MessageBox.Show("Invalid submission index.")
                End If
            Catch ex As Exception
                MessageBox.Show($"Error deleting submission: {ex.Message}")
            End Try
        End If
    End Sub

    ' Method to reload all submissions
    Private Async Function ReloadAllSubmissions() As Task
        submissions.Clear()
        currentIndex = 0
        totalSubmissions = 0

        ' Load the first batch of submissions
        Await LoadSubmissions(currentIndex)
        DisplaySubmission()
    End Function

    ' Edit current submission
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Store the email ID of the current submission
        If currentIndex >= 0 Then
            Dim currentSubmission = submissions(currentIndex)
            If currentSubmission IsNot Nothing AndAlso currentSubmission("email") IsNot Nothing Then
                editingEmail = currentSubmission("email").ToString()
            End If
        End If

        ' Enable editing of the fields
        EnableEditing(True)
    End Sub

    ' Enable or disable editing of the fields
    Private Sub EnableEditing(enable As Boolean)
        txtName.ReadOnly = Not enable
        txtEmail.ReadOnly = Not enable
        txtPhoneNum.ReadOnly = Not enable
        txtGithubLink.ReadOnly = Not enable
        txtStopwatchTime.ReadOnly = Not enable

        If enable Then
            txtName.BackColor = System.Drawing.SystemColors.Window
            txtEmail.BackColor = System.Drawing.SystemColors.Window
            txtPhoneNum.BackColor = System.Drawing.SystemColors.Window
            txtGithubLink.BackColor = System.Drawing.SystemColors.Window
            txtStopwatchTime.BackColor = System.Drawing.SystemColors.Window
        Else
            txtName.BackColor = System.Drawing.SystemColors.Control
            txtEmail.BackColor = System.Drawing.SystemColors.Control
            txtPhoneNum.BackColor = System.Drawing.SystemColors.Control
            txtGithubLink.BackColor = System.Drawing.SystemColors.Control
            txtStopwatchTime.BackColor = System.Drawing.SystemColors.Control
        End If

        ' Toggle visibility of Save button
        btnSave.Visible = enable
        btnEdit.Visible = Not enable
        btnNext.Enabled = Not enable
        btnPrevious.Enabled = Not enable
        btnSearch.Enabled = Not enable
        btnDelete.Enabled = Not enable
        txtSearchEmail.ReadOnly = enable

        ' Set focus to the first editable field
        If enable Then
            txtName.Focus()
        Else
            Me.Focus()
        End If
    End Sub

    ' Save edited submission
    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MessageBox.Show("Are you sure you want to save these changes?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            ' Prepare updated submission
            Dim updatedSubmission As New JObject()
            updatedSubmission("name") = txtName.Text
            updatedSubmission("email") = txtEmail.Text
            updatedSubmission("phone") = txtPhoneNum.Text
            updatedSubmission("github_link") = txtGithubLink.Text
            updatedSubmission("stopwatch_time") = txtStopwatchTime.Text

            ' Send updated submission to server
            Try
                Using client As New HttpClient()
                    Dim requestUri = $"https://slidely-backend.onrender.com/api/update/{editingEmail}"
                    Dim content = New StringContent(updatedSubmission.ToString(), System.Text.Encoding.UTF8, "application/json")
                    Dim response = Await client.PutAsync(requestUri, content)
                    response.EnsureSuccessStatusCode() ' Throw on error response

                    Dim updated = Await response.Content.ReadAsStringAsync()
                    Debug.WriteLine(updated)
                    If updated.ToLower() = "true" Then
                        MessageBox.Show("Submission updated successfully.")
                        ' Update the local submission list
                        Dim currentSubmission = submissions(currentIndex)
                        currentSubmission("name") = updatedSubmission("name").ToString()
                        currentSubmission("email") = updatedSubmission("email").ToString()
                        currentSubmission("phone") = updatedSubmission("phone").ToString()
                        currentSubmission("github_link") = updatedSubmission("github_link").ToString()
                        currentSubmission("stopwatch_time") = updatedSubmission("stopwatch_time").ToString()

                        EnableEditing(False)
                        DisplaySubmission()
                    Else
                        MessageBox.Show("Failed to update submission.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error updating submission: {ex.Message}")
            End Try
        End If
        SetFormFocus()
    End Sub


End Class
