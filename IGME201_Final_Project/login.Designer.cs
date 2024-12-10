namespace IGME201_Final_Project
{
    partial class login
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
            this.accQuestion = new System.Windows.Forms.Label();
            this.CreateAcc = new System.Windows.Forms.Button();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.loginConfirm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.PasswordTypeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // accQuestion
            // 
            this.accQuestion.AutoSize = true;
            this.accQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accQuestion.Location = new System.Drawing.Point(406, 723);
            this.accQuestion.Name = "accQuestion";
            this.accQuestion.Size = new System.Drawing.Size(388, 29);
            this.accQuestion.TabIndex = 15;
            this.accQuestion.Text = "Don\'t have an account? Create one!";
            // 
            // CreateAcc
            // 
            this.CreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CreateAcc.Location = new System.Drawing.Point(445, 786);
            this.CreateAcc.Name = "CreateAcc";
            this.CreateAcc.Size = new System.Drawing.Size(294, 53);
            this.CreateAcc.TabIndex = 14;
            this.CreateAcc.Text = "Create an Account";
            this.CreateAcc.UseVisualStyleBackColor = true;
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.LoginTitle.Location = new System.Drawing.Point(453, 187);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(212, 82);
            this.LoginTitle.TabIndex = 13;
            this.LoginTitle.Text = "Login";
            // 
            // loginConfirm
            // 
            this.loginConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.loginConfirm.Location = new System.Drawing.Point(508, 601);
            this.loginConfirm.Name = "loginConfirm";
            this.loginConfirm.Size = new System.Drawing.Size(165, 57);
            this.loginConfirm.TabIndex = 12;
            this.loginConfirm.Text = "Login";
            this.loginConfirm.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox1.Location = new System.Drawing.Point(445, 398);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 48);
            this.textBox1.TabIndex = 11;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Username.Location = new System.Drawing.Point(435, 355);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(183, 40);
            this.Username.TabIndex = 10;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Password.Location = new System.Drawing.Point(438, 459);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(175, 40);
            this.Password.TabIndex = 9;
            this.Password.Text = "Password";
            // 
            // PasswordTypeBox
            // 
            this.PasswordTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.PasswordTypeBox.Location = new System.Drawing.Point(445, 510);
            this.PasswordTypeBox.Name = "PasswordTypeBox";
            this.PasswordTypeBox.Size = new System.Drawing.Size(307, 48);
            this.PasswordTypeBox.TabIndex = 8;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 1027);
            this.Controls.Add(this.accQuestion);
            this.Controls.Add(this.CreateAcc);
            this.Controls.Add(this.LoginTitle);
            this.Controls.Add(this.loginConfirm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordTypeBox);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accQuestion;
        private System.Windows.Forms.Button CreateAcc;
        private System.Windows.Forms.Label LoginTitle;
        private System.Windows.Forms.Button loginConfirm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PasswordTypeBox;
    }
}