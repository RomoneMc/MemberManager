<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Relations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNewRelation = New System.Windows.Forms.Button()
        Me.btnSaveRelation = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RelationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactLiteDataSet = New MemberManagerLite.ContactLiteDataSet()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RelationTableAdapter = New MemberManagerLite.ContactLiteDataSetTableAdapters.RelationTableAdapter()
        Me.Person_RelationTableAdapter = New MemberManagerLite.ContactLiteDataSetTableAdapters.Person_RelationTableAdapter()
        Me.tcRelationships = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbxNonAttendants = New System.Windows.Forms.ListBox()
        Me.cbxRelations = New System.Windows.Forms.ComboBox()
        Me.RelationListBox = New System.Windows.Forms.ListBox()
        Me.btnRemovePerson = New System.Windows.Forms.Button()
        Me.btnSaveAssignment = New System.Windows.Forms.Button()
        Me.txtRelationRole = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRemoveRelation = New System.Windows.Forms.Button()
        Me.txtRelationID = New System.Windows.Forms.TextBox()
        Me.PersonRelationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonTableAdapter = New MemberManagerLite.ContactLiteDataSetTableAdapters.PersonTableAdapter()
        Me.bgLoadSources = New System.ComponentModel.BackgroundWorker()
        CType(Me.RelationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactLiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcRelationships.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PersonRelationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(390, 452)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(105, 38)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Close"
        '
        'btnNext
        '
        Me.btnNext.Image = Global.MemberManagerLite.My.Resources.Resources.appbar_navigate_next
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNext.Location = New System.Drawing.Point(273, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(61, 33)
        Me.btnNext.TabIndex = 2
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Image = Global.MemberManagerLite.My.Resources.Resources.appbar_navigate_previous
        Me.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrevious.Location = New System.Drawing.Point(213, 3)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(61, 33)
        Me.btnPrevious.TabIndex = 2
        Me.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNewRelation
        '
        Me.btnNewRelation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNewRelation.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNewRelation.Location = New System.Drawing.Point(5, 3)
        Me.btnNewRelation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNewRelation.Name = "btnNewRelation"
        Me.btnNewRelation.Size = New System.Drawing.Size(77, 33)
        Me.btnNewRelation.TabIndex = 0
        Me.btnNewRelation.Text = "New"
        '
        'btnSaveRelation
        '
        Me.btnSaveRelation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSaveRelation.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSaveRelation.Location = New System.Drawing.Point(381, 3)
        Me.btnSaveRelation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveRelation.Name = "btnSaveRelation"
        Me.btnSaveRelation.Size = New System.Drawing.Size(93, 33)
        Me.btnSaveRelation.TabIndex = 0
        Me.btnSaveRelation.Text = "Save"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RelationBindingSource, "Relation Name", True))
        Me.TextBox2.Location = New System.Drawing.Point(148, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(272, 27)
        Me.TextBox2.TabIndex = 1
        '
        'RelationBindingSource
        '
        Me.RelationBindingSource.DataMember = "Relation"
        Me.RelationBindingSource.DataSource = Me.ContactLiteDataSet
        '
        'ContactLiteDataSet
        '
        Me.ContactLiteDataSet.DataSetName = "ContactLiteDataSet"
        Me.ContactLiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteCustomSource.AddRange(New String() {"Family", "Choir", "Group"})
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RelationBindingSource, "Relation Type", True))
        Me.TextBox1.Location = New System.Drawing.Point(148, 136)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 27)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(39, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Relation Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(31, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Relation Name:"
        '
        'RelationTableAdapter
        '
        Me.RelationTableAdapter.ClearBeforeFill = True
        '
        'Person_RelationTableAdapter
        '
        Me.Person_RelationTableAdapter.ClearBeforeFill = True
        '
        'tcRelationships
        '
        Me.tcRelationships.Controls.Add(Me.TabPage1)
        Me.tcRelationships.Controls.Add(Me.TabPage2)
        Me.tcRelationships.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.tcRelationships.Location = New System.Drawing.Point(12, 12)
        Me.tcRelationships.Name = "tcRelationships"
        Me.tcRelationships.SelectedIndex = 0
        Me.tcRelationships.Size = New System.Drawing.Size(487, 433)
        Me.tcRelationships.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.BackgroundImage = Global.MemberManagerLite.My.Resources.Resources.tiny_grid
        Me.TabPage1.Controls.Add(Me.lbxNonAttendants)
        Me.TabPage1.Controls.Add(Me.cbxRelations)
        Me.TabPage1.Controls.Add(Me.RelationListBox)
        Me.TabPage1.Controls.Add(Me.btnRemovePerson)
        Me.TabPage1.Controls.Add(Me.btnSaveAssignment)
        Me.TabPage1.Controls.Add(Me.txtRelationRole)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(479, 400)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Manage Members"
        '
        'lbxNonAttendants
        '
        Me.lbxNonAttendants.DisplayMember = "Name"
        Me.lbxNonAttendants.FormattingEnabled = True
        Me.lbxNonAttendants.ItemHeight = 20
        Me.lbxNonAttendants.Location = New System.Drawing.Point(13, 11)
        Me.lbxNonAttendants.Name = "lbxNonAttendants"
        Me.lbxNonAttendants.Size = New System.Drawing.Size(201, 304)
        Me.lbxNonAttendants.TabIndex = 1
        Me.lbxNonAttendants.ValueMember = "PersonID"
        '
        'cbxRelations
        '
        Me.cbxRelations.DataSource = Me.RelationBindingSource
        Me.cbxRelations.DisplayMember = "Relation Name"
        Me.cbxRelations.FormattingEnabled = True
        Me.cbxRelations.Location = New System.Drawing.Point(220, 11)
        Me.cbxRelations.Name = "cbxRelations"
        Me.cbxRelations.Size = New System.Drawing.Size(248, 28)
        Me.cbxRelations.TabIndex = 4
        Me.cbxRelations.ValueMember = "RelationID"
        '
        'RelationListBox
        '
        Me.RelationListBox.DisplayMember = "Name"
        Me.RelationListBox.FormattingEnabled = True
        Me.RelationListBox.ItemHeight = 20
        Me.RelationListBox.Location = New System.Drawing.Point(220, 51)
        Me.RelationListBox.Name = "RelationListBox"
        Me.RelationListBox.Size = New System.Drawing.Size(248, 264)
        Me.RelationListBox.TabIndex = 7
        Me.RelationListBox.ValueMember = "ID"
        '
        'btnRemovePerson
        '
        Me.btnRemovePerson.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRemovePerson.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRemovePerson.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnRemovePerson.Location = New System.Drawing.Point(334, 322)
        Me.btnRemovePerson.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemovePerson.Name = "btnRemovePerson"
        Me.btnRemovePerson.Size = New System.Drawing.Size(134, 28)
        Me.btnRemovePerson.TabIndex = 3
        Me.btnRemovePerson.Text = "Remove Relation"
        '
        'btnSaveAssignment
        '
        Me.btnSaveAssignment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSaveAssignment.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSaveAssignment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnSaveAssignment.Location = New System.Drawing.Point(114, 355)
        Me.btnSaveAssignment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveAssignment.Name = "btnSaveAssignment"
        Me.btnSaveAssignment.Size = New System.Drawing.Size(100, 30)
        Me.btnSaveAssignment.TabIndex = 3
        Me.btnSaveAssignment.Text = "Save"
        '
        'txtRelationRole
        '
        Me.txtRelationRole.Location = New System.Drawing.Point(57, 323)
        Me.txtRelationRole.Name = "txtRelationRole"
        Me.txtRelationRole.Size = New System.Drawing.Size(157, 27)
        Me.txtRelationRole.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Role:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.BackgroundImage = Global.MemberManagerLite.My.Resources.Resources.tiny_grid
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.txtRelationID)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(479, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "New Relationship"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnPrevious)
        Me.Panel1.Controls.Add(Me.btnRemoveRelation)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnNewRelation)
        Me.Panel1.Controls.Add(Me.btnSaveRelation)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 41)
        Me.Panel1.TabIndex = 4
        '
        'btnRemoveRelation
        '
        Me.btnRemoveRelation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRemoveRelation.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRemoveRelation.Location = New System.Drawing.Point(88, 3)
        Me.btnRemoveRelation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemoveRelation.Name = "btnRemoveRelation"
        Me.btnRemoveRelation.Size = New System.Drawing.Size(75, 33)
        Me.btnRemoveRelation.TabIndex = 0
        Me.btnRemoveRelation.Text = "Remove"
        '
        'txtRelationID
        '
        Me.txtRelationID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RelationBindingSource, "RelationID", True))
        Me.txtRelationID.Location = New System.Drawing.Point(148, 79)
        Me.txtRelationID.Name = "txtRelationID"
        Me.txtRelationID.Size = New System.Drawing.Size(126, 27)
        Me.txtRelationID.TabIndex = 3
        '
        'PersonRelationBindingSource
        '
        Me.PersonRelationBindingSource.DataMember = "Person_Relation"
        Me.PersonRelationBindingSource.DataSource = Me.ContactLiteDataSet
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'bgLoadSources
        '
        '
        'Relations
        '
        Me.AcceptButton = Me.btnSaveAssignment
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.MemberManagerLite.My.Resources.Resources.pixel_weave
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(509, 503)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.tcRelationships)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Relations"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Relations"
        CType(Me.RelationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactLiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcRelationships.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PersonRelationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSaveRelation As System.Windows.Forms.Button
    Friend WithEvents ContactLiteDataSet As MemberManagerLite.ContactLiteDataSet
    Friend WithEvents RelationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RelationTableAdapter As MemberManagerLite.ContactLiteDataSetTableAdapters.RelationTableAdapter
    Friend WithEvents PersonRelationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Person_RelationTableAdapter As MemberManagerLite.ContactLiteDataSetTableAdapters.Person_RelationTableAdapter
    Friend WithEvents btnNewRelation As System.Windows.Forms.Button
    Friend WithEvents tcRelationships As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents RelationListBox As System.Windows.Forms.ListBox
    Friend WithEvents btnSaveAssignment As System.Windows.Forms.Button
    Friend WithEvents txtRelationRole As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxRelations As System.Windows.Forms.ComboBox
    Friend WithEvents PersonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonTableAdapter As MemberManagerLite.ContactLiteDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents lbxNonAttendants As System.Windows.Forms.ListBox
    Friend WithEvents btnRemoveRelation As System.Windows.Forms.Button
    Friend WithEvents txtRelationID As System.Windows.Forms.TextBox
    Friend WithEvents btnRemovePerson As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bgLoadSources As System.ComponentModel.BackgroundWorker

End Class
