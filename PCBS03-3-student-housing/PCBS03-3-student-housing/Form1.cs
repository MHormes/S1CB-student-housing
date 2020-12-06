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
        //account names and passwords
        private string adminNamePass = "admin";
        private string studentNamePass = "student";
        
        public Form1()
        {
            InitializeComponent();
        }

        //login button clicked
        private void button_login_Click(object sender, EventArgs e)
        {
            //check if there is an empty texbox. if yes -> error
            if (string.IsNullOrEmpty(textBox_accountName.Text) || string.IsNullOrEmpty(textBox_accountPassword.Text)) {
                MessageBox.Show("Account name and password required. Please retry.");
                return;
            }
            //check if account name is admin
            if (textBox_accountName.Text == adminNamePass)
            {
                //check if admin password is correct
                if(textBox_accountPassword.Text == adminNamePass) {
                    //form1 closed and go to admin form
                    adminForm nextForm = new adminForm();
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();
                }
                //wrong password
                else {
                    errorPassword();
                    return;
                }
            }
            //check if account name is student
            else if (textBox_accountName.Text == studentNamePass)
            {
                //check if student password is correct
                if (textBox_accountPassword.Text == studentNamePass) {
                    //form1 closed and go to student form
                    studentForm nextForm = new studentForm();
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();
                }
                //wrong password
                else
                {
                    errorPassword();
                    return;
                }
            }
            //account inserted is not admin or student -> error
            else {
                errorAccount();
                return;
            }
        }

        //account error
        private void errorAccount()
        {
            MessageBox.Show("The account doesn't exist. Please retry.");
            return;
        }

        //password error
        private void errorPassword()
        {
            MessageBox.Show("Wrong password. Please retry.");
            return;
        }
    }
}
