<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewNumber
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.dgvNumbers = New System.Windows.Forms.DataGridView()
        Me.PersonTelephoneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactLiteDataSet = New MemberManagerLite.ContactLiteDataSet()
        Me.Person_TelephoneTableAdapter = New MemberManagerLite.ContactLiteDataSetTableAdapters.Person_TelephoneTableAdapter()
        Me.cbxMembers = New System.Windows.Forms.ComboBox()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonTableAdapter = New MemberManagerLite.ContactLiteDataSetTableAdapters.PersonTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNewNumber = New System.Windows.Forms.Button()
        Me.NumberIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvNumbers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonTelephoneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactLiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(264, 310)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(231, 38)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(109, 30)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Save"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(118, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(110, 30)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Close"
        '
        'dgvNumbers
        '
        Me.dgvNumbers.AllowUserToAddRows = False
        Me.dgvNumbers.AllowUserToResizeRows = False
        Me.dgvNumbers.AutoGenerateColumns = False
        Me.dgvNumbers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNumbers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvNumbers.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvNumbers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvNumbers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNumbers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumberIDDataGridViewTextBoxColumn, Me.PersonID, Me.NumberType, Me.PhoneNumber})
        Me.dgvNumbers.DataSource = Me.PersonTelephoneBindingSource
        Me.dgvNumbers.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvNumbers.Location = New System.Drawing.Point(12, 50)
        Me.dgvNumbers.Name = "dgvNumbers"
        Me.dgvNumbers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dgvNumbers.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNumbers.Size = New System.Drawing.Size(483, 253)
        Me.dgvNumbers.TabIndex = 1
        '
        'PersonTelephoneBindingSource
        '
        Me.PersonTelephoneBindingSource.DataMember = "Person_Telephone"
        Me.PersonTelephoneBindingSource.DataSource = Me.ContactLiteDataSet
        '
        'ContactLiteDataSet
        '
        Me.ContactLiteDataSet.DataSetName = "ContactLiteDataSet"
        Me.ContactLiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Person_TelephoneTableAdapter
        '
        Me.Person_TelephoneTableAdapter.ClearBeforeFill = True
        '
        'cbxMembers
        '
        Me.cbxMembers.DataSource = Me.PersonBindingSource
        Me.cbxMembers.DisplayMember = "First Name"
        Me.cbxMembers.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.cbxMembers.FormattingEnabled = True
        Me.cbxMembers.Location = New System.Drawing.Point(12, 12)
        Me.cbxMembers.Name = "cbxMembers"
        Me.cbxMembers.Size = New System.Drawing.Size(262, 33)
        Me.cbxMembers.TabIndex = 2
        Me.cbxMembers.ValueMember = "PersonID"
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me.ContactLiteDataSet
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Last Name", True))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(280, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'btnNewNumber
        '
        Me.btnNewNumber.Location = New System.Drawing.Point(13, 314)
        Me.btnNewNumber.Name = "btnNewNumber"
        Me.btnNewNumber.Size = New System.Drawing.Size(100, 30)
        Me.btnNewNumber.TabIndex = 4
        Me.btnNewNumber.Text = "New"
        Me.btnNewNumber.UseVisualStyleBackColor = True
        '
        'NumberIDDataGridViewTextBoxColumn
        '
        Me.NumberIDDataGridViewTextBoxColumn.DataPropertyName = "NumberID"
        Me.NumberIDDataGridViewTextBoxColumn.HeaderText = "NumberID"
        Me.NumberIDDataGridViewTextBoxColumn.Name = "NumberIDDataGridViewTextBoxColumn"
        Me.NumberIDDataGridViewTextBoxColumn.Visible = False
        '
        'PersonID
        '
        Me.PersonID.DataPropertyName = "PersonID"
        Me.PersonID.HeaderText = "PersonID"
        Me.PersonID.Name = "PersonID"
        Me.PersonID.Visible = False
        '
        'NumberType
        '
        Me.NumberType.DataPropertyName = "Number Type"
        Me.NumberType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.NumberType.HeaderText = "Number Type"
        Me.NumberType.Items.AddRange(New Object() {"Mobile", "Landline", "International", "Postpaid", "LIME", "Digicel"})
        Me.NumberType.Name = "NumberType"
        Me.NumberType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NumberType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'PhoneNumber
        '
        Me.PhoneNumber.DataPropertyName = "Phone Number"
        Me.PhoneNumber.HeaderText = "Phone Number"
        Me.PhoneNumber.Name = "PhoneNumber"
        '
        'NewNumber
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MemberManagerLite.My.Resources.Resources.pixel_weave
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(507, 361)
        Me.Controls.Add(Me.btnNewNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxMembers)
        Me.Controls.Add(Me.dgvNumbers)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewNumber"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Number"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvNumbers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonTelephoneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactLiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents dgvNumbers As System.Windows.Forms.DataGridView
    Friend WithEvents ContactLiteDataSet As MemberManagerLite.ContactLiteDataSet
    Friend WithEvents PersonTelephoneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Person_TelephoneTableAdapter As MemberManagerLite.ContactLiteDataSetTableAdapters.Person_TelephoneTableAdapter
    Friend WithEvents cbxMembers As System.Windows.Forms.ComboBox
    Friend WithEvents PersonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonTableAdapter As MemberManagerLite.ContactLiteDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNewNumber As System.Windows.Forms.Button
    Friend WithEvents NumberIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersonID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PhoneNumber As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
