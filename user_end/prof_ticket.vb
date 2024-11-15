Public Class prof_ticket
    Public Property p_dept As String
    Public Property FullName As String
    Public Property p_reason As String
    Public Property p_Duration As Integer
    Public Property p_pcnum As Integer
    Public Property p_labNo As String ' Change to String if it's a room number like "Lab 202"
    Public Property restype As String
    Public Property TicketId As String
    Public Property TicketDate As DateTime

    Private Sub prof_ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = TicketDate.ToString("MM/dd/yyyy HH:mm:ss")
        TextBox2.Text = FullName
        TextBox3.Text = restype
        TextBox4.Text = p_labNo
        TextBox5.Text = p_pcnum.ToString()
        TextBox6.Text = p_reason
        TextBox7.Text = p_Duration.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit() 'pangs sara lang di ko pa alam pano to 
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim Form1 As New Form1
        Form1.ShowDialog()

    End Sub
End Class