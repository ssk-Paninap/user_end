Public Class prof_single

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim prof_single As New generated_ticket
        generated_ticket.ShowDialog()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim prof_single As New prof_info1
        prof_info1.ShowDialog()
    End Sub
    Private Sub prof_single_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class