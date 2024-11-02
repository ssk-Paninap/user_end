

Public Class prof_ticket
    Public Property p_dept As String
    Public Property FullName As String
    Public Property p_reason As String
    Public Property p_Duration As Integer
    Public Property p_pcnum As Integer
    Public Property p_labNo As Integer
    Public Property restype As String
    Public Property TicketDate As DateTime

    Private Sub prof_ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = TicketDate.ToString("MM/dd/yyyy HH:mm:ss")
        TextBox2.Text = FullName
        TextBox3.Text = restype
        TextBox4.Text = p_dept
        TextBox5.Text = p_reason
        TextBox6.Text = p_pcnum
        TextBox7.Text = p_labNo
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