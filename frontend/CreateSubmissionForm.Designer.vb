<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNum = New TextBox()
        txtGithubLink = New TextBox()
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNum = New Label()
        lblGithubLink = New Label()
        lblStopwatch = New Label()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(200, 46)
        txtName.Margin = New Padding(4, 5, 4, 5)
        txtName.Name = "txtName"
        txtName.Size = New Size(265, 27)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(200, 92)
        txtEmail.Margin = New Padding(4, 5, 4, 5)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(265, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Location = New Point(200, 138)
        txtPhoneNum.Margin = New Padding(4, 5, 4, 5)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(265, 27)
        txtPhoneNum.TabIndex = 2
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(200, 185)
        txtGithubLink.Margin = New Padding(4, 5, 4, 5)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(265, 27)
        txtGithubLink.TabIndex = 3
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.ForeColor = Color.FromArgb(CByte(255), CByte(165), CByte(0))
        lblName.Location = New Point(40, 46)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(52, 20)
        lblName.TabIndex = 4
        lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.ForeColor = Color.FromArgb(CByte(255), CByte(165), CByte(0))
        lblEmail.Location = New Point(40, 92)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(49, 20)
        lblEmail.TabIndex = 5
        lblEmail.Text = "Email:"
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.AutoSize = True
        lblPhoneNum.ForeColor = Color.FromArgb(CByte(255), CByte(165), CByte(0))
        lblPhoneNum.Location = New Point(40, 138)
        lblPhoneNum.Margin = New Padding(4, 0, 4, 0)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(89, 20)
        lblPhoneNum.TabIndex = 6
        lblPhoneNum.Text = "Phone Num:"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.ForeColor = Color.FromArgb(CByte(255), CByte(165), CByte(0))
        lblGithubLink.Location = New Point(40, 185)
        lblGithubLink.Margin = New Padding(4, 0, 4, 0)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(145, 20)
        lblGithubLink.TabIndex = 7
        lblGithubLink.Text = "GitHub Link For Task:"
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.ForeColor = Color.FromArgb(CByte(255), CByte(165), CByte(0))
        lblStopwatch.Location = New Point(200, 231)
        lblStopwatch.Margin = New Padding(4, 0, 4, 0)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(63, 20)
        lblStopwatch.TabIndex = 8
        lblStopwatch.Text = "00:00:00"
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.White
        btnToggleStopwatch.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(165), CByte(0))
        btnToggleStopwatch.FlatStyle = FlatStyle.Flat
        btnToggleStopwatch.ForeColor = Color.FromArgb(CByte(255), CByte(165), CByte(0))
        btnToggleStopwatch.Location = New Point(40, 262)
        btnToggleStopwatch.Margin = New Padding(4, 5, 4, 5)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(163, 71)
        btnToggleStopwatch.TabIndex = 9
        btnToggleStopwatch.Text = "Toggle Stopwatch (ctrl+T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.White
        btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(165), CByte(0))
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.ForeColor = Color.FromArgb(CByte(255), CByte(165), CByte(0))
        btnSubmit.Location = New Point(307, 262)
        btnSubmit.Margin = New Padding(4, 5, 4, 5)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(169, 71)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "Submit (ctrl+S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1176, 532)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(lblStopwatch)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhoneNum)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 5, 4, 5)
        Name = "CreateSubmissionForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNum As System.Windows.Forms.TextBox
    Friend WithEvents txtGithubLink As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhoneNum As System.Windows.Forms.Label
    Friend WithEvents lblGithubLink As System.Windows.Forms.Label
    Friend WithEvents lblStopwatch As System.Windows.Forms.Label
    Friend WithEvents btnToggleStopwatch As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
