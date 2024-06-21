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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.txtGithubLink = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhoneNum = New System.Windows.Forms.Label()
        Me.lblGithubLink = New System.Windows.Forms.Label()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.TabIndex = 0
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 60)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 20)
        Me.txtEmail.TabIndex = 1
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(150, 90)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(200, 20)
        Me.txtPhoneNum.TabIndex = 2
        '
        'txtGithubLink
        '
        Me.txtGithubLink.Location = New System.Drawing.Point(150, 120)
        Me.txtGithubLink.Name = "txtGithubLink"
        Me.txtGithubLink.Size = New System.Drawing.Size(200, 20)
        Me.txtGithubLink.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = Color.FromArgb(255, 165, 0) ' Orange color
        Me.lblName.Location = New System.Drawing.Point(30, 30)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.ForeColor = Color.FromArgb(255, 165, 0) ' Orange color
        Me.lblEmail.Location = New System.Drawing.Point(30, 60)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email:"
        '
        'lblPhoneNum
        '
        Me.lblPhoneNum.AutoSize = True
        Me.lblPhoneNum.ForeColor = Color.FromArgb(255, 165, 0) ' Orange color
        Me.lblPhoneNum.Location = New System.Drawing.Point(30, 90)
        Me.lblPhoneNum.Name = "lblPhoneNum"
        Me.lblPhoneNum.Size = New System.Drawing.Size(67, 13)
        Me.lblPhoneNum.TabIndex = 6
        Me.lblPhoneNum.Text = "Phone Num:"
        '
        'lblGithubLink
        '
        Me.lblGithubLink.AutoSize = True
        Me.lblGithubLink.ForeColor = Color.FromArgb(255, 165, 0) ' Orange color
        Me.lblGithubLink.Location = New System.Drawing.Point(30, 120)
        Me.lblGithubLink.Name = "lblGithubLink"
        Me.lblGithubLink.Size = New System.Drawing.Size(109, 13)
        Me.lblGithubLink.TabIndex = 7
        Me.lblGithubLink.Text = "GitHub Link For Task:"
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.ForeColor = Color.FromArgb(255, 165, 0) ' Orange color
        Me.lblStopwatch.Location = New System.Drawing.Point(150, 150)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(49, 13)
        Me.lblStopwatch.TabIndex = 8
        Me.lblStopwatch.Text = "00:00:00"
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.BackColor = Color.White
        Me.btnToggleStopwatch.ForeColor = Color.FromArgb(255, 165, 0) ' Orange color
        Me.btnToggleStopwatch.FlatStyle = FlatStyle.Flat
        Me.btnToggleStopwatch.FlatAppearance.BorderSize = 1
        Me.btnToggleStopwatch.FlatAppearance.BorderColor = Color.FromArgb(255, 165, 0) ' Orange border color
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(30, 170)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(120, 30)
        Me.btnToggleStopwatch.TabIndex = 9
        Me.btnToggleStopwatch.Text = "Toggle Stopwatch"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = Color.White
        Me.btnSubmit.ForeColor = Color.FromArgb(255, 165, 0) ' Orange color
        Me.btnSubmit.FlatStyle = FlatStyle.Flat
        Me.btnSubmit.FlatAppearance.BorderSize = 1
        Me.btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(255, 165, 0) ' Orange border color
        Me.btnSubmit.Location = New System.Drawing.Point(230, 170)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(120, 30)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 250)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.lblGithubLink)
        Me.Controls.Add(Me.lblPhoneNum)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtGithubLink)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.BackColor = Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Name = "CreateSubmissionForm"
        Me.Text = "Create Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
