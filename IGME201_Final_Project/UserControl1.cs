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
    public partial class UserControl1 : UserControl
    {
        public static UserControl1 instance;


            public bool usernameValid = false;
        public bool passwordValid = false;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void loginConfirm_Click(object sender, EventArgs e)
        {

        }

        private void accQuestion_Click(object sender, EventArgs e)
        {

        }

        private void Cofirmbtn_Click(object sender, EventArgs e)
        {
            if (passwordValid && usernameValid)
            {
                string[][] info = new string[2][];
                info[0] = new string[] { CreateAccPasswordtxtbox.Text };
                info[1] = new string[] { null,null,null,null,null}; 
                try
                {

                    Form1.instance.userInfo.users.Add(CreateAccUsernametxtbox.Text, info);
                    Form1.instance.currentInfo = Form1.instance.userInfo.users[CreateAccUsernametxtbox.Text];
                    Form1.instance.currentUser = LoginUsernametxtbox.Text;
                    Form1.instance.menuBtn.Enabled = true;
                    Form1.instance.menuBtn.PerformClick();
                }
                catch (Exception ex)
                {
                    createAcctUsernameError.SetError(this.CreateAccUsernametxtbox, "Account with Username Already Exists");
                 

                }
                
                
        }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginUsernametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginTitle_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccUsernametxtbox_TextChanged(object sender, EventArgs e)
        {
            if ((CreateAccUsernametxtbox.Text.Length < 3) || (CreateAccUsernametxtbox.Text.Length > 16) || (Char.IsLower(CreateAccUsernametxtbox.Text, 0)) || (Char.IsNumber(CreateAccUsernametxtbox.Text, 0)) || (!Char.IsLetterOrDigit(CreateAccUsernametxtbox.Text, 0)))
            {
                createAcctUsernameError.SetError(this.CreateAccUsernametxtbox, "Must begin with a capital letter and be between 3-16 characters");
                usernameValid = false;
            }
            else
            {
                createAcctUsernameError.Clear();
                usernameValid = true;
            }

            if (usernameValid && passwordValid)
            {
                Cofirmbtn.Enabled = true;
            }
            else
            {
                Cofirmbtn.Enabled = false;
            }
        }

        private void UsernameCreateAccLbl_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccPasswordtxtbox_TextChanged(object sender, EventArgs e)
        {
            if ((CreateAccPasswordtxtbox.Text.Length < 8) || (CreateAccPasswordtxtbox.Text.Any(c => char.IsLetter(c)) == false) || (CreateAccPasswordtxtbox.Text.Any(c => char.IsDigit(c)) == false) || (CreateAccPasswordtxtbox.Text.Any(c => !char.IsLetterOrDigit(c)) == false))
            {
                createAcctPasswordError.SetError(this.CreateAccPasswordtxtbox, "Must be at least 8 characters and include at least one letter, number, and special character");
                passwordValid = false;
            }
            else
            {
                createAcctPasswordError.Clear();
                passwordValid = true;
            }

            if (usernameValid && passwordValid)
            {
                Cofirmbtn.Enabled = true;
            } else
            {
                Cofirmbtn.Enabled= false;
            }
        }

        private void UsernameCreateAcclabel_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void loginConfirm_Click_1(object sender, EventArgs e)
        {
            

            if (Form1.instance.userInfo.users.ContainsKey(LoginUsernametxtbox.Text)) 

            {
               Form1.instance.currentInfo = Form1.instance.userInfo.users[LoginUsernametxtbox.Text];
                if (Form1.instance.currentInfo[0][0] == LoginPasswordTypeBox.Text)
                {
                    Form1.instance.currentUser = LoginUsernametxtbox.Text;
                    Form1.instance.menuBtn.Enabled = true;
                    Form1.instance.menuBtn.PerformClick();
                }
                
            }
            
            
            
        }

        private void LoginPasswordTypeBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
