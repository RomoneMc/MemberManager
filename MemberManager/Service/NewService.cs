using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MemberManager.Service
{
    public partial class NewService : Form
    {
        Random rnd = new Random();

        public NewService()
        {
            InitializeComponent();
        }

        private void NewService_Load(object sender, EventArgs e)
        {
            this.serviceTableAdapter.Fill(this.contactDataSet.Service);
            serviceBindingSource.AddNew();
            txtServiceNumber.Text = rnd.Next(1000000, 2000000).ToString();
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
