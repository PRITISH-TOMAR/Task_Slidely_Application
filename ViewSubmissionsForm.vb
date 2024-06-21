Imports System.Net.Http
Imports System.Net.Sockets
Imports Newtonsoft.Json

Public Class ViewSubmissionForm
    Inherits System.Windows.Forms.Form

    Private currentIndex As Integer = -1
    Private currentData As List(Of Submission)
    Private api As String = "http://localhost:3000/read?"

    '/////////////////////////////////////////////////////////////////////////////////
    'INITIALIZATION
    Public Sub New()
        InitializeComponent()

        ' Enable KeyPreview
        Me.KeyPreview = True

        '  event handlers for buttons and form-level key events
        AddHandler btnPrevious.Click, AddressOf btnPrevious_Click
        AddHandler btnNext.Click, AddressOf btnNext_Click
        AddHandler Me.KeyDown, AddressOf Form_KeyDown
        AddHandler btnIndexSearch.Click, AddressOf btnSearchClick
    End Sub


    '////////////////////////////////////////////////////////////////////////
    'API CALLING
    Private Async Function FetchDataAsync(url As String) As Task(Of Submission)
        Dim apiUrl As String = url

        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)


                If response.IsSuccessStatusCode Then
                    Dim responseData As String = Await response.Content.ReadAsStringAsync()

                    ' Deserialize JSON response 
                    Dim dataEntry As Submission = JsonConvert.DeserializeObject(Of Submission)(responseData)
                    Return dataEntry
                Else

                    Return Nothing
                End If
            Catch ex As Exception

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Using
    End Function

    'display data based on index or email
    Private Async Sub FetchAndDisplayData(url As String)
        Dim dataEntry As Submission = Await FetchDataAsync(url)


        If dataEntry IsNot Nothing Then
            DisplayData(dataEntry)
            txtIndexSearch.Text = currentIndex.ToString()
        Else
            MessageBox.Show($"No data found for given value.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    '////////////////////////////////////////////////////////////////////////
    '  display a data entry 
    Private Sub DisplayData(dataEntry As Submission)
        txtName.Text = dataEntry.name
        txtEmail.Text = dataEntry.email
        txtPhoneNumber.Text = dataEntry.phone
        txtGitHubRepo.Text = dataEntry.github_link
        txtStopwatch.Text = dataEntry.stopwatch_time
    End Sub

    '  display data based on index or email 
    Private Sub GetData()
        Dim emailOrIndex As String = txtIndexSearch.Text.Trim()
        Dim index As Integer


        If Integer.TryParse(emailOrIndex, index) Then

            currentIndex = index
            FetchAndDisplayData($"{api}index={currentIndex}")
        ElseIf Not String.IsNullOrEmpty(emailOrIndex) Then

            FetchAndDisplayData($"{api}email={emailOrIndex}")
            txtIndexSearch.Text = currentIndex.ToString()
        Else

            MessageBox.Show("Invalid Input!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    '/////////////////////////////////////////////////////////////////////

    ' EVENT HANDLINGS
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs)

        If e.Control AndAlso e.KeyCode = Keys.P Then
            Previous()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            NextBut()
        ElseIf e.KeyCode = Keys.Enter Then
            GetData()
        End If
    End Sub


    Private Sub btnPrevious_Click(sender As Object, e As EventArgs)
        Previous()
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs)
        NextBut()
    End Sub
    Private Sub btnSearchClick(sender As Object, e As EventArgs)
        GetData()
    End Sub

    '///////////////////////////////////////////////////////////////////////
    ' BUTTONS FUNCTIONS
    Private Sub Previous()
        If currentIndex > 0 Then
            currentIndex -= 1
            FetchAndDisplayData($"{api}index={currentIndex}")
        End If
    End Sub




    Private Sub NextBut()
        If currentIndex >= 0 Then
            currentIndex += 1
            FetchAndDisplayData($"{api}index={currentIndex}")
        End If
    End Sub


    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        currentIndex = -1
        txtName.Clear()
        txtEmail.Clear()
        txtPhoneNumber.Clear()
        txtGitHubRepo.Clear()
        txtStopwatch.Clear()
        txtIndexSearch.Clear()
    End Sub

    '



End Class

