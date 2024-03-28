Public Class AddRentalForm

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearRentalButton.Click
        CustomerNameTextBox.Text = ""
        VehicleTextBox.Text = ""

    End Sub
    Private Sub CancelRentalButton_Click(sender As Object, e As EventArgs) Handles CancelRentalButton.Click
        Me.Close()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles ExitAddRentalButton.Click
        Me.Close()
    End Sub
End Class