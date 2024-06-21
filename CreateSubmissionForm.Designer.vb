<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form


    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.SuspendLayout()

        Me.Name = "CreateSubmissionForm"
        Me.ResumeLayout(False)

        Me.KeyPreview = True


        '/////////////////////////////////////////////////////////////////////////
        ' Setting INITIAL LAYOUT

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Create Submission Form"
        Dim primaryScreen As Screen = Screen.PrimaryScreen
        Dim screenWidth As Integer = primaryScreen.Bounds.Width
        Dim screenHeight As Integer = primaryScreen.Bounds.Height

        Me.Size = New Size(screenWidth / 2, screenHeight / 2)

        '////////////////////////////////////////////////////////////////////////////
        ' Initialize controls
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGitHubRepo = New TextBox()
        btnStartStop = New Button()
        btnSubmit = New Button()
        lblStopwatch = New TextBox()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithubRepo = New Label()




        Dim textBoxWidth As Integer = 300
        Dim textBoxHeight As Integer = 40
        Dim buttonWidth As Integer = 120
        Dim buttonHeight As Integer = 40
        Dim spacing As Integer = 50

        Dim startY As Integer = 100

        ' Set properties
        txtName.Location = New Point(850, 200)
        txtEmail.Location = New Point(850, 240)
        txtPhoneNumber.Location = New Point(850, 280)
        txtGitHubRepo.Location = New Point(850, 320)
        btnStartStop.Location = New Point(800, 360)
        btnSubmit.Location = New Point(900, 400)
        lblStopwatch.Location = New Point(1000, 360)

        Me.txtName.Size = New System.Drawing.Size(textBoxWidth, textBoxHeight)
        Me.txtEmail.Size = New System.Drawing.Size(textBoxWidth, textBoxHeight)
        txtPhoneNumber.Size = New System.Drawing.Size(textBoxWidth, textBoxHeight)
        txtGitHubRepo.Size = New System.Drawing.Size(textBoxWidth, textBoxHeight)
        btnStartStop.Size = New Size(150, 30)
        btnSubmit.Size = New Size(150, 30)
        lblStopwatch.Size = New Size(100, 30)

        btnStartStop.Text = "Stop (Ctrl + T)"
        btnSubmit.Text = "Submit (Ctrl + S)"
        lblStopwatch.Text = "00:00:00"
        btnStartStop.BackColor = Color.FromArgb(255, 236, 153)
        btnSubmit.BackColor = Color.FromArgb(168, 220, 252)




        lblName.Text = "Name:"
        lblEmail.Text = "Email:"
        lblPhone.Text = "Phone:"
        lblGithubRepo.Text = "GitHub link:"


        ' Add placeholders
        SetPlaceholder(txtName, "Enter your name")
        SetPlaceholder(txtEmail, "Enter your email")
        SetPlaceholder(txtPhoneNumber, "Enter your phone number")
        SetPlaceholder(txtGitHubRepo, "Enter your GitHub link")




        ' Add controls to the form
        Me.Controls.Add(lblName)
        Me.Controls.Add(lblEmail)
        Me.Controls.Add(lblPhone)
        Me.Controls.Add(lblGitHubRepo)
        Me.Controls.Add(txtName)
        Me.Controls.Add(txtEmail)
        Me.Controls.Add(txtPhoneNumber)
        Me.Controls.Add(txtGitHubRepo)
        Me.Controls.Add(btnStartStop)
        Me.Controls.Add(btnSubmit)
        Me.Controls.Add(lblStopwatch)


        AddHandler Me.Resize, AddressOf Me.CreateSubmission_Resize

        CenterControls()


    End Sub
    '////////////////////////////////////////////////////////////////////////////////
    ' ALIGNING TO CENTER
    Private Sub CenterControls()
        Dim screenWidth As Integer = Me.ClientSize.Width
        Dim screenHeight As Integer = Me.ClientSize.Height

        Dim textBoxWidth As Integer = Me.txtName.Width
        Dim textBoxHeight As Integer = Me.txtName.Height

        Dim spacing As Integer = 50

        Dim centerX As Integer = (screenWidth - textBoxWidth) / 2
        Dim startY As Integer = 100

        Me.txtName.Location = New Point(centerX, startY)
        Me.txtEmail.Location = New Point(centerX, startY + spacing)
        Me.txtPhoneNumber.Location = New Point(centerX, startY + 2 * spacing)
        Me.txtGitHubRepo.Location = New Point(centerX, startY + 3 * spacing)

        Me.lblName.Location = New Point(centerX - 100, startY)
        Me.lblEmail.Location = New Point(centerX - 100, startY + spacing)
        Me.lblPhone.Location = New Point(centerX - 100, startY + 2 * spacing)
        Me.lblGithubRepo.Location = New Point(centerX - 150, startY + 3 * spacing)

        centerX = (screenWidth - btnStartStop.Width) / 2

        btnStartStop.Location = New Point(centerX - 100, startY + 4.5 * spacing)
        btnSubmit.Location = New Point(centerX, startY + 5.5 * spacing)
        lblStopwatch.Location = New Point(centerX + 100, startY + 4.5 * spacing)

    End Sub
    '/////////////////////////////////////////////////////////////////////////////////
    'PLACEHOLDERS
    Private Sub SetPlaceholder(txtBox As TextBox, placeholder As String)
        txtBox.Text = placeholder
        txtBox.ForeColor = Color.Gray
        AddHandler txtBox.Enter, Sub(sender, e)
                                     If txtBox.ForeColor = Color.Gray Then
                                         txtBox.Text = ""
                                         txtBox.ForeColor = Color.Black
                                     End If
                                 End Sub
        AddHandler txtBox.Leave, Sub(sender, e)
                                     If String.IsNullOrWhiteSpace(txtBox.Text) Then
                                         txtBox.Text = placeholder
                                         txtBox.ForeColor = Color.Gray
                                     End If
                                 End Sub
    End Sub
    '//////////////////////////////////////////////////////////
    'REQUIRED FOR GETTING RESPONSE MESSAGES
    Public Class DataType
        Public Property Property1 As String
        Public Property Property2 As String
        ' Add more properties as needed
    End Class
    Public Class ErrorResponse
        Public Property Message As String
        Public Property Submission As DataType
    End Class

    '////////////////////////////////////////////////////////////////////////
    Private Sub CreateSubmission_Resize(sender As Object, e As EventArgs)
        CenterControls()
    End Sub
    '/////////////////////////////////////////////////////////////////


    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Private WithEvents txtGitHubRepo As System.Windows.Forms.TextBox
    Private WithEvents lblName As System.Windows.Forms.Label
    Private WithEvents lblEmail As System.Windows.Forms.Label
    Private WithEvents lblPhone As System.Windows.Forms.Label
    Private WithEvents lblGithubRepo As System.Windows.Forms.Label
    Private WithEvents btnStartStop As System.Windows.Forms.Button
    Private WithEvents btnSubmit As System.Windows.Forms.Button
    Private lblStopwatch As System.Windows.Forms.TextBox

End Class