using System;
using Eauth;
using System.Windows.Forms;

namespace Eauth_CS_Winform
{
    public partial class eauthUpgradeForm : Form
    {
        EauthPrimaryClass eauthClass = new EauthPrimaryClass(); //  Creates a new instance of the "EauthPrimaryClass" class and assigns it to the "eauthClass" variable

        public eauthUpgradeForm()
        {
            InitializeComponent();
        }

        private void loginInsteadButton_Click(object sender, EventArgs e)
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void eauthUpgradeForm_Load(object sender, EventArgs e)
        {
            if (await eauthClass.InitRequest() == false)
            {
                MessageBox.Show(EauthPrimaryClass.errorMessage);
            }
        }

        private async void upgradeButton_Click(object sender, EventArgs e)
        {
            upgradeButton.Enabled = false;
            if (await eauthClass.UpgradeRequest(nameInput.Text, keyInput.Text))
            {
                // Code block executed if credentials are valid:
                MessageBox.Show("The account has been successfully upgraded.");
            }
            else
            {
                MessageBox.Show(EauthPrimaryClass.errorMessage);
            }
            upgradeButton.Enabled = true;
        }
    }
}
