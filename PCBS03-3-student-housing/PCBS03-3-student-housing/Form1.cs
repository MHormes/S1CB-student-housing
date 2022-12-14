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

        //Student student = new Student();

        //account names and passwords
        private string adminNamePass = "admin";

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

            else 
            {
                List<Tuple<string, string>> studentList = new List<Tuple<string, string>>();
                //new list
                studentList = Student.getStudentList();

                bool found = Student.itContainsStudent(textBox_accountName.Text);
                int index = -1;

                if (!found)
                {
                    errorAccount();
                    return;
                }

                foreach(Tuple<string, string> stud in studentList)
                {
                    if (textBox_accountName.Text == stud.Item1)
                        index = studentList.IndexOf(stud);
                }
                    
                //check if student password is correct
                if (textBox_accountPassword.Text == studentList.ElementAt(index).Item2)
                {
                    studentName = textBox_accountName.Text;
                    //form1 closed and go to student form
                    studentForm nextForm = new studentForm(studentName);
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
        }

        //account error
        private void errorAccount()
        {
            MessageBox.Show("The account doesn't exist. Please retry.");
            textBox_accountPassword.Clear();
            textBox_accountPassword.Text = "Password";
            textBox_accountPassword.ForeColor = Color.Gray;
            textBox_accountPassword.TextAlign = HorizontalAlignment.Center;
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

        private void textBox_accountName_Enter(object sender, EventArgs e)
        {
            if(textBox_accountName.Text == "Account name")
            {
                textBox_accountName.Text = "";
                textBox_accountName.ForeColor = Color.Black;
                textBox_accountName.TextAlign = HorizontalAlignment.Left;
            }
        } 

        private void textBox_accountName_Leave(object sender, EventArgs e)
        {
            if(textBox_accountName.Text == "")
            {
                textBox_accountName.Text = "Account name";
                textBox_accountName.ForeColor = Color.Gray;
                textBox_accountName.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void textBox_accountPassword_Enter(object sender, EventArgs e)
        {        
            if (textBox_accountPassword.Text == "Password")
            {
                textBox_accountPassword.UseSystemPasswordChar = true;
                textBox_accountPassword.Clear();
                textBox_accountPassword.ForeColor = Color.Black;
                textBox_accountPassword.TextAlign = HorizontalAlignment.Left;  
            }
        }

        private void textBox_accountPassword_Leave(object sender, EventArgs e)
        {
            if (textBox_accountPassword.Text == "")
            {
                textBox_accountPassword.UseSystemPasswordChar = false;
                textBox_accountPassword.Text = "Password";
                textBox_accountPassword.ForeColor = Color.Gray;
                textBox_accountPassword.TextAlign = HorizontalAlignment.Center;
            } 
        }

        private void pnlBackground_Click(object sender, EventArgs e)
        {
            textBox_defocus.Focus();
        }

        private void textBox_accountPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button_login.PerformClick();
            }

            if (e.KeyChar == (char)Keys.Tab)
            {
                textBox_accountName.Focus();
            }
        }

        private void textBox_accountName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                textBox_accountPassword.Focus();
            }
        }

        private void textBox_defocus_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            //{
            textBox_accountName.Focus();
            //}
        }

        //dims the 'X' icon for visual feedback of hover
        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Gray;
        }

        //brightens the 'X' icon for visual feedback of lack of hover
        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.White;
        }
    }
}
