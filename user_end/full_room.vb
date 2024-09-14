Public Class full_room

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim full_room As New prof_info1
        prof_info1.Show()

        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim full_room As New generated_ticket
        generated_ticket.Show()

        Me.Hide()
    End Sub
End Class