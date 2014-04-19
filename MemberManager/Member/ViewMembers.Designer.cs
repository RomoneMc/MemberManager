namespace MemberManager.Member
{
    partial class ViewMembers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMembers));
            this.dgvMemberGrid = new System.Windows.Forms.DataGridView();
            this.personID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anniversaryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberSinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterBaptismDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Church = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherMinistryDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.previousRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDataSet = new MemberManager.ContactDataSet();
            this.personTableAdapter = new MemberManager.ContactDataSetTableAdapters.PersonTableAdapter();
            this.pnlManageMembers = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).BeginInit();
            this.pnlManageMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMemberGrid
            // 
            this.dgvMemberGrid.AllowUserToAddRows = false;
            this.dgvMemberGrid.AllowUserToOrderColumns = true;
            this.dgvMemberGrid.AllowUserToResizeRows = false;
            this.dgvMemberGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMemberGrid.AutoGenerateColumns = false;
            this.dgvMemberGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMemberGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMemberGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMemberGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMemberGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personID,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.maritalStatusDataGridViewTextBoxColumn,
            this.anniversaryDateDataGridViewTextBoxColumn,
            this.childrenDataGridViewTextBoxColumn,
            this.occupationDataGridViewTextBoxColumn,
            this.memberRoleDataGridViewTextBoxColumn,
            this.visitsDataGridViewTextBoxColumn,
            this.memberSinceDataGridViewTextBoxColumn,
            this.waterBaptismDateDataGridViewTextBoxColumn,
            this.Church,
            this.otherMinistryDataGridViewCheckBoxColumn,
            this.previousRoleDataGridViewTextBoxColumn});
            this.dgvMemberGrid.DataSource = this.personBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMemberGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMemberGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMemberGrid.Location = new System.Drawing.Point(14, 52);
            this.dgvMemberGrid.MultiSelect = false;
            this.dgvMemberGrid.Name = "dgvMemberGrid";
            this.dgvMemberGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMemberGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberGrid.Size = new System.Drawing.Size(845, 423);
            this.dgvMemberGrid.TabIndex = 0;
            // 
            // personID
            // 
            this.personID.DataPropertyName = "PersonID";
            this.personID.HeaderText = "PersonID";
            this.personID.Name = "personID";
            this.personID.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // maritalStatusDataGridViewTextBoxColumn
            // 
            this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "Marital Status";
            this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "Marital Status";
            this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
            // 
            // anniversaryDateDataGridViewTextBoxColumn
            // 
            this.anniversaryDateDataGridViewTextBoxColumn.DataPropertyName = "Anniversary Date";
            this.anniversaryDateDataGridViewTextBoxColumn.HeaderText = "Anniversary Date";
            this.anniversaryDateDataGridViewTextBoxColumn.Name = "anniversaryDateDataGridViewTextBoxColumn";
            // 
            // childrenDataGridViewTextBoxColumn
            // 
            this.childrenDataGridViewTextBoxColumn.DataPropertyName = "Children";
            this.childrenDataGridViewTextBoxColumn.HeaderText = "Children";
            this.childrenDataGridViewTextBoxColumn.Name = "childrenDataGridViewTextBoxColumn";
            // 
            // occupationDataGridViewTextBoxColumn
            // 
            this.occupationDataGridViewTextBoxColumn.DataPropertyName = "Occupation";
            this.occupationDataGridViewTextBoxColumn.HeaderText = "Occupation";
            this.occupationDataGridViewTextBoxColumn.Name = "occupationDataGridViewTextBoxColumn";
            // 
            // memberRoleDataGridViewTextBoxColumn
            // 
            this.memberRoleDataGridViewTextBoxColumn.DataPropertyName = "Member Role";
            this.memberRoleDataGridViewTextBoxColumn.HeaderText = "Member Role";
            this.memberRoleDataGridViewTextBoxColumn.Name = "memberRoleDataGridViewTextBoxColumn";
            // 
            // visitsDataGridViewTextBoxColumn
            // 
            this.visitsDataGridViewTextBoxColumn.DataPropertyName = "Visits";
            this.visitsDataGridViewTextBoxColumn.HeaderText = "Visits";
            this.visitsDataGridViewTextBoxColumn.Name = "visitsDataGridViewTextBoxColumn";
            // 
            // memberSinceDataGridViewTextBoxColumn
            // 
            this.memberSinceDataGridViewTextBoxColumn.DataPropertyName = "Member Since";
            this.memberSinceDataGridViewTextBoxColumn.HeaderText = "Member Since";
            this.memberSinceDataGridViewTextBoxColumn.Name = "memberSinceDataGridViewTextBoxColumn";
            // 
            // waterBaptismDateDataGridViewTextBoxColumn
            // 
            this.waterBaptismDateDataGridViewTextBoxColumn.DataPropertyName = "Water Baptism Date";
            this.waterBaptismDateDataGridViewTextBoxColumn.HeaderText = "Water Baptism Date";
            this.waterBaptismDateDataGridViewTextBoxColumn.Name = "waterBaptismDateDataGridViewTextBoxColumn";
            // 
            // Church
            // 
            this.Church.DataPropertyName = "Church";
            this.Church.HeaderText = "Church";
            this.Church.Name = "Church";
            // 
            // otherMinistryDataGridViewCheckBoxColumn
            // 
            this.otherMinistryDataGridViewCheckBoxColumn.DataPropertyName = "Other Ministry";
            this.otherMinistryDataGridViewCheckBoxColumn.HeaderText = "Other Ministry";
            this.otherMinistryDataGridViewCheckBoxColumn.Name = "otherMinistryDataGridViewCheckBoxColumn";
            // 
            // previousRoleDataGridViewTextBoxColumn
            // 
            this.previousRoleDataGridViewTextBoxColumn.DataPropertyName = "Previous Role";
            this.previousRoleDataGridViewTextBoxColumn.HeaderText = "Previous Role";
            this.previousRoleDataGridViewTextBoxColumn.Name = "previousRoleDataGridViewTextBoxColumn";
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
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // pnlManageMembers
            // 
            this.pnlManageMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlManageMembers.BackColor = System.Drawing.Color.White;
            this.pnlManageMembers.BackgroundImage = global::MemberManager.Properties.Resources.diagonal_noise;
            this.pnlManageMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlManageMembers.Controls.Add(this.label1);
            this.pnlManageMembers.Controls.Add(this.txtSearch);
            this.pnlManageMembers.Controls.Add(this.btnRemoveMember);
            this.pnlManageMembers.Controls.Add(this.btnEditMember);
            this.pnlManageMembers.Controls.Add(this.btnAddMember);
            this.pnlManageMembers.Location = new System.Drawing.Point(-6, -1);
            this.pnlManageMembers.Name = "pnlManageMembers";
            this.pnlManageMembers.Size = new System.Drawing.Size(883, 47);
            this.pnlManageMembers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(511, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSearch.Location = new System.Drawing.Point(562, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(302, 32);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveMember.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnRemoveMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRemoveMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMember.Image = global::MemberManager.Properties.Resources.remove_user_32;
            this.btnRemoveMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveMember.Location = new System.Drawing.Point(281, 5);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(144, 35);
            this.btnRemoveMember.TabIndex = 0;
            this.btnRemoveMember.Text = "Remove Member";
            this.btnRemoveMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveMember.UseVisualStyleBackColor = false;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.BackColor = System.Drawing.Color.Transparent;
            this.btnEditMember.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnEditMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMember.Image = global::MemberManager.Properties.Resources.edit_user_32;
            this.btnEditMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMember.Location = new System.Drawing.Point(150, 5);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(125, 35);
            this.btnEditMember.TabIndex = 0;
            this.btnEditMember.Text = "Edit Member";
            this.btnEditMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditMember.UseVisualStyleBackColor = false;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMember.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Image = global::MemberManager.Properties.Resources.add_user_32;
            this.btnAddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMember.Location = new System.Drawing.Point(19, 5);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(125, 35);
            this.btnAddMember.TabIndex = 0;
            this.btnAddMember.Text = "New Member";
            this.btnAddMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // ViewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 487);
            this.Controls.Add(this.pnlManageMembers);
            this.Controls.Add(this.dgvMemberGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewMembers";
            this.Text = "Members";
            this.Load += new System.EventHandler(this.ViewMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).EndInit();
            this.pnlManageMembers.ResumeLayout(false);
            this.pnlManageMembers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMemberGrid;
        private System.Windows.Forms.Panel pnlManageMembers;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.Button btnEditMember;
        private ContactDataSet contactDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private ContactDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anniversaryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberSinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterBaptismDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Church;
        private System.Windows.Forms.DataGridViewCheckBoxColumn otherMinistryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousRoleDataGridViewTextBoxColumn;
    }
}