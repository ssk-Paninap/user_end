Imports MySql.Data.MySqlClient

Public Class dbhelper
    Private connectionString As String = "Server=localhost;Database=labpass;Uid=root;Pwd=;"

    Public Function InsertReservation(student_id As String, fullname As String, year_lvl As Integer, course As Integer, reason As String, duration As Integer, pc_number As Integer, lab_number As Integer) As Boolean
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim command As New MySqlCommand("INSERT INTO user_reservation (student_id, fullname, year_lvl, course, reason, duration, pc_number, lab_number) VALUES (@student_id, @fullname, @year_lvl, @course, @reason, @duration, @pc_number, @lab_number)", connection)

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
End Class
