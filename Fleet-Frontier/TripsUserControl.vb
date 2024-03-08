Public Class TripsUserControl
    ' Declare a shared variable to store the reference to the opened form
    Public openedCreateTripForm As CreateTrip = Nothing

    Private Sub AddTripsButton_Click(sender As Object, e As EventArgs) Handles AddTripsButton.Click
        ' Check if the form is already open and not disposed
        If openedCreateTripForm IsNot Nothing AndAlso Not openedCreateTripForm.IsDisposed Then
            ' If open, bring the existing form to the front
            openedCreateTripForm.BringToFront()
        Else
            ' If not open, create a new instance of the form
            openedCreateTripForm = New CreateTrip()
            openedCreateTripForm.Show()
        End If

    End Sub
End Class
