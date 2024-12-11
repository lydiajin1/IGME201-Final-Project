namespace IGME201_Final_Project
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
            this.Homebtn = new System.Windows.Forms.Button();
            this.Menubtn = new System.Windows.Forms.Button();
            this.Cartbtn = new System.Windows.Forms.Button();
            this.Checkoutbtn = new System.Windows.Forms.Button();
            this.userControl41 = new IGME201_Final_Project.UserControl4();
            this.userControl31 = new IGME201_Final_Project.UserControl3();
            this.userControl21 = new IGME201_Final_Project.UserControl2();
            this.userControl11 = new IGME201_Final_Project.UserControl1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Checkoutbtn);
            this.panel1.Controls.Add(this.Cartbtn);
            this.panel1.Controls.Add(this.Menubtn);
            this.panel1.Controls.Add(this.Homebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 100);
            this.panel1.TabIndex = 0;
            // 
            // Homebtn
            // 
            this.Homebtn.Location = new System.Drawing.Point(61, 30);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(109, 36);
            this.Homebtn.TabIndex = 0;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // Menubtn
            // 
            this.Menubtn.Location = new System.Drawing.Point(313, 21);
            this.Menubtn.Name = "Menubtn";
            this.Menubtn.Size = new System.Drawing.Size(116, 45);
            this.Menubtn.TabIndex = 1;
            this.Menubtn.Text = "Menu";
            this.Menubtn.UseVisualStyleBackColor = true;
            this.Menubtn.Click += new System.EventHandler(this.Menubtn_Click);
            // 
            // Cartbtn
            // 
            this.Cartbtn.Location = new System.Drawing.Point(636, 24);
            this.Cartbtn.Name = "Cartbtn";
            this.Cartbtn.Size = new System.Drawing.Size(102, 51);
            this.Cartbtn.TabIndex = 2;
            this.Cartbtn.Text = "Cart";
            this.Cartbtn.UseVisualStyleBackColor = true;
            this.Cartbtn.Click += new System.EventHandler(this.Cartbtn_Click);
            // 
            // Checkoutbtn
            // 
            this.Checkoutbtn.Location = new System.Drawing.Point(871, 25);
            this.Checkoutbtn.Name = "Checkoutbtn";
            this.Checkoutbtn.Size = new System.Drawing.Size(166, 36);
            this.Checkoutbtn.TabIndex = 3;
            this.Checkoutbtn.Text = "Checkout";
            this.Checkoutbtn.UseVisualStyleBackColor = true;
            this.Checkoutbtn.Click += new System.EventHandler(this.Checkoutbtn_Click);
            // 
            // userControl41
            // 
            this.userControl41.BackColor = System.Drawing.SystemColors.ControlText;
            this.userControl41.Location = new System.Drawing.Point(0, 95);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(1255, 870);
            this.userControl41.TabIndex = 1;
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userControl31.Location = new System.Drawing.Point(0, 95);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(1265, 870);
            this.userControl31.TabIndex = 2;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.CadetBlue;
            this.userControl21.Location = new System.Drawing.Point(0, 95);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1255, 870);
            this.userControl21.TabIndex = 3;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Chocolate;
            this.userControl11.Location = new System.Drawing.Point(0, 95);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1255, 870);
            this.userControl11.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1255, 961);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl41);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Checkoutbtn;
        private System.Windows.Forms.Button Cartbtn;
        private System.Windows.Forms.Button Menubtn;
        private System.Windows.Forms.Button Homebtn;
        private UserControl4 userControl41;
        private UserControl3 userControl31;
        private UserControl2 userControl21;
        private UserControl1 userControl11;
    }
}

