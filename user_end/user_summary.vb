Public Class user_summary
    Private Sub user_summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("First Year")
        ComboBox1.Items.Add("Second Year")
        ComboBox1.Items.Add("Third Year")
        ComboBox1.Items.Add("Fourth Year")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user_info As New Form2
        user_info.Show()
    End Sub
End Class