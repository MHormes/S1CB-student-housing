using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PCBS03_3_student_housing
{
    public partial class Form1 : Form
    {
        //string to pass the username to an other form for later use
        public static string studentName;

        //account names and passwords
        private string adminNamePass = "admin";
        private string studentNamePass = "student";
        private string studentNamePass1 = "student1";

        //mouse coords which are needed for GUI drag bar functionality
        public Point mouseLocation;
        
        public Form1()
        {
            InitializeComponent();
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
            //EDIT THIS USING THE STUDENT LIST!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //check if account name is student
            else if (textBox_accountName.Text == studentNamePass || textBox_accountName.Text == studentNamePass1)
            {
                //check if student password is correct
                if (textBox_accountPassword.Text == studentNamePass || textBox_accountPassword.Text == studentNamePass1)
                {
                    studentName = textBox_accountName.Text;
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

        //'X' icon used to close current form
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //updates mouse position when the panel is clicked
        private void pnlDragBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        //updates window position based on the movement on mouse to simulate the default 'drag bar' that was removed due to design reasons
        private void pnlDragBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        
        private void pnlBackground_Paint(object sender, PaintEventArgs e)
        {
                //creates a color gradient as the background to make the form more visually appealing
                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                               Color.FromArgb(138, 92, 251),
                                                               Color.FromArgb(83, 47, 171),
                                                               90F))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }

                //creates a border in order to better differenciate the form from any other applications behind it
                int borderThickness = 4;
                using (Pen p = new Pen(Color.FromArgb(66,66,66), borderThickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle((borderThickness/2),
                                                              (borderThickness/2),
                                                              pnlBackground.ClientSize.Width - borderThickness,
                                                              pnlBackground.ClientSize.Height - borderThickness));
                }
        }

    }
}
