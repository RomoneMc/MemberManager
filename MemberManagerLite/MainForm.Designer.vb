<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblMemberCount = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDeleteMember = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactLiteDataSet = New MemberManagerLite.ContactLiteDataSet()
        Me.lblCommunity = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMemberRole = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMemberSince = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pbxMemberPicture = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvMembers = New System.Windows.Forms.DataGridView()
        Me.PersonalID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EmailAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreetColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommunityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberRole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberImage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberSince = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadRelationships = New System.ComponentModel.BackgroundWorker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ofdFindPicture = New System.Windows.Forms.OpenFileDialog()
        Me.dgvBirthdays = New System.Windows.Forms.DataGridView()
        Me.PersonIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdaySource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbxBirthdays = New System.Windows.Forms.GroupBox()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.PersonID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Street = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Community = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonTableAdapter = New MemberManagerLite.ContactLiteDataSetTableAdapters.PersonTableAdapter()
        Me.Person_RelationTableAdapter = New MemberManagerLite.ContactLiteDataSetTableAdapters.Person_RelationTableAdapter()
        Me.TableAdapterManager = New MemberManagerLite.ContactLiteDataSetTableAdapters.TableAdapterManager()
        Me.Person_TelephoneTableAdapter = New MemberManagerLite.ContactLiteDataSetTableAdapters.Person_TelephoneTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpBasic = New System.Windows.Forms.TabPage()
        Me.tbpMore = New System.Windows.Forms.TabPage()
        Me.btnNewRelation = New System.Windows.Forms.Button()
        Me.lbxRelations = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbxNumbers = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNewNumber = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactLiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMemberPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBirthdays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BirthdaySource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBirthdays.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tbpBasic.SuspendLayout()
        Me.tbpMore.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = Global.MemberManagerLite.My.Resources.Resources.pixel_weave
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.lblMemberCount)
        Me.Panel1.Controls.Add(Me.btnExport)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnDeleteMember)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.txtFilter)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 36)
        Me.Panel1.TabIndex = 3
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Image = Global.MemberManagerLite.My.Resources.Resources.logout_26
        Me.btnLogout.Location = New System.Drawing.Point(347, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(30, 32)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblMemberCount
        '
        Me.lblMemberCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMemberCount.AutoSize = True
        Me.lblMemberCount.BackColor = System.Drawing.Color.Transparent
        Me.lblMemberCount.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.lblMemberCount.Location = New System.Drawing.Point(682, 8)
        Me.lblMemberCount.Name = "lblMemberCount"
        Me.lblMemberCount.Size = New System.Drawing.Size(77, 18)
        Me.lblMemberCount.TabIndex = 2
        Me.lblMemberCount.Text = "Member(s)"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(264, 2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(81, 29)
        Me.btnExport.TabIndex = 4
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(177, 2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(81, 29)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnDeleteMember
        '
        Me.btnDeleteMember.Location = New System.Drawing.Point(90, 2)
        Me.btnDeleteMember.Name = "btnDeleteMember"
        Me.btnDeleteMember.Size = New System.Drawing.Size(81, 29)
        Me.btnDeleteMember.TabIndex = 4
        Me.btnDeleteMember.Text = "Remove"
        Me.btnDeleteMember.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 29)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilter.Location = New System.Drawing.Point(511, 4)
        Me.txtFilter.MaximumSize = New System.Drawing.Size(150, 25)
        Me.txtFilter.MinimumSize = New System.Drawing.Size(132, 25)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(143, 25)
        Me.txtFilter.TabIndex = 3
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Gender", True))
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblGender.Location = New System.Drawing.Point(144, 64)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(74, 20)
        Me.lblGender.TabIndex = 2
        Me.lblGender.Text = "lblGender"
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me.ContactLiteDataSet
        '
        'ContactLiteDataSet
        '
        Me.ContactLiteDataSet.DataSetName = "ContactLiteDataSet"
        Me.ContactLiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblCommunity
        '
        Me.lblCommunity.AutoSize = True
        Me.lblCommunity.BackColor = System.Drawing.Color.Transparent
        Me.lblCommunity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Community", True))
        Me.lblCommunity.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblCommunity.Location = New System.Drawing.Point(144, 123)
        Me.lblCommunity.Name = "lblCommunity"
        Me.lblCommunity.Size = New System.Drawing.Size(102, 20)
        Me.lblCommunity.TabIndex = 2
        Me.lblCommunity.Text = "lblCommunity"
        Me.lblCommunity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "DOB", True))
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label13.Location = New System.Drawing.Point(144, 150)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "lblDOB"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.BackColor = System.Drawing.Color.Transparent
        Me.lblOccupation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Company", True))
        Me.lblOccupation.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblOccupation.Location = New System.Drawing.Point(144, 178)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(89, 20)
        Me.lblOccupation.TabIndex = 2
        Me.lblOccupation.Text = "lblCompany"
        Me.lblOccupation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLastName
        '
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Last Name", True))
        Me.lblLastName.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(46, 165)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(291, 37)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Label2"
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblEmailAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Email Address", True))
        Me.lblEmailAddress.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblEmailAddress.Location = New System.Drawing.Point(144, 243)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(167, 49)
        Me.lblEmailAddress.TabIndex = 2
        Me.lblEmailAddress.Text = "lblEmail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(73, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Gender:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMemberRole
        '
        Me.lblMemberRole.AutoSize = True
        Me.lblMemberRole.BackColor = System.Drawing.Color.Transparent
        Me.lblMemberRole.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Member Role", True))
        Me.lblMemberRole.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblMemberRole.Location = New System.Drawing.Point(145, 300)
        Me.lblMemberRole.Name = "lblMemberRole"
        Me.lblMemberRole.Size = New System.Drawing.Size(112, 20)
        Me.lblMemberRole.TabIndex = 2
        Me.lblMemberRole.Text = "lblMemberRole"
        Me.lblMemberRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(46, 123)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 20)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Community:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(82, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Street:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMemberSince
        '
        Me.lblMemberSince.AutoSize = True
        Me.lblMemberSince.BackColor = System.Drawing.Color.Transparent
        Me.lblMemberSince.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Member Since", True))
        Me.lblMemberSince.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblMemberSince.Location = New System.Drawing.Point(145, 330)
        Me.lblMemberSince.Name = "lblMemberSince"
        Me.lblMemberSince.Size = New System.Drawing.Size(117, 20)
        Me.lblMemberSince.TabIndex = 2
        Me.lblMemberSince.Text = "lblMemberSince"
        Me.lblMemberSince.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFirstName
        '
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "First Name", True))
        Me.lblFirstName.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(46, 129)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(291, 38)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "Label2"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(90, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 20)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "DOB:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Street", True))
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblAddress.Location = New System.Drawing.Point(144, 94)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(65, 20)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "lblStreet"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(48, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Company:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pbxMemberPicture
        '
        Me.pbxMemberPicture.BackColor = System.Drawing.Color.Transparent
        Me.pbxMemberPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxMemberPicture.DataBindings.Add(New System.Windows.Forms.Binding("ImageLocation", Me.PersonBindingSource, "Member Image", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.pbxMemberPicture.ErrorImage = Nothing
        Me.pbxMemberPicture.Image = Global.MemberManagerLite.My.Resources.Resources.appbar_people
        Me.pbxMemberPicture.InitialImage = Global.MemberManagerLite.My.Resources.Resources.appbar_people
        Me.pbxMemberPicture.Location = New System.Drawing.Point(78, 3)
        Me.pbxMemberPicture.Name = "pbxMemberPicture"
        Me.pbxMemberPicture.Size = New System.Drawing.Size(229, 126)
        Me.pbxMemberPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxMemberPicture.TabIndex = 3
        Me.pbxMemberPicture.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(31, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Email Address:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(36, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Member Role:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(31, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Member Since:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.dgvMembers)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(5, 130)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 524)
        Me.Panel2.TabIndex = 4
        '
        'dgvMembers
        '
        Me.dgvMembers.AllowUserToResizeRows = False
        Me.dgvMembers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMembers.AutoGenerateColumns = False
        Me.dgvMembers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMembers.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvMembers.ColumnHeadersHeight = 30
        Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PersonalID, Me.FirstName, Me.LastName, Me.Gender, Me.EmailAddress, Me.DOB, Me.Telephone, Me.StreetColumn, Me.CommunityColumn, Me.DataGridViewTextBoxColumn10, Me.CompanyNumber, Me.MemberRole, Me.MemberImage, Me.MemberSince})
        Me.dgvMembers.DataSource = Me.PersonBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMembers.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMembers.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvMembers.Location = New System.Drawing.Point(0, 35)
        Me.dgvMembers.Name = "dgvMembers"
        Me.dgvMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dgvMembers.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMembers.ShowCellErrors = False
        Me.dgvMembers.ShowCellToolTips = False
        Me.dgvMembers.ShowEditingIcon = False
        Me.dgvMembers.ShowRowErrors = False
        Me.dgvMembers.Size = New System.Drawing.Size(781, 489)
        Me.dgvMembers.TabIndex = 3
        '
        'PersonalID
        '
        Me.PersonalID.DataPropertyName = "PersonID"
        Me.PersonalID.Frozen = True
        Me.PersonalID.HeaderText = "PersonID"
        Me.PersonalID.Name = "PersonalID"
        Me.PersonalID.Visible = False
        Me.PersonalID.Width = 76
        '
        'FirstName
        '
        Me.FirstName.DataPropertyName = "First Name"
        Me.FirstName.Frozen = True
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Width = 96
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "Last Name"
        Me.LastName.Frozen = True
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        Me.LastName.Width = 95
        '
        'Gender
        '
        Me.Gender.DataPropertyName = "Gender"
        Me.Gender.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.Gender.Name = "Gender"
        Me.Gender.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Gender.Width = 76
        '
        'EmailAddress
        '
        Me.EmailAddress.DataPropertyName = "Email Address"
        Me.EmailAddress.HeaderText = "Email Address"
        Me.EmailAddress.Name = "EmailAddress"
        Me.EmailAddress.Width = 116
        '
        'DOB
        '
        Me.DOB.DataPropertyName = "DOB"
        Me.DOB.HeaderText = "DOB (mm/dd/yyyy)"
        Me.DOB.Name = "DOB"
        Me.DOB.Width = 143
        '
        'Telephone
        '
        Me.Telephone.DataPropertyName = "Telephone"
        Me.Telephone.HeaderText = "Telephone"
        Me.Telephone.Name = "Telephone"
        Me.Telephone.Width = 94
        '
        'StreetColumn
        '
        Me.StreetColumn.DataPropertyName = "Street"
        Me.StreetColumn.HeaderText = "Street"
        Me.StreetColumn.Name = "StreetColumn"
        Me.StreetColumn.Width = 67
        '
        'CommunityColumn
        '
        Me.CommunityColumn.DataPropertyName = "Community"
        Me.CommunityColumn.HeaderText = "Community"
        Me.CommunityColumn.Name = "CommunityColumn"
        Me.CommunityColumn.Width = 98
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Company"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Company"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 88
        '
        'CompanyNumber
        '
        Me.CompanyNumber.DataPropertyName = "Company Number"
        Me.CompanyNumber.HeaderText = "Company Number"
        Me.CompanyNumber.Name = "CompanyNumber"
        Me.CompanyNumber.Width = 140
        '
        'MemberRole
        '
        Me.MemberRole.DataPropertyName = "Member Role"
        Me.MemberRole.HeaderText = "Member Role"
        Me.MemberRole.Name = "MemberRole"
        Me.MemberRole.Width = 113
        '
        'MemberImage
        '
        Me.MemberImage.DataPropertyName = "Member Image"
        Me.MemberImage.HeaderText = "Member Image"
        Me.MemberImage.Name = "MemberImage"
        Me.MemberImage.Visible = False
        Me.MemberImage.Width = 94
        '
        'MemberSince
        '
        Me.MemberSince.DataPropertyName = "Member Since"
        Me.MemberSince.HeaderText = "Member Since"
        Me.MemberSince.Name = "MemberSince"
        Me.MemberSince.Width = 117
        '
        'LoadRelationships
        '
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 47)
        Me.Label10.TabIndex = 5
        '
        'ofdFindPicture
        '
        Me.ofdFindPicture.AddExtension = False
        '
        'dgvBirthdays
        '
        Me.dgvBirthdays.AllowUserToAddRows = False
        Me.dgvBirthdays.AllowUserToDeleteRows = False
        Me.dgvBirthdays.AllowUserToResizeColumns = False
        Me.dgvBirthdays.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvBirthdays.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBirthdays.AutoGenerateColumns = False
        Me.dgvBirthdays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBirthdays.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvBirthdays.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBirthdays.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvBirthdays.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvBirthdays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBirthdays.ColumnHeadersVisible = False
        Me.dgvBirthdays.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PersonIDDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn})
        Me.dgvBirthdays.DataSource = Me.BirthdaySource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBirthdays.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBirthdays.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgvBirthdays.Location = New System.Drawing.Point(6, 17)
        Me.dgvBirthdays.MultiSelect = False
        Me.dgvBirthdays.Name = "dgvBirthdays"
        Me.dgvBirthdays.ReadOnly = True
        Me.dgvBirthdays.RowHeadersVisible = False
        Me.dgvBirthdays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBirthdays.Size = New System.Drawing.Size(248, 88)
        Me.dgvBirthdays.TabIndex = 9
        '
        'PersonIDDataGridViewTextBoxColumn
        '
        Me.PersonIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID"
        Me.PersonIDDataGridViewTextBoxColumn.HeaderText = "PersonID"
        Me.PersonIDDataGridViewTextBoxColumn.Name = "PersonIDDataGridViewTextBoxColumn"
        Me.PersonIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PersonIDDataGridViewTextBoxColumn.Visible = False
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        DataGridViewCellStyle4.Format = "M"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DOBDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        Me.DOBDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BirthdaySource
        '
        Me.BirthdaySource.DataMember = "Person"
        Me.BirthdaySource.DataSource = Me.ContactLiteDataSet
        '
        'gbxBirthdays
        '
        Me.gbxBirthdays.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxBirthdays.BackColor = System.Drawing.Color.Transparent
        Me.gbxBirthdays.Controls.Add(Me.dgvBirthdays)
        Me.gbxBirthdays.Location = New System.Drawing.Point(522, 10)
        Me.gbxBirthdays.Name = "gbxBirthdays"
        Me.gbxBirthdays.Size = New System.Drawing.Size(264, 111)
        Me.gbxBirthdays.TabIndex = 10
        Me.gbxBirthdays.TabStop = False
        Me.gbxBirthdays.Text = "Upcoming Birthdays"
        '
        'pbxLogo
        '
        Me.pbxLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxLogo.DataBindings.Add(New System.Windows.Forms.Binding("ImageLocation", Global.MemberManagerLite.My.MySettings.Default, "LogoLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pbxLogo.ErrorImage = Global.MemberManagerLite.My.Resources.Resources.appbar_people_multiple
        Me.pbxLogo.ImageLocation = Global.MemberManagerLite.My.MySettings.Default.LogoLocation
        Me.pbxLogo.Location = New System.Drawing.Point(15, 10)
        Me.pbxLogo.MaximumSize = New System.Drawing.Size(165, 150)
        Me.pbxLogo.MinimumSize = New System.Drawing.Size(117, 110)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(117, 111)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 6
        Me.pbxLogo.TabStop = False
        '
        'PersonID
        '
        Me.PersonID.DataPropertyName = "PersonID"
        Me.PersonID.Frozen = True
        Me.PersonID.HeaderText = "PersonID"
        Me.PersonID.Name = "PersonID"
        Me.PersonID.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First Name"
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last Name"
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.Items.AddRange(New Object() {"Male", "Female"})
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "DOB"
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn11.HeaderText = "DOB (mm/dd/yyyy)"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 130
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Telephone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telephone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Street
        '
        Me.Street.DataPropertyName = "Street"
        Me.Street.HeaderText = "Street"
        Me.Street.Name = "Street"
        '
        'Community
        '
        Me.Community.DataPropertyName = "Community"
        Me.Community.HeaderText = "Community"
        Me.Community.Name = "Community"
        '
        'Company
        '
        Me.Company.DataPropertyName = "Company"
        Me.Company.HeaderText = "Company"
        Me.Company.Name = "Company"
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'Person_RelationTableAdapter
        '
        Me.Person_RelationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Person_RelationTableAdapter = Me.Person_RelationTableAdapter
        Me.TableAdapterManager.Person_TelephoneTableAdapter = Nothing
        Me.TableAdapterManager.PersonTableAdapter = Me.PersonTableAdapter
        Me.TableAdapterManager.RelationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MemberManagerLite.ContactLiteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Person_TelephoneTableAdapter
        '
        Me.Person_TelephoneTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tbpBasic)
        Me.TabControl1.Controls.Add(Me.tbpMore)
        Me.TabControl1.Location = New System.Drawing.Point(805, 236)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(371, 418)
        Me.TabControl1.TabIndex = 4
        '
        'tbpBasic
        '
        Me.tbpBasic.AutoScroll = True
        Me.tbpBasic.AutoScrollMargin = New System.Drawing.Size(0, 10)
        Me.tbpBasic.BackgroundImage = Global.MemberManagerLite.My.Resources.Resources.pixel_weave
        Me.tbpBasic.Controls.Add(Me.lblGender)
        Me.tbpBasic.Controls.Add(Me.lblAddress)
        Me.tbpBasic.Controls.Add(Me.lblEmailAddress)
        Me.tbpBasic.Controls.Add(Me.Label5)
        Me.tbpBasic.Controls.Add(Me.Label2)
        Me.tbpBasic.Controls.Add(Me.lblOccupation)
        Me.tbpBasic.Controls.Add(Me.Label12)
        Me.tbpBasic.Controls.Add(Me.Label8)
        Me.tbpBasic.Controls.Add(Me.lblMemberRole)
        Me.tbpBasic.Controls.Add(Me.lblCommunity)
        Me.tbpBasic.Controls.Add(Me.Label6)
        Me.tbpBasic.Controls.Add(Me.Label3)
        Me.tbpBasic.Controls.Add(Me.Label14)
        Me.tbpBasic.Controls.Add(Me.Label7)
        Me.tbpBasic.Controls.Add(Me.Label13)
        Me.tbpBasic.Controls.Add(Me.lblMemberSince)
        Me.tbpBasic.Location = New System.Drawing.Point(4, 26)
        Me.tbpBasic.Name = "tbpBasic"
        Me.tbpBasic.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpBasic.Size = New System.Drawing.Size(363, 388)
        Me.tbpBasic.TabIndex = 0
        Me.tbpBasic.Text = "Basic Info"
        Me.tbpBasic.UseVisualStyleBackColor = True
        '
        'tbpMore
        '
        Me.tbpMore.BackgroundImage = Global.MemberManagerLite.My.Resources.Resources.pixel_weave
        Me.tbpMore.Controls.Add(Me.btnNewRelation)
        Me.tbpMore.Controls.Add(Me.lbxRelations)
        Me.tbpMore.Controls.Add(Me.Label9)
        Me.tbpMore.Controls.Add(Me.lbxNumbers)
        Me.tbpMore.Controls.Add(Me.Label4)
        Me.tbpMore.Controls.Add(Me.btnNewNumber)
        Me.tbpMore.Location = New System.Drawing.Point(4, 26)
        Me.tbpMore.Name = "tbpMore"
        Me.tbpMore.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpMore.Size = New System.Drawing.Size(363, 388)
        Me.tbpMore.TabIndex = 1
        Me.tbpMore.Text = "More Info"
        Me.tbpMore.UseVisualStyleBackColor = True
        '
        'btnNewRelation
        '
        Me.btnNewRelation.Location = New System.Drawing.Point(221, 158)
        Me.btnNewRelation.Name = "btnNewRelation"
        Me.btnNewRelation.Size = New System.Drawing.Size(80, 29)
        Me.btnNewRelation.TabIndex = 12
        Me.btnNewRelation.Text = "Manage"
        Me.btnNewRelation.UseVisualStyleBackColor = True
        '
        'lbxRelations
        '
        Me.lbxRelations.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbxRelations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbxRelations.FormattingEnabled = True
        Me.lbxRelations.ItemHeight = 17
        Me.lbxRelations.Location = New System.Drawing.Point(129, 99)
        Me.lbxRelations.Name = "lbxRelations"
        Me.lbxRelations.Size = New System.Drawing.Size(172, 53)
        Me.lbxRelations.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(57, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Relations:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbxNumbers
        '
        Me.lbxNumbers.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbxNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbxNumbers.FormattingEnabled = True
        Me.lbxNumbers.ItemHeight = 17
        Me.lbxNumbers.Location = New System.Drawing.Point(129, 21)
        Me.lbxNumbers.Name = "lbxNumbers"
        Me.lbxNumbers.Size = New System.Drawing.Size(172, 53)
        Me.lbxNumbers.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(50, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Telephone:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNewNumber
        '
        Me.btnNewNumber.BackColor = System.Drawing.Color.Transparent
        Me.btnNewNumber.BackgroundImage = Global.MemberManagerLite.My.Resources.Resources.appbar_settings
        Me.btnNewNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNewNumber.FlatAppearance.BorderSize = 0
        Me.btnNewNumber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNewNumber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNewNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewNumber.Location = New System.Drawing.Point(88, 32)
        Me.btnNewNumber.Name = "btnNewNumber"
        Me.btnNewNumber.Size = New System.Drawing.Size(45, 54)
        Me.btnNewNumber.TabIndex = 10
        Me.btnNewNumber.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.pbxMemberPicture)
        Me.Panel3.Controls.Add(Me.lblLastName)
        Me.Panel3.Controls.Add(Me.lblFirstName)
        Me.Panel3.Location = New System.Drawing.Point(805, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(367, 215)
        Me.Panel3.TabIndex = 11
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.MemberManagerLite.My.Resources.Resources.tiny_grid
        Me.ClientSize = New System.Drawing.Size(1188, 662)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.gbxBirthdays)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Manager"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactLiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMemberPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBirthdays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BirthdaySource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBirthdays.ResumeLayout(False)
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tbpBasic.ResumeLayout(False)
        Me.tbpBasic.PerformLayout()
        Me.tbpMore.ResumeLayout(False)
        Me.tbpMore.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxMemberPicture As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMemberCount As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ContactLiteDataSet As MemberManagerLite.ContactLiteDataSet
    Friend WithEvents PersonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonTableAdapter As MemberManagerLite.ContactLiteDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents btnDeleteMember As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LoadRelationships As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblOccupation As System.Windows.Forms.Label
    Friend WithEvents lblEmailAddress As System.Windows.Forms.Label
    Friend WithEvents lblMemberRole As System.Windows.Forms.Label
    Friend WithEvents lblMemberSince As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ofdFindPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Person_RelationTableAdapter As MemberManagerLite.ContactLiteDataSetTableAdapters.Person_RelationTableAdapter
    Friend WithEvents dgvMembers As System.Windows.Forms.DataGridView
    Friend WithEvents TableAdapterManager As MemberManagerLite.ContactLiteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents dgvBirthdays As System.Windows.Forms.DataGridView
    Friend WithEvents BirthdaySource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gbxBirthdays As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersonID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Street As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Community As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Company As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblCommunity As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Person_TelephoneTableAdapter As MemberManagerLite.ContactLiteDataSetTableAdapters.Person_TelephoneTableAdapter
    Friend WithEvents PersonalID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gender As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents EmailAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telephone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StreetColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommunityColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberRole As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberImage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberSince As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpBasic As System.Windows.Forms.TabPage
    Friend WithEvents tbpMore As System.Windows.Forms.TabPage
    Friend WithEvents btnNewRelation As System.Windows.Forms.Button
    Friend WithEvents lbxRelations As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbxNumbers As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnNewNumber As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
