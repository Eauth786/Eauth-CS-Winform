using System;
using System.Windows.Forms;
using Eauth;

namespace Eauth_CS_Winform
{
    public partial class eauthLoginFormLK : Form
    {
        EauthPrimaryClass eauthClass = new EauthPrimaryClass(); //  Creates a new instance of the "EauthPrimaryClass" class and assigns it to the "eauthClass" variable

        public eauthLoginFormLK()
        {
            InitializeComponent();
        }

        private async void eauthLoginFormLK_Load(object sender, EventArgs e)
        {
            if (await eauthClass.InitRequest() == false)
            {
                MessageBox.Show(EauthPrimaryClass.errorMessage);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string licenseKey = licenseField1.Text + "-" + licenseField2.Text + "-" + licenseField3.Text + "-" + licenseField4.Text;
            if (licenseKey.EndsWith("-"))
            {
                licenseKey = licenseKey.Remove(licenseKey.Length - 1);
            }

            loginButton.Enabled = false;
            if (await eauthClass.LoginRequest("", "", licenseKey))
            {
                // Code block executed if credentials are valid:
                MessageBox.Show(EauthPrimaryClass.loggedMessage
                    + "\n " + "Rank: " + EauthPrimaryClass.userRank
                    + "\n " + "Hardware-ID: " + EauthPrimaryClass.userHwid
                    + "\n " + "Register Date: " + EauthPrimaryClass.registerDate
                    + "\n " + "Expire Date: " + EauthPrimaryClass.expireDate);
            }
            else
            {
                MessageBox.Show(EauthPrimaryClass.errorMessage);
            }
            loginButton.Enabled = true;
        }

        private void loginNamePasswordButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            eauthLoginFormUP loginForm = new eauthLoginFormUP();

            // Hide the current form
            this.Hide();

            // Show the new form
            loginForm.ShowDialog();

            // Close the current form
            this.Close();
        }

        private void licenseField1_TextChanged(object sender, EventArgs e)
        {
            licenseField2.Text = "";
            licenseField3.Text = "";
            licenseField4.Text = "";
            try
            {
                string[] parts = licenseField1.Text.Split('-');
                licenseField1.Text = parts[0];
                licenseField2.Text = parts[1];
                licenseField3.Text = parts[2];
                licenseField4.Text = parts[3];
            }
            catch
            {

            }
        }
    }
}
