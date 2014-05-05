namespace MemberManager.Service
{
    partial class Service
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.dgvServiceList = new System.Windows.Forms.DataGridView();
            this.serviceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDataSet = new MemberManager.ContactDataSet();
            this.lblServiceTitle = new System.Windows.Forms.Label();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAttendantCount = new System.Windows.Forms.Label();
            this.LoadServiceAttendants = new System.ComponentModel.BackgroundWorker();
            this.lblServiceNumber = new System.Windows.Forms.Label();
            this.btnNewService = new System.Windows.Forms.Button();
            this.btnNewAttendant = new System.Windows.Forms.Button();
            this.dgvAttendants = new System.Windows.Forms.DataGridView();
            this.serviceTableAdapter = new MemberManager.ContactDataSetTableAdapters.ServiceTableAdapter();
            this.attendantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendantsTableAdapter = new MemberManager.ContactDataSetTableAdapters.AttendantsTableAdapter();
            this.personTableAdapter = new MemberManager.ContactDataSetTableAdapters.PersonTableAdapter();
            this.btnEditService = new System.Windows.Forms.Button();
            this.ttHinter = new System.Windows.Forms.ToolTip(this.components);
            this.btnSendReminder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendantsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServiceList
            // 
            this.dgvServiceList.AllowUserToAddRows = false;
            this.dgvServiceList.AllowUserToOrderColumns = true;
            this.dgvServiceList.AllowUserToResizeRows = false;
            this.dgvServiceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvServiceList.AutoGenerateColumns = false;
            this.dgvServiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServiceList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvServiceList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvServiceList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvServiceList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceNumberDataGridViewTextBoxColumn,
            this.serviceTitleDataGridViewTextBoxColumn,
            this.serviceDateDataGridViewTextBoxColumn});
            this.dgvServiceList.DataSource = this.serviceBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiceList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServiceList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvServiceList.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvServiceList.Location = new System.Drawing.Point(0, 0);
            this.dgvServiceList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvServiceList.MultiSelect = false;
            this.dgvServiceList.Name = "dgvServiceList";
            this.dgvServiceList.ReadOnly = true;
            this.dgvServiceList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvServiceList.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dgvServiceList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceList.Size = new System.Drawing.Size(261, 477);
            this.dgvServiceList.TabIndex = 0;
            this.dgvServiceList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceList_CellEndEdit);
            this.dgvServiceList.SelectionChanged += new System.EventHandler(this.dgvServiceList_SelectionChanged);
            this.dgvServiceList.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvServiceList_UserDeletingRow);
            // 
            // serviceNumberDataGridViewTextBoxColumn
            // 
            this.serviceNumberDataGridViewTextBoxColumn.DataPropertyName = "Service Number";
            this.serviceNumberDataGridViewTextBoxColumn.HeaderText = "Service Number";
            this.serviceNumberDataGridViewTextBoxColumn.Name = "serviceNumberDataGridViewTextBoxColumn";
            this.serviceNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // serviceTitleDataGridViewTextBoxColumn
            // 
            this.serviceTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serviceTitleDataGridViewTextBoxColumn.DataPropertyName = "Service Title";
            this.serviceTitleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.serviceTitleDataGridViewTextBoxColumn.Name = "serviceTitleDataGridViewTextBoxColumn";
            this.serviceTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceTitleDataGridViewTextBoxColumn.Width = 57;
            // 
            // serviceDateDataGridViewTextBoxColumn
            // 
            this.serviceDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serviceDateDataGridViewTextBoxColumn.DataPropertyName = "Service Date";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.serviceDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.serviceDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.serviceDateDataGridViewTextBoxColumn.Name = "serviceDateDataGridViewTextBoxColumn";
            this.serviceDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceDateDataGridViewTextBoxColumn.Width = 60;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.contactDataSet;
            // 
            // contactDataSet
            // 
            this.contactDataSet.DataSetName = "ContactDataSet";
            this.contactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblServiceTitle
            // 
            this.lblServiceTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServiceTitle.AutoSize = true;
            this.lblServiceTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Service Title", true));
            this.lblServiceTitle.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceTitle.Location = new System.Drawing.Point(267, 19);
            this.lblServiceTitle.Name = "lblServiceTitle";
            this.lblServiceTitle.Size = new System.Drawing.Size(268, 65);
            this.lblServiceTitle.TabIndex = 2;
            this.lblServiceTitle.Text = "Service Title";
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpServiceDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpServiceDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.serviceBindingSource, "Service Date", true));
            this.dtpServiceDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpServiceDate.Location = new System.Drawing.Point(317, 103);
            this.dtpServiceDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(339, 29);
            this.dtpServiceDate.TabIndex = 3;
            this.dtpServiceDate.Value = new System.DateTime(2014, 4, 24, 23, 59, 59, 0);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(280, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "on";
            // 
            // lblAttendantCount
            // 
            this.lblAttendantCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttendantCount.AutoSize = true;
            this.lblAttendantCount.BackColor = System.Drawing.Color.Transparent;
            this.lblAttendantCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAttendantCount.Location = new System.Drawing.Point(571, 137);
            this.lblAttendantCount.Name = "lblAttendantCount";
            this.lblAttendantCount.Size = new System.Drawing.Size(73, 15);
            this.lblAttendantCount.TabIndex = 6;
            this.lblAttendantCount.Text = "Attendant(s)";
            // 
            // LoadServiceAttendants
            // 
            this.LoadServiceAttendants.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LoadServiceAttendants_DoWork);
            this.LoadServiceAttendants.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.LoadServiceAttendants_RunWorkerCompleted);
            // 
            // lblServiceNumber
            // 
            this.lblServiceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServiceNumber.AutoSize = true;
            this.lblServiceNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Service Number", true));
            this.lblServiceNumber.Location = new System.Drawing.Point(568, 106);
            this.lblServiceNumber.Name = "lblServiceNumber";
            this.lblServiceNumber.Size = new System.Drawing.Size(43, 17);
            this.lblServiceNumber.TabIndex = 7;
            this.lblServiceNumber.Text = "label2";
            // 
            // btnNewService
            // 
            this.btnNewService.BackColor = System.Drawing.Color.Transparent;
            this.btnNewService.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNewService.FlatAppearance.BorderSize = 0;
            this.btnNewService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnNewService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewService.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewService.Image = global::MemberManager.Properties.Resources.appbar_group_add;
            this.btnNewService.Location = new System.Drawing.Point(3, 5);
            this.btnNewService.Name = "btnNewService";
            this.btnNewService.Size = new System.Drawing.Size(57, 57);
            this.btnNewService.TabIndex = 1;
            this.ttHinter.SetToolTip(this.btnNewService, "New Service");
            this.btnNewService.UseVisualStyleBackColor = false;
            this.btnNewService.Click += new System.EventHandler(this.btnNewService_Click);
            // 
            // btnNewAttendant
            // 
            this.btnNewAttendant.BackColor = System.Drawing.Color.Transparent;
            this.btnNewAttendant.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNewAttendant.FlatAppearance.BorderSize = 0;
            this.btnNewAttendant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnNewAttendant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewAttendant.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewAttendant.Image = global::MemberManager.Properties.Resources.appbar_people;
            this.btnNewAttendant.Location = new System.Drawing.Point(3, 130);
            this.btnNewAttendant.Name = "btnNewAttendant";
            this.btnNewAttendant.Size = new System.Drawing.Size(57, 57);
            this.btnNewAttendant.TabIndex = 1;
            this.ttHinter.SetToolTip(this.btnNewAttendant, "Add Attendants for this service.");
            this.btnNewAttendant.UseVisualStyleBackColor = false;
            this.btnNewAttendant.Click += new System.EventHandler(this.btnNewAttendant_Click);
            // 
            // dgvAttendants
            // 
            this.dgvAttendants.AllowUserToAddRows = false;
            this.dgvAttendants.AllowUserToOrderColumns = true;
            this.dgvAttendants.AllowUserToResizeRows = false;
            this.dgvAttendants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvAttendants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendants.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAttendants.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAttendants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAttendants.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAttendants.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAttendants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendants.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendants.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAttendants.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAttendants.Location = new System.Drawing.Point(317, 156);
            this.dgvAttendants.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAttendants.MultiSelect = false;
            this.dgvAttendants.Name = "dgvAttendants";
            this.dgvAttendants.ReadOnly = true;
            this.dgvAttendants.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAttendants.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dgvAttendants.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAttendants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendants.Size = new System.Drawing.Size(339, 301);
            this.dgvAttendants.TabIndex = 9;
            this.dgvAttendants.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvAttendants_UserDeletingRow);
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // attendantsBindingSource
            // 
            this.attendantsBindingSource.DataMember = "Attendants";
            this.attendantsBindingSource.DataSource = this.contactDataSet;
            // 
            // attendantsTableAdapter
            // 
            this.attendantsTableAdapter.ClearBeforeFill = true;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditService
            // 
            this.btnEditService.BackColor = System.Drawing.Color.Transparent;
            this.btnEditService.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditService.FlatAppearance.BorderSize = 0;
            this.btnEditService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnEditService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditService.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditService.Image = global::MemberManager.Properties.Resources.appbar_edit;
            this.btnEditService.Location = new System.Drawing.Point(3, 67);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(57, 57);
            this.btnEditService.TabIndex = 1;
            this.ttHinter.SetToolTip(this.btnEditService, "Edit Selected Service");
            this.btnEditService.UseVisualStyleBackColor = false;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // ttHinter
            // 
            this.ttHinter.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // btnSendReminder
            // 
            this.btnSendReminder.BackColor = System.Drawing.Color.Transparent;
            this.btnSendReminder.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSendReminder.FlatAppearance.BorderSize = 0;
            this.btnSendReminder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnSendReminder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSendReminder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSendReminder.Image = global::MemberManager.Properties.Resources.appbar_email_hardedge;
            this.btnSendReminder.Location = new System.Drawing.Point(3, 193);
            this.btnSendReminder.Name = "btnSendReminder";
            this.btnSendReminder.Size = new System.Drawing.Size(57, 57);
            this.btnSendReminder.TabIndex = 1;
            this.ttHinter.SetToolTip(this.btnSendReminder, "Mail a reminder");
            this.btnSendReminder.UseVisualStyleBackColor = false;
            this.btnSendReminder.Click += new System.EventHandler(this.btnSendReminder_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnNewService);
            this.panel1.Controls.Add(this.btnNewAttendant);
            this.panel1.Controls.Add(this.btnEditService);
            this.panel1.Controls.Add(this.btnSendReminder);
            this.panel1.Location = new System.Drawing.Point(692, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 477);
            this.panel1.TabIndex = 10;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemberManager.Properties.Resources.tiny_grid;
            this.ClientSize = new System.Drawing.Size(757, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAttendantCount);
            this.Controls.Add(this.dgvAttendants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpServiceDate);
            this.Controls.Add(this.lblServiceTitle);
            this.Controls.Add(this.dgvServiceList);
            this.Controls.Add(this.lblServiceNumber);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendantsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServiceList;
        private ContactDataSet contactDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private ContactDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.Label lblServiceTitle;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAttendantCount;
        private System.Windows.Forms.BindingSource attendantsBindingSource;
        private ContactDataSetTableAdapters.AttendantsTableAdapter attendantsTableAdapter;
        private ContactDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.ComponentModel.BackgroundWorker LoadServiceAttendants;
        private System.Windows.Forms.Label lblServiceNumber;
        private System.Windows.Forms.Button btnNewAttendant;
        private System.Windows.Forms.DataGridView dgvAttendants;
        private System.Windows.Forms.Button btnNewService;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.ToolTip ttHinter;
        private System.Windows.Forms.Button btnSendReminder;
        private System.Windows.Forms.Panel panel1;
    }
}