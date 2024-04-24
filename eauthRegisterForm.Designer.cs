
namespace Eauth_CS_Winform
{
    partial class eauthRegisterForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.registerInsteadButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.exitButton = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.colorPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.registerButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwordInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.nameInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.keyInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.emailInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.DragStartTransparencyValue = 1D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // registerInsteadButton
            // 
            this.registerInsteadButton.Animated = true;
            this.registerInsteadButton.AutoRoundedCorners = true;
            this.registerInsteadButton.BorderRadius = 10;
            this.registerInsteadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerInsteadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerInsteadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerInsteadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerInsteadButton.FillColor = System.Drawing.Color.Transparent;
            this.registerInsteadButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.registerInsteadButton.ForeColor = System.Drawing.Color.White;
            this.registerInsteadButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.registerInsteadButton.Location = new System.Drawing.Point(15, 212);
            this.registerInsteadButton.Name = "registerInsteadButton";
            this.registerInsteadButton.Size = new System.Drawing.Size(310, 23);
            this.registerInsteadButton.TabIndex = 25;
            this.registerInsteadButton.Text = "I Have an Account";
            this.registerInsteadButton.Click += new System.EventHandler(this.loginInsteadButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.FillColor = System.Drawing.Color.Transparent;
            this.exitButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(21)))), ((int)(((byte)(39)))));
            this.exitButton.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.exitButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.exitButton.Location = new System.Drawing.Point(295, 9);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.exitButton.Size = new System.Drawing.Size(30, 35);
            this.exitButton.TabIndex = 24;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.colorPanel.Location = new System.Drawing.Point(0, 0);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(334, 1);
            this.colorPanel.TabIndex = 23;
            // 
            // registerButton
            // 
            this.registerButton.Animated = true;
            this.registerButton.AutoRoundedCorners = true;
            this.registerButton.BorderRadius = 10;
            this.registerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.registerButton.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(15, 183);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(310, 23);
            this.registerButton.TabIndex = 22;
            this.registerButton.Text = "Register";
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 17);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Eauth | Register";
            // 
            // passwordInput
            // 
            this.passwordInput.Animated = true;
            this.passwordInput.AutoRoundedCorners = true;
            this.passwordInput.BackColor = System.Drawing.Color.Transparent;
            this.passwordInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.passwordInput.BorderRadius = 10;
            this.passwordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInput.DefaultText = "";
            this.passwordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.passwordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.passwordInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordInput.ForeColor = System.Drawing.Color.LightGray;
            this.passwordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordInput.Location = new System.Drawing.Point(44, 115);
            this.passwordInput.MaxLength = 32;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '●';
            this.passwordInput.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.passwordInput.PlaceholderText = "Password";
            this.passwordInput.SelectedText = "";
            this.passwordInput.ShadowDecoration.BorderRadius = 3;
            this.passwordInput.ShadowDecoration.Depth = 5;
            this.passwordInput.ShadowDecoration.Enabled = true;
            this.passwordInput.Size = new System.Drawing.Size(244, 23);
            this.passwordInput.TabIndex = 20;
            this.passwordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // nameInput
            // 
            this.nameInput.Animated = true;
            this.nameInput.AutoRoundedCorners = true;
            this.nameInput.BackColor = System.Drawing.Color.Transparent;
            this.nameInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.nameInput.BorderRadius = 10;
            this.nameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameInput.DefaultText = "";
            this.nameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.nameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.nameInput.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.ForeColor = System.Drawing.Color.LightGray;
            this.nameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameInput.Location = new System.Drawing.Point(44, 57);
            this.nameInput.MaxLength = 16;
            this.nameInput.Name = "nameInput";
            this.nameInput.PasswordChar = '\0';
            this.nameInput.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.nameInput.PlaceholderText = "Username";
            this.nameInput.SelectedText = "";
            this.nameInput.ShadowDecoration.BorderRadius = 3;
            this.nameInput.ShadowDecoration.Depth = 5;
            this.nameInput.ShadowDecoration.Enabled = true;
            this.nameInput.Size = new System.Drawing.Size(244, 23);
            this.nameInput.TabIndex = 19;
            this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // keyInput
            // 
            this.keyInput.Animated = true;
            this.keyInput.AutoRoundedCorners = true;
            this.keyInput.BackColor = System.Drawing.Color.Transparent;
            this.keyInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.keyInput.BorderRadius = 10;
            this.keyInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyInput.DefaultText = "";
            this.keyInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.keyInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.keyInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keyInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keyInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.keyInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.keyInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keyInput.ForeColor = System.Drawing.Color.LightGray;
            this.keyInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keyInput.Location = new System.Drawing.Point(44, 144);
            this.keyInput.MaxLength = 15;
            this.keyInput.Name = "keyInput";
            this.keyInput.PasswordChar = '●';
            this.keyInput.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.keyInput.PlaceholderText = "License Key";
            this.keyInput.SelectedText = "";
            this.keyInput.ShadowDecoration.BorderRadius = 3;
            this.keyInput.ShadowDecoration.Depth = 5;
            this.keyInput.ShadowDecoration.Enabled = true;
            this.keyInput.Size = new System.Drawing.Size(244, 23);
            this.keyInput.TabIndex = 26;
            this.keyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.keyInput.UseSystemPasswordChar = true;
            // 
            // emailInput
            // 
            this.emailInput.Animated = true;
            this.emailInput.AutoRoundedCorners = true;
            this.emailInput.BackColor = System.Drawing.Color.Transparent;
            this.emailInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.emailInput.BorderRadius = 10;
            this.emailInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailInput.DefaultText = "";
            this.emailInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.emailInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.emailInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailInput.ForeColor = System.Drawing.Color.LightGray;
            this.emailInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailInput.Location = new System.Drawing.Point(44, 86);
            this.emailInput.MaxLength = 15;
            this.emailInput.Name = "emailInput";
            this.emailInput.PasswordChar = '\0';
            this.emailInput.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.emailInput.PlaceholderText = "Email Address";
            this.emailInput.SelectedText = "";
            this.emailInput.ShadowDecoration.BorderRadius = 3;
            this.emailInput.ShadowDecoration.Depth = 5;
            this.emailInput.ShadowDecoration.Enabled = true;
            this.emailInput.Size = new System.Drawing.Size(244, 23);
            this.emailInput.TabIndex = 27;
            this.emailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eauthRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(334, 264);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.registerInsteadButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.nameInput);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "eauthRegisterForm";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eauth.us.to";
            this.TopMost = false;
            this.Load += new System.EventHandler(this.eauthRegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton registerInsteadButton;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton exitButton;
        private Siticone.Desktop.UI.WinForms.SiticonePanel colorPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton registerButton;
        private System.Windows.Forms.Label nameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox passwordInput;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox nameInput;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox keyInput;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox emailInput;
    }
}

