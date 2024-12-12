namespace IGME201_Final_Project
{
    partial class UserControl3
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
            this.CartTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CartTitle
            // 
            this.CartTitle.AutoSize = true;
            this.CartTitle.Font = new System.Drawing.Font("Berlin Sans FB", 48F);
            this.CartTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.CartTitle.Location = new System.Drawing.Point(335, 32);
            this.CartTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CartTitle.Name = "CartTitle";
            this.CartTitle.Size = new System.Drawing.Size(146, 71);
            this.CartTitle.TabIndex = 32;
            this.CartTitle.Text = "Cart";
            this.CartTitle.Click += new System.EventHandler(this.MenuTitle_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.Controls.Add(this.CartTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(837, 566);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CartTitle;
    }
}
