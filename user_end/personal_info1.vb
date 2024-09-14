Public Class personal_info1

    Private Sub goToStudForm_Click(sender As Object, e As EventArgs) Handles goToStudForm.Click
        Dim studForm As New Form2
        studForm.Show()

        Me.Hide()
    End Sub

    Private Sub goToProfForm_Click(sender As Object, e As EventArgs) Handles goToProfForm.Click
        Dim profForm As New prof_info1
        prof_info1.Show()

        Me.Hide()
    End Sub
End Class