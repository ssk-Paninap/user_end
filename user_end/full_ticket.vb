Imports System.Collections.Specialized.BitVector32

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
        TextBox1.Text = TicketId
        TextBox2.Text = TicketDate.ToString("MM/dd/yyyy HH:mm:ss")
        TextBox3.Text = FullName
        TextBox4.Text = restype
        TextBox5.Text = p_dept

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class