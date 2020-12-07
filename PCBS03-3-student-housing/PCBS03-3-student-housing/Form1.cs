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
        }

        //login button clicked
        private void button_login_Click(object sender, EventArgs e)
        {

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
