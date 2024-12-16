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
            this.CartPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CartTitle
            // 
            this.CartTitle.AutoEllipsis = true;
            this.CartTitle.AutoSize = true;
            this.CartTitle.Font = new System.Drawing.Font("Berlin Sans FB", 48F);
            this.CartTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.CartTitle.Location = new System.Drawing.Point(335, 20);
            this.CartTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CartTitle.Name = "CartTitle";
            this.CartTitle.Size = new System.Drawing.Size(146, 71);
            this.CartTitle.TabIndex = 32;
            this.CartTitle.Text = "Cart";
            // 
            // CartPanel
            // 
            this.CartPanel.BackColor = System.Drawing.Color.Snow;
            this.CartPanel.Location = new System.Drawing.Point(89, 117);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(638, 261);
            this.CartPanel.TabIndex = 33;
            this.CartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CartPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 36F);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(282, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 54);
            this.label2.TabIndex = 35;
            this.label2.Text = "Total";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoEllipsis = true;
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Berlin Sans FB", 36F);
            this.totalLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.totalLabel.Location = new System.Drawing.Point(434, 395);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(141, 54);
            this.totalLabel.TabIndex = 36;
            this.totalLabel.Text = "$0.00";
            this.totalLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CartPanel);
            this.Controls.Add(this.CartTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(837, 566);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CartTitle;
        private System.Windows.Forms.FlowLayoutPanel CartPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalLabel;
    }
}
