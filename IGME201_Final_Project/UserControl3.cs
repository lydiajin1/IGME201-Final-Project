﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IGME201_Final_Project
{
    public partial class UserControl3 : UserControl


    {
        public UserControl3()
        {
            InitializeComponent();
            

        }

        private void UserControl3_Load(object sender, EventArgs e) {
            int total = 0;
            for (int i = 0; i < Form1.instance.fooditems.Count(); i++)
            {

                FoodItems item = Form1.instance.fooditems[i];
                if (item.getQuantity() != 0)
                {
                    int j = 10;
                    System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                    label.Text = "Name: " + item.name + " Price:" + (item.price * item.quantity).ToString() + " Quantity: " + item.quantity.ToString();
                    if (i == 0)
                    {
                        label.Location = new Point(107, 86);
                    }
                    label.Location = new Point(107, 86 + j);
                    label.AutoSize = true;

                    label.Font = new Font("Calibri", 16);
                    this.Controls.Add(label);
                    total += (item.price * item.quantity);
                    j += 10;
                }
            }
            totalLabel.Text = "Total: " + total.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadCart()
        {
            CartPanel.Controls.Clear();
            int total = 0;
            for (int i = 0; i < Form1.instance.fooditems.Count(); i++)
            {

                FoodItems item = Form1.instance.fooditems[i];
                if (item.getQuantity() != 0)
                {
                    int j = 10;
                    System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                    label.Text = "Name: " + item.name + "  $" + (item.price * item.quantity).ToString() + "   Quantity:" + item.quantity.ToString();
                    //if (i == 0)
                    //{
                    //    label.Location = new Point(107, 86);
                    //}
                    //label.Location = new Point(107, 86 + j);
                    label.AutoSize = true;

                    label.Font = new Font("Calibri", 20);
                    CartPanel.Controls.Add(label);
                    total += (item.price * item.quantity);
                    j += 10;
                }
            }

            totalLabel.Text = "$" + total.ToString();
        }

        private void CartPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
