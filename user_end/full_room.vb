Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class full_room

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim fullname As String = Form1.FullName
        Dim department As String = Form1.p_dept
        Dim reservation_type As String = Form1.restype
        Dim reason As String = Form1.p_reason
        Dim room_number As String = ComboBox2.SelectedItem.ToString()
        Dim section As String = ComboBox3.SelectedItem.ToString()
        Dim duration As Integer = ComboBox4.SelectedIndex
        ' Get the actual time slot text
        Dim durationText As String = ComboBox4.SelectedItem.ToString()
        Dim ticketDate As DateTime = DateTime.Now
        Dim ticketId As String = GenerateUniqueTicketId()

        Dim db As New dbhelper()
        Dim success As Boolean = db.InsertTeacherReservation(ticketId, section, fullname,
                                                    department, reservation_type,
                                                    reason, room_number, duration, section)

        If success Then
            MessageBox.Show("Reservation added successfully!")
            Me.Hide()
            Dim profTick As New fullroom_ticket With {
            .FullName = fullname,
            .p_dept = department,
            .restype = reservation_type,
            .p_reason = reason,
            .p_labNo = room_number,
            .p_duration = durationText,  ' Pass the actual time slot text instead of the index
            .TicketDate = ticketDate,
            .TicketId = ticketId,
            .section = section
        }
            profTick.ShowDialog()
        End If
    End Sub

    Private Function GenerateUniqueTicketId() As String
        Dim ticketId As String = String.Empty
        Dim isUnique As Boolean = False
        Dim random As New Random()

        While Not isUnique
            ' Generate a random ticket ID
            ticketId = random.Next(100000, 999999).ToString()

            ' Check if ticket ID is unique

            Dim connectionString As String = "Server=localhost;Database=labpass;Uid=root;Pwd=;"
            Using connection As New MySqlConnection(connectionString)
                Using checkCommand As New MySqlCommand("SELECT COUNT(*) FROM user_reservation WHERE ticket_id = @ticketId", connection)
                    checkCommand.Parameters.AddWithValue("@ticketId", ticketId)

                    Try
                        connection.Open()
                        Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                        isUnique = (count = 0)
                    Catch ex As Exception
                        MessageBox.Show("Error checking ticket ID uniqueness: " & ex.Message)
                    End Try
                End Using
            End Using
        End While

        Return ticketId
    End Function


    Private Sub full_room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("School of Information Technology/ Computer Science")
        ComboBox1.Items.Add("Nursing")
        ComboBox1.Items.Add("Criminology")
        ComboBox1.Items.Add("Education")
        ComboBox1.Items.Add("Psychology")

        ComboBox2.Items.Add("202")
        ComboBox2.Items.Add("203")
        ComboBox2.Items.Add("204")
        ComboBox2.Items.Add("205")

        ComboBox3.Items.Add("Section 1")
        ComboBox3.Items.Add("Section 2")
        ComboBox3.Items.Add("Section 3")
        ComboBox3.Items.Add("Section 4")

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
        ComboBox3.SelectedItem = Form1.section
        ComboBox1.Text = Form1.p_dept ' This should now reflect the selected department name



        Form1.restype = "One Room"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim profInfo As New prof_info1
        profInfo.Show()
    End Sub
    Private Sub full_room_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class
