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

        private ErrorProvider errorProvider = new ErrorProvider();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //firstname
            String input = textBox1.Text;
            if (input.Length > 0 && !input.All(char.IsDigit))
            {
                errorProvider.SetError(textBox1, "");
                FirstName = true; 
            }
            else
            {
                errorProvider.SetError(textBox1, "Must be at least 1 letter");
                FirstName = false; 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //lastname
            String input = textBox2.Text;
            if (input.Length > 0 && !input.All(char.IsDigit))
            {
                errorProvider.SetError(textBox2, "");
                LastName = true;
            }
            else
            {
                errorProvider.SetError(textBox2, "Must be at least 1 letter");
                LastName = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //cardnum
            String input = textBox3.Text;
            if (input.Length == 16 && input.All(char.IsDigit))
            {
                errorProvider.SetError(textBox3, "");
                CardNum = true;
            }
            else
            {
                errorProvider.SetError(textBox3, "Must be 16 digits");
                CardNum = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //ExpDate
            String input = textBox4.Text;
            if (input.Length == 5 && input.Contains("/"))
            {
                errorProvider.SetError(textBox4, "");
                ExpDate = true;
            }
            else
            {
                errorProvider.SetError(textBox4, "Must be at valid date in format MM/YY");
                ExpDate = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //CVC
            String input = textBox5.Text;
            if (input.Length == 3 && input.All(char.IsDigit))
            {
                errorProvider.SetError(textBox5, "");
                CVC = true;
            }
            else
            {
                errorProvider.SetError(textBox5, "Must be 3 digits");
                CVC = false;
            }
        }

        private void ExpLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
