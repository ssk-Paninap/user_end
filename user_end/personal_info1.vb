Public Class personal_info1

    Private Sub fn_tb_TextChanged(sender As Object, e As EventArgs) Handles fn_tb.TextChanged
        ' Store the full name into the shared variable in Form1
        Form1.FullName = fn_tb.Text
    End Sub

    Private Sub goToStudForm_Click(sender As Object, e As EventArgs) Handles goToStudForm.Click
        ' Navigate to Form2
        Me.Hide()
        Dim studForm As New Form2
        studForm.ShowDialog()
    End Sub

    Private Sub goToProfForm_Click(sender As Object, e As EventArgs) Handles goToProfForm.Click
        ' Navigate to prof_info1
        Me.Hide()
        Dim profForm As New prof_info1
        profForm.ShowDialog() ' Changed to ShowDialog for consistency
    End Sub
End Class
