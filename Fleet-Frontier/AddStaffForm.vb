Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AddStaffForm


    Private Sub AddStaffCloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub StaffClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = ""
        PhoneNumberTextBox.Text = ""
        TypeComboBox.SelectedIndex = -1
        TypeComboBox.Text = ""
        AvailabilityTextBox.Text = ""
    End Sub
End Class