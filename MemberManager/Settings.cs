using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;
using System.Configuration;

namespace MemberManager
{
    public partial class Settings : Form
    {
        string location;

        public Settings()
        {
            InitializeComponent();
        }

        public void updateConfigFile(string con)
        {
            //updating config file
            XmlDocument XmlDoc = new XmlDocument();
            //Loading the Config file
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    //setting the coonection string
                    xElement.FirstChild.Attributes[2].Value = con;
                }
            }
            //writing the connection string in config file
            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fbdDBLocation.ShowDialog() == DialogResult.OK)
            {
                string str = "Data Source=";
                location = fbdDBLocation.SelectedPath;
                location += @"\Contact.accdb";
                str = str + location;

                txtNewConnectionString.Text = str;

                updateConfigFile(str);
                SqlConnection db = new SqlConnection();
                ConfigurationManager.RefreshSection("connectionStrings");
                db.ConnectionString = ConfigurationManager.ConnectionStrings["MemberManager.Properties.Settings.ContactConnectionString"].ToString();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txtOldConnectionString.Text = ConfigurationManager.ConnectionStrings["MemberManager.Properties.Settings.ContactConnectionString"].ToString();
        }
    }
}
