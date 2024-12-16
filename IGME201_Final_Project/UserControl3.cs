﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void MenuTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int total = 0;
            for (int i = 0; i < Form1.instance.fooditems.Count(); i++) {
                
                foodItem item = Form1.instance.fooditems[i];
                if (item.getQuantity() != 0) {
                    Label label = new Label();
                    label.Text = "Name: " + item.name + " Price:" + (item.price * item.quantity).ToString() + " Quantity: " + item.quantity.ToString();
                    total += (item.price * item.quantity);
                }
            }
            Label totalLabel = new Label();
            totalLabel.Text = "Total: "+total.ToString();
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
    }
}
