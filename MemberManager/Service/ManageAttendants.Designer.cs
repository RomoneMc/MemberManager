namespace MemberManager.Service
{
    partial class ManageAttendants
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
            this.lblServiceName = new System.Windows.Forms.Label();
            this.attendantsTableAdapter = new MemberManager.ContactDataSetTableAdapters.AttendantsTableAdapter();
            this.contactDataSet = new MemberManager.ContactDataSet();
            this.personTableAdapter = new MemberManager.ContactDataSetTableAdapters.PersonTableAdapter();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clbAttendants = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServiceName
            // 
            this.lblServiceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServiceName.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(12, 10);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(332, 85);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "Add Attendants for  ";
            // 
            // attendantsTableAdapter
            // 
            this.attendantsTableAdapter.ClearBeforeFill = true;
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
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.contactDataSet;
            // 
            // clbAttendants
            // 
            this.clbAttendants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbAttendants.BackColor = System.Drawing.Color.White;
            this.clbAttendants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbAttendants.CheckOnClick = true;
            this.clbAttendants.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.personBindingSource, "Name", true));
            this.clbAttendants.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.clbAttendants.FormatString = "Name";
            this.clbAttendants.FormattingEnabled = true;
            this.clbAttendants.Location = new System.Drawing.Point(12, 98);
            this.clbAttendants.Name = "clbAttendants";
            this.clbAttendants.Size = new System.Drawing.Size(332, 332);
            this.clbAttendants.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnSave.Location = new System.Drawing.Point(6, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 43);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnClose.Location = new System.Drawing.Point(169, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(169, 43);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlControls.Controls.Add(this.btnSave);
            this.pnlControls.Controls.Add(this.btnClose);
            this.pnlControls.Location = new System.Drawing.Point(6, 430);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(341, 49);
            this.pnlControls.TabIndex = 5;
            // 
            // ManageAttendants
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::MemberManager.Properties.Resources.tiny_grid;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(356, 488);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.clbAttendants);
            this.Controls.Add(this.lblServiceName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageAttendants";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Attendants";
            this.Load += new System.EventHandler(this.ManageAttendants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServiceName;
        private ContactDataSetTableAdapters.AttendantsTableAdapter attendantsTableAdapter;
        private ContactDataSet contactDataSet;
        private ContactDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.CheckedListBox clbAttendants;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlControls;
    }
}