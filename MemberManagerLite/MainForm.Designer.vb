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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMemberCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDeleteMember = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.pnlMemberInformation = New System.Windows.Forms.Panel()
        Me.lbxRelations = New System.Windows.Forms.ListBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactLiteDataSet = New MemberManagerLite.ContactLiteDataSet()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMemberRole = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMemberSince = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnNewRelation = New System.Windows.Forms.Button()
        Me.pbxMemberPicture = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbxDivider = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PersonDataGridView = New System.Windows.Forms.DataGridView()
        Me.PersonID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberImage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadRelationships = New System.ComponentModel.BackgroundWorker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ofdFindPicture = New System.Windows.Forms.OpenFileDialog()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.dgvBirthdays = New System.Windows.Forms.DataGridView()
        Me.PersonIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdaySource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.PersonTableAdapter = New MemberManagerLite.ContactLiteDataSetTableAdapters.PersonTableAdapter()
        Me.Person_RelationTableAdapter = New MemberManagerLite.ContactLiteDataSetTableAdapters.Person_RelationTableAdapter()
        Me.TableAdapterManager = New MemberManagerLite.ContactLiteDataSetTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        Me.pnlMemberInformation.SuspendLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactLiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMemberPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDivider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PersonDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBirthdays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BirthdaySource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = Global.MemberManagerLite.My.Resources.Resources.pixel_weave
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblMemberCount)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnExport)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnDeleteMember)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.txtFilter)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 36)
        Me.Panel1.TabIndex = 3
        '
        'lblMemberCount
        '
        Me.lblMemberCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMemberCount.AutoSize = True
        Me.lblMemberCount.BackColor = System.Drawing.Color.Transparent
        Me.lblMemberCount.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.lblMemberCount.Location = New System.Drawing.Point(607, 8)
        Me.lblMemberCount.Name = "lblMemberCount"
        Me.lblMemberCount.Size = New System.Drawing.Size(77, 18)
        Me.lblMemberCount.TabIndex = 2
        Me.lblMemberCount.Text = "Member(s)"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(356, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Search:"
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
        Me.txtFilter.Location = New System.Drawing.Point(409, 4)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(170, 25)
        Me.txtFilter.TabIndex = 3
        '
        'pnlMemberInformation
        '
        Me.pnlMemberInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMemberInformation.BackColor = System.Drawing.Color.DarkGray
        Me.pnlMemberInformation.BackgroundImage = Global.MemberManagerLite.My.Resources.Resources.pixel_weave
        Me.pnlMemberInformation.Controls.Add(Me.lbxRelations)
        Me.pnlMemberInformation.Controls.Add(Me.lblGender)
        Me.pnlMemberInformation.Controls.Add(Me.Label13)
        Me.pnlMemberInformation.Controls.Add(Me.lblTelephone)
        Me.pnlMemberInformation.Controls.Add(Me.Label9)
        Me.pnlMemberInformation.Controls.Add(Me.lblOccupation)
        Me.pnlMemberInformation.Controls.Add(Me.lblLastName)
        Me.pnlMemberInformation.Controls.Add(Me.lblEmailAddress)
        Me.pnlMemberInformation.Controls.Add(Me.Label2)
        Me.pnlMemberInformation.Controls.Add(Me.lblMemberRole)
        Me.pnlMemberInformation.Controls.Add(Me.Label3)
        Me.pnlMemberInformation.Controls.Add(Me.lblMemberSince)
        Me.pnlMemberInformation.Controls.Add(Me.lblFirstName)
        Me.pnlMemberInformation.Controls.Add(Me.Label12)
        Me.pnlMemberInformation.Controls.Add(Me.Label4)
        Me.pnlMemberInformation.Controls.Add(Me.lblAddress)
        Me.pnlMemberInformation.Controls.Add(Me.Label5)
        Me.pnlMemberInformation.Controls.Add(Me.btnNewRelation)
        Me.pnlMemberInformation.Controls.Add(Me.pbxMemberPicture)
        Me.pnlMemberInformation.Controls.Add(Me.Label6)
        Me.pnlMemberInformation.Controls.Add(Me.pbxDivider)
        Me.pnlMemberInformation.Controls.Add(Me.Label7)
        Me.pnlMemberInformation.Controls.Add(Me.Label8)
        Me.pnlMemberInformation.Location = New System.Drawing.Point(717, -1)
        Me.pnlMemberInformation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlMemberInformation.Name = "pnlMemberInformation"
        Me.pnlMemberInformation.Size = New System.Drawing.Size(318, 664)
        Me.pnlMemberInformation.TabIndex = 1
        '
        'lbxRelations
        '
        Me.lbxRelations.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbxRelations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbxRelations.FormattingEnabled = True
        Me.lbxRelations.ItemHeight = 17
        Me.lbxRelations.Location = New System.Drawing.Point(127, 551)
        Me.lbxRelations.Name = "lbxRelations"
        Me.lbxRelations.Size = New System.Drawing.Size(172, 53)
        Me.lbxRelations.TabIndex = 6
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Gender", True))
        Me.lblGender.Location = New System.Drawing.Point(124, 238)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(65, 17)
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "DOB", True))
        Me.Label13.Location = New System.Drawing.Point(124, 339)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "lblDOB"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.BackColor = System.Drawing.Color.Transparent
        Me.lblTelephone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Telephone", True))
        Me.lblTelephone.Location = New System.Drawing.Point(124, 366)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(83, 17)
        Me.lblTelephone.TabIndex = 2
        Me.lblTelephone.Text = "lblTelephone"
        Me.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(55, 551)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Relations:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.BackColor = System.Drawing.Color.Transparent
        Me.lblOccupation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Occupation", True))
        Me.lblOccupation.Location = New System.Drawing.Point(124, 396)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(88, 17)
        Me.lblOccupation.TabIndex = 2
        Me.lblOccupation.Text = "lblOccupation"
        Me.lblOccupation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLastName
        '
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Last Name", True))
        Me.lblLastName.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(8, 187)
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
        Me.lblEmailAddress.Location = New System.Drawing.Point(130, 427)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(167, 60)
        Me.lblEmailAddress.TabIndex = 2
        Me.lblEmailAddress.Text = "lblEmail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(67, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Gender:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMemberRole
        '
        Me.lblMemberRole.AutoSize = True
        Me.lblMemberRole.BackColor = System.Drawing.Color.Transparent
        Me.lblMemberRole.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Member Role", True))
        Me.lblMemberRole.Location = New System.Drawing.Point(125, 490)
        Me.lblMemberRole.Name = "lblMemberRole"
        Me.lblMemberRole.Size = New System.Drawing.Size(98, 17)
        Me.lblMemberRole.TabIndex = 2
        Me.lblMemberRole.Text = "lblMemberRole"
        Me.lblMemberRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(63, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Address:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMemberSince
        '
        Me.lblMemberSince.AutoSize = True
        Me.lblMemberSince.BackColor = System.Drawing.Color.Transparent
        Me.lblMemberSince.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Member Since", True))
        Me.lblMemberSince.Location = New System.Drawing.Point(125, 520)
        Me.lblMemberSince.Name = "lblMemberSince"
        Me.lblMemberSince.Size = New System.Drawing.Size(102, 17)
        Me.lblMemberSince.TabIndex = 2
        Me.lblMemberSince.Text = "lblMemberSince"
        Me.lblMemberSince.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFirstName
        '
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "First Name", True))
        Me.lblFirstName.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(8, 151)
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
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(84, 339)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "DOB:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(48, 366)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Telephone:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Address", True))
        Me.lblAddress.Location = New System.Drawing.Point(124, 268)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(173, 60)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "lblAddress"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(42, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Occupation:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNewRelation
        '
        Me.btnNewRelation.Location = New System.Drawing.Point(127, 608)
        Me.btnNewRelation.Name = "btnNewRelation"
        Me.btnNewRelation.Size = New System.Drawing.Size(80, 29)
        Me.btnNewRelation.TabIndex = 5
        Me.btnNewRelation.Text = "Manage"
        Me.btnNewRelation.UseVisualStyleBackColor = True
        '
        'pbxMemberPicture
        '
        Me.pbxMemberPicture.BackColor = System.Drawing.Color.Transparent
        Me.pbxMemberPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxMemberPicture.DataBindings.Add(New System.Windows.Forms.Binding("ImageLocation", Me.PersonBindingSource, "Member Image", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.pbxMemberPicture.ErrorImage = Nothing
        Me.pbxMemberPicture.Image = Global.MemberManagerLite.My.Resources.Resources.appbar_people
        Me.pbxMemberPicture.InitialImage = Global.MemberManagerLite.My.Resources.Resources.appbar_people
        Me.pbxMemberPicture.Location = New System.Drawing.Point(89, 19)
        Me.pbxMemberPicture.Name = "pbxMemberPicture"
        Me.pbxMemberPicture.Size = New System.Drawing.Size(129, 126)
        Me.pbxMemberPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxMemberPicture.TabIndex = 3
        Me.pbxMemberPicture.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(25, 427)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Email Address:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pbxDivider
        '
        Me.pbxDivider.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbxDivider.BackColor = System.Drawing.Color.Navy
        Me.pbxDivider.Location = New System.Drawing.Point(0, 0)
        Me.pbxDivider.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pbxDivider.Name = "pbxDivider"
        Me.pbxDivider.Size = New System.Drawing.Size(2, 670)
        Me.pbxDivider.TabIndex = 2
        Me.pbxDivider.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(30, 490)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Member Role:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(25, 520)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Member Since:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.PersonDataGridView)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(5, 130)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(706, 524)
        Me.Panel2.TabIndex = 4
        '
        'PersonDataGridView
        '
        Me.PersonDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PersonDataGridView.AutoGenerateColumns = False
        Me.PersonDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.PersonDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.PersonDataGridView.ColumnHeadersHeight = 30
        Me.PersonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.PersonDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PersonID, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.MemberImage})
        Me.PersonDataGridView.DataSource = Me.PersonBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PersonDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.PersonDataGridView.GridColor = System.Drawing.Color.Gainsboro
        Me.PersonDataGridView.Location = New System.Drawing.Point(0, 35)
        Me.PersonDataGridView.Name = "PersonDataGridView"
        Me.PersonDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.PersonDataGridView.Size = New System.Drawing.Size(706, 489)
        Me.PersonDataGridView.TabIndex = 3
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
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn11.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Telephone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telephone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Occupation"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Occupation"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Email Address"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Email Address"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Member Role"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Member Role"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Member Since"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Member Since"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'MemberImage
        '
        Me.MemberImage.DataPropertyName = "Member Image"
        Me.MemberImage.HeaderText = "Member Image"
        Me.MemberImage.Name = "MemberImage"
        Me.MemberImage.Visible = False
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
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.Image = Global.MemberManagerLite.My.Resources.Resources.logout_26
        Me.btnLogout.Location = New System.Drawing.Point(386, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(42, 38)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'dgvBirthdays
        '
        Me.dgvBirthdays.AllowUserToAddRows = False
        Me.dgvBirthdays.AllowUserToDeleteRows = False
        Me.dgvBirthdays.AllowUserToResizeColumns = False
        Me.dgvBirthdays.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvBirthdays.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBirthdays.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBirthdays.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgvBirthdays.Location = New System.Drawing.Point(6, 17)
        Me.dgvBirthdays.MultiSelect = False
        Me.dgvBirthdays.Name = "dgvBirthdays"
        Me.dgvBirthdays.ReadOnly = True
        Me.dgvBirthdays.RowHeadersVisible = False
        Me.dgvBirthdays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBirthdays.Size = New System.Drawing.Size(265, 102)
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
        DataGridViewCellStyle3.Format = "M"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DOBDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dgvBirthdays)
        Me.GroupBox1.Location = New System.Drawing.Point(434, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 125)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Upcoming Birthdays"
        '
        'pbxLogo
        '
        Me.pbxLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxLogo.DataBindings.Add(New System.Windows.Forms.Binding("ImageLocation", Global.MemberManagerLite.My.MySettings.Default, "LogoLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pbxLogo.ErrorImage = Global.MemberManagerLite.My.Resources.Resources.appbar_people_multiple
        Me.pbxLogo.ImageLocation = Global.MemberManagerLite.My.MySettings.Default.LogoLocation
        Me.pbxLogo.Location = New System.Drawing.Point(12, 10)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(117, 110)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 6
        Me.pbxLogo.TabStop = False
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
        Me.TableAdapterManager.PersonTableAdapter = Me.PersonTableAdapter
        Me.TableAdapterManager.RelationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MemberManagerLite.ContactLiteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.MemberManagerLite.My.Resources.Resources.tiny_grid
        Me.ClientSize = New System.Drawing.Size(1028, 662)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.pnlMemberInformation)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Manager"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlMemberInformation.ResumeLayout(False)
        Me.pnlMemberInformation.PerformLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactLiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMemberPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDivider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PersonDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBirthdays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BirthdaySource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlMemberInformation As System.Windows.Forms.Panel
    Friend WithEvents pbxDivider As System.Windows.Forms.PictureBox
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnNewRelation As System.Windows.Forms.Button
    Friend WithEvents LoadRelationships As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
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
    Friend WithEvents lbxRelations As System.Windows.Forms.ListBox
    Friend WithEvents PersonDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TableAdapterManager As MemberManagerLite.ContactLiteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PersonID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberImage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents dgvBirthdays As System.Windows.Forms.DataGridView
    Friend WithEvents BirthdaySource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
