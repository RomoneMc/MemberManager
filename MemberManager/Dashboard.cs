using System;
using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;
using OpenDoorLibrary;

namespace MemberManager
{
    public partial class Dashboard : Form
    {
        Computer MyComputer = new Computer();
        string Votd = String.Empty;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //this.personTableAdapter.Fill(this.contactDataSet.Person);
            lblUsername.Text = OpenDoorLibrary.User.username;
            Time.Start();

            // Retrieve verse of the day if internet is available
            if (MyComputer.Network.IsAvailable)
                SetVerseoftheDay.RunWorkerAsync();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            Form f = new Member.ViewMembers();
            f.Show();
        }

        // Background Worker Set Verse of the Day

        private void SetVerseoftheDay_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Votd = OpenDoorLibrary.VerseoftheDay.GetVerseoftheDay();
        }

        private void SetVerseoftheDay_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            lblVerseoftheDay.Text = Votd;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
