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
        public bool isFirstName = false;
        public bool isLastName = false;
        public bool isCardNum = false;
        public bool isExpDate = false;
        public bool isCVC = false;

        public UserControl4()
        {
            InitializeComponent();
            if (Form1.instance.currentInfo[1][0] != null)
            {
                textBox1.Text = Form1.instance.currentInfo[1][0];
                textBox2.Text = Form1.instance.currentInfo[1][1];
                textBox3.Text = Form1.instance.currentInfo[1][2];
                textBox4.Text = Form1.instance.currentInfo[1][3];
                textBox5.Text = Form1.instance.currentInfo[1][4];
            }
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

            if (isFirstName && isLastName && isCardNum && isExpDate && isCVC)
            {
                // Show the dialog modally if all are true
                confirmationDialog.ShowDialog();
                 Form1.instance.currentInfo[1][0] = textBox1.Text;
               Form1.instance.currentInfo[1][1] = textBox2.Text  ;
                Form1.instance.currentInfo[1][2] = textBox3.Text;
                Form1.instance.currentInfo[1][3] = textBox4.Text;
                Form1.instance.currentInfo[1][4] = textBox5.Text;
                Form1.instance.Save();

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
                isFirstName = true; 
            }
            else
            {
                errorProvider.SetError(textBox1, "Must be at least 1 letter");
                isFirstName = false; 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //lastname
            String input = textBox2.Text;
            if (input.Length > 0 && !input.All(char.IsDigit))
            {
                errorProvider.SetError(textBox2, "");
                isLastName = true;
            }
            else
            {
                errorProvider.SetError(textBox2, "Must be at least 1 letter");
                isLastName = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //cardnum
            String input = textBox3.Text;
            if (input.Length == 16 && input.All(char.IsDigit))
            {
                errorProvider.SetError(textBox3, "");
                isCardNum = true;
            }
            else
            {
                errorProvider.SetError(textBox3, "Must be 16 digits");
                isCardNum = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //ExpDate
            String input = textBox4.Text;
            if (input.Length == 5 && input.Contains("/"))
            {
                errorProvider.SetError(textBox4, "");
                isExpDate = true;
            }
            else
            {
                errorProvider.SetError(textBox4, "Must be at valid date in format MM/YY");
                isExpDate = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //CVC
            String input = textBox5.Text;
            if (input.Length == 3 && input.All(char.IsDigit))
            {
                errorProvider.SetError(textBox5, "");
                isCVC = true;
            }
            else
            {
                errorProvider.SetError(textBox5, "Must be 3 digits");
                isCVC = false;
            }
        }

        private void ExpLbl_Click(object sender, EventArgs e)
        {

        }

        private void UserControl4_Load(object sender, EventArgs e)
        {

        }
    }
}
