
namespace Eauth_CS_Winform
{
    partial class eauthLoginFormLK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.exitButton = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.loginButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.licenseKeyInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.colorPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.loginNamePasswordButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
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
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Animated = true;
            this.loginButton.AutoRoundedCorners = true;
            this.loginButton.BorderRadius = 10;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.loginButton.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(12, 122);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(310, 23);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "Login";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(88, 17);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Eauth | Login";
            // 
            // licenseKeyInput
            // 
            this.licenseKeyInput.Animated = true;
            this.licenseKeyInput.AutoRoundedCorners = true;
            this.licenseKeyInput.BackColor = System.Drawing.Color.Transparent;
            this.licenseKeyInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.licenseKeyInput.BorderRadius = 10;
            this.licenseKeyInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.licenseKeyInput.DefaultText = "";
            this.licenseKeyInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.licenseKeyInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.licenseKeyInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.licenseKeyInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.licenseKeyInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.licenseKeyInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.licenseKeyInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.licenseKeyInput.ForeColor = System.Drawing.Color.LightGray;
            this.licenseKeyInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.licenseKeyInput.Location = new System.Drawing.Point(44, 72);
            this.licenseKeyInput.MaxLength = 15;
            this.licenseKeyInput.Name = "licenseKeyInput";
            this.licenseKeyInput.PasswordChar = '●';
            this.licenseKeyInput.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.licenseKeyInput.PlaceholderText = "License Key";
            this.licenseKeyInput.SelectedText = "";
            this.licenseKeyInput.ShadowDecoration.BorderRadius = 3;
            this.licenseKeyInput.ShadowDecoration.Depth = 5;
            this.licenseKeyInput.ShadowDecoration.Enabled = true;
            this.licenseKeyInput.Size = new System.Drawing.Size(244, 23);
            this.licenseKeyInput.TabIndex = 10;
            this.licenseKeyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.licenseKeyInput.UseSystemPasswordChar = true;
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.colorPanel.Location = new System.Drawing.Point(0, 0);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(334, 1);
            this.colorPanel.TabIndex = 15;
            // 
            // loginNamePasswordButton
            // 
            this.loginNamePasswordButton.Animated = true;
            this.loginNamePasswordButton.AutoRoundedCorners = true;
            this.loginNamePasswordButton.BorderRadius = 10;
            this.loginNamePasswordButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginNamePasswordButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginNamePasswordButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginNamePasswordButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginNamePasswordButton.FillColor = System.Drawing.Color.Transparent;
            this.loginNamePasswordButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.loginNamePasswordButton.ForeColor = System.Drawing.Color.White;
            this.loginNamePasswordButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.loginNamePasswordButton.Location = new System.Drawing.Point(12, 151);
            this.loginNamePasswordButton.Name = "loginNamePasswordButton";
            this.loginNamePasswordButton.Size = new System.Drawing.Size(310, 23);
            this.loginNamePasswordButton.TabIndex = 16;
            this.loginNamePasswordButton.Text = "Return Instead";
            this.loginNamePasswordButton.Click += new System.EventHandler(this.loginNamePasswordButton_Click);
            // 
            // eauthLoginFormLK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(334, 220);
            this.Controls.Add(this.loginNamePasswordButton);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.licenseKeyInput);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "eauthLoginFormLK";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eauth.us.to";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.eauthLoginFormLK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton exitButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton loginButton;
        private System.Windows.Forms.Label nameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox licenseKeyInput;
        private Siticone.Desktop.UI.WinForms.SiticonePanel colorPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton loginNamePasswordButton;
    }
}