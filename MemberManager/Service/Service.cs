using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace MemberManager.Service
{
    public partial class Service : Form
    {
        ContactDataSet.AttendantsDataTable atd = new ContactDataSet.AttendantsDataTable();

        public Service()
        {
            InitializeComponent();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            this.serviceTableAdapter.Fill(this.contactDataSet.Service);
            this.attendantsTableAdapter.Fill(this.contactDataSet.Attendants);
            this.personTableAdapter.Fill(this.contactDataSet.Person);

            if (!LoadServiceAttendants.IsBusy)
            {
                LoadServiceAttendants.RunWorkerAsync();
            }

        }

        private void LoadServiceAttendants_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int snumber = Int32.Parse(lblServiceNumber.Text);
            atd = attendantsTableAdapter.GetAttendantsByService(snumber);
        }

        private void LoadServiceAttendants_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            dgvAttendants.DataSource = atd;
            dgvAttendants.Columns["Service Number"].Visible = false;
            dgvAttendants.Columns["PersonID"].Visible = false;

            if(dgvAttendants.RowCount == 0)
            {
                lblAttendantCount.Text = "No Attendants";
            }
            else
            {
                lblAttendantCount.Text = dgvAttendants.RowCount.ToString() + " Attendants";
            }
        }

        private void dgvServiceList_SelectionChanged(object sender, EventArgs e)
        {
            if(!LoadServiceAttendants.IsBusy)
            {
                LoadServiceAttendants.RunWorkerAsync();
            }
        }

        private void dgvAttendants_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to remove this attendant?", "Remove Attendant", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                int personid = (int)dgvAttendants.SelectedRows[0].Cells["PersonID"].Value;
                attendantsTableAdapter.Delete(personid, Int32.Parse(lblServiceNumber.Text));

                LoadServiceAttendants.RunWorkerAsync();
                dgvAttendants.DataSource = atd;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnNewAttendant_Click(object sender, EventArgs e)
        {
            ManageAttendants f = new ManageAttendants(Int32.Parse(lblServiceNumber.Text), lblServiceTitle.Text);

            if(f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadServiceAttendants.RunWorkerAsync();
                dgvAttendants.DataSource = atd;
            }
        }

        private void dgvServiceList_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to remove this service?", "Remove Service", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                serviceTableAdapter.Delete(Int32.Parse(lblServiceNumber.Text));
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dgvServiceList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to edit this service?", "Edit Service", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                serviceBindingSource.EndEdit();
                serviceTableAdapter.Update(contactDataSet.Service);
                contactDataSet.AcceptChanges();
            }
            else
            {
                dgvServiceList.CancelEdit();
            }
        }

        private void btnNewService_Click(object sender, EventArgs e)
        {
            NewService f = new NewService();
            if(f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.serviceTableAdapter.Fill(contactDataSet.Service);
            }
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            EditService f = new EditService(Int32.Parse(lblServiceNumber.Text), lblServiceTitle.Text);
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.serviceTableAdapter.Fill(contactDataSet.Service);
            }
        }

        private void btnSendReminder_Click(object sender, EventArgs e)
        {
            ContactDataSet.PersonDataTable addresses = personTableAdapter.GetEmailAddresses();
            //String[] emails = new string[addresses.Rows.Count];
            string addr = "romonemc@gmail.com";

            for (int i = 0; i < addresses.Rows.Count; i++)
            {
                //emails[i] = addresses[i].Email;
                addr += ", " + addresses[i].Email;
            }

            try
            {
                string body = "You are being cordially invited to The Open Door Church " + lblServiceTitle.Text + " service  which is on " + dtpServiceDate.Value.ToLongDateString() + " starting at 10:00 A.M.";
                MailAddress fr = new MailAddress("romonemc@gmail.com", "Romone Mcfarlane from Open Door Church");

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("romonemc@gmail.com", "mcfarlane1");

                MailMessage msg = new MailMessage(fr.ToString(), addr, lblServiceTitle.Text, body);
                client.Send(msg);
                MessageBox.Show("Reminder Sent Successfully.");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
