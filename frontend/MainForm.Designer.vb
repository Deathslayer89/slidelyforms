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
        btnViewSubmissions.ForeColor = Color.FromArgb(255, 165, 0) ' Orange color
        btnViewSubmissions.FlatStyle = FlatStyle.Flat
        btnViewSubmissions.FlatAppearance.BorderSize = 1
        btnViewSubmissions.FlatAppearance.BorderColor = Color.FromArgb(255, 165, 0) ' Orange border color
        btnViewSubmissions.Location = New Point(67, 100)
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
        btnCreateSubmission.ForeColor = Color.FromArgb(255, 165, 0) ' Orange color
        btnCreateSubmission.FlatStyle = FlatStyle.Flat
        btnCreateSubmission.FlatAppearance.BorderSize = 1
        btnCreateSubmission.FlatAppearance.BorderColor = Color.FromArgb(255, 165, 0) ' Orange border color
        btnCreateSubmission.Location = New Point(67, 180)
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
        lblTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.ForeColor = Color.FromArgb(255, 165, 0) ' Orange color
        lblTitle.Location = New Point(50, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(233, 32)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Submission Manager"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(333, 308)
        Controls.Add(lblTitle)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        BackColor = Color.WhiteSmoke
        FormBorderStyle = FormBorderStyle.FixedDialog
        StartPosition = FormStartPosition.CenterScreen
        Margin = New Padding(4, 5, 4, 5)
        Name = "MainForm"
        Text = "Slidely Form App"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnViewSubmissions As System.Windows.Forms.Button
    Friend WithEvents btnCreateSubmission As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
