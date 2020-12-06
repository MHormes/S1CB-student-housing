using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBS03_3_student_housing
{
    public partial class Form1 : Form
    {
        private string adminNamePass = "admin";
        private string studentNamePass = "student";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox_accountName.Text) || string.IsNullOrEmpty(textBox_accountPassword.Text)) {
                MessageBox.Show("Account name and password required. Please retry.");
                return;
            }

            if (textBox_accountName.Text == adminNamePass)
            {
                if(textBox_accountPassword.Text == adminNamePass) {
                    MessageBox.Show("Success");
                }
                else {
                    errorPassword();
                    return;
                }
            }
            else if (textBox_accountName.Text == studentNamePass)
            {
                if (textBox_accountPassword.Text == studentNamePass) {
                    MessageBox.Show("Success");
                }
                else {
                    errorPassword();
                    return;
                }
            }
            else {
                errorAccount();
                return;
            }
        }

        private void errorAccount()
        {
            MessageBox.Show("The account doesn't exist. Please retry.");
            return;
        }

        private void errorPassword()
        {
            MessageBox.Show("Wrong password. Please retry.");
            return;
        }
    }
}
