
namespace PlayerDesktop
{
    partial class Authorization
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
            this.loginBox = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.autName = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(120, 93);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(135, 26);
            this.loginBox.TabIndex = 0;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(66, 93);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(48, 20);
            this.login.TabIndex = 1;
            this.login.Text = "Login";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(36, 141);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(78, 20);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // autName
            // 
            this.autName.AutoSize = true;
            this.autName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autName.Location = new System.Drawing.Point(115, 37);
            this.autName.Name = "autName";
            this.autName.Size = new System.Drawing.Size(84, 25);
            this.autName.TabIndex = 3;
            this.autName.Text = "LOG IN";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(120, 138);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(135, 26);
            this.passwordBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "LogIn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.autName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.loginBox);
            this.panel1.Controls.Add(this.password);
            this.panel1.Location = new System.Drawing.Point(278, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 319);
            this.panel1.TabIndex = 6;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 509);
            this.Controls.Add(this.panel1);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label autName;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}