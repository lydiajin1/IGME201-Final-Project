namespace IGME201_Final_Project
{
    partial class HomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button loginConfirm;
            this.accQuestion = new System.Windows.Forms.Label();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.LoginUsernametxtbox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.LoginPasswordTypeBox = new System.Windows.Forms.TextBox();
            this.UsernameCreateAccLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateAccUsernametxtbox = new System.Windows.Forms.TextBox();
            this.CreateAcctxtBox = new System.Windows.Forms.TextBox();
            this.Cofirmbtn = new System.Windows.Forms.Button();
            this.UsernameCreateAcclabel = new System.Windows.Forms.Label();
            this.CreatePasswordlbl = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            loginConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accQuestion
            // 
            this.accQuestion.AutoSize = true;
            this.accQuestion.Font = new System.Drawing.Font("Berlin Sans FB", 36F);
            this.accQuestion.ForeColor = System.Drawing.Color.Cornsilk;
            this.accQuestion.Location = new System.Drawing.Point(650, 256);
            this.accQuestion.Name = "accQuestion";
            this.accQuestion.Size = new System.Drawing.Size(498, 78);
            this.accQuestion.TabIndex = 22;
            this.accQuestion.Text = "Create Account";
            this.accQuestion.Click += new System.EventHandler(this.accQuestion_Click);
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Berlin Sans FB", 36F);
            this.LoginTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.LoginTitle.Location = new System.Drawing.Point(187, 256);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(197, 78);
            this.LoginTitle.TabIndex = 21;
            this.LoginTitle.Text = "Login";
            this.LoginTitle.Click += new System.EventHandler(this.LoginTitle_Click);
            // 
            // loginConfirm
            // 
            loginConfirm.Font = new System.Drawing.Font("Berlin Sans FB", 18F);
            loginConfirm.ForeColor = System.Drawing.Color.DarkSlateGray;
            loginConfirm.Location = new System.Drawing.Point(219, 654);
            loginConfirm.Name = "loginConfirm";
            loginConfirm.Size = new System.Drawing.Size(165, 57);
            loginConfirm.TabIndex = 20;
            loginConfirm.Text = "Login";
            loginConfirm.UseVisualStyleBackColor = true;
            // 
            // LoginUsernametxtbox
            // 
            this.LoginUsernametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LoginUsernametxtbox.Location = new System.Drawing.Point(156, 451);
            this.LoginUsernametxtbox.Name = "LoginUsernametxtbox";
            this.LoginUsernametxtbox.Size = new System.Drawing.Size(307, 48);
            this.LoginUsernametxtbox.TabIndex = 19;
            this.LoginUsernametxtbox.TextChanged += new System.EventHandler(this.LoginUsernametxtbox_TextChanged);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Berlin Sans FB", 18F);
            this.Username.ForeColor = System.Drawing.Color.Cornsilk;
            this.Username.Location = new System.Drawing.Point(146, 408);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(167, 39);
            this.Username.TabIndex = 18;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Berlin Sans FB", 18F);
            this.Password.ForeColor = System.Drawing.Color.Cornsilk;
            this.Password.Location = new System.Drawing.Point(149, 512);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(157, 39);
            this.Password.TabIndex = 17;
            this.Password.Text = "Password";
            // 
            // LoginPasswordTypeBox
            // 
            this.LoginPasswordTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LoginPasswordTypeBox.Location = new System.Drawing.Point(156, 563);
            this.LoginPasswordTypeBox.Name = "LoginPasswordTypeBox";
            this.LoginPasswordTypeBox.Size = new System.Drawing.Size(307, 48);
            this.LoginPasswordTypeBox.TabIndex = 16;
            // 
            // UsernameCreateAccLbl
            // 
            this.UsernameCreateAccLbl.AutoSize = true;
            this.UsernameCreateAccLbl.Font = new System.Drawing.Font("Berlin Sans FB", 18F);
            this.UsernameCreateAccLbl.ForeColor = System.Drawing.Color.Cornsilk;
            this.UsernameCreateAccLbl.Location = new System.Drawing.Point(756, 403);
            this.UsernameCreateAccLbl.Name = "UsernameCreateAccLbl";
            this.UsernameCreateAccLbl.Size = new System.Drawing.Size(167, 39);
            this.UsernameCreateAccLbl.TabIndex = 23;
            this.UsernameCreateAccLbl.Text = "Username";
            this.UsernameCreateAccLbl.Click += new System.EventHandler(this.UsernameCreateAccLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 18F);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(756, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "Password";
            // 
            // CreateAccUsernametxtbox
            // 
            this.CreateAccUsernametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CreateAccUsernametxtbox.Location = new System.Drawing.Point(763, 451);
            this.CreateAccUsernametxtbox.Name = "CreateAccUsernametxtbox";
            this.CreateAccUsernametxtbox.Size = new System.Drawing.Size(307, 48);
            this.CreateAccUsernametxtbox.TabIndex = 25;
            this.CreateAccUsernametxtbox.TextChanged += new System.EventHandler(this.CreateAccUsernametxtbox_TextChanged);
            // 
            // CreateAcctxtBox
            // 
            this.CreateAcctxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CreateAcctxtBox.Location = new System.Drawing.Point(763, 623);
            this.CreateAcctxtBox.Name = "CreateAcctxtBox";
            this.CreateAcctxtBox.Size = new System.Drawing.Size(307, 48);
            this.CreateAcctxtBox.TabIndex = 26;
            // 
            // Cofirmbtn
            // 
            this.Cofirmbtn.Font = new System.Drawing.Font("Berlin Sans FB", 18F);
            this.Cofirmbtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Cofirmbtn.Location = new System.Drawing.Point(825, 769);
            this.Cofirmbtn.Name = "Cofirmbtn";
            this.Cofirmbtn.Size = new System.Drawing.Size(165, 57);
            this.Cofirmbtn.TabIndex = 27;
            this.Cofirmbtn.Text = "Confirm";
            this.Cofirmbtn.UseVisualStyleBackColor = true;
            this.Cofirmbtn.Click += new System.EventHandler(this.Cofirmbtn_Click);
            // 
            // UsernameCreateAcclabel
            // 
            this.UsernameCreateAcclabel.AutoSize = true;
            this.UsernameCreateAcclabel.Font = new System.Drawing.Font("Berlin Sans FB", 13F);
            this.UsernameCreateAcclabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.UsernameCreateAcclabel.Location = new System.Drawing.Point(756, 520);
            this.UsernameCreateAcclabel.Name = "UsernameCreateAcclabel";
            this.UsernameCreateAcclabel.Size = new System.Drawing.Size(358, 29);
            this.UsernameCreateAcclabel.TabIndex = 28;
            this.UsernameCreateAcclabel.Text = "Must be a least 1 character long!";
            // 
            // CreatePasswordlbl
            // 
            this.CreatePasswordlbl.AutoSize = true;
            this.CreatePasswordlbl.Font = new System.Drawing.Font("Berlin Sans FB", 13F);
            this.CreatePasswordlbl.ForeColor = System.Drawing.Color.Cornsilk;
            this.CreatePasswordlbl.Location = new System.Drawing.Point(756, 682);
            this.CreatePasswordlbl.Name = "CreatePasswordlbl";
            this.CreatePasswordlbl.Size = new System.Drawing.Size(358, 29);
            this.CreatePasswordlbl.TabIndex = 29;
            this.CreatePasswordlbl.Text = "Must be a least 1 character long!";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Berlin Sans FB", 48F);
            this.Title.ForeColor = System.Drawing.Color.Cornsilk;
            this.Title.Location = new System.Drawing.Point(237, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(775, 105);
            this.Title.TabIndex = 30;
            this.Title.Text = "Ritchie’s Fast Food";
            this.Title.Click += new System.EventHandler(this.label2_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CreatePasswordlbl);
            this.Controls.Add(this.UsernameCreateAcclabel);
            this.Controls.Add(this.Cofirmbtn);
            this.Controls.Add(this.CreateAcctxtBox);
            this.Controls.Add(this.CreateAccUsernametxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameCreateAccLbl);
            this.Controls.Add(this.accQuestion);
            this.Controls.Add(this.LoginTitle);
            this.Controls.Add(loginConfirm);
            this.Controls.Add(this.LoginUsernametxtbox);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LoginPasswordTypeBox);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1255, 870);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accQuestion;
        private System.Windows.Forms.Label LoginTitle;
        private System.Windows.Forms.TextBox LoginUsernametxtbox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox LoginPasswordTypeBox;
        private System.Windows.Forms.Label UsernameCreateAccLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreateAccUsernametxtbox;
        private System.Windows.Forms.TextBox CreateAcctxtBox;
        private System.Windows.Forms.Button Cofirmbtn;
        private System.Windows.Forms.Label UsernameCreateAcclabel;
        private System.Windows.Forms.Label CreatePasswordlbl;
        private System.Windows.Forms.Label Title;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
