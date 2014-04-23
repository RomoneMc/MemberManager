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
            this.personTableAdapter.Fill(this.contactDataSet.Person);
            lblUsername.Text = OpenDoorLibrary.User.username;
            Time.Start();

            cbxChooseDisplay.SelectedIndex = 0;

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

        private void cbxChooseDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxChooseDisplay.SelectedIndex == 0)
            {
                gbUpcomingEvents.Text = "Upcoming Birthdays";
                personBindingSource.Filter = "DOB >= #" + DateTime.Today + "# AND DOB <= #" + DateTime.Today.AddDays(7) + "#";
                pbxDisplayImage.Image = MemberManager.Properties.Resources.bcake;
            }
            else
            {
                gbUpcomingEvents.Text = "Upcoming Anniversaries";
                personBindingSource.Filter = "[Anniversary Date] >= #" + DateTime.Today + "# AND [Anniversary Date] <= #" + DateTime.Today.AddDays(7) + "#";
                pbxDisplayImage.Image = MemberManager.Properties.Resources.Rings_icon;
            }
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void dgvBirthdays_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (cbxChooseDisplay.SelectedIndex == 1)
            {
                if (dgv.Columns[e.ColumnIndex].Name == "name" && e.RowIndex >= 0 && dgv["name", e.RowIndex].Value is string)
                {
                    string modname;
                    string n = e.Value.ToString();

                    int spacepos = n.LastIndexOf(" ");
                    int dashpos = n.LastIndexOf("-");

                    if(dashpos > spacepos)
                    {
                        modname = n.Remove(0, dashpos + 1);
                        modname = modname.Insert(0, "The ");
                    }
                    else
                    {
                        modname = n.Remove(0, spacepos);
                        modname = modname.Insert(0, "The");
                    }

                    modname = modname.Insert(modname.Length, "'s");
                    e.Value = modname;
                }
            }
        }

        private void btnNewService_Click(object sender, EventArgs e)
        {
            Form service = new Service.Service();
            service.Show();
        }
    }
}
