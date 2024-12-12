using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGME201_Final_Project
{
    public partial class UserControl4 : UserControl
    {
        public bool FirstName = false;
        public bool LastName = false;
        public bool CardNum = false;
        public bool ExpDate = false;
        public bool CVC = false;

        public UserControl4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display the confirmation dialog
            Form confirmationDialog = new Form
            {

                Text = "Order Confirmation",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                Size = new Size(300, 200),
                Font = new Font("Berlin Sans FB", 16),
                BackColor = Color.DarkSalmon,
                ForeColor = Color.White
            };

            Form ErroDialog = new Form
            {

                Text = "Order Confirmation",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                Size = new Size(300, 200),
                Font = new Font("Berlin Sans FB", 16),
                BackColor = Color.DarkSalmon,
                ForeColor = Color.White
            };

            Label confirmationMessage = new Label
            {
                Text = "Your order has now been confirmed.\nThank you for your purchase!",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label ErrornMessage = new Label
            {
                Text = "Please fill out all fields correctly.",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            confirmationDialog.Controls.Add(confirmationMessage);
            ErroDialog.Controls.Add(ErrornMessage);

            if (FirstName && LastName && CardNum && ExpDate && CVC)
            {
                // Show the dialog modally if all are true
                confirmationDialog.ShowDialog();
            }
            else
            {

                ErroDialog.ShowDialog();
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //firstname
            String input = textBox1.Text;
            if (input.Length > 0 && !input.All(char.IsDigit))
            {
                FirstName = true; 
            }
            else
            {
                FirstName = false; 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //lastname
            String input = textBox2.Text;
            if (input.Length > 0 && !input.All(char.IsDigit))
            {
                LastName = true;
            }
            else
            {
                LastName = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //cardnum
            String input = textBox3.Text;
            if (input.Length > 15 && input.All(char.IsDigit))
            {
                CardNum = true;
            }
            else
            {
                CardNum = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //ExpDate
            String input = textBox4.Text;
            if (input.Length > 4 && input.Contains("/"))
            {
                ExpDate = true;
            }
            else
            {
                ExpDate = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //CVC
            String input = textBox5.Text;
            if (input.Length > 2 && input.All(char.IsDigit))
            {
                CVC = true;
            }
            else
            {
                CVC = false;
            }
        }
    }
}
