using System;
using System.Windows.Forms;
using OpenDoorLibrary;

namespace MemberManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text != String.Empty && txtPassword.Text != String.Empty)
            {
                if (usersTableAdapter.LoginQuery(txtUsername.Text, txtPassword.Text) == 1)
                {
                    User defaultuser = new User(txtUsername.Text);

                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your username or password is incorrect. Please try again.", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter both your username and password.", "Blank Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtUsername.Clear();
            txtUsername.Focus();
            txtPassword.Clear();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings f = new Settings();
            f.ShowDialog();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                btnSettings.Visible = true;
            }
            else
            {
                btnSettings.Visible = false;
            }
        }

    }
}