namespace MemberManager.Member
{
    partial class AddMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDataSet = new MemberManager.ContactDataSet();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxMaritalStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudChildren = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpAnniversary = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDateWaterBaptism = new System.Windows.Forms.DateTimePicker();
            this.txtChurch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPrevRespons = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpInformation = new System.Windows.Forms.TabPage();
            this.tbpRelationships = new System.Windows.Forms.TabPage();
            this.personTableAdapter = new MemberManager.ContactDataSetTableAdapters.PersonTableAdapter();
            this.rolesTableAdapter = new MemberManager.ContactDataSetTableAdapters.RolesTableAdapter();
            this.txtDateWaterBaptism = new System.Windows.Forms.TextBox();
            this.txtAnniversary = new System.Windows.Forms.TextBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.cxCounselling = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildren)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(38, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gender:";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(92, 13);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 27);
            this.txtName.TabIndex = 1;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.contactDataSet;
            // 
            // contactDataSet
            // 
            this.contactDataSet.DataSetName = "ContactDataSet";
            this.contactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPersonID
            // 
            this.txtPersonID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "PersonID", true));
            this.txtPersonID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPersonID.Location = new System.Drawing.Point(237, 13);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(92, 27);
            this.txtPersonID.TabIndex = 2;
            this.txtPersonID.TextChanged += new System.EventHandler(this.txtPersonID_TextChanged);
            // 
            // cbxGender
            // 
            this.cbxGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Gender", true));
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(92, 113);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(139, 28);
            this.cbxGender.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(92, 163);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(188, 27);
            this.txtAddress.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "D.O.B.:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personBindingSource, "DOB", true));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(92, 63);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(139, 27);
            this.dtpDOB.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Telephone:";
            // 
            // txtTelephone
            // 
            this.txtTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Telephone", true));
            this.txtTelephone.Location = new System.Drawing.Point(92, 213);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(188, 27);
            this.txtTelephone.TabIndex = 10;
            this.txtTelephone.Text = "(876) ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(92, 263);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 27);
            this.txtEmail.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(369, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Marital Status:";
            // 
            // cbxMaritalStatus
            // 
            this.cbxMaritalStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Marital Status", true));
            this.cbxMaritalStatus.FormattingEnabled = true;
            this.cbxMaritalStatus.Items.AddRange(new object[] {
            "Single",
            "Engaged",
            "Married",
            "Widowed"});
            this.cbxMaritalStatus.Location = new System.Drawing.Point(466, 13);
            this.cbxMaritalStatus.Name = "cbxMaritalStatus";
            this.cbxMaritalStatus.Size = new System.Drawing.Size(162, 28);
            this.cbxMaritalStatus.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(401, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Children:";
            // 
            // nudChildren
            // 
            this.nudChildren.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personBindingSource, "Children", true));
            this.nudChildren.Location = new System.Drawing.Point(466, 112);
            this.nudChildren.Name = "nudChildren";
            this.nudChildren.Size = new System.Drawing.Size(79, 27);
            this.nudChildren.TabIndex = 16;
            this.nudChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(382, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Anniversary:";
            // 
            // dtpAnniversary
            // 
            this.dtpAnniversary.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAnniversary.Location = new System.Drawing.Point(466, 63);
            this.dtpAnniversary.Name = "dtpAnniversary";
            this.dtpAnniversary.Size = new System.Drawing.Size(162, 27);
            this.dtpAnniversary.TabIndex = 18;
            this.dtpAnniversary.ValueChanged += new System.EventHandler(this.dtpAnniversary_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Profession:";
            // 
            // txtProfession
            // 
            this.txtProfession.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Occupation", true));
            this.txtProfession.Location = new System.Drawing.Point(92, 313);
            this.txtProfession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(188, 27);
            this.txtProfession.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(317, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Date of Water Baptism:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(409, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Church:";
            // 
            // dtpDateWaterBaptism
            // 
            this.dtpDateWaterBaptism.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateWaterBaptism.Location = new System.Drawing.Point(466, 162);
            this.dtpDateWaterBaptism.Name = "dtpDateWaterBaptism";
            this.dtpDateWaterBaptism.Size = new System.Drawing.Size(162, 27);
            this.dtpDateWaterBaptism.TabIndex = 23;
            this.dtpDateWaterBaptism.ValueChanged += new System.EventHandler(this.dtpDateWaterBaptism_ValueChanged);
            // 
            // txtChurch
            // 
            this.txtChurch.AutoCompleteCustomSource.AddRange(new string[] {
            "Open Door Church"});
            this.txtChurch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtChurch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtChurch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Other Ministry", true));
            this.txtChurch.Location = new System.Drawing.Point(466, 213);
            this.txtChurch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChurch.Name = "txtChurch";
            this.txtChurch.Size = new System.Drawing.Size(204, 27);
            this.txtChurch.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cxCounselling);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(17, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 103);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spiritually or physically empowered areas";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rolesBindingSource, "Administration", true));
            this.checkBox7.Location = new System.Drawing.Point(262, 64);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(126, 24);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Text = "Administration";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rolesBindingSource, "Prayer", true));
            this.checkBox6.Location = new System.Drawing.Point(187, 64);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(69, 24);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Prayer";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rolesBindingSource, "Praise & Worship", true));
            this.checkBox5.Location = new System.Drawing.Point(17, 64);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(155, 24);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Praise and Worship";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rolesBindingSource, "Hospitality", true));
            this.checkBox4.Location = new System.Drawing.Point(514, 34);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 24);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Hospitality";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rolesBindingSource, "Sunday School", true));
            this.checkBox3.Location = new System.Drawing.Point(272, 34);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(125, 24);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Sunday School";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rolesBindingSource, "Youth Fellowship", true));
            this.checkBox2.Location = new System.Drawing.Point(126, 34);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(140, 24);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Youth Fellowship";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rolesBindingSource, "Evangelism", true));
            this.checkBox1.Location = new System.Drawing.Point(17, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Evangelism";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(327, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Prev. Responsibilities:";
            // 
            // txtPrevRespons
            // 
            this.txtPrevRespons.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Previous Role", true));
            this.txtPrevRespons.Location = new System.Drawing.Point(465, 263);
            this.txtPrevRespons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrevRespons.Multiline = true;
            this.txtPrevRespons.Name = "txtPrevRespons";
            this.txtPrevRespons.Size = new System.Drawing.Size(204, 77);
            this.txtPrevRespons.TabIndex = 27;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(498, 515);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 33);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(603, 515);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 33);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpInformation);
            this.tabControl1.Controls.Add(this.tbpRelationships);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 497);
            this.tabControl1.TabIndex = 29;
            // 
            // tbpInformation
            // 
            this.tbpInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbpInformation.Controls.Add(this.txtAnniversary);
            this.tbpInformation.Controls.Add(this.txtDateWaterBaptism);
            this.tbpInformation.Controls.Add(this.txtName);
            this.tbpInformation.Controls.Add(this.label2);
            this.tbpInformation.Controls.Add(this.label3);
            this.tbpInformation.Controls.Add(this.txtPersonID);
            this.tbpInformation.Controls.Add(this.groupBox1);
            this.tbpInformation.Controls.Add(this.txtPrevRespons);
            this.tbpInformation.Controls.Add(this.cbxGender);
            this.tbpInformation.Controls.Add(this.label14);
            this.tbpInformation.Controls.Add(this.label5);
            this.tbpInformation.Controls.Add(this.txtAddress);
            this.tbpInformation.Controls.Add(this.txtChurch);
            this.tbpInformation.Controls.Add(this.label6);
            this.tbpInformation.Controls.Add(this.dtpDateWaterBaptism);
            this.tbpInformation.Controls.Add(this.dtpDOB);
            this.tbpInformation.Controls.Add(this.label13);
            this.tbpInformation.Controls.Add(this.label7);
            this.tbpInformation.Controls.Add(this.label12);
            this.tbpInformation.Controls.Add(this.txtTelephone);
            this.tbpInformation.Controls.Add(this.dtpAnniversary);
            this.tbpInformation.Controls.Add(this.txtProfession);
            this.tbpInformation.Controls.Add(this.label10);
            this.tbpInformation.Controls.Add(this.label4);
            this.tbpInformation.Controls.Add(this.nudChildren);
            this.tbpInformation.Controls.Add(this.label11);
            this.tbpInformation.Controls.Add(this.label9);
            this.tbpInformation.Controls.Add(this.txtEmail);
            this.tbpInformation.Controls.Add(this.cbxMaritalStatus);
            this.tbpInformation.Controls.Add(this.label8);
            this.tbpInformation.Controls.Add(this.txtRoleID);
            this.tbpInformation.Location = new System.Drawing.Point(4, 29);
            this.tbpInformation.Name = "tbpInformation";
            this.tbpInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInformation.Size = new System.Drawing.Size(682, 464);
            this.tbpInformation.TabIndex = 0;
            this.tbpInformation.Text = "Member Information";
            // 
            // tbpRelationships
            // 
            this.tbpRelationships.BackgroundImage = global::MemberManager.Properties.Resources.linedpaper;
            this.tbpRelationships.Location = new System.Drawing.Point(4, 29);
            this.tbpRelationships.Name = "tbpRelationships";
            this.tbpRelationships.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRelationships.Size = new System.Drawing.Size(682, 464);
            this.tbpRelationships.TabIndex = 1;
            this.tbpRelationships.Text = "Relationships";
            this.tbpRelationships.UseVisualStyleBackColor = true;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // txtDateWaterBaptism
            // 
            this.txtDateWaterBaptism.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Water Baptism Date", true));
            this.txtDateWaterBaptism.Location = new System.Drawing.Point(465, 162);
            this.txtDateWaterBaptism.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDateWaterBaptism.Name = "txtDateWaterBaptism";
            this.txtDateWaterBaptism.Size = new System.Drawing.Size(130, 27);
            this.txtDateWaterBaptism.TabIndex = 28;
            // 
            // txtAnniversary
            // 
            this.txtAnniversary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Anniversary Date", true));
            this.txtAnniversary.Location = new System.Drawing.Point(466, 63);
            this.txtAnniversary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnniversary.Name = "txtAnniversary";
            this.txtAnniversary.Size = new System.Drawing.Size(129, 27);
            this.txtAnniversary.TabIndex = 29;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.contactDataSet;
            // 
            // txtRoleID
            // 
            this.txtRoleID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "PersonID", true));
            this.txtRoleID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtRoleID.Location = new System.Drawing.Point(188, 313);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(92, 27);
            this.txtRoleID.TabIndex = 30;
            // 
            // cxCounselling
            // 
            this.cxCounselling.AutoSize = true;
            this.cxCounselling.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rolesBindingSource, "Sunday School", true));
            this.cxCounselling.Location = new System.Drawing.Point(403, 34);
            this.cxCounselling.Name = "cxCounselling";
            this.cxCounselling.Size = new System.Drawing.Size(105, 24);
            this.cxCounselling.TabIndex = 1;
            this.cxCounselling.Text = "Counselling";
            this.cxCounselling.UseVisualStyleBackColor = true;
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::MemberManager.Properties.Resources.tiny_grid;
            this.ClientSize = new System.Drawing.Size(714, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddMember";
            this.Text = "New Member";
            this.Load += new System.EventHandler(this.AddMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildren)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpInformation.ResumeLayout(false);
            this.tbpInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxMaritalStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudChildren;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpAnniversary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProfession;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDateWaterBaptism;
        private System.Windows.Forms.TextBox txtChurch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPrevRespons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpInformation;
        private System.Windows.Forms.TabPage tbpRelationships;
        private ContactDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private ContactDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private ContactDataSet contactDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TextBox txtDateWaterBaptism;
        private System.Windows.Forms.TextBox txtAnniversary;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.CheckBox cxCounselling;
    }
}