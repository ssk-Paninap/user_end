Public Class prof_single

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fullname As String = Form1.FullName
        Dim department As String = Form1.p_dept ' This should now hold the department name
        Dim reservation_type As String = Form1.restype
        Dim reason As String = Form1.p_reason
        Dim room_number As String = ComboBox2.SelectedItem
        Dim pc_number As String = Form1.p_pcnum
        Dim duration As Integer = Integer.Parse(ComboBox4.SelectedValue)

        Dim db As New dbhelper()
        Dim success As Boolean = db.InsertTeacherReservation(fullname, department, reservation_type, reason, room_number, pc_number, duration)

        If success Then
            MessageBox.Show("Teacher reservation added successfully!")
        Else
            MessageBox.Show("Failed to add teacher reservation.")
        End If
        Application.Exit()

        Me.Hide()
        Dim prof_single As New generated_ticket
        generated_ticket.ShowDialog()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim prof_single As New prof_info1
        prof_info1.ShowDialog()
    End Sub
    Private Sub prof_single_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub prof_single_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Dept A")
        ComboBox1.Items.Add("Dept B")
        ComboBox1.Items.Add("Dept C")
        ComboBox1.Items.Add("Dept D")
        ComboBox1.Items.Add("Dept E")

        ComboBox2.Items.Add("Lab 202")
        ComboBox2.Items.Add("Lab 203")
        ComboBox2.Items.Add("Lab 204")
        ComboBox2.Items.Add("Lab 205")

        ComboBox3.Items.Add("1")
        ComboBox3.Items.Add("2")
        ComboBox3.Items.Add("3")
        ComboBox3.Items.Add("4")
        ComboBox3.Items.Add("5")
        ComboBox3.Items.Add("6")
        ComboBox3.Items.Add("7")
        ComboBox3.Items.Add("8")
        ComboBox3.Items.Add("9")
        ComboBox3.Items.Add("10")

        ComboBox4.Items.Add("Acads")
        ComboBox4.Items.Add("Research")
        ComboBox4.Items.Add("Online Class")
        ComboBox4.Items.Add("Project Building")

        ComboBox5.Items.Add("7:00 - 8:00")
        ComboBox5.Items.Add("8:00 - 9:00")
        ComboBox5.Items.Add("9:00 - 10:00")
        ComboBox5.Items.Add("10:00 - 11:00")
        ComboBox5.Items.Add("11:00 - 12:00")
        ComboBox5.Items.Add("12:00 - 13:00")
        ComboBox5.Items.Add("13:00 - 14:00")
        ComboBox5.Items.Add("14:00 - 15:00")
        ComboBox5.Items.Add("15:00 - 16:00")
        ComboBox5.Items.Add("16:00 - 17:00")

        Label1.Text = "Just to clarify " & Form1.FullName
        ComboBox3.SelectedItem = Form1.p_reason
        ComboBox1.Text = Form1.p_dept
    End Sub
End Class