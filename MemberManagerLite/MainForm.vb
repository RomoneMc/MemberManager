Public Class MainForm
    Property PID As Integer

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PersonTableAdapter.Fill(Me.ContactLiteDataSet.Person)
        lblMemberCount.Text = (PersonDataGridView.RowCount - 1).ToString() + " Member(s)"

        BirthdaySource.Filter = "DOB >= #" + DateTime.Today + "# AND DOB <= #" + DateTime.Today.AddDays(7) + "#"
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        Dim filter As String = "'%" + txtFilter.Text + "%'"
        PersonBindingSource.Filter = "[First Name] like " & filter & " OR [Last Name] like " & filter & " OR [Address] like " & filter
    End Sub

    Private Sub dgvMembers_SelectionChanged(sender As Object, e As EventArgs) Handles PersonDataGridView.SelectionChanged
        Try
            PID = Integer.Parse(PersonDataGridView.Item("PersonID", PersonDataGridView.CurrentRow.Index).Value)
            LoadRelations()
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
        If PersonDataGridView.SelectedCells.Count = 0 Then
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
            PersonDataGridView.Item("MemberImage", PersonDataGridView.CurrentRow.Index).Value = ofdFindPicture.FileName
        End If
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

    Private Sub btnNewRelation_Click(sender As Object, e As EventArgs) Handles btnNewRelation.Click
        Dim f As Relations = New Relations(PID)
        f.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.PersonTableAdapter.Fill(Me.ContactLiteDataSet.Person)
    End Sub
End Class