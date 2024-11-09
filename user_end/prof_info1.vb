Imports System.Drawing.Drawing2D

Public Class prof_info1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.p_reason = ComboBox2.SelectedItem.ToString()
        Form1.restype = RadioButton2.ToString()

        Form1.p_dept = ComboBox1.SelectedItem.ToString()

        If RadioButton1.Checked Then
            Form1.restype = "Full Room"
            Me.Hide()
            Dim full As New full_room
            full.ShowDialog()

        ElseIf RadioButton2.Checked Then
            Form1.restype = "single Room"
            Me.Hide()
            Dim prof_sing As New prof_single
            prof_sing.ShowDialog()

        Else
            MessageBox.Show("Please select an option before proceeding.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim prof_info1 As New personal_info1
        prof_info1.ShowDialog()
    End Sub

    Private Sub prof_info1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("School of Information Technology/ Computer Science")
        ComboBox1.Items.Add("Nursing")
        ComboBox1.Items.Add("Criminology")
        ComboBox1.Items.Add("Education")
        ComboBox1.Items.Add("Psychology")

        Label1.Text = "Greetings! Prof. " & Form1.FullName

        ComboBox2.Items.Add("Acads")
        ComboBox2.Items.Add("Research")
        ComboBox2.Items.Add("Online Class")
        ComboBox2.Items.Add("Project Building")

        ComboBox2.Text = Form1.p_reason
        ComboBox1.Text = Form1.p_dept

    End Sub

    Private Sub prof_info1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
