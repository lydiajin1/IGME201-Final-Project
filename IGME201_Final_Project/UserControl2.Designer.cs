namespace IGME201_Final_Project
{
    partial class UserControl2
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
            this.MenuTitle = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.EntreesLabel = new System.Windows.Forms.Label();
            this.hamburgerContainer = new System.Windows.Forms.Panel();
            this.HamburgerAddBtn = new System.Windows.Forms.Button();
            this.HamburgerPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HamburgerLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuItemsContainer = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hamburgerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.MenuItemsContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTitle
            // 
            this.MenuTitle.AutoSize = true;
            this.MenuTitle.Font = new System.Drawing.Font("Berlin Sans FB", 48F);
            this.MenuTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.MenuTitle.Location = new System.Drawing.Point(482, 49);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(269, 105);
            this.MenuTitle.TabIndex = 31;
            this.MenuTitle.Text = "Menu";
            this.MenuTitle.Click += new System.EventHandler(this.MenuTitle_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1122, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(31, 658);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // EntreesLabel
            // 
            this.EntreesLabel.AutoSize = true;
            this.EntreesLabel.Font = new System.Drawing.Font("Berlin Sans FB", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntreesLabel.Location = new System.Drawing.Point(3, 0);
            this.EntreesLabel.Name = "EntreesLabel";
            this.EntreesLabel.Size = new System.Drawing.Size(195, 61);
            this.EntreesLabel.TabIndex = 1;
            this.EntreesLabel.Text = "Entrees";
            // 
            // hamburgerContainer
            // 
            this.hamburgerContainer.BackColor = System.Drawing.SystemColors.Control;
            this.hamburgerContainer.Controls.Add(this.HamburgerAddBtn);
            this.hamburgerContainer.Controls.Add(this.HamburgerPrice);
            this.hamburgerContainer.Controls.Add(this.pictureBox1);
            this.hamburgerContainer.Controls.Add(this.HamburgerLabel);
            this.hamburgerContainer.Location = new System.Drawing.Point(138, 91);
            this.hamburgerContainer.Name = "hamburgerContainer";
            this.hamburgerContainer.Size = new System.Drawing.Size(371, 509);
            this.hamburgerContainer.TabIndex = 2;
            // 
            // HamburgerAddBtn
            // 
            this.HamburgerAddBtn.Location = new System.Drawing.Point(92, 423);
            this.HamburgerAddBtn.Name = "HamburgerAddBtn";
            this.HamburgerAddBtn.Size = new System.Drawing.Size(174, 67);
            this.HamburgerAddBtn.TabIndex = 5;
            this.HamburgerAddBtn.Text = "Add to Cart";
            this.HamburgerAddBtn.UseVisualStyleBackColor = true;
            // 
            // HamburgerPrice
            // 
            this.HamburgerPrice.AutoSize = true;
            this.HamburgerPrice.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HamburgerPrice.Location = new System.Drawing.Point(135, 366);
            this.HamburgerPrice.Name = "HamburgerPrice";
            this.HamburgerPrice.Size = new System.Drawing.Size(106, 44);
            this.HamburgerPrice.TabIndex = 4;
            this.HamburgerPrice.Text = "$7.99";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IGME201_Final_Project.Properties.Resources.hamburger_img;
            this.pictureBox1.Location = new System.Drawing.Point(34, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // HamburgerLabel
            // 
            this.HamburgerLabel.AutoSize = true;
            this.HamburgerLabel.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HamburgerLabel.Location = new System.Drawing.Point(74, 13);
            this.HamburgerLabel.Name = "HamburgerLabel";
            this.HamburgerLabel.Size = new System.Drawing.Size(214, 44);
            this.HamburgerLabel.TabIndex = 0;
            this.HamburgerLabel.Text = "Hamburger";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(624, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 509);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 67);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "$7.99";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IGME201_Final_Project.Properties.Resources.hamburger_img;
            this.pictureBox2.Location = new System.Drawing.Point(34, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hamburger";
            // 
            // MenuItemsContainer
            // 
            this.MenuItemsContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MenuItemsContainer.Controls.Add(this.panel5);
            this.MenuItemsContainer.Controls.Add(this.panel4);
            this.MenuItemsContainer.Controls.Add(this.panel3);
            this.MenuItemsContainer.Controls.Add(this.hamburgerContainer);
            this.MenuItemsContainer.Controls.Add(this.EntreesLabel);
            this.MenuItemsContainer.Controls.Add(this.vScrollBar1);
            this.MenuItemsContainer.Location = new System.Drawing.Point(49, 169);
            this.MenuItemsContainer.Name = "MenuItemsContainer";
            this.MenuItemsContainer.Size = new System.Drawing.Size(1154, 658);
            this.MenuItemsContainer.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(624, 658);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(371, 509);
            this.panel5.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(92, 423);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 67);
            this.button3.TabIndex = 5;
            this.button3.Text = "Add to Cart";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "$7.99";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::IGME201_Final_Project.Properties.Resources.hamburger_img;
            this.pictureBox4.Location = new System.Drawing.Point(34, 63);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(300, 300);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 44);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hamburger";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(138, 658);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 509);
            this.panel4.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 67);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add to Cart";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "$7.99";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::IGME201_Final_Project.Properties.Resources.hamburger_img;
            this.pictureBox3.Location = new System.Drawing.Point(34, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(300, 300);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 44);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hamburger";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.Controls.Add(this.MenuItemsContainer);
            this.Controls.Add(this.MenuTitle);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1256, 871);
            this.hamburgerContainer.ResumeLayout(false);
            this.hamburgerContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.MenuItemsContainer.ResumeLayout(false);
            this.MenuItemsContainer.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MenuTitle;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label EntreesLabel;
        private System.Windows.Forms.Panel hamburgerContainer;
        private System.Windows.Forms.Button HamburgerAddBtn;
        private System.Windows.Forms.Label HamburgerPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HamburgerLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel MenuItemsContainer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
    }
}
