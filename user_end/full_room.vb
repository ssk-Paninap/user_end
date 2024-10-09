Public Class full_room

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim full_room As New prof_info1
        prof_info1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim full_room As New generated_ticket
        generated_ticket.Show()

    End Sub
End Class