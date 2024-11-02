Public Class personal_info1

    Private Sub fn_tb_TextChanged(sender As Object, e As EventArgs) Handles fn_tb.TextChanged
        Form1.FullName = fn_tb.Text
    End Sub

    Private Sub goToStudForm_Click(sender As Object, e As EventArgs) Handles goToStudForm.Click
        ' Navigate to Form2
        Me.Hide()
        Dim studForm As New Form2
        studForm.ShowDialog()
    End Sub

    Private Sub goToProfForm_Click(sender As Object, e As EventArgs) Handles goToProfForm.Click

        Me.Hide()
        Dim profForm As New prof_info1
        profForm.ShowDialog()
    End Sub

    Private Sub personal_info1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
