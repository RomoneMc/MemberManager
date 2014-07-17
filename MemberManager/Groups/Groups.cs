using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MemberManager.Groups
{
    public partial class Groups : Form
    {
        public Groups()
        {
            InitializeComponent();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            this.personTableAdapter.Fill(this.contactDataSet.Person);
            this.relationTableAdapter.Fill(this.contactDataSet.Relation);
            this.person_RelationTableAdapter.Fill(this.contactDataSet.Person_Relation);
        }
    }
}