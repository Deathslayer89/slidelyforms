<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNum = New Label()
        lblGithubLink = New Label()
        lblStopwatchTime = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNum = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        btnSearch = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        lblSearchEmail = New Label()
        txtSearchEmail = New TextBox()
        btnSave = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.ForeColor = Color.DarkOrange
        lblName.Location = New Point(40, 46)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(52, 20)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.ForeColor = Color.DarkOrange
        lblEmail.Location = New Point(40, 92)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(49, 20)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email:"
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.AutoSize = True
        lblPhoneNum.ForeColor = Color.DarkOrange
        lblPhoneNum.Location = New Point(40, 138)
        lblPhoneNum.Margin = New Padding(4, 0, 4, 0)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(89, 20)
        lblPhoneNum.TabIndex = 2
        lblPhoneNum.Text = "Phone Num:"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.ForeColor = Color.DarkOrange
        lblGithubLink.Location = New Point(40, 185)
        lblGithubLink.Margin = New Padding(4, 0, 4, 0)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(145, 20)
        lblGithubLink.TabIndex = 3
        lblGithubLink.Text = "GitHub Link For Task:"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.ForeColor = Color.DarkOrange
        lblStopwatchTime.Location = New Point(40, 231)
        lblStopwatchTime.Margin = New Padding(4, 0, 4, 0)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(119, 20)
        lblStopwatchTime.TabIndex = 4
        lblStopwatchTime.Text = "Stopwatch Time:"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.White
        txtName.Location = New Point(200, 46)
        txtName.Margin = New Padding(4, 5, 4, 5)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(265, 27)
        txtName.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.White
        txtEmail.Location = New Point(200, 92)
        txtEmail.Margin = New Padding(4, 5, 4, 5)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(265, 27)
        txtEmail.TabIndex = 6
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.BackColor = Color.White
        txtPhoneNum.Location = New Point(200, 138)
        txtPhoneNum.Margin = New Padding(4, 5, 4, 5)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.ReadOnly = True
        txtPhoneNum.Size = New Size(265, 27)
        txtPhoneNum.TabIndex = 7
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = Color.White
        txtGithubLink.Location = New Point(200, 185)
        txtGithubLink.Margin = New Padding(4, 5, 4, 5)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(265, 27)
        txtGithubLink.TabIndex = 8
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BackColor = Color.White
        txtStopwatchTime.Location = New Point(200, 231)
        txtStopwatchTime.Margin = New Padding(4, 5, 4, 5)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(265, 27)
        txtStopwatchTime.TabIndex = 9
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.DarkOrange
        btnPrevious.ForeColor = Color.White
        btnPrevious.Location = New Point(40, 308)
        btnPrevious.Margin = New Padding(4, 5, 4, 5)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(100, 46)
        btnPrevious.TabIndex = 10
        btnPrevious.Text = "PREVIOUS"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.DarkOrange
        btnNext.ForeColor = Color.White
        btnNext.Location = New Point(356, 308)
        btnNext.Margin = New Padding(4, 5, 4, 5)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(100, 46)
        btnNext.TabIndex = 11
        btnNext.Text = "NEXT"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.DarkOrange
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(186, 493)
        btnSearch.Margin = New Padding(4, 5, 4, 5)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(100, 46)
        btnSearch.TabIndex = 12
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.DarkOrange
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(573, 66)
        btnDelete.Margin = New Padding(4, 5, 4, 5)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(100, 46)
        btnDelete.TabIndex = 13
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.DarkOrange
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(573, 125)
        btnEdit.Margin = New Padding(4, 5, 4, 5)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(100, 46)
        btnEdit.TabIndex = 14
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' lblSearchEmail
        ' 
        lblSearchEmail.AutoSize = True
        lblSearchEmail.ForeColor = Color.DarkOrange
        lblSearchEmail.Location = New Point(40, 424)
        lblSearchEmail.Margin = New Padding(4, 0, 4, 0)
        lblSearchEmail.Name = "lblSearchEmail"
        lblSearchEmail.Size = New Size(101, 20)
        lblSearchEmail.TabIndex = 15
        lblSearchEmail.Text = "Search Email: "
        ' 
        ' txtSearchEmail
        ' 
        txtSearchEmail.BackColor = Color.White
        txtSearchEmail.Location = New Point(149, 424)
        txtSearchEmail.Margin = New Padding(4, 5, 4, 5)
        txtSearchEmail.Name = "txtSearchEmail"
        txtSearchEmail.Size = New Size(265, 27)
        txtSearchEmail.TabIndex = 16
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.DarkOrange
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(573, 194)
        btnSave.Margin = New Padding(4, 5, 4, 5)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(100, 46)
        btnSave.TabIndex = 17
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        btnSave.Visible = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1541, 553)
        Controls.Add(btnSave)
        Controls.Add(txtSearchEmail)
        Controls.Add(lblSearchEmail)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(btnSearch)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhoneNum)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Margin = New Padding(4, 5, 4, 5)
        Name = "ViewSubmissionsForm"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhoneNum As System.Windows.Forms.Label
    Friend WithEvents lblGithubLink As System.Windows.Forms.Label
    Friend WithEvents lblStopwatchTime As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNum As System.Windows.Forms.TextBox
    Friend WithEvents txtGithubLink As System.Windows.Forms.TextBox
    Friend WithEvents txtStopwatchTime As System.Windows.Forms.TextBox
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents lblSearchEmail As System.Windows.Forms.Label
    Friend WithEvents txtSearchEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button

End Class
