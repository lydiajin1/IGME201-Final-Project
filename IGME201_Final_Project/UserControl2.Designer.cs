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
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.Controls.Add(this.MenuTitle);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1256, 871);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MenuTitle;
    }
}
