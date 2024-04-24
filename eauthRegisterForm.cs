using System;
using System.Windows.Forms;
using Eauth;

namespace Eauth_CS_Winform
{
    public partial class eauthRegisterForm : Form
    {
        EauthPrimaryClass eauthClass = new EauthPrimaryClass(); //  Creates a new instance of the "EauthPrimaryClass" class and assigns it to the "eauthClass" variable

        public eauthRegisterForm()
        {
            InitializeComponent();
        }

        private async void eauthRegisterForm_Load(object sender, EventArgs e)
        {
            if (await eauthClass.InitRequest() == false)
            {
                MessageBox.Show(EauthPrimaryClass.errorMessage);
            }
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

        private async void registerButton_Click(object sender, EventArgs e)
        {
            registerButton.Enabled = false;
            if (await eauthClass.RegisterRequest(nameInput.Text, emailInput.Text, passwordInput.Text, keyInput.Text))
            {
                // Code block executed if credentials are valid:
                MessageBox.Show(EauthPrimaryClass.registeredMessage);
                registerButton.PerformClick();
            }
            else
            {
                MessageBox.Show(EauthPrimaryClass.errorMessage);
            }
            registerButton.Enabled = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
