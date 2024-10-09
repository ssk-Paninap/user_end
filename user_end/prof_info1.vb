Public Class prof_info1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked Then
            Me.Hide()
            Dim full As New full_room
            full_room.ShowDialog()


        ElseIf RadioButton2.Checked Then
            Me.Hide()
            Dim prof_sing As New prof_single
            prof_single.ShowDialog()


        Else

            MessageBox.Show("Please select an option before proceeding.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim prof_info1 As New personal_info1
        personal_info1.ShowDialog()

    End Sub
End Class