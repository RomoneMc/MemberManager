Public Class MainForm
    Property PID As Integer
    Dim filter As String
    Dim viewimage As Form = Nothing

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PersonTableAdapter.Fill(Me.ContactLiteDataSet.Person)
        dgvMembers.Focus()
        lblMemberCount.Text = (dgvMembers.RowCount - 1).ToString() + " Member(s)"

        BirthdaySource.Filter = "DOB >= #" + DateTime.Today + "# AND DOB <= #" + DateTime.Today.AddDays(7) + "#"
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        filter = "'%" + txtFilter.Text + "%'"
        PersonBindingSource.Filter = "[First Name] like " & filter & " OR [Last Name] like " & filter & " OR [Community] like " & filter
        lblMemberCount.Text = (dgvMembers.RowCount - 1).ToString() + " Member(s)"
    End Sub

    Private Sub dgvMembers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMembers.SelectionChanged
        Try
            PID = Integer.Parse(dgvMembers.Item("PersonalID", dgvMembers.CurrentRow.Index).Value)
            'LoadRelations()
            'LoadContactNumbers()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            PersonBindingSource.EndEdit()
            PersonTableAdapter.Update(ContactLiteDataSet.Person)
            ContactLiteDataSet.AcceptChanges()
        Catch ex As Exception
            MessageBox.Show("Could not save this member. Please try again." & vbNewLine & " More Information: " & ex.Message)
        End Try

        Me.PersonTableAdapter.Fill(Me.ContactLiteDataSet.Person)
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportOptions.ShowDialog()
    End Sub

    Private Sub btnDeleteMember_Click(sender As Object, e As EventArgs) Handles btnDeleteMember.Click
        If dgvMembers.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a member first.", "No Member Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to remove this member?", "Remove Member", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Try
                PersonTableAdapter.Delete(PID)
                Me.PersonTableAdapter.Fill(Me.ContactLiteDataSet.Person)
            Catch ex As Exception
                MessageBox.Show("Could not remove this member." & vbNewLine & "Reason " & ex.Message, "Remove Member Failed", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try
        End If
    End Sub

    Private Sub pbxMemberPicture_DoubleClick(sender As Object, e As EventArgs) Handles pbxMemberPicture.DoubleClick
        If ofdFindPicture.ShowDialog() = Windows.Forms.DialogResult.OK Then
            dgvMembers.Item("MemberImage", dgvMembers.CurrentRow.Index).Value = ofdFindPicture.FileName
        End If
    End Sub

    Sub LoadContactNumbers()
        lbxNumbers.Items.Clear()

        Try
            Dim dt As ContactLiteDataSet.Person_TelephoneDataTable = Person_TelephoneTableAdapter.GetNumbers(PID)

            For index = 0 To dt.Count - 1
                lbxNumbers.Items.Add(dt(index).Item("Numbers"))
            Next
        Catch ex As Exception

        End Try
    End Sub

    Sub LoadRelations()
        lbxRelations.Items.Clear()

        Try
            Dim dt As ContactLiteDataSet.Person_RelationDataTable = Person_RelationTableAdapter.GetRelations(PID)

            For index = 0 To Person_RelationTableAdapter.GetRelations(PID).Count - 1
                lbxRelations.Items.Add(dt(index).Item("Relation Name"))
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNewRelation_Click(sender As Object, e As EventArgs)
        Dim f As Relations = New Relations(PID)
        f.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.PersonTableAdapter.Fill(Me.ContactLiteDataSet.Person)
        Me.Person_RelationTableAdapter.Fill(Me.ContactLiteDataSet.Person_Relation)
        Me.Person_TelephoneTableAdapter.Fill(Me.ContactLiteDataSet.Person_Telephone)
        lblMemberCount.Text = (dgvMembers.RowCount - 1).ToString() + " Member(s)"
    End Sub

    Private Sub btnNewNumber_Click(sender As Object, e As EventArgs)
        NewNumber.ShowDialog()
    End Sub

    Private Sub dgvMembers_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgvMembers.UserAddedRow
        lblMemberCount.Text = (dgvMembers.RowCount - 1).ToString() + " Member(s)"
    End Sub

    Private Sub dgvMembers_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgvMembers.UserDeletedRow
        lblMemberCount.Text = (dgvMembers.RowCount - 1).ToString() + " Member(s)"
    End Sub

    Private Sub LoadRelationships_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadRelationships.DoWork

    End Sub

    Private Sub pbxMemberPicture_Click(sender As Object, e As EventArgs) Handles pbxMemberPicture.Click
        If IsNothing(viewimage) Then
            viewimage = New MemberManagerLite.ViewImage(pbxMemberPicture.ImageLocation)
            viewimage.Show()
        Else
            viewimage.Close()
            viewimage = New MemberManagerLite.ViewImage(pbxMemberPicture.ImageLocation)
            viewimage.Show()
        End If
    End Sub
End Class