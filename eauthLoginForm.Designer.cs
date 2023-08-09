
namespace Eauth_CS_Winform
{
    partial class eauthLoginForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.registerInsteadButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(186, 186);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(112, 48);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerInsteadButton
            // 
            this.registerInsteadButton.Location = new System.Drawing.Point(141, 240);
            this.registerInsteadButton.Name = "registerInsteadButton";
            this.registerInsteadButton.Size = new System.Drawing.Size(200, 45);
            this.registerInsteadButton.TabIndex = 5;
            this.registerInsteadButton.Text = "Register instead";
            this.registerInsteadButton.UseVisualStyleBackColor = true;
            this.registerInsteadButton.Click += new System.EventHandler(this.registerInsteadButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "License Key";
            // 
            // keyInput
            // 
            this.keyInput.Location = new System.Drawing.Point(122, 157);
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(239, 20);
            this.keyInput.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(122, 95);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(239, 20);
            this.passwordInput.TabIndex = 13;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(122, 38);
            this.nameInput.MaxLength = 36;
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(239, 20);
            this.nameInput.TabIndex = 12;
            // 
            // eauthLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 294);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.registerInsteadButton);
            this.Controls.Add(this.loginButton);
            this.Name = "eauthLoginForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eauth.us.to";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.eauthLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerInsteadButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox nameInput;
    }
}

