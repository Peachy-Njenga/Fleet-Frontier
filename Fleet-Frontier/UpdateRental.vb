Public Class UpdateRental
    Private Sub UpdateRentalButton_Click(sender As Object, e As EventArgs) Handles UpdateRentalButton.Click
        CustomerNameTextBox.Text = ""
        VehicleComboBox.SelectedIndex = -1
        VehicleComboBox.Text = ""

        CustomerNameTextBox.Focus()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        CustomerNameTextBox.Text = ""
        VehicleComboBox.SelectedIndex = -1
        VehicleComboBox.Text = ""
    End Sub

    Private Sub CancelRentalButton_Click(sender As Object, e As EventArgs) Handles CancelRentalButton.Click
        Me.Close()

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub
End Class