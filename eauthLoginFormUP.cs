using System;
using System.Windows.Forms;
using Eauth;

namespace Eauth_CS_Winform
{
    public partial class eauthLoginFormUP : Form
    {
        EauthPrimaryClass eauthClass = new EauthPrimaryClass(); //  Creates a new instance of the "EauthPrimaryClass" class and assigns it to the "eauthClass" variable
        
        public eauthLoginFormUP()
        {
            InitializeComponent();
        }

        private async void eauthLoginForm_Load(object sender, EventArgs e)
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
            loginButton.Enabled = false;
            if (await eauthClass.LoginRequest(nameInput.Text, passwordInput.Text, ""))
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

        private void registerInsteadButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            eauthRegisterForm registerForm = new eauthRegisterForm();

            // Hide the current form
            this.Hide();

            // Show the new form
            registerForm.ShowDialog();

            // Close the current form
            this.Close();
        }

        private void loginNamePasswordButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            eauthLoginFormLK loginForm = new eauthLoginFormLK();

            // Hide the current form
            this.Hide();

            // Show the new form
            loginForm.ShowDialog();

            // Close the current form
            this.Close();
        }
    }
}
