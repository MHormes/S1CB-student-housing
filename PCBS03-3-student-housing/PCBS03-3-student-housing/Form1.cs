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

        public Point mouseLocation;
        
        public Form1()
        {
            InitializeComponent();

            //create hardcoded news pieces to test if it works
            News newsTest = new News("This is a test message", "Maarten Hormes");
            News newsTest1 = new News("This is a test message", "Luca Pulvirenti");
            News newsTest2 = new News("This is a test message", "Alessandro Busacchi");
            adminForm.newsList.Add(newsTest);
            adminForm.newsList.Add(newsTest1);
            adminForm.newsList.Add(newsTest2);
        }

        //login button clicked
        private void button_login_Click(object sender, EventArgs e)
        {
            //check if there is an empty texbox. if yes -> error
            if (string.IsNullOrEmpty(textBox_accountName.Text) || string.IsNullOrEmpty(textBox_accountPassword.Text))
            {
                MessageBox.Show("Account name and password required. Please retry.");
                return;
            }

            //check if account name is admin
            if (textBox_accountName.Text == adminNamePass)
            {
                //check if admin password is correct
                if (textBox_accountPassword.Text == adminNamePass)
                {
                    //form1 closed and go to admin form
                    adminForm nextForm = new adminForm();
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
            //check if account name is student
            else if (textBox_accountName.Text == studentNamePass)
            {
                //check if student password is correct
                if (textBox_accountPassword.Text == studentNamePass)
                {
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
            else
            {
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

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBackground_Paint(object sender, PaintEventArgs e)
        {
            if (pnlBackground.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 1;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              pnlBackground.ClientSize.Width - thickness,
                                                              pnlBackground.ClientSize.Height - thickness));
                }
            }
        }

        private void pnlDragBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void pnlDragBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlDragBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void pnlDragBar_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
    }
}
