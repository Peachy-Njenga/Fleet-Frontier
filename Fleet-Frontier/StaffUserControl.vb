Public Class StaffUserControl
    Private Sub AddStaffButton_Click(sender As Object, e As EventArgs) Handles AddStaffButton.Click
        Dim formIsOpen As Boolean = False
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is AddStaffForm Then 'Form1 with the name of your form
                formIsOpen = True
                frm.BringToFront()
                Exit For
            End If
        Next

        ' If the form is not open, create and show it
        If Not formIsOpen Then
            Dim newForm As New AddStaffForm()
            newForm.Show()
        End If
    End Sub
End Class
