Public Class prof_info1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked Then
            Dim full As New full_room
            full_room.Show()

            Me.Hide()
        ElseIf RadioButton2.Checked Then

            Dim prof_sing As New prof_single
            prof_single.Show()

            Me.Hide()
        Else

            MessageBox.Show("Please select an option before proceeding.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prof_info1 As New personal_info1
        personal_info1.Show()

        Me.Hide()
    End Sub
End Class