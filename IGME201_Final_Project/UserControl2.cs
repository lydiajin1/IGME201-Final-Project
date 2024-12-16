using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGME201_Final_Project
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();

        }



        private void CreateAcc_Click(object sender, EventArgs e)
        {
         
        }

        private void accQuestion_Click(object sender, EventArgs e)
        {

        }

        private void LoginTitle_Click(object sender, EventArgs e)
        {

        }

        private void loginConfirm_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTypeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuTitle_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void HamburgerAddBtn_Click(object sender, EventArgs e)
        {
            Form1.instance.fooditems[0].quantity ++;
            int textVal = Convert.ToInt32(NumItems.Text);
            textVal++;
            NumItems.Text = textVal.ToString();
        }

        private void PizzaAddBtn_Click(object sender, EventArgs e)
        {
            Form1.instance.fooditems[1].quantity++;
            int textVal = Convert.ToInt32(NumItems.Text);
            textVal++;
            NumItems.Text = textVal.ToString();
        }

        private void SaladAddBtn_Click(object sender, EventArgs e)
        {
            Form1.instance.fooditems[2].quantity++;
            int textVal = Convert.ToInt32(NumItems.Text);
            textVal++;
            NumItems.Text = textVal.ToString();
        }

        private void GarbagePlateAddBtn_Click(object sender, EventArgs e)
        {
            Form1.instance.fooditems[3].quantity++;
            int textVal = Convert.ToInt32(NumItems.Text);
            textVal++;
            NumItems.Text = textVal.ToString();
        }

        private void FrenchFriesAddBtn_Click(object sender, EventArgs e)
        {
            Form1.instance.fooditems[4].quantity++;
            int textVal = Convert.ToInt32(NumItems.Text);
            textVal++;
            NumItems.Text = textVal.ToString();
        }

        private void NuggetsAddBtn_Click(object sender, EventArgs e)
        {
            Form1.instance.fooditems[5].quantity++;
            int textVal = Convert.ToInt32(NumItems.Text);
            textVal++;
            NumItems.Text = textVal.ToString();
        }

        private void LemonadeAddBtn_Click(object sender, EventArgs e)
        {
            Form1.instance.fooditems[6].quantity++;
            int textVal = Convert.ToInt32(NumItems.Text);
            textVal++;
            NumItems.Text = textVal.ToString();
        }

        private void SodaAddBtn_Click(object sender, EventArgs e)
        {
            Form1.instance.fooditems[7].quantity++;
            int textVal = Convert.ToInt32(NumItems.Text);
            textVal++;
            NumItems.Text = textVal.ToString();
        }

        private void NumItems_TextChanged(object sender, EventArgs e)
        {
            Form1.instance.cartBtn.Enabled = true;
        }
    }
}
