namespace IGME201_Final_Project
{
    partial class UserControl4
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
            this.CheckoutTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckoutTitle
            // 
            this.CheckoutTitle.AutoSize = true;
            this.CheckoutTitle.Font = new System.Drawing.Font("Berlin Sans FB", 48F);
            this.CheckoutTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.CheckoutTitle.Location = new System.Drawing.Point(280, 32);
            this.CheckoutTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CheckoutTitle.Name = "CheckoutTitle";
            this.CheckoutTitle.Size = new System.Drawing.Size(283, 71);
            this.CheckoutTitle.TabIndex = 33;
            this.CheckoutTitle.Text = "Checkout";
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.Controls.Add(this.CheckoutTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(837, 566);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CheckoutTitle;
    }
}
