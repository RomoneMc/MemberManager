namespace MemberManager.Groups
{
    partial class Groups
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
            this.relationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDataSet = new MemberManager.ContactDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadMembers = new System.ComponentModel.BackgroundWorker();
            this.relationTableAdapter = new MemberManager.ContactDataSetTableAdapters.RelationTableAdapter();
            this.personRelationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.person_RelationTableAdapter = new MemberManager.ContactDataSetTableAdapters.Person_RelationTableAdapter();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personTableAdapter = new MemberManager.ContactDataSetTableAdapters.PersonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.relationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personRelationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // relationBindingSource
            // 
            this.relationBindingSource.DataMember = "Relation";
            this.relationBindingSource.DataSource = this.contactDataSet;
            // 
            // contactDataSet
            // 
            this.contactDataSet.DataSetName = "ContactDataSet";
            this.contactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.relationBindingSource, "Relation Name", true));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.Location = new System.Drawing.Point(244, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.relationBindingSource, "Relation Type", true));
            this.label2.Location = new System.Drawing.Point(248, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // relationTableAdapter
            // 
            this.relationTableAdapter.ClearBeforeFill = true;
            // 
            // personRelationBindingSource
            // 
            this.personRelationBindingSource.DataMember = "Person_Relation";
            this.personRelationBindingSource.DataSource = this.contactDataSet;
            // 
            // person_RelationTableAdapter
            // 
            this.person_RelationTableAdapter.ClearBeforeFill = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.contactDataSet;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::MemberManager.Properties.Resources.tiny_grid;
            this.ClientSize = new System.Drawing.Size(752, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Groups";
            this.ShowIcon = false;
            this.Text = "Groups";
            this.Load += new System.EventHandler(this.Groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personRelationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ContactDataSet contactDataSet;
        private System.Windows.Forms.BindingSource relationBindingSource;
        private ContactDataSetTableAdapters.RelationTableAdapter relationTableAdapter;
        private System.ComponentModel.BackgroundWorker LoadMembers;
        private System.Windows.Forms.BindingSource personRelationBindingSource;
        private ContactDataSetTableAdapters.Person_RelationTableAdapter person_RelationTableAdapter;
        private System.Windows.Forms.BindingSource personBindingSource;
        private ContactDataSetTableAdapters.PersonTableAdapter personTableAdapter;
    }
}