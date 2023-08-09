using System;
using System.Windows.Forms;
using Eauth;

namespace Eauth_CS_Winform
{
    public partial class eauthLoginForm : Form
    {
        EauthPrimaryClass eauthClass = new EauthPrimaryClass(); //  Creates a new instance of the "EauthPrimaryClass" class and assigns it to the "eauthClass" variable
        
        public eauthLoginForm()
        {
            InitializeComponent();
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

        private async void loginButton_Click(object sender, EventArgs e)
        {
            if (await eauthClass.LoginRequest(nameInput.Text, passwordInput.Text, keyInput.Text))
            {
                MessageBox.Show(EauthPrimaryClass.loggedMessage
                    + "\n " + "Rank: " + eauthClass.userRank
                    + "\n " + "Hardware-ID: " + eauthClass.userHwid
                    + "\n " + "Register Date: " + eauthClass.registerDate
                    + "\n " + "Expire Date: " + eauthClass.expireDate);
            }
        }

        private void eauthLoginForm_Load(object sender, EventArgs e)
        {
            eauthClass.InitRequest(); // Init request (required)
        }
    }
}
