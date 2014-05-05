namespace MemberManager
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnNewService = new System.Windows.Forms.Button();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.mcCalendar = new System.Windows.Forms.MonthCalendar();
            this.gbUpcomingEvents = new System.Windows.Forms.GroupBox();
            this.cbxChooseDisplay = new System.Windows.Forms.ComboBox();
            this.dgvBirthdays = new System.Windows.Forms.DataGridView();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDataSet = new MemberManager.ContactDataSet();
            this.pbxDisplayImage = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblVerseoftheDay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.personTableAdapter = new MemberManager.ContactDataSetTableAdapters.PersonTableAdapter();
            this.SetVerseoftheDay = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.gbUpcomingEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirthdays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisplayImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.btnNewService);
            this.groupBox1.Controls.Add(this.btnNewMember);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(286, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tasks";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::MemberManager.Properties.Resources.appbar_door_leave;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(15, 134);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(132, 96);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnNewService
            // 
            this.btnNewService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewService.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNewService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnNewService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnNewService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewService.Image = global::MemberManager.Properties.Resources.appbar_church;
            this.btnNewService.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewService.Location = new System.Drawing.Point(163, 32);
            this.btnNewService.Name = "btnNewService";
            this.btnNewService.Size = new System.Drawing.Size(132, 96);
            this.btnNewService.TabIndex = 2;
            this.btnNewService.Text = "Service";
            this.btnNewService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewService.UseVisualStyleBackColor = true;
            this.btnNewService.Click += new System.EventHandler(this.btnNewService_Click);
            // 
            // btnNewMember
            // 
            this.btnNewMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNewMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnNewMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMember.Image = global::MemberManager.Properties.Resources.appbar_people_multiple;
            this.btnNewMember.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewMember.Location = new System.Drawing.Point(15, 32);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(132, 96);
            this.btnNewMember.TabIndex = 0;
            this.btnNewMember.Text = "Members";
            this.btnNewMember.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // mcCalendar
            // 
            this.mcCalendar.Location = new System.Drawing.Point(30, 89);
            this.mcCalendar.Name = "mcCalendar";
            this.mcCalendar.TabIndex = 1;
            // 
            // gbUpcomingEvents
            // 
            this.gbUpcomingEvents.BackColor = System.Drawing.Color.Transparent;
            this.gbUpcomingEvents.Controls.Add(this.cbxChooseDisplay);
            this.gbUpcomingEvents.Controls.Add(this.dgvBirthdays);
            this.gbUpcomingEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUpcomingEvents.Location = new System.Drawing.Point(617, 119);
            this.gbUpcomingEvents.Name = "gbUpcomingEvents";
            this.gbUpcomingEvents.Size = new System.Drawing.Size(283, 304);
            this.gbUpcomingEvents.TabIndex = 1;
            this.gbUpcomingEvents.TabStop = false;
            this.gbUpcomingEvents.Text = "Upcoming Birthdays";
            // 
            // cbxChooseDisplay
            // 
            this.cbxChooseDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseDisplay.FormattingEnabled = true;
            this.cbxChooseDisplay.Items.AddRange(new object[] {
            "Birthdays",
            "Anniversaries"});
            this.cbxChooseDisplay.Location = new System.Drawing.Point(19, 33);
            this.cbxChooseDisplay.Name = "cbxChooseDisplay";
            this.cbxChooseDisplay.Size = new System.Drawing.Size(248, 29);
            this.cbxChooseDisplay.TabIndex = 3;
            this.cbxChooseDisplay.SelectedIndexChanged += new System.EventHandler(this.cbxChooseDisplay_SelectedIndexChanged);
            // 
            // dgvBirthdays
            // 
            this.dgvBirthdays.AllowUserToAddRows = false;
            this.dgvBirthdays.AllowUserToDeleteRows = false;
            this.dgvBirthdays.AllowUserToResizeColumns = false;
            this.dgvBirthdays.AllowUserToResizeRows = false;
            this.dgvBirthdays.AutoGenerateColumns = false;
            this.dgvBirthdays.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBirthdays.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBirthdays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBirthdays.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBirthdays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBirthdays.ColumnHeadersVisible = false;
            this.dgvBirthdays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIDDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.name});
            this.dgvBirthdays.DataSource = this.personBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBirthdays.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBirthdays.GridColor = System.Drawing.Color.RoyalBlue;
            this.dgvBirthdays.Location = new System.Drawing.Point(19, 68);
            this.dgvBirthdays.MultiSelect = false;
            this.dgvBirthdays.Name = "dgvBirthdays";
            this.dgvBirthdays.RowHeadersVisible = false;
            this.dgvBirthdays.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBirthdays.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBirthdays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBirthdays.ShowCellErrors = false;
            this.dgvBirthdays.ShowEditingIcon = false;
            this.dgvBirthdays.ShowRowErrors = false;
            this.dgvBirthdays.Size = new System.Drawing.Size(248, 223);
            this.dgvBirthdays.TabIndex = 2;
            this.dgvBirthdays.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBirthdays_CellFormatting);
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "PersonID";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            dataGridViewCellStyle1.Format = "M";
            dataGridViewCellStyle1.NullValue = null;
            this.dOBDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.Width = 5;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Width = 5;
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
            // pbxDisplayImage
            // 
            this.pbxDisplayImage.BackColor = System.Drawing.Color.Transparent;
            this.pbxDisplayImage.Image = global::MemberManager.Properties.Resources.Rings_icon;
            this.pbxDisplayImage.InitialImage = null;
            this.pbxDisplayImage.Location = new System.Drawing.Point(850, 97);
            this.pbxDisplayImage.Name = "pbxDisplayImage";
            this.pbxDisplayImage.Size = new System.Drawing.Size(50, 50);
            this.pbxDisplayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxDisplayImage.TabIndex = 1;
            this.pbxDisplayImage.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(76, 18);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(141, 47);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "5:20 pm";
            // 
            // lblVerseoftheDay
            // 
            this.lblVerseoftheDay.BackColor = System.Drawing.Color.Transparent;
            this.lblVerseoftheDay.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerseoftheDay.Location = new System.Drawing.Point(31, 273);
            this.lblVerseoftheDay.Name = "lblVerseoftheDay";
            this.lblVerseoftheDay.Size = new System.Drawing.Size(227, 150);
            this.lblVerseoftheDay.TabIndex = 4;
            this.lblVerseoftheDay.Text = "The night is nearly over; the day is almost here. So let us put aside the deeds o" +
    "f darkness and put on the armor of light.\r\n\r\nRomans 13:11-12 (NIV)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome back,";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(299, 40);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(146, 45);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Angeline";
            // 
            // Time
            // 
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // SetVerseoftheDay
            // 
            this.SetVerseoftheDay.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SetVerseoftheDay_DoWork);
            this.SetVerseoftheDay.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SetVerseoftheDay_RunWorkerCompleted);
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(912, 435);
            this.Controls.Add(this.pbxDisplayImage);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVerseoftheDay);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.gbUpcomingEvents);
            this.Controls.Add(this.mcCalendar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbUpcomingEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirthdays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisplayImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar mcCalendar;
        private System.Windows.Forms.GroupBox gbUpcomingEvents;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnNewService;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Label lblVerseoftheDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pbxDisplayImage;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.DataGridView dgvBirthdays;
        private ContactDataSet contactDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private ContactDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.ComponentModel.BackgroundWorker SetVerseoftheDay;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox cbxChooseDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}

