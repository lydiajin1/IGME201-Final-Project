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
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public UsersInfo userInfo;
        public string currentUser;
        public string[][] currentInfo;
        public Button menuBtn;
        public Button cartBtn;
        public Button checkoutBtn;


        public Form1()
        {
            instance = this;
            InitializeComponent();
            userInfo = new UsersInfo();
            userInfo.LoadUsers();
            menuBtn = Menubtn;
            cartBtn = Cartbtn;
            checkoutBtn = Checkoutbtn;
            menuBtn.Enabled = false;
            cartBtn.Enabled = false;
            checkoutBtn.Enabled = false;

        }  

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl11.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl11.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl21.BringToFront();
        }

        private void Cartbtn_Click(object sender, EventArgs e)
        {
            userControl31.Show();
            userControl11.Hide();
            userControl21.Hide();
            userControl41.Hide();
            userControl31.BringToFront();
        }

        private void Checkoutbtn_Click(object sender, EventArgs e)
        {
            userControl41.Show();
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.BringToFront();
            //comment

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        public void Save()
        {
           userInfo.users[currentUser] = currentInfo;
            userInfo.SaveUsers();
        }
    }
}
