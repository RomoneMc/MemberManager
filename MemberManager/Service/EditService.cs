using System;
using System.Windows.Forms;

namespace MemberManager.Service
{
    public partial class EditService : Form
    {
        int ServiceID { get; set; }
        string ServiceName { get; set; }

        public EditService()
        {
            InitializeComponent();
        }

        public EditService(int sid, string sname)
        {
            InitializeComponent();
            ServiceID = sid;
            ServiceName = sname;
        }

        private void EditService_Load(object sender, EventArgs e)
        {
            this.serviceTableAdapter.Fill(this.contactDataSet.Service);
            lblServiceName.Text = lblServiceName.Text.Insert(lblServiceName.Text.Length, " " + ServiceName);
            serviceBindingSource.Position = serviceBindingSource.Find("Service Number", ServiceID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            serviceBindingSource.EndEdit();
            serviceTableAdapter.Update(this.contactDataSet.Service);
            contactDataSet.AcceptChanges();

            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
