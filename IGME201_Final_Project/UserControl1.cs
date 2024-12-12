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
            }
            else
            {
                createAcctUsernameError.Clear();
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
            }
            else
            {
                createAcctPasswordError.Clear();
            }
        }
    }
}
