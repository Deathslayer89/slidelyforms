<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        lblTitle = New Label()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.White
        btnViewSubmissions.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(165), CByte(0))
        btnViewSubmissions.FlatStyle = FlatStyle.Flat
        btnViewSubmissions.ForeColor = Color.FromArgb(CByte(255), CByte(165), CByte(0))
        btnViewSubmissions.Location = New Point(569, 201)
        btnViewSubmissions.Margin = New Padding(4, 5, 4, 5)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(200, 46)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "View Submissions"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.White
        btnCreateSubmission.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(165), CByte(0))
        btnCreateSubmission.FlatStyle = FlatStyle.Flat
        btnCreateSubmission.ForeColor = Color.FromArgb(CByte(255), CByte(165), CByte(0))
        btnCreateSubmission.Location = New Point(569, 365)
        btnCreateSubmission.Margin = New Padding(4, 5, 4, 5)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(200, 46)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "Create Submission"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(255), CByte(165), CByte(0))
        lblTitle.Location = New Point(512, 93)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(313, 41)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Submission Manager"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1422, 591)
        Controls.Add(lblTitle)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 5, 4, 5)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Slidely Form App"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnViewSubmissions As System.Windows.Forms.Button
    Friend WithEvents btnCreateSubmission As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
