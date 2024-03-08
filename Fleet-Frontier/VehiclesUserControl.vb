Public Class VehiclesUserControl
    ' Declare a shared variable to store the reference to the opened form
    Public openedAddVehicleForm As AddVehicle = Nothing
    Private Sub AddVehicleButton_Click(sender As Object, e As EventArgs) Handles AddVehicleButton.Click
        ' Check if the form is already open and not disposed
        If openedAddVehicleForm IsNot Nothing AndAlso Not openedAddVehicleForm.IsDisposed Then
            ' If open, bring the existing form to the front
            openedAddVehicleForm.BringToFront()
        Else
            ' If not open, create a new instance of the form
            openedAddVehicleForm = New AddVehicle()
            openedAddVehicleForm.Show()
        End If
    End Sub

End Class
