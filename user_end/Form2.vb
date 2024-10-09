Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim personalInfoForm As New personal_info1
        personalInfoForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Store values from this form into shared variables
        Form1.StudentID = TextBox1.Text
        Form1.Reason = TextBox2.Text
        Form1.YearLevel = ComboBox1.SelectedIndex + 1
        Form1.Course = ComboBox2.SelectedIndex

        ' Hide the current form
        Me.Hide()


        Dim goToSummary As New user_summary
        goToSummary.ShowDialog()

        Me.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox1 (Year Level)
        ComboBox1.Items.Add("1st Year")
        ComboBox1.Items.Add("2nd Year")
        ComboBox1.Items.Add("3rd Year")
        ComboBox1.Items.Add("4th Year")

        ComboBox2.Items.Add("Course 1")
        ComboBox2.Items.Add("Course 2")
        ComboBox2.Items.Add("Course 3")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
