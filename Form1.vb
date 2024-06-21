Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    ' Event handler for the View Submissions button click
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        ViewSubmissions()
    End Sub

    ' Event handler for the Create Submission button click
    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        CreateSubmission()
    End Sub

    ' Method to view submissions
    Private Sub ViewSubmissions()
        Dim viewForm As New ViewSubmissionForm()
        viewForm.Show()
    End Sub

    ' Method to create a new submission
    Private Sub CreateSubmission()
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    ' Event handler for key down events
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check for specific key combinations
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Ctrl + V to view submissions
            ViewSubmissions()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Ctrl + N to create new submission
            CreateSubmission()
        End If
    End Sub





End Class
