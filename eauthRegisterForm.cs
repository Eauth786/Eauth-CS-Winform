using Eauth;
using System;
using System.Windows.Forms;

namespace Eauth_CS_Winform
{
    public partial class eauthRegisterForm : Form
    {
        EauthPrimaryClass eauthClass = new EauthPrimaryClass(); //  Creates a new instance of the "EauthPrimaryClass" class and assigns it to the "eauthClass" variable

        public eauthRegisterForm()
        {
            InitializeComponent();
        }

        private void loginInsteadButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            eauthLoginForm loginForm = new eauthLoginForm();

            // Hide the current form
            this.Hide();

            // Show the new form
            loginForm.ShowDialog();

            // Close the current form
            this.Close();
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EauthPrimaryClass.registeredMessage);
            if (await eauthClass.RegisterRequest(nameInput.Text, passwordInput.Text, keyInput.Text))
            {
                MessageBox.Show("" + EauthPrimaryClass.registeredMessage);
            }
        }
    }
}
