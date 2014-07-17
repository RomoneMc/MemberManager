Imports System.Windows.Forms

Public Class NewNumber
    Property PID

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            PersonTelephoneBindingSource.EndEdit()
            Person_TelephoneTableAdapter.Update(ContactLiteDataSet.Person_Telephone)
            ContactLiteDataSet.AcceptChanges()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub NewNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.PersonTableAdapter.Fill(Me.ContactLiteDataSet.Person)
            Me.Person_TelephoneTableAdapter.Fill(Me.ContactLiteDataSet.Person_Telephone)
            cbxMembers.SelectedIndex = 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbxMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMembers.SelectedIndexChanged
        Try
            PID = cbxMembers.SelectedValue
            Dim query As String = "'" & PID & "'"

            PersonTelephoneBindingSource.Filter = "PersonID = " + query
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvNumbers_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgvNumbers.UserAddedRow
        dgvNumbers.Item("PersonID", dgvNumbers.RowCount - 1).Value = PID
    End Sub

    Private Sub btnNewNumber_Click_1(sender As Object, e As EventArgs) Handles btnNewNumber.Click
        PersonTelephoneBindingSource.AddNew()
        dgvNumbers.Item("PersonID", dgvNumbers.RowCount - 1).Value = PID
    End Sub

    Private Sub dgvNumbers_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvNumbers.UserDeletingRow
        If MessageBox.Show("Are you sure you would like to remove this number?", "Remove Number", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            PersonTelephoneBindingSource.EndEdit()
            Person_TelephoneTableAdapter.Update(ContactLiteDataSet.Person_Telephone)
            ContactLiteDataSet.AcceptChanges()
        Else
            e.Cancel = True
        End If
    End Sub
End Class
