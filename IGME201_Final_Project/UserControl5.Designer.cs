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
            this.Thanks.Location = new System.Drawing.Point(59, 125);
            this.Thanks.Name = "Thanks";
            this.Thanks.Size = new System.Drawing.Size(338, 48);
            this.Thanks.TabIndex = 40;
            this.Thanks.Text = "You order has now been confirmed!\r\nThank you for you purchase!";
            this.Thanks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Thanks.Click += new System.EventHandler(this.Thanks_Click);
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.Controls.Add(this.Thanks);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(470, 325);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Thanks;
    }
}
