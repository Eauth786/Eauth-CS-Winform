
namespace Eauth_CS_Winform
{
    partial class eauthUpgradeForm
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
            this.loginInsteadButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.exitButton = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.colorPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.upgradeButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.keyInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
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
            // loginInsteadButton
            // 
            this.loginInsteadButton.Animated = true;
            this.loginInsteadButton.AutoRoundedCorners = true;
            this.loginInsteadButton.BorderRadius = 10;
            this.loginInsteadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginInsteadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginInsteadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginInsteadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginInsteadButton.FillColor = System.Drawing.Color.Transparent;
            this.loginInsteadButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.loginInsteadButton.ForeColor = System.Drawing.Color.White;
            this.loginInsteadButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.loginInsteadButton.Location = new System.Drawing.Point(12, 153);
            this.loginInsteadButton.Name = "loginInsteadButton";
            this.loginInsteadButton.Size = new System.Drawing.Size(310, 23);
            this.loginInsteadButton.TabIndex = 25;
            this.loginInsteadButton.Text = "Back to Login";
            this.loginInsteadButton.Click += new System.EventHandler(this.loginInsteadButton_Click);
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
            // upgradeButton
            // 
            this.upgradeButton.Animated = true;
            this.upgradeButton.AutoRoundedCorners = true;
            this.upgradeButton.BorderRadius = 10;
            this.upgradeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.upgradeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.upgradeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.upgradeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.upgradeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.upgradeButton.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.upgradeButton.ForeColor = System.Drawing.Color.White;
            this.upgradeButton.Location = new System.Drawing.Point(12, 124);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(310, 23);
            this.upgradeButton.TabIndex = 22;
            this.upgradeButton.Text = "Upgrade";
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(107, 17);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Eauth | Upgrade";
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
            this.nameInput.MaxLength = 99;
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
            this.keyInput.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyInput.ForeColor = System.Drawing.Color.LightGray;
            this.keyInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keyInput.Location = new System.Drawing.Point(44, 86);
            this.keyInput.MaxLength = 99;
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
            // eauthUpgradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(334, 203);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.loginInsteadButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.upgradeButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "eauthUpgradeForm";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eauth.us.to";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.eauthUpgradeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton loginInsteadButton;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton exitButton;
        private Siticone.Desktop.UI.WinForms.SiticonePanel colorPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton upgradeButton;
        private System.Windows.Forms.Label nameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox nameInput;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox keyInput;
    }
}