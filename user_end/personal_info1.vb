Public Class personal_info1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles fn_tb.TextChanged

    End Sub

    Private Sub goToStudForm_Click(sender As Object, e As EventArgs) Handles goToStudForm.Click
        Dim studForm As New Form2
        studForm.Show()
    End Sub
End Class