Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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
        Form1.Reason = ComboBox3.SelectedItem
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

        ComboBox2.Items.Add("BSIT")
        ComboBox2.Items.Add("BSCS")
        ComboBox2.Items.Add("BSED")
        ComboBox2.Items.Add("BEED")
        ComboBox2.Items.Add("BSN")

        ComboBox3.Items.Add("Acads")
        ComboBox3.Items.Add("Research")
        ComboBox3.Items.Add("Online Class")
        ComboBox3.Items.Add("Project Building")


        Label1.Text = "Hi, " & Form1.FullName & "! Please proceed."
    End Sub
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
