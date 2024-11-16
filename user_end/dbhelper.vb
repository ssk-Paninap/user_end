Imports MySql.Data.MySqlClient

Public Class dbhelper
    Private ReadOnly connectionString As String = "Server=localhost;Database=labpass;Uid=root;Pwd=;"

    ' Function to check if a room/PC is already reserved
    Private Function IsTimeSlotAvailable(connection As MySqlConnection, roomNumber As String, pcNumber As String, duration As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM teacher_reservation " &
                            "WHERE room_number = @room_number AND " &
                            "pc_number = @pc_number AND " &
                            "duration = @duration AND " &
                            "DATE(reservation_date) = CURDATE()"

        Using cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@room_number", roomNumber)
            cmd.Parameters.AddWithValue("@pc_number", pcNumber)
            cmd.Parameters.AddWithValue("@duration", duration)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count = 0
        End Using
    End Function

    ' Student reservation function
    Public Function InsertReservation(student_id As String, fullname As String,
                                    year_lvl As Integer, course As Integer,
                                    reason As String, duration As Integer,
                                    pc_number As Integer, lab_number As Integer,
                                    ticket_id As String) As Boolean
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Check if the PC is available
                If Not IsTimeSlotAvailable(connection, lab_number.ToString(), pc_number.ToString(), duration) Then
                    MessageBox.Show("This PC is already reserved for the selected time slot.")
                    Return False
                End If

                ' SQL command with correctly matched parameter names
                Dim query As String = "INSERT INTO user_reservation " &
                                    "(ticket_id, student_id, fullname, year_lvl, course, " &
                                    "reason, duration, pc_number, lab_number, reservation_date) " &
                                    "VALUES (@ticket_id, @student_id, @fullname, @year_lvl, " &
                                    "@course, @reason, @duration, @pc_number, @lab_number, @reservation_date)"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ticket_id", ticket_id)
                    command.Parameters.AddWithValue("@student_id", student_id)
                    command.Parameters.AddWithValue("@fullname", fullname)
                    command.Parameters.AddWithValue("@year_lvl", year_lvl)
                    command.Parameters.AddWithValue("@course", course)
                    command.Parameters.AddWithValue("@reason", reason)
                    command.Parameters.AddWithValue("@duration", duration)
                    command.Parameters.AddWithValue("@pc_number", pc_number)
                    command.Parameters.AddWithValue("@lab_number", lab_number)
                    command.Parameters.AddWithValue("@reservation_date", DateTime.Now)

                    command.ExecuteNonQuery()
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message & vbCrLf &
                              "Details: " & ex.ToString())
                Return False
            End Try
        End Using
    End Function

    ' Teacher reservation function
    Public Function InsertTeacherReservation(ticket_id As String, fullname As String,
                                           department As String, reservation_type As String,
                                           reason As String, room_number As String,
                                           pc_number As String, duration As Integer,
                                           section As String) As Boolean
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Check if the room/PC is available
                If Not IsTimeSlotAvailable(connection, room_number, pc_number, duration) Then
                    MessageBox.Show("This room/PC is already reserved for the selected time slot.")
                    Return False
                End If

                ' SQL command with correctly matched parameter names
                Dim query As String = "INSERT INTO teacher_reservation " &
                                    "(ticket_id, fullname, department, reservation_type, " &
                                    "reason, room_number, pc_number, duration, " &
                                    "reservation_date, section) " &
                                    "VALUES (@ticket_id, @fullname, @department, " &
                                    "@reservation_type, @reason, @room_number, " &
                                    "@pc_number, @duration, @reservation_date, @section)"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ticket_id", ticket_id)
                    command.Parameters.AddWithValue("@fullname", fullname)
                    command.Parameters.AddWithValue("@department", department)
                    command.Parameters.AddWithValue("@reservation_type", reservation_type)
                    command.Parameters.AddWithValue("@reason", reason)
                    command.Parameters.AddWithValue("@room_number", room_number)
                    command.Parameters.AddWithValue("@pc_number", pc_number)
                    command.Parameters.AddWithValue("@duration", duration)
                    command.Parameters.AddWithValue("@section", section)
                    command.Parameters.AddWithValue("@reservation_date", DateTime.Now)

                    command.ExecuteNonQuery()
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message & vbCrLf &
                              "Details: " & ex.ToString())
                Return False
            End Try
        End Using
    End Function
End Class