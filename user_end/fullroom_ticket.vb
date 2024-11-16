Public Class fullroom_ticket
    Public Property p_dept As String
    Public Property FullName As String
    Public Property p_reason As String
    Public Property p_duration As String
    Public Property p_pcnum As Integer
    Public Property p_labNo As String ' Change to String if it's a room number like "Lab 202"
    Public Property restype As String
    Public Property TicketId As String
    Public Property TicketDate As DateTime
    Public Property section As String




    Private Sub prof_ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox8.Text = TicketDate.ToString("MM/dd/yyyy HH:mm:ss")
        TextBox1.Text = TicketId
        TextBox2.Text = FullName
        TextBox3.Text = restype
        TextBox4.Text = p_labNo
        TextBox5.Text = p_dept
        TextBox6.Text = p_reason
        TextBox7.Text = p_duration
        TextBox9.Text = section


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim Form1 As New Form1
        Form1.ShowDialog()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class