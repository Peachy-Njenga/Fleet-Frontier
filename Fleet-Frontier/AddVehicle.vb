Imports MySql.Data.MySqlClient

Public Class AddVehicle
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim ConnectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"
        conn = New MySqlConnection(ConnectionString)

        Try
            conn.Open()
            Dim insertQuery As String = "INSERT INTO vehicle (numberPlate, `fuel_cost/km`, is_available, created_at) VALUES (@plate, @fuel, @availability, @time)"
            command = New MySqlCommand(insertQuery, conn)
            command.Parameters.AddWithValue("@plate", NumberPlateTextBox.Text)
            command.Parameters.AddWithValue("@fuel", FuelTextBox.Text)
            command.Parameters.AddWithValue("@availability", AvailabilityTextBox.Text)

            ' Convert DateTimePicker value to MySQL date format
            Dim formattedDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
            command.Parameters.AddWithValue("@time", formattedDate)

            command.ExecuteNonQuery()
            MessageBox.Show("Vehicle Created Successfully!!!")
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub VehicleClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NumberPlateTextBox.Text = ""
        FuelTextBox.Text = ""
        AvailabilityTextBox.Text = ""
    End Sub
End Class
