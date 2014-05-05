using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MemberManager.Member
{
    public partial class AddMember : Form
    {
        Random rnd = new Random();
        int addedcount = 0;

        public AddMember()
        {
            InitializeComponent();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            dtpDateWaterBaptism.MaxDate = DateTime.Today;
            dtpAnniversary.MaxDate = DateTime.Today;
            dtpDOB.MaxDate = DateTime.Today;

            personBindingSource.AddNew();
            rolesBindingSource.AddNew();
            txtPersonID.Text = GenerateRandomPersonId();

            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                personBindingSource.EndEdit();
                personTableAdapter.Update(contactDataSet.Person);

                rolesBindingSource.EndEdit();
                rolesTableAdapter.Update(contactDataSet.Roles);

                contactDataSet.AcceptChanges();

                addedcount += 1;
                lblAddedCount.Text = addedcount.ToString();
            }
            catch (Exception)
            {
                throw;
            }

            personBindingSource.AddNew();
            rolesBindingSource.AddNew();

            List<CheckBox> chbox = tbpInformation.Controls.OfType<CheckBox>().ToList<CheckBox>();

            foreach (var box in chbox)
            {
                box.Checked = false;
            }

            txtPersonID.Text = GenerateRandomPersonId();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (addedcount > 0)
                DialogResult = System.Windows.Forms.DialogResult.OK;

            this.Close();
        }

        void ClearForm()
        {
            List<TextBox> ctrls = tbpInformation.Controls.OfType<TextBox>().ToList<TextBox>();
            List<CheckBox> cboxes = tbpInformation.Controls.OfType<CheckBox>().ToList<CheckBox>();

            foreach (var t in ctrls)
                t.Clear();

            foreach (var c in cboxes)
                c.Checked = false;

            cbxGender.Text = String.Empty;
            cbxMaritalStatus.Text = String.Empty;
            nudChildren.Value = 0;
        }

        string GenerateRandomPersonId()
        {
            return rnd.Next(1000000, 2000000).ToString();
        }

        private void dtpDateWaterBaptism_ValueChanged(object sender, EventArgs e)
        {
            txtDateWaterBaptism.Text = dtpDateWaterBaptism.Value.ToShortDateString();
        }

        private void dtpAnniversary_ValueChanged(object sender, EventArgs e)
        {
            txtAnniversary.Text = dtpAnniversary.Value.ToShortDateString();
        }

        private void txtPersonID_TextChanged(object sender, EventArgs e)
        {
            txtRoleID.Text = txtPersonID.Text;
        }

    }
}
