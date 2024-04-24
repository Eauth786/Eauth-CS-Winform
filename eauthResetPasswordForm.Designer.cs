
namespace Eauth_CS_Winform
{
    partial class eauthResetPasswordForm
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
            this.resetButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.nameLabel = new System.Windows.Forms.Label();
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
            this.loginInsteadButton.Location = new System.Drawing.Point(12, 125);
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
            // resetButton
            // 
            this.resetButton.Animated = true;
            this.resetButton.AutoRoundedCorners = true;
            this.resetButton.BorderRadius = 10;
            this.resetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.resetButton.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(12, 96);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(310, 23);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(88, 17);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Eauth | Reset";
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
            this.emailInput.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput.ForeColor = System.Drawing.Color.LightGray;
            this.emailInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailInput.Location = new System.Drawing.Point(44, 57);
            this.emailInput.MaxLength = 99;
            this.emailInput.Name = "emailInput";
            this.emailInput.PasswordChar = '\0';
            this.emailInput.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.emailInput.PlaceholderText = "Email";
            this.emailInput.SelectedText = "";
            this.emailInput.ShadowDecoration.BorderRadius = 3;
            this.emailInput.ShadowDecoration.Depth = 5;
            this.emailInput.ShadowDecoration.Enabled = true;
            this.emailInput.Size = new System.Drawing.Size(244, 23);
            this.emailInput.TabIndex = 19;
            this.emailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eauthResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(334, 173);
            this.Controls.Add(this.loginInsteadButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.emailInput);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "eauthResetPasswordForm";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eauth.us.to";
            this.TopMost = false;
            this.Load += new System.EventHandler(this.eauthResetPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton loginInsteadButton;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton exitButton;
        private Siticone.Desktop.UI.WinForms.SiticonePanel colorPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton resetButton;
        private System.Windows.Forms.Label nameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox emailInput;
    }
}