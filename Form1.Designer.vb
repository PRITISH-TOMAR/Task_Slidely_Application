<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' Required designer variable.
    Private components As System.ComponentModel.IContainer


    Private Sub InitializeComponent()
        SuspendLayout()





        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()

        ' 
        ' btnViewSubmissions
        ' 

        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(300, 50)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.BackColor = Color.FromArgb(255, 236, 153)
        btnViewSubmissions.Text = "View Submissions (Ctrl + V)"

        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.Location = New Point(800, 400)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(300, 50)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.BackColor = Color.FromArgb(168, 220, 252)
        btnCreateSubmission.Text = "Create New Submission (Ctrl + N)"

        ' 
        ' Form1
        ' 

        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        Name = "Form1"
        ResumeLayout(False)


        Me.KeyPreview = True




        AddHandler Me.Resize, AddressOf Me.Form1_Resize

        CenterControls()
    End Sub

    '///////////////////////////////////////////////////////////////////////
    'ALIGN TO CENTER
    Private Sub CenterControls()


        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "PZ_ALPHA Task 2 form"
        Dim primaryScreen As Screen = Screen.PrimaryScreen
        Dim screenWidth As Integer = primaryScreen.Bounds.Width
        Dim screenHeight As Integer = primaryScreen.Bounds.Height

        Me.Size = New Size(screenWidth / 3, screenHeight / 2)


        screenWidth = Me.ClientSize.Width
        screenHeight = Me.ClientSize.Height

        Dim textBoxWidth As Integer = Me.btnViewSubmissions.Width
        Dim textBoxHeight As Integer = Me.btnViewSubmissions.Height

        Dim spacing As Integer = 100

        Dim centerX As Integer = (screenWidth - textBoxWidth) / 2
        Dim startY As Integer = (screenHeight - 2 * textBoxHeight) / 2

        Me.btnViewSubmissions.Location = New Point(centerX, startY)
        Me.btnCreateSubmission.Location = New Point(centerX, startY + spacing)
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs)
        CenterControls()
    End Sub


    '///////////////////////////////////////////////////////////////////////////////////////
    Private WithEvents btnViewSubmissions As System.Windows.Forms.Button
    Private WithEvents btnCreateSubmission As System.Windows.Forms.Button
End Class
