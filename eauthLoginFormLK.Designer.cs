
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
            this.licenseField3 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.colorPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.loginNamePasswordButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.licenseField4 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.licenseField1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.licenseField2 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.enterKeyLabel = new System.Windows.Forms.Label();
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
            // licenseField3
            // 
            this.licenseField3.Animated = true;
            this.licenseField3.AutoRoundedCorners = true;
            this.licenseField3.BackColor = System.Drawing.Color.Transparent;
            this.licenseField3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.licenseField3.BorderRadius = 10;
            this.licenseField3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.licenseField3.DefaultText = "";
            this.licenseField3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.licenseField3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.licenseField3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.licenseField3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.licenseField3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.licenseField3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.licenseField3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.licenseField3.ForeColor = System.Drawing.Color.LightGray;
            this.licenseField3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.licenseField3.Location = new System.Drawing.Point(170, 72);
            this.licenseField3.MaxLength = 4;
            this.licenseField3.Name = "licenseField3";
            this.licenseField3.PasswordChar = '●';
            this.licenseField3.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.licenseField3.PlaceholderText = "";
            this.licenseField3.ReadOnly = true;
            this.licenseField3.SelectedText = "";
            this.licenseField3.ShadowDecoration.BorderRadius = 3;
            this.licenseField3.ShadowDecoration.Depth = 5;
            this.licenseField3.ShadowDecoration.Enabled = true;
            this.licenseField3.Size = new System.Drawing.Size(73, 23);
            this.licenseField3.TabIndex = 10;
            this.licenseField3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.licenseField3.UseSystemPasswordChar = true;
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
            // licenseField4
            // 
            this.licenseField4.Animated = true;
            this.licenseField4.AutoRoundedCorners = true;
            this.licenseField4.BackColor = System.Drawing.Color.Transparent;
            this.licenseField4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.licenseField4.BorderRadius = 10;
            this.licenseField4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.licenseField4.DefaultText = "";
            this.licenseField4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.licenseField4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.licenseField4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.licenseField4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.licenseField4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.licenseField4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.licenseField4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.licenseField4.ForeColor = System.Drawing.Color.LightGray;
            this.licenseField4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.licenseField4.Location = new System.Drawing.Point(249, 72);
            this.licenseField4.MaxLength = 4;
            this.licenseField4.Name = "licenseField4";
            this.licenseField4.PasswordChar = '●';
            this.licenseField4.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.licenseField4.PlaceholderText = "";
            this.licenseField4.ReadOnly = true;
            this.licenseField4.SelectedText = "";
            this.licenseField4.ShadowDecoration.BorderRadius = 3;
            this.licenseField4.ShadowDecoration.Depth = 5;
            this.licenseField4.ShadowDecoration.Enabled = true;
            this.licenseField4.Size = new System.Drawing.Size(73, 23);
            this.licenseField4.TabIndex = 17;
            this.licenseField4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.licenseField4.UseSystemPasswordChar = true;
            // 
            // licenseField1
            // 
            this.licenseField1.Animated = true;
            this.licenseField1.AutoRoundedCorners = true;
            this.licenseField1.BackColor = System.Drawing.Color.Transparent;
            this.licenseField1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.licenseField1.BorderRadius = 10;
            this.licenseField1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.licenseField1.DefaultText = "";
            this.licenseField1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.licenseField1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.licenseField1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.licenseField1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.licenseField1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.licenseField1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.licenseField1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.licenseField1.ForeColor = System.Drawing.Color.LightGray;
            this.licenseField1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.licenseField1.Location = new System.Drawing.Point(12, 72);
            this.licenseField1.MaxLength = 18;
            this.licenseField1.Name = "licenseField1";
            this.licenseField1.PasswordChar = '●';
            this.licenseField1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.licenseField1.PlaceholderText = "";
            this.licenseField1.SelectedText = "";
            this.licenseField1.ShadowDecoration.BorderRadius = 3;
            this.licenseField1.ShadowDecoration.Depth = 5;
            this.licenseField1.ShadowDecoration.Enabled = true;
            this.licenseField1.Size = new System.Drawing.Size(73, 23);
            this.licenseField1.TabIndex = 18;
            this.licenseField1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.licenseField1.UseSystemPasswordChar = true;
            this.licenseField1.TextChanged += new System.EventHandler(this.licenseField1_TextChanged);
            // 
            // licenseField2
            // 
            this.licenseField2.Animated = true;
            this.licenseField2.AutoRoundedCorners = true;
            this.licenseField2.BackColor = System.Drawing.Color.Transparent;
            this.licenseField2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.licenseField2.BorderRadius = 10;
            this.licenseField2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.licenseField2.DefaultText = "";
            this.licenseField2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.licenseField2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.licenseField2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.licenseField2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.licenseField2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.licenseField2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.licenseField2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.licenseField2.ForeColor = System.Drawing.Color.LightGray;
            this.licenseField2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.licenseField2.Location = new System.Drawing.Point(91, 72);
            this.licenseField2.MaxLength = 4;
            this.licenseField2.Name = "licenseField2";
            this.licenseField2.PasswordChar = '●';
            this.licenseField2.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.licenseField2.PlaceholderText = "";
            this.licenseField2.ReadOnly = true;
            this.licenseField2.SelectedText = "";
            this.licenseField2.ShadowDecoration.BorderRadius = 3;
            this.licenseField2.ShadowDecoration.Depth = 5;
            this.licenseField2.ShadowDecoration.Enabled = true;
            this.licenseField2.Size = new System.Drawing.Size(73, 23);
            this.licenseField2.TabIndex = 19;
            this.licenseField2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.licenseField2.UseSystemPasswordChar = true;
            // 
            // enterKeyLabel
            // 
            this.enterKeyLabel.AutoSize = true;
            this.enterKeyLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterKeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.enterKeyLabel.Location = new System.Drawing.Point(75, 48);
            this.enterKeyLabel.Name = "enterKeyLabel";
            this.enterKeyLabel.Size = new System.Drawing.Size(186, 17);
            this.enterKeyLabel.TabIndex = 20;
            this.enterKeyLabel.Text = "Please enter your license key:";
            // 
            // eauthLoginFormLK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(334, 220);
            this.Controls.Add(this.enterKeyLabel);
            this.Controls.Add(this.licenseField2);
            this.Controls.Add(this.licenseField1);
            this.Controls.Add(this.licenseField4);
            this.Controls.Add(this.loginNamePasswordButton);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.licenseField3);
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
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox licenseField3;
        private Siticone.Desktop.UI.WinForms.SiticonePanel colorPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton loginNamePasswordButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox licenseField2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox licenseField1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox licenseField4;
        private System.Windows.Forms.Label enterKeyLabel;
    }
}