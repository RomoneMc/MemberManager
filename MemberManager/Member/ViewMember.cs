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
    public partial class ViewMember : Form
    {
        public ViewMember()
        {
            InitializeComponent();
        }

        private void ViewMember_Load(object sender, EventArgs e)
        {
            this.personTableAdapter.Fill(this.contactDataSet.Person);
            this.rolesTableAdapter.Fill(this.contactDataSet.Roles);

            rolesBindingSource.Position = rolesBindingSource.Find("PersonID", lblPersonID.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "'%" + txtSearch.Text + "%'";
            personBindingSource.Filter = "Name like " + query;
        }

        private void btnPreviousMember_Click(object sender, EventArgs e)
        {
            personBindingSource.MovePrevious();
        }

        private void btnNextMember_Click(object sender, EventArgs e)
        {
            personBindingSource.MoveNext();
        }

        private void lblPersonID_TextChanged_1(object sender, EventArgs e)
        {
            rolesBindingSource.Position = rolesBindingSource.Find("PersonID", lblPersonID.Text);
        }
    }
}
