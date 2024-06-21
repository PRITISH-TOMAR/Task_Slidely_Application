Imports System.Net
Imports System.Net.Http
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

' Define your Submission class


Public Class CreateSubmissionForm
    Inherits Form

    Private stopwatch As New Stopwatch()
    Private WithEvents timer As New Timer()
    Private apiUrl As String = "http://localhost:3000/submit"



    Public Sub New()

        InitializeComponent()



        '//////////////////////////////////////////////////////////////////'
        'EVENT HANDLERS ADDRESSINGS
        AddHandler btnStartStop.Click, AddressOf btnStartStop_Click
        AddHandler btnSubmit.Click, AddressOf btnSubmit_Click
        AddHandler Me.KeyDown, AddressOf Form_KeyDown


        timer.Interval = 1000
        timer.Start()
        stopwatch.Start()
    End Sub


    '////////////////////////////////////////////////////////////////////////////
    ' SETTING FUNCTIONS FOR CLICKS
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs)
        ' Check for Ctrl + T to toggle stopwatch
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ToggleStopwatch()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            submitall()
        End If
    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs)
        ToggleStopwatch()
    End Sub

    Private Sub ToggleStopwatch()
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnStartStop.Text = "Start (Ctrl + T)"
            timer.Stop()
        Else
            stopwatch.Start()
            btnStartStop.Text = "Stop (Ctrl + T)"
            timer.Start()
        End If
    End Sub
    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs)

        Await submitall()

    End Sub

    '////////////////////////////////////////////////////////////////////////////////////
    ' ESSANTIAL FUNCTIONS
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    '////////////////////////////////////////////////////////////////////////////////
    'SUBMITTING DATA THROUGH API
    Private Async Function submitall() As Task
        ' Retrieve form values/////////////////////////////////////////////////
        Dim name As String = txtName.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim phone As String = txtPhoneNumber.Text.Trim()
        Dim github_link As String = txtGitHubRepo.Text.Trim()
        Dim stopwatch_time As String = lblStopwatch.Text

        '///// DEBUGING
        Console.WriteLine($"Name: {name}, Email: {email}, Phone: {phone}, GitHub: {github_link}, Stopwatch: {stopwatch_time}")

        ' Validate input
        Dim errorMessage As String = ValidateInput(name, email, phone)
        If Not String.IsNullOrEmpty(errorMessage) Then
            MessageBox.Show(errorMessage, "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Create submission object
        Dim newSubmission As New Submission With {
        .name = name,
        .email = email,
        .phone = phone,
        .github_link = github_link,
        .stopwatch_time = stopwatch_time
    }

        ' Serialize object to JSON
        Dim jsonPayload As String = JsonConvert.SerializeObject(newSubmission)





        ' Create HttpClient instance
        Using client As New HttpClient()
            Try
                ' Prepare the request content
                Dim content As New StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json")
                Debug.WriteLine($"JSON PayloContentad: {content}")
                ' Send POST request asynchronously
                Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content)

                ' Check the status code
                If response.IsSuccessStatusCode Then
                    Dim responseData As String = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show("Data sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf response.StatusCode = HttpStatusCode.InternalServerError Then
                    Dim errorData As String = Await response.Content.ReadAsStringAsync()

                    Dim errorResponse As ErrorResponse = JsonConvert.DeserializeObject(Of ErrorResponse)(errorData)
                    MessageBox.Show("Server error occurred." & vbCrLf & "Status code: 500" & vbCrLf & "Error: " & errorResponse.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim errorData As String = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show("Failed to send data." & vbCrLf & "Status code: " & response.StatusCode & vbCrLf & "Error: " & errorData, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Function

    '/////////////////////////////////////////////////////////////////////////////////
    ' Validation logic for name, email, and phone number
    Private Function ValidateInput(name As String, email As String, phoneNumber As String) As String

        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Dim phonePattern As String = "^[0-9]+$"
        Dim namePattern As String = "^[a-zA-Z\s]+$"

        If Not Regex.IsMatch(email, emailPattern) Then
            Return "Invalid email format."
        End If

        If Not Regex.IsMatch(phoneNumber, phonePattern) Then
            Return "Phone number must be numerical."
        End If

        If Not Regex.IsMatch(name, namePattern) Then
            Return "Name must contain only alphabetic characters."
        End If

        Return String.Empty
    End Function



End Class
