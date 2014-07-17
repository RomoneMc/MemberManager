Imports System.Windows.Forms

Public Class Relations
    Dim PID As Integer
    Dim Pname As String

    Sub New(id As Integer)
        InitializeComponent()
        PID = id
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Relations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshSources()

        RelationListBox.DataSource = PersonTableAdapter.GetNamesByRelations(cbxRelations.SelectedValue)
        lbxNonAttendants.DataSource = PersonTableAdapter.GetNonMembers(cbxRelations.SelectedValue)
    End Sub

    Private Sub btnSaveRelation_Click(sender As Object, e As EventArgs) Handles btnSaveRelation.Click
        RelationBindingSource.EndEdit()
        RelationTableAdapter.Update(ContactLiteDataSet.Relation)
        ContactLiteDataSet.AcceptChanges()

        RefreshSources()
        LoadListboxes()
    End Sub

    Private Sub btnNewRelation_Click(sender As Object, e As EventArgs) Handles btnNewRelation.Click
        RelationBindingSource.AddNew()
    End Sub

    Private Sub btnSaveAssignment_Click(sender As Object, e As EventArgs) Handles btnSaveAssignment.Click
        Try
            Person_RelationTableAdapter.Insert(cbxRelations.SelectedValue, lbxNonAttendants.SelectedValue, txtRelationRole.Text)

            RefreshSources()
            LoadListboxes()
        Catch ex As Exception

        End Try

        txtRelationRole.Text = String.Empty
    End Sub

    Private Sub cbxRelations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRelations.SelectedIndexChanged
        LoadListboxes()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        RelationBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        RelationBindingSource.MovePrevious()
    End Sub

    Sub LoadListboxes()
        RelationListBox.DataSource = PersonTableAdapter.GetNamesByRelations(cbxRelations.SelectedValue)
        lbxNonAttendants.DataSource = PersonTableAdapter.GetNonMembers(cbxRelations.SelectedValue)
    End Sub

    Sub RefreshSources()
        Me.PersonTableAdapter.Fill(Me.ContactLiteDataSet.Person)
        Me.RelationTableAdapter.Fill(Me.ContactLiteDataSet.Relation)
        Me.Person_RelationTableAdapter.Fill(Me.ContactLiteDataSet.Person_Relation)
    End Sub

    Private Sub btnRemoveRelation_Click(sender As Object, e As EventArgs) Handles btnRemoveRelation.Click
        If MessageBox.Show("Are you sure you would like to remove this relationship?", "Remove Relationship", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Try
                RelationTableAdapter.Delete(txtRelationID.Text)

                RelationTableAdapter.Update(ContactLiteDataSet.Relation)
                ContactLiteDataSet.AcceptChanges()

                RefreshSources()
                LoadListboxes()
            Catch ex As Exception
                MessageBox.Show("Could not remove relationship." & vbNewLine & "Reason: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnRemovePerson_Click(sender As Object, e As EventArgs) Handles btnRemovePerson.Click
        If MessageBox.Show("Are you sure you would like to remove this person from the relationship/group?", "Remove from Relationship/Group", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Try
                Person_RelationTableAdapter.Delete(RelationListBox.SelectedValue)
                RelationTableAdapter.Update(ContactLiteDataSet.Relation)
                ContactLiteDataSet.AcceptChanges()

                RefreshSources()
                LoadListboxes()
            Catch ex As Exception
                MessageBox.Show("Could not remove person from this relationship or group." & vbNewLine & "Reason: " & ex.Message, "Remove Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class