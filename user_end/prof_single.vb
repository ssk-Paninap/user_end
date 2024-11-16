Imports System.Collections.Specialized.BitVector32
Imports MySql.Data.MySqlClient

Public Class prof_single
    Private Sub prof_single_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("School of Information Technology/ Computer Science")
        ComboBox1.Items.Add("Nursing")
        ComboBox1.Items.Add("Criminology")
        ComboBox1.Items.Add("Education")
        ComboBox1.Items.Add("Psychology")

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

        ComboBox5.Items.AddRange(New String() {
        "7:00 - 8:00",
        "8:00 - 9:00",
        "9:00 - 10:00",
        "10:00 - 11:00",
        "11:00 - 12:00",
        "12:00 - 13:00",
        "13:00 - 14:00",
        "14:00 - 15:00",
        "15:00 - 16:00",
        "16:00 - 17:00"
    })

        Label1.Text = "Just to clarify " & Form1.FullName
        ComboBox4.Text = Form1.p_reason
        ComboBox1.Text = Form1.p_dept

        Form1.restype = "One PC"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Add validation for all required fields
        If ComboBox2.SelectedItem Is Nothing OrElse
       ComboBox3.SelectedItem Is Nothing OrElse
       ComboBox5.SelectedItem Is Nothing Then
            MessageBox.Show("Please select all required fields (Room, PC Number, and Duration).")
            Return
        End If

        Try
            Dim fullname As String = Form1.FullName
            Dim department As String = Form1.p_dept
            Dim reservation_type As String = Form1.restype
            Dim reason As String = Form1.p_reason
            Dim room_number As String = ComboBox2.SelectedItem.ToString()
            Dim pc_number As String = ComboBox3.SelectedItem.ToString() ' Changed to String to match DB helper
            Dim duration As Integer = ComboBox5.SelectedIndex ' Store index for database
            Dim durationText As String = ComboBox5.SelectedItem.ToString() ' Store text for display
            Dim ticketDate As DateTime = DateTime.Now
            Dim ticketId As String = GenerateUniqueTicketId()
            Dim section As String = ComboBox3.SelectedItem.ToString()

            Dim db As New dbhelper()
            Dim success As Boolean = db.InsertTeacherReservation(
            ticketId,
            fullname,
            department,
            reservation_type,
            reason,
            room_number,
            pc_number,
            duration,  ' Pass the index for database storage
            section
        )

            If success Then
                MessageBox.Show("Teacher reservation added successfully!")
                Me.Hide()
                Dim profTick As New prof_ticket With {
                .FullName = fullname,
                .p_dept = department,
                .restype = reservation_type,
                .p_reason = reason,
                .p_labNo = room_number,
                .p_pcnum = pc_number,
                .p_Duration = durationText,  ' Pass the actual time text for display
                .TicketDate = ticketDate,
                .TicketId = ticketId
            }
                profTick.ShowDialog()
            Else
                MessageBox.Show("Failed to add teacher reservation.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error processing reservation: " & ex.Message)
        End Try
    End Sub

    Private Function GenerateUniqueTicketId() As String
        Dim ticketId As String = String.Empty
        Dim isUnique As Boolean = False
        Dim random As New Random()

        While Not isUnique
            Try
                ' Random generation for ticket ID
                ticketId = random.Next(100000, 999999).ToString()

                ' Check both tables for unique ticket ID
                Dim connectionString As String = "Server=localhost;Database=labpass;Uid=root;Pwd=;"
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Check user_reservation table
                    Using checkCommand1 As New MySqlCommand(
                    "SELECT COUNT(*) FROM user_reservation WHERE ticket_id = @ticketId",
                    connection)

                        checkCommand1.Parameters.AddWithValue("@ticketId", ticketId)
                        Dim count1 As Integer = Convert.ToInt32(checkCommand1.ExecuteScalar())

                        ' Check teacher_reservation table
                        Using checkCommand2 As New MySqlCommand(
                        "SELECT COUNT(*) FROM teacher_reservation WHERE ticket_id = @ticketId",
                        connection)

                            checkCommand2.Parameters.AddWithValue("@ticketId", ticketId)
                            Dim count2 As Integer = Convert.ToInt32(checkCommand2.ExecuteScalar())

                            ' ID is unique if it doesn't exist in either table
                            isUnique = (count1 = 0 AndAlso count2 = 0)
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error checking ticket ID uniqueness: " & ex.Message)
                Return DateTime.Now.Ticks.ToString() ' Fallback unique ID if database check fails
            End Try
        End While

        Return ticketId
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim prof_single As New prof_info1
        prof_info1.ShowDialog()
    End Sub
    Private Sub prof_single_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class