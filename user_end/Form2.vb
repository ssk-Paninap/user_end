Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Hide the current form
        Me.Hide()

        ' Open the personal_info1 form
        Dim personalInfoForm As New personal_info1
        personalInfoForm.ShowDialog()

        ' After the next form closes, optionally show this form again
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Store values from this form into shared variables
        Form1.StudentID = TextBox1.Text ' Assuming TextBox1 is for Student ID
        Form1.Reason = TextBox2.Text ' Assuming TextBox2 is for Reason
        Form1.YearLevel = ComboBox1.SelectedIndex + 1 ' Assuming ComboBox1 is for Year Level (0-indexed)
        Form1.Course = ComboBox2.SelectedIndex ' Assuming ComboBox2 is for Course (0-indexed)

        ' Hide the current form
        Me.Hide()

        ' Open the user_summary form
        Dim goToSummary As New user_summary
        goToSummary.ShowDialog()

        ' After the next form closes, optionally show this form again
        Me.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox1 (Year Level)
        ComboBox1.Items.Add("1st Year")
        ComboBox1.Items.Add("2nd Year")
        ComboBox1.Items.Add("3rd Year")
        ComboBox1.Items.Add("4th Year")

        ' Populate ComboBox2 (Course)
        ComboBox2.Items.Add("Course 1") ' Replace with actual course names
        ComboBox2.Items.Add("Course 2") ' Replace with actual course names
        ComboBox2.Items.Add("Course 3") ' Replace with actual course names
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' You can add any additional logic here if needed
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ' You can add any additional logic here if needed
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' You can add any additional logic here if needed
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' You can add any additional logic here if needed
    End Sub
End Class
