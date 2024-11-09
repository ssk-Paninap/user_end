Public Class full_ticket
    Public Property p_dept As String
    Public Property FullName As String
    Public Property p_Duration As Integer
    Public Property p_pcnum As Integer
    Public Property p_labNo As String ' Change to String if it's a room number like "Lab 202"
    Public Property restype As String
    Public Property TicketId As String
    Public Property TicketDate As DateTime

    Private Sub prof_ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox.Text =
        TextBox.Text = TicketDate.ToString("MM/dd/yyyy HH:mm:ss")
        TextBox.Text = FullName
        TextBox.Text = restype
        TextBox.Text = p_dept
        TextBox.Text = p_section
    End Sub
End Class