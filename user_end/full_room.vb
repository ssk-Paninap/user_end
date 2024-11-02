Public Class full_room

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim profInfo As New prof_info1
        profInfo.Show()
    End Sub

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
        'Me.Hide()
        ' Dim prof_ticket As New prof_ticket
        ' prof_ticket.ShowDialog()
    End Sub

    Private Sub full_room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Dept A")
        ComboBox1.Items.Add("Dept B")
        ComboBox1.Items.Add("Dept C")
        ComboBox1.Items.Add("Dept D")
        ComboBox1.Items.Add("Dept E")

        ComboBox2.Items.Add("Lab 202")
        ComboBox2.Items.Add("Lab 203")
        ComboBox2.Items.Add("Lab 204")
        ComboBox2.Items.Add("Lab 205")

        ComboBox3.Items.Add("Section 1 BSIT")
        ComboBox3.Items.Add("Section 2 BSIT")
        ComboBox3.Items.Add("Section 3 BSIT")
        ComboBox3.Items.Add("Section 4 BSIT")
        ComboBox3.Items.Add("Section 1 BSCS")
        ComboBox3.Items.Add("Section 2 BSCS")


        ComboBox4.Items.Add("7:00 - 8:00")
        ComboBox4.Items.Add("8:00 - 9:00")
        ComboBox4.Items.Add("9:00 - 10:00")
        ComboBox4.Items.Add("10:00 - 11:00")
        ComboBox4.Items.Add("11:00 - 12:00")
        ComboBox4.Items.Add("12:00 - 13:00")
        ComboBox4.Items.Add("13:00 - 14:00")
        ComboBox4.Items.Add("14:00 - 15:00")
        ComboBox4.Items.Add("15:00 - 16:00")
        ComboBox4.Items.Add("16:00 - 17:00")


        Label1.Text = "Just to clarify " & Form1.FullName
        ComboBox3.SelectedItem = Form1.p_reason
        ComboBox1.Text = Form1.p_dept ' This should now reflect the selected department name

        Form1.restype = "One Room"
    End Sub

    Private Sub full_room_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class
