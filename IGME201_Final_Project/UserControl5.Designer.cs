namespace IGME201_Final_Project
{
    partial class UserControl5
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
            this.Thanks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Thanks
            // 
            this.Thanks.AutoSize = true;
            this.Thanks.Font = new System.Drawing.Font("Berlin Sans FB", 16F);
            this.Thanks.ForeColor = System.Drawing.Color.White;
            this.Thanks.Location = new System.Drawing.Point(88, 192);
            this.Thanks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Thanks.Name = "Thanks";
            this.Thanks.Size = new System.Drawing.Size(485, 70);
            this.Thanks.TabIndex = 40;
            this.Thanks.Text = "You order has now been confirmed!\r\nThank you for you purchase!";
            this.Thanks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Thanks.Click += new System.EventHandler(this.Thanks_Click);
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.Controls.Add(this.Thanks);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(705, 500);
            this.Load += new System.EventHandler(this.UserControl5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Thanks;
    }
}
