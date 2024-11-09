Imports MySql.Data.MySqlClient
Public Class user_summary
    Private Sub user_summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'year levels  
        ComboBox1.Items.Add("First Year")
        ComboBox1.Items.Add("Second Year")
        ComboBox1.Items.Add("Third Year")
        ComboBox1.Items.Add("Fourth Year")

        ' Courses kulang pa
        ComboBox2.Items.Add("BSIT")
        ComboBox2.Items.Add("BSCS")
        ComboBox2.Items.Add("BSED")
        ComboBox2.Items.Add("BEED")
        ComboBox2.Items.Add("BSN")

        'PC numbers 
        ComboBox3.Items.Add("PC 1")
        ComboBox3.Items.Add("PC 2")
        ComboBox3.Items.Add("PC 3")
        ComboBox3.Items.Add("PC 4")
        ComboBox3.Items.Add("PC 5")
        ComboBox3.Items.Add("PC 6")
        ComboBox3.Items.Add("PC 7")
        ComboBox3.Items.Add("PC 8")
        ComboBox3.Items.Add("PC 9")
        ComboBox3.Items.Add("PC 10")
        ComboBox3.Items.Add("PC 11")
        ComboBox3.Items.Add("PC 12")

        'lab list wag burahin to wala ako panagalan ng var'
        ComboBox4.Items.Add("Lab 202")
        ComboBox4.Items.Add("Lab 203")
        ComboBox4.Items.Add("Lab 204")

        ComboBox5.Items.Add("Acads")
        ComboBox5.Items.Add("Research")
        ComboBox5.Items.Add("Online Class")
        ComboBox5.Items.Add("Project Building")

        ComboBox6.Items.Add("7:00 - 8:00")
        ComboBox6.Items.Add("8:00 - 9:00")
        ComboBox6.Items.Add("9:00 - 10:00")
        ComboBox6.Items.Add("10:00 - 11:00")
        ComboBox6.Items.Add("11:00 - 12:00")
        ComboBox6.Items.Add("12:00 - 13:00")
        ComboBox6.Items.Add("13:00 - 14:00")
        ComboBox6.Items.Add("14:00 - 15:00")
        ComboBox6.Items.Add("15:00 - 16:00")
        ComboBox6.Items.Add("16:00 - 17:00")

        Label1.Text = "Just to clarify " & Form1.FullName
        TextBox1.Text = Form1.StudentID
        ComboBox1.SelectedIndex = Form1.YearLevel - 1
        ComboBox2.SelectedIndex = Form1.Course
        ComboBox5.Text = Form1.reason
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim user_info As New Form2
        user_info.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim studentId As String = Form1.StudentID
        Dim fullname As String = Form1.FullName ' Assign FullName correctly here
        Dim yearLevel As Integer = ComboBox1.SelectedIndex + 1
        Dim course As String = ComboBox2.SelectedItem.ToString()
        Dim reason As String = ComboBox5.SelectedItem.ToString()
        Dim duration As Integer = Integer.Parse(ComboBox6.SelectedIndex)
        Dim pcNumber As String = ComboBox3.SelectedItem.ToString()
        Dim labNumber As String = ComboBox4.SelectedItem.ToString()

        Dim ticketId As String = GenerateUniqueTicketId()

        'DB CONNETION
        Dim connectionString As String = "Server=localhost;Database=labpass;Uid=root;Pwd=;"
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("INSERT INTO user_reservation (ticket_id, student_id, fullname, year_lvl, course, reason, duration, pc_number, lab_number, ticket_date) VALUES (@ticketId, @studentId, @fullname, @yearLevel, @course, @reason, @duration, @pcNumber, @labNumber, @ticketDate)", connection)
            command.Parameters.AddWithValue("@ticketId", ticketId)
            command.Parameters.AddWithValue("@studentId", studentId)
            command.Parameters.AddWithValue("@fullname", fullname)
            command.Parameters.AddWithValue("@yearLevel", yearLevel)
            command.Parameters.AddWithValue("@course", course)
            command.Parameters.AddWithValue("@reason", reason)
            command.Parameters.AddWithValue("@duration", duration)
            command.Parameters.AddWithValue("@pcNumber", pcNumber)
            command.Parameters.AddWithValue("@labNumber", labNumber)
            command.Parameters.AddWithValue("@ticketDate", DateTime.Now)

            Try
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Ticket generated successfully!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Dim genTick As New generated_ticket With {
        .StudentId = studentId,
        .FullName = fullname, ' Ensure FullName is passed here
        .YearLevel = yearLevel.ToString(),
        .Course = course,
        .Reason = reason,
        .Duration = duration,
        .PCNumber = pcNumber,
        .LabNumber = labNumber,
        .TicketDate = DateTime.Now,
        .TicketId = ticketId
    }   'values para sa generated ticket display

        Me.Hide()
        genTick.ShowDialog()
    End Sub

    Private Function GenerateUniqueTicketId() As String
        Dim ticketId As String = String.Empty
        Dim isUnique As Boolean = False
        Dim random As New Random()

        While Not isUnique
            'Random generation for ticker ID
            ticketId = random.Next(100000, 999999).ToString()

            ' check if there is a similar id sa DB
            Dim connectionString As String = "Server=localhost;Database=labpass;Uid=root;Pwd=;"
            Using connection As New MySqlConnection(connectionString)
                Dim checkCommand As New MySqlCommand("SELECT COUNT(*) FROM user_reservation WHERE ticket_id = @ticketId", connection)
                checkCommand.Parameters.AddWithValue("@ticketId", ticketId)

                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                    isUnique = (count = 0)
                Catch ex As Exception
                    MessageBox.Show("Error checking ticket ID uniqueness: " & ex.Message)
                End Try
            End Using
        End While

        Return ticketId
    End Function


    Private Sub personal_info1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class
