Public Class prof_ticket
    Public Property FullName As String
    Public Property p_dept As String
    Public Property restype As String
    Public Property p_reason As String
    Public Property p_labNo As String
    Public Property p_pcnum As String
    Public Property p_Duration As String
    Public Property TicketDate As DateTime
    Public Property TicketId As String





    Private Sub prof_ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox8.Text = TicketDate.ToString("MM/dd/yyyy HH:mm:ss")
        TextBox1.Text = TicketId
        TextBox2.Text = FullName
        TextBox3.Text = restype
        TextBox4.Text = p_labNo
        TextBox5.Text = p_pcnum.ToString()
        TextBox6.Text = p_reason
        TextBox7.Text = p_Duration
        TextBox9.Text = p_dept
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