﻿namespace IGME201_Final_Project
{
    partial class Form1
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
            this.accQuestion = new System.Windows.Forms.Label();
            this.CreateAcc = new System.Windows.Forms.Button();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.loginConfirm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.PasswordTypeBox = new System.Windows.Forms.TextBox();
            this.userControl21 = new IGME201_Final_Project.UserControl2();
            this.userControl11 = new IGME201_Final_Project.UserControl1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.accQuestion);
            this.panel1.Controls.Add(this.CreateAcc);
            this.panel1.Controls.Add(this.LoginTitle);
            this.panel1.Controls.Add(this.loginConfirm);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.PasswordTypeBox);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 962);
            this.panel1.TabIndex = 2;
            // 
            // accQuestion
            // 
            this.accQuestion.AutoSize = true;
            this.accQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accQuestion.Location = new System.Drawing.Point(433, 691);
            this.accQuestion.Name = "accQuestion";
            this.accQuestion.Size = new System.Drawing.Size(388, 29);
            this.accQuestion.TabIndex = 23;
            this.accQuestion.Text = "Don\'t have an account? Create one!";
            // 
            // CreateAcc
            // 
            this.CreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CreateAcc.Location = new System.Drawing.Point(472, 754);
            this.CreateAcc.Name = "CreateAcc";
            this.CreateAcc.Size = new System.Drawing.Size(294, 53);
            this.CreateAcc.TabIndex = 22;
            this.CreateAcc.Text = "Create an Account";
            this.CreateAcc.UseVisualStyleBackColor = true;
            this.CreateAcc.Click += new System.EventHandler(this.CreateAcc_Click_1);
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.LoginTitle.Location = new System.Drawing.Point(480, 155);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(212, 82);
            this.LoginTitle.TabIndex = 21;
            this.LoginTitle.Text = "Login";
            // 
            // loginConfirm
            // 
            this.loginConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.loginConfirm.Location = new System.Drawing.Point(535, 569);
            this.loginConfirm.Name = "loginConfirm";
            this.loginConfirm.Size = new System.Drawing.Size(165, 57);
            this.loginConfirm.TabIndex = 20;
            this.loginConfirm.Text = "Login";
            this.loginConfirm.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox1.Location = new System.Drawing.Point(472, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 48);
            this.textBox1.TabIndex = 19;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Username.Location = new System.Drawing.Point(462, 323);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(183, 40);
            this.Username.TabIndex = 18;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Password.Location = new System.Drawing.Point(465, 427);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(175, 40);
            this.Password.TabIndex = 17;
            this.Password.Text = "Password";
            // 
            // PasswordTypeBox
            // 
            this.PasswordTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.PasswordTypeBox.Location = new System.Drawing.Point(472, 478);
            this.PasswordTypeBox.Name = "PasswordTypeBox";
            this.PasswordTypeBox.Size = new System.Drawing.Size(307, 48);
            this.PasswordTypeBox.TabIndex = 16;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.CadetBlue;
            this.userControl21.Location = new System.Drawing.Point(0, -2);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1256, 972);
            this.userControl21.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Chocolate;
            this.userControl11.Location = new System.Drawing.Point(0, -2);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1256, 972);
            this.userControl11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 961);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private System.Windows.Forms.Panel panel1;
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

