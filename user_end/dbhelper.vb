Imports MySql.Data.MySqlClient

Public Class dbhelper
    Private connectionString As String = "Server=localhost;Database=labpass;Uid=root;Pwd=;"

    Public Function InsertReservation(student_id As String, fullname As String, year_lvl As Integer, course As Integer, reason As String, duration As Integer, pc_number As Integer, lab_number As Integer, ticket_id As String) As Boolean
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                ' Updated SQL command to include ticket_id
                Dim command As New MySqlCommand("INSERT INTO user_reservation (user_id, student_id, fullname, year_lvl, course, reason, duration, pc_number, lab_number) VALUES (@ticket_id, @student_id, @fullname, @year_lvl, @course, @reason, @duration, @pc_number, @lab_number)", connection)

                ' Add the new parameter for ticket_id
                command.Parameters.AddWithValue("@user_id", ticket_id)
                command.Parameters.AddWithValue("@student_id", student_id)
                command.Parameters.AddWithValue("@fullname", fullname)
                command.Parameters.AddWithValue("@year_lvl", year_lvl)
                command.Parameters.AddWithValue("@course", course)
                command.Parameters.AddWithValue("@reason", reason)
                command.Parameters.AddWithValue("@duration", duration)
                command.Parameters.AddWithValue("@pc_number", pc_number)
                command.Parameters.AddWithValue("@lab_number", lab_number)

                command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function InsertTeacherReservation(fullname As String, department As String, reservation_type As String, reason As String, room_number As String, pc_number As String, duration As Integer) As Boolean
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                ' SQL command to insert a new teacher reservation
                Dim command As New MySqlCommand("INSERT INTO teacher_reservation (fullname, department, reservation_type, reason, room_number, pc_number, duration, reservation_date) VALUES (@fullname, @department, @reservation_type, @reason, @room_number, @pc_number, @duration, @reservation_date)", connection)

                ' Add parameters for the teacher reservation
                command.Parameters.AddWithValue("@fullname", fullname)
                command.Parameters.AddWithValue("@department", department)
                command.Parameters.AddWithValue("@reservation_type", reservation_type)
                command.Parameters.AddWithValue("@reason", reason)
                command.Parameters.AddWithValue("@room_number", room_number)
                command.Parameters.AddWithValue("@pc_number", pc_number)
                command.Parameters.AddWithValue("@duration", duration)

                ' Add current timestamp for reservation_date
                command.Parameters.AddWithValue("@reservation_date", DateTime.Now)

                command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function
End Class
