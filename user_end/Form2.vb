Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("First Year")
        ComboBox1.Items.Add("Second Year")
        ComboBox1.Items.Add("Third Year")
        ComboBox1.Items.Add("Fourth Year")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim personalInfoForm As New personal_info1
        personalInfoForm.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim goToSummary As New user_summary
        goToSummary.Show()

    End Sub
End Class