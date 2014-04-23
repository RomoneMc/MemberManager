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
    public partial class ManageAttendants : Form
    {
        public int ServiceID;
        public string ServiceName;

        public ManageAttendants()
        {
            InitializeComponent();
        }

        public ManageAttendants(int sid, string sname)
        {
            ServiceID = sid;
            ServiceName = sname;
            InitializeComponent();
        }

        private void ManageAttendants_Load(object sender, EventArgs e)
        {
            lblServiceName.Text = lblServiceName.Text.Insert(lblServiceName.Text.Length - 1, ServiceName);
            this.attendantsTableAdapter.Fill(this.contactDataSet.Attendants);
            this.personTableAdapter.Fill(this.contactDataSet.Person);

            try
            {
                clbAttendants.DataSource = personTableAdapter.GetNonAttendants(ServiceID);
                clbAttendants.DisplayMember = "Name";
                clbAttendants.ValueMember = "PersonID";
            }
            catch (Exception)
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (object checkeditem in clbAttendants.CheckedItems)
            {
                DataRowView person = checkeditem as DataRowView;

                int id = (int) person["PersonID"];
                string name = person["Name"].ToString();

                attendantsTableAdapter.Insert(ServiceID, id);
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
