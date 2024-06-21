Partial Class ViewSubmissionForm
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        '//////////////////////////////////////////////////////////////////////
        ' CENETR THE FORM
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "View Submission Form"
        Dim primaryScreen As Screen = Screen.PrimaryScreen
        Dim screenWidth As Integer = primaryScreen.Bounds.Width
        Dim screenHeight As Integer = primaryScreen.Bounds.Height

        Me.Size = New Size(screenWidth / 2, screenHeight / 2 + 30)



        '/////////////////////////////////////////////////////////////
        ' COMPONENTS
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtGitHubRepo = New System.Windows.Forms.TextBox()
        Me.txtStopwatch = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        lblStopwatch = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithubRepo = New Label()

        Me.btnReset = New System.Windows.Forms.Button()

        Me.lblIndexSearch = New System.Windows.Forms.Label()
        Me.txtIndexSearch = New System.Windows.Forms.TextBox()
        Me.btnIndexSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()

        ' control sizes
        Dim textBoxWidth As Integer = 300
        Dim textBoxHeight As Integer = 40
        Dim buttonWidth As Integer = 120
        Dim buttonHeight As Integer = 30
        Dim spacing As Integer = 50

        ' Calculate starting position for centering controls
        Dim startY As Integer = 100

        '
        ' txtName
        '
        Me.txtName.Size = New System.Drawing.Size(textBoxWidth, textBoxHeight)
        Me.txtName.TabIndex = 0
        Me.txtName.ReadOnly = True
        Me.txtName.BackColor = Color.FromArgb(240, 236, 236)
        '
        ' txtEmail
        '
        Me.txtEmail.Size = New System.Drawing.Size(textBoxWidth, textBoxHeight)
        Me.txtEmail.TabIndex = 1
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.BackColor = Color.FromArgb(240, 236, 236)

        '
        ' txtPhoneNumber
        '
        Me.txtPhoneNumber.Size = New System.Drawing.Size(textBoxWidth, textBoxHeight)
        Me.txtPhoneNumber.TabIndex = 2
        Me.txtPhoneNumber.ReadOnly = True
        Me.txtPhoneNumber.BackColor = Color.FromArgb(240, 236, 236)

        '
        ' txtGitHubRepo
        '
        Me.txtGitHubRepo.Size = New System.Drawing.Size(textBoxWidth, textBoxHeight)
        Me.txtGitHubRepo.TabIndex = 3
        Me.txtGitHubRepo.ReadOnly = True
        Me.txtGitHubRepo.BackColor = Color.FromArgb(240, 236, 236)

        '
        ' txtStopwatch
        '
        Me.txtStopwatch.Size = New System.Drawing.Size(textBoxWidth, textBoxHeight)
        Me.txtStopwatch.TabIndex = 6
        Me.txtStopwatch.ReadOnly = True
        Me.txtStopwatch.BackColor = Color.FromArgb(240, 236, 236)

        '
        ' btnPrevious
        '
        Me.btnPrevious.Size = New System.Drawing.Size(200, buttonHeight)
        Me.btnPrevious.TabIndex = 4
        Me.btnPrevious.Text = "Previous (Ctrl + P)"
        Me.btnPrevious.BackColor = Color.FromArgb(255, 236, 153)

        '
        ' btnNext
        '
        Me.btnNext.Size = New System.Drawing.Size(200, buttonHeight)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next (Ctrl + N)"
        Me.btnNext.BackColor = Color.FromArgb(168, 220, 252)

        '
        ' txtSearchEmail

        Me.txtIndexSearch.Size = New System.Drawing.Size(textBoxWidth, textBoxHeight)


        '
        ' btnSearch
        '


        Me.btnIndexSearch.Size = New System.Drawing.Size(buttonWidth, buttonHeight)

        Me.btnIndexSearch.Text = "Search"


        '
        ' btnReset
        '
        Me.btnReset.Size = New System.Drawing.Size(buttonWidth, buttonHeight)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True

        '
        ' lblEmailSearch
        '



        Me.lblIndexSearch.AutoSize = True

        Me.lblIndexSearch.Text = "Search by Index or email:"

        '  Labels 

        lblStopwatch.Text = "Timestamp:"
        lblName.Text = "Name:"
        lblEmail.Text = "Email:"
        lblPhone.Text = "Phone:"
        lblGithubRepo.Text = "Github Link:"

        ' ViewSubmissionForm
        '
        '////////////////////////////////////////////////////////////////////
        'ADDING TO CONTROLS
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtStopwatch)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtGitHubRepo)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblIndexSearch)
        Me.Controls.Add(Me.btnIndexSearch)
        Me.Controls.Add(Me.txtIndexSearch)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblGithubRepo)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Name = "ViewSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

        ' Add resize event handler
        AddHandler Me.Resize, AddressOf Me.ViewSubmissionForm_Resize

        ' Call the center controls method initially
        CenterControls()
    End Sub

    '///////////////////////////////////////////////////////////////////////////////////////
    Private Sub CenterControls()

        Dim screenWidth As Integer = Me.ClientSize.Width
        Dim screenHeight As Integer = Me.ClientSize.Height

        Dim textBoxWidth As Integer = Me.txtName.Width
        Dim textBoxHeight As Integer = Me.txtName.Height
        Dim buttonWidth As Integer = Me.btnPrevious.Width
        Dim buttonHeight As Integer = Me.btnPrevious.Height
        Dim spacing As Integer = 50

        Dim centerX As Integer = (screenWidth - textBoxWidth) / 2
        Dim centerY As Integer = (screenHeight) / 2
        Dim startY As Integer = centerY - 100



        '//////////////////////////////////////////////////////////////////////////
        'Setting Layout 
        Me.lblIndexSearch.Location = New Point(centerX - textBoxWidth / 2 - 150, startY - 1.5 * spacing)
        Me.txtIndexSearch.Location = New Point(centerX - textBoxWidth / 2 + 55, startY - 1.5 * spacing)
        Me.btnIndexSearch.Location = New Point(centerX + textBoxWidth / 2 + 70, startY - 1.5 * spacing)

        Me.btnReset.Location = New Point(centerX + textBoxWidth / 2 + 300, startY - 1.5 * spacing)



        Me.txtName.Location = New Point(centerX, startY)
        Me.txtEmail.Location = New Point(centerX, startY + spacing)
        Me.txtPhoneNumber.Location = New Point(centerX, startY + 2 * spacing)
        Me.txtGitHubRepo.Location = New Point(centerX, startY + 3 * spacing)
        Me.txtStopwatch.Location = New Point(centerX, startY + 4 * spacing)
        Me.btnPrevious.Location = New Point(centerX - buttonWidth - 10, startY + 5 * spacing)
        Me.btnNext.Location = New Point(centerX + buttonWidth + 10, startY + 5 * spacing)


        ' Location of Labels
        Me.lblName.Location = New Point(centerX - 2 * spacing, startY)
        Me.lblEmail.Location = New Point(centerX - 2 * spacing, startY + spacing)
        Me.lblPhone.Location = New Point(centerX - 2 * spacing, startY + 2 * spacing)
        Me.lblGithubRepo.Location = New Point(centerX - 2 * spacing, startY + 3 * spacing)
        Me.lblStopwatch.Location = New Point(centerX - 2 * spacing, startY + 4 * spacing)


    End Sub

    ' Event handler for form resize
    Private Sub ViewSubmissionForm_Resize(sender As Object, e As EventArgs)
        CenterControls()
    End Sub

    '//////////////////////////////////////////////////////////////////////////////////////

    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Private WithEvents txtGitHubRepo As System.Windows.Forms.TextBox
    Private WithEvents txtStopwatch As System.Windows.Forms.TextBox
    Private WithEvents btnPrevious As System.Windows.Forms.Button
    Private WithEvents btnNext As System.Windows.Forms.Button

    Private WithEvents btnReset As System.Windows.Forms.Button

    Private WithEvents lblIndexSearch As System.Windows.Forms.Label
    Private WithEvents txtIndexSearch As System.Windows.Forms.TextBox
    Private WithEvents btnIndexSearch As System.Windows.Forms.Button

    Private WithEvents lblName As System.Windows.Forms.Label
    Private WithEvents lblEmail As System.Windows.Forms.Label
    Private WithEvents lblPhone As System.Windows.Forms.Label
    Private WithEvents lblGithubRepo As System.Windows.Forms.Label
    Private lblStopwatch As System.Windows.Forms.Label
End Class
