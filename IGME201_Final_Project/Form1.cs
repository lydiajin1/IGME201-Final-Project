using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IGME201_Final_Project
{
    public partial class Form1 : Form
    {
        public static Form1 instance;

        public UsersInfo userInfo;
        public string currentUser;
        public string[][] currentInfo;
        public System.Windows.Forms.Button menuBtn;
        public System.Windows.Forms.Button cartBtn;
        public System.Windows.Forms.Button checkoutBtn;
        public List<FoodItems> fooditems = new List<FoodItems>();
        public FoodItems burger = new FoodItems(5,"Burger");
        public FoodItems pizza  = new FoodItems(4,"Pizza");
        public FoodItems salad = new FoodItems(4, "Salad");
        public FoodItems garbagePlate = new FoodItems(6, "Garbage Plate");
        public FoodItems fries = new FoodItems(2, "French Fries");
        public FoodItems nuggets = new FoodItems(3, "Chicken Nuggets");
        public FoodItems soda = new DrinkItems("Medium", 1, "Soda");
        public FoodItems lemonade = new DrinkItems("Large", 2, "Lemonade");

        public Form1()
        {
            instance = this;
            InitializeComponent();
            userInfo = new UsersInfo();
            userInfo.LoadUsers();
            menuBtn = Menubtn;
            cartBtn = Cartbtn;
            checkoutBtn = Checkoutbtn;
            menuBtn.Enabled = true; // flip this back in the future
            cartBtn.Enabled = false;
            checkoutBtn.Enabled = false;
            fooditems.Add(burger);
            fooditems.Add(pizza);
            fooditems.Add(salad);
            fooditems.Add(garbagePlate);
            fooditems.Add(fries);
            fooditems.Add(nuggets);
            fooditems.Add(soda);
            fooditems.Add(lemonade);


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
            if (currentInfo[1][0] != null)
            {
                userControl41.uploadText();
            }
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
