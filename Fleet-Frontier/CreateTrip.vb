Public Class CreateTrip
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        FromComboBox.SelectedIndex = -1
        FromComboBox.Text = ""
        ToComboBox.SelectedIndex = -1
        ToComboBox.Text = ""
        VehicleComboBox.SelectedIndex = -1
        VehicleComboBox.Text = ""
        DriverComboBox.SelectedIndex = -1
        DriverComboBox.Text = ""
        ConductorComboBox.SelectedIndex = -1
        ConductorComboBox.Text = ""
    End Sub
End Class