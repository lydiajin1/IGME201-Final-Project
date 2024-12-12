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
            this.PaymentTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PaymentTitle
            // 
            this.PaymentTitle.AutoSize = true;
            this.PaymentTitle.Font = new System.Drawing.Font("Berlin Sans FB", 48F);
            this.PaymentTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.PaymentTitle.Location = new System.Drawing.Point(280, 32);
            this.PaymentTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PaymentTitle.Name = "PaymentTitle";
            this.PaymentTitle.Size = new System.Drawing.Size(274, 71);
            this.PaymentTitle.TabIndex = 33;
            this.PaymentTitle.Text = "Payment";
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.Controls.Add(this.PaymentTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(837, 566);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PaymentTitle;
    }
}
