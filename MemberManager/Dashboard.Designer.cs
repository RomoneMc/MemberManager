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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnNewService = new System.Windows.Forms.Button();
            this.btnViewMembers = new System.Windows.Forms.Button();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.mcCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvBirthdays = new System.Windows.Forms.DataGridView();
            this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactDataSet = new MemberManager.ContactDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblVerseoftheDay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.personTableAdapter = new MemberManager.ContactDataSetTableAdapters.PersonTableAdapter();
            this.SetVerseoftheDay = new System.ComponentModel.BackgroundWorker();
            this.personBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvAnniversaries = new System.Windows.Forms.DataGridView();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirthdays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnniversaries)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.btnNewService);
            this.groupBox1.Controls.Add(this.btnViewMembers);
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
            this.btnLogout.Location = new System.Drawing.Point(163, 141);
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
            // 
            // btnViewMembers
            // 
            this.btnViewMembers.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnViewMembers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnViewMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMembers.Image = global::MemberManager.Properties.Resources.appbar_settings;
            this.btnViewMembers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewMembers.Location = new System.Drawing.Point(15, 141);
            this.btnViewMembers.Name = "btnViewMembers";
            this.btnViewMembers.Size = new System.Drawing.Size(132, 96);
            this.btnViewMembers.TabIndex = 1;
            this.btnViewMembers.Text = "Settings";
            this.btnViewMembers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewMembers.UseVisualStyleBackColor = true;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.dgvBirthdays);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(617, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 187);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upcoming Birthdays";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvBirthdays
            // 
            this.dgvBirthdays.AllowUserToAddRows = false;
            this.dgvBirthdays.AllowUserToDeleteRows = false;
            this.dgvBirthdays.AllowUserToResizeColumns = false;
            this.dgvBirthdays.AllowUserToResizeRows = false;
            this.dgvBirthdays.AutoGenerateColumns = false;
            this.dgvBirthdays.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBirthdays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBirthdays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBirthdays.ColumnHeadersVisible = false;
            this.dgvBirthdays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn});
            this.dgvBirthdays.DataSource = this.personBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBirthdays.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBirthdays.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBirthdays.Location = new System.Drawing.Point(20, 28);
            this.dgvBirthdays.MultiSelect = false;
            this.dgvBirthdays.Name = "dgvBirthdays";
            this.dgvBirthdays.ReadOnly = true;
            this.dgvBirthdays.RowHeadersVisible = false;
            this.dgvBirthdays.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBirthdays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBirthdays.ShowCellErrors = false;
            this.dgvBirthdays.ShowEditingIcon = false;
            this.dgvBirthdays.ShowRowErrors = false;
            this.dgvBirthdays.Size = new System.Drawing.Size(248, 139);
            this.dgvBirthdays.TabIndex = 2;
            // 
            // personBindingSource1
            // 
            this.personBindingSource1.DataMember = "Person";
            this.personBindingSource1.DataSource = this.contactDataSet;
            // 
            // contactDataSet
            // 
            this.contactDataSet.DataSetName = "ContactDataSet";
            this.contactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.dgvAnniversaries);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(617, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 212);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Upcoming Anniversaries";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(233, -10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
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
            this.lblUsername.Location = new System.Drawing.Point(299, 38);
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
            // personBindingSource2
            // 
            this.personBindingSource2.DataMember = "Person";
            this.personBindingSource2.DataSource = this.contactDataSet;
            // 
            // dgvAnniversaries
            // 
            this.dgvAnniversaries.AllowUserToAddRows = false;
            this.dgvAnniversaries.AllowUserToDeleteRows = false;
            this.dgvAnniversaries.AllowUserToResizeColumns = false;
            this.dgvAnniversaries.AllowUserToResizeRows = false;
            this.dgvAnniversaries.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAnniversaries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAnniversaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnniversaries.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnniversaries.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAnniversaries.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAnniversaries.Location = new System.Drawing.Point(20, 28);
            this.dgvAnniversaries.MultiSelect = false;
            this.dgvAnniversaries.Name = "dgvAnniversaries";
            this.dgvAnniversaries.ReadOnly = true;
            this.dgvAnniversaries.RowHeadersVisible = false;
            this.dgvAnniversaries.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvAnniversaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAnniversaries.ShowCellErrors = false;
            this.dgvAnniversaries.ShowEditingIcon = false;
            this.dgvAnniversaries.ShowRowErrors = false;
            this.dgvAnniversaries.Size = new System.Drawing.Size(248, 168);
            this.dgvAnniversaries.TabIndex = 3;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "PersonID";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(912, 435);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVerseoftheDay);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mcCalendar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirthdays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnniversaries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar mcCalendar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnNewService;
        private System.Windows.Forms.Button btnViewMembers;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Label lblVerseoftheDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.DataGridView dgvBirthdays;
        private ContactDataSet contactDataSet;
        private System.Windows.Forms.BindingSource personBindingSource1;
        private ContactDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.ComponentModel.BackgroundWorker SetVerseoftheDay;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.BindingSource personBindingSource2;
        private System.Windows.Forms.DataGridView dgvAnniversaries;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
    }
}

