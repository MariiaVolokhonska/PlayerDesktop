
namespace PlayerDesktop
{
    partial class Regestration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginRegistrationLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginRegistrationBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.passwordRegistrationBox = new System.Windows.Forms.TextBox();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.repeatedPasswordBox = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.signUpButton);
            this.panel1.Controls.Add(this.repeatedPasswordBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.signUpLabel);
            this.panel1.Controls.Add(this.passwordRegistrationBox);
            this.panel1.Controls.Add(this.phoneNumberBox);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Controls.Add(this.loginRegistrationBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.loginRegistrationLabel);
            this.panel1.Location = new System.Drawing.Point(120, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 357);
            this.panel1.TabIndex = 0;
            // 
            // loginRegistrationLabel
            // 
            this.loginRegistrationLabel.AutoSize = true;
            this.loginRegistrationLabel.Location = new System.Drawing.Point(110, 65);
            this.loginRegistrationLabel.Name = "loginRegistrationLabel";
            this.loginRegistrationLabel.Size = new System.Drawing.Size(48, 20);
            this.loginRegistrationLabel.TabIndex = 0;
            this.loginRegistrationLabel.Text = "Login";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(110, 111);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(48, 20);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // loginRegistrationBox
            // 
            this.loginRegistrationBox.Location = new System.Drawing.Point(192, 62);
            this.loginRegistrationBox.Name = "loginRegistrationBox";
            this.loginRegistrationBox.Size = new System.Drawing.Size(100, 26);
            this.loginRegistrationBox.TabIndex = 4;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(192, 105);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 26);
            this.emailBox.TabIndex = 5;
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(192, 152);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(100, 26);
            this.phoneNumberBox.TabIndex = 6;
            // 
            // passwordRegistrationBox
            // 
            this.passwordRegistrationBox.Location = new System.Drawing.Point(192, 195);
            this.passwordRegistrationBox.Name = "passwordRegistrationBox";
            this.passwordRegistrationBox.Size = new System.Drawing.Size(100, 26);
            this.passwordRegistrationBox.TabIndex = 7;
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpLabel.Location = new System.Drawing.Point(122, 14);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(99, 29);
            this.signUpLabel.TabIndex = 8;
            this.signUpLabel.Text = "Sign Up";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Repeat Password";
            // 
            // repeatedPasswordBox
            // 
            this.repeatedPasswordBox.Location = new System.Drawing.Point(192, 240);
            this.repeatedPasswordBox.Name = "repeatedPasswordBox";
            this.repeatedPasswordBox.Size = new System.Drawing.Size(100, 26);
            this.repeatedPasswordBox.TabIndex = 10;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(127, 290);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(94, 33);
            this.signUpButton.TabIndex = 11;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // Regestration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 528);
            this.Controls.Add(this.panel1);
            this.Name = "Regestration";
            this.Text = "Regestration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox repeatedPasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.TextBox passwordRegistrationBox;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox loginRegistrationBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label loginRegistrationLabel;
    }
}