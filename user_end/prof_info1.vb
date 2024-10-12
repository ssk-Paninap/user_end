Public Class prof_info1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked Then
            Me.Hide()
            Dim full As New full_room
            full_room.ShowDialog()

        ElseIf RadioButton2.Checked Then
            Me.Hide()
            Dim prof_sing As New prof_single
            prof_single.ShowDialog()

        Else

            MessageBox.Show("Please select an option before proceeding.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim prof_info1 As New personal_info1
        personal_info1.ShowDialog()

    End Sub

    Private Sub prof_info1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("A")
        ComboBox1.Items.Add("B")
        ComboBox1.Items.Add("C")
        ComboBox1.Items.Add("D")
        ComboBox1.Items.Add("E")

        Label1.Text = "Greetings! Prof. " & Form1.FullName
    End Sub

    Private Sub prof_info1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class