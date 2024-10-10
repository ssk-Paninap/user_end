Public Class generated_ticket
    Public Property StudentId As String
    Public Property FullName As String
    Public Property YearLevel As String
    Public Property Course As String
    Public Property Reason As String
    Public Property Duration As Integer
    Public Property PCNumber As String
    Public Property LabNumber As String
    Public Property TicketDate As DateTime
    Public Property TicketId As String

    Private Sub generated_ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display receipt information
        TextBox1.Text = "===== TICKET RESERVED!! =====" & Environment.NewLine &
                        "Ticket ID: " & TicketId & Environment.NewLine & ' Added Ticket ID here
                        "Student ID: " & StudentId & Environment.NewLine &
                        "Full Name: " & FullName & Environment.NewLine &
                        "Year Level: " & YearLevel & Environment.NewLine &
                        "Course: " & Course & Environment.NewLine &
                        "Reason: " & Reason & Environment.NewLine &
                        "Duration: " & Duration & " minutes" & Environment.NewLine &
                        "PC Number: " & PCNumber & Environment.NewLine &
                        "Lab Number: " & LabNumber & Environment.NewLine &
                        "Ticket Date: " & TicketDate.ToString() & Environment.NewLine &
                        "==================="
        TextBox1.Text = StudentId
        TextBox2.Text = TicketId
        TextBox3.Text = YearLevel
        TextBox4.Text = FullName
        TextBox5.Text = Duration
        TextBox6.Text = Reason
        TextBox7.Text = LabNumber
        TextBox8.Text = PCNumber
        TextBox9.Text = TicketDate.ToString()
        TextBox10.Text = Course
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Application.Exit() 'pangs sara lang di ko pa alam pano to 
    End Sub
    Private Sub generated_ticket_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim Form1 As New Form1
        Form1.ShowDialog()
    End Sub
End Class
