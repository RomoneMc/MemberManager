using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MemberManager.Member
{
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            this.personTableAdapter.Fill(this.contactDataSet.Person);
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            Form addMember = new AddMember();
            if (addMember.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.personTableAdapter.Fill(this.contactDataSet.Person);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "'%" + txtSearch.Text + "%'";
            personBindingSource.Filter = "Name like " + query;
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you would like to remove this member?", "Remove Member", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                int pid = (int)dgvMemberGrid.SelectedRows[0].Cells["personID"].Value;

                try
                {
                    personTableAdapter.DeleteMember(pid);
                    this.personTableAdapter.Fill(this.contactDataSet.Person);
                }
                catch (Exception)
                {
                    MessageBox.Show("Member could not be removed. Please try again later.");
                }
            }
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            
        }
    }
}
