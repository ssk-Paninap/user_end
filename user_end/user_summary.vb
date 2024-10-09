Imports System.Data.SqlClient ' Import the required namespace for SQL

Public Class user_summary
    Private Sub user_summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load year levels into ComboBox1
        ComboBox1.Items.Add("First Year")
        ComboBox1.Items.Add("Second Year")
        ComboBox1.Items.Add("Third Year")
        ComboBox1.Items.Add("Fourth Year")

        ' Load course options into ComboBox2 
        ComboBox2.Items.Add("Course 1")
        ComboBox2.Items.Add("Course 2")
        ComboBox2.Items.Add("Course 3")

        ' Load PC numbers into ComboBox3 
        ComboBox3.Items.Add("PC 1")
        ComboBox3.Items.Add("PC 2")
        ComboBox3.Items.Add("PC 3")

        ' Load room numbers into ComboBox4 
        ComboBox4.Items.Add("Room A")
        ComboBox4.Items.Add("Room B")
        ComboBox4.Items.Add("Room C")

        ' Populate text boxes with the data from shared variables
        TextBox1.Text = Form1.FullName
        ComboBox1.SelectedIndex = Form1.YearLevel - 1
        ComboBox2.SelectedIndex = Form1.Course ' 
        TextBox2.Text = Form1.Reason ' 
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim user_info As New Form2
        user_info.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim studentId As String = Form1.StudentID
        Dim fullname As String = TextBox1.Text
        Dim yearLevel As Integer = ComboBox1.SelectedIndex + 1
        Dim course As Integer = ComboBox2.SelectedIndex
        Dim reason As String = TextBox2.Text
        Dim duration As Integer = Integer.Parse(TextBox3.Text)
        Dim pcNumber As Integer = ComboBox3.SelectedIndex + 1
        Dim labNumber As Integer = ComboBox4.SelectedIndex + 1

        ' Database connection and insertion
        Dim connectionString As String = "Server=localhost;Database=labpass;Uid=root;Pwd=;"
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("INSERT INTO user_reservation (student_id, fullname, year_lvl, course, reason, duration, pc_number, lab_number, ticket_date) VALUES (@studentId, @fullname, @yearLevel, @course, @reason, @duration, @pcNumber, @labNumber, @ticketDate)", connection)
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

        Me.Hide()
        Dim genTick As New generated_ticket
        genTick.ShowDialog()
    End Sub

End Class
