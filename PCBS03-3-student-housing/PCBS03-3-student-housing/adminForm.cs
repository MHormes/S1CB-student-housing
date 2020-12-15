﻿using System;
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
    public partial class adminForm : Form
    {
        //Define class and List for admin newspage tab
        News news;
        public static List<News> newsList = new List<News>();

        //get studentComplaint list
        List<Complaint> adminComplaints = studentForm.complaintStudentList;

        Student student = new Student();

        //mouse coords which are needed for GUI drag bar functionality
        public Point mouseLocation;

        public adminForm()
        {
            InitializeComponent();
            UpdateNewsList();
            UpdateComplaintList();
        }

        //Add news to the news tab
        private void btnAddNews_Click(object sender, EventArgs e)
        {
            
            //check if input is not empty
            if(!String.IsNullOrWhiteSpace(tbxMessage.Text) && !String.IsNullOrWhiteSpace(tbxAuthorName.Text))
            {
                //add news object
                news = new News(tbxMessage.Text, tbxAuthorName.Text);
                //add to the newslist
                newsList.Add(news);
                //update the listbox
                UpdateNewsList();
            }
            //one of 2 fields empty? show message
            else
            {
                MessageBox.Show("Please fill in both fields before pressing the add button");
            }   
        }

        // Method for updating the news listbox. 
        private void UpdateNewsList()
        {
            //clear it to fill it again
            lbxAdminNews.Items.Clear();

            //take all items and add them 1 by 1 in the Listbox.
            foreach(News news in newsList)
            {
                lbxAdminNews.Items.Add(news.GetNews());
            }
        }

        //logout button
        private void button_logout_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        //tenant added to the list
        private void button_addTenant_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_tenantName.Text) || String.IsNullOrEmpty(textBox_tenantPassword.Text))
            {
                MessageBox.Show("Account name and password required. Please retry.");
                return;
            }
            student.addStudent(textBox_tenantName.Text, textBox_tenantPassword.Text);
            //textbox cleared
            textBox_tenantName.Clear();
            textBox_tenantPassword.Clear();
            //list updated
            UpdateStudentList();
        }

        //tenant removed from the list
        private void button_removeTenant_Click(object sender, EventArgs e)
        {
            //name required
            if (String.IsNullOrEmpty(textBox_tenantName.Text))
            {
                MessageBox.Show("Account name required. Please retry.");
                return;
            }

            //student present in the list?
            if (student.itContainsStudent(textBox_tenantName.Text))
            {
                //yes -> remove
                student.removeStudent(textBox_tenantName.Text);
                //textbox cleared
                textBox_tenantName.Clear();
                //list updated
                UpdateStudentList();
            }
            //no -> error
            else
            {
                MessageBox.Show("Name not present in the list. Please retry.");
                return;
            }
        }

        private void UpdateStudentList()
        {
            //listbox cleared
            listBox_tenants.Items.Clear();
            List<Tuple<string, string>> studentList = new List<Tuple<string, string>>();
            //new list
            studentList = student.getStudentList();

            //take all items and add them 1 by 1 in the Listbox.
            foreach (Tuple<string, string> student in studentList)
            {
                listBox_tenants.Items.Add(student.Item1 + " - " + student.Item2);
            }
        }

        private void UpdateComplaintList()
        {
            lbxAdminComplaint.Items.Clear();

            foreach (Complaint com in adminComplaints)
            {
                lbxAdminComplaint.Items.Add(com.GetComplaint());
            }
        }

        private void btnRefreshComplaints_Click(object sender, EventArgs e)
        {
            UpdateComplaintList();
        }

        private void btnAddComplaintComment_Click(object sender, EventArgs e)
        {
            foreach(Complaint com in adminComplaints)
            {
                if(com.GetComplaint() == (string)lbxAdminComplaint.SelectedItem)
                {
                    if (String.IsNullOrWhiteSpace(tbxComplaintComment.Text))
                    {
                        MessageBox.Show("Please give a comment before clicking the button");
                        return;
                    }
                    com.AdminComment = tbxComplaintComment.Text;
                    MessageBox.Show($"Comment add to complaint: {com.GetComplaint()}");
                    UpdateComplaintList();
                    return;
                }
            }
        }

        private void btnCheckComplaint_Click(object sender, EventArgs e)
        {
            foreach(Complaint com in adminComplaints)
            {
                if(com.GetComplaint() == (string)lbxAdminComplaint.SelectedItem)
                {
                    adminComplaints.Remove(com);
                    MessageBox.Show("Complaint checked of as done");
                    UpdateComplaintList();
                    return;
                }
            }
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
            using (Pen p = new Pen(Color.FromArgb(66, 66, 66), borderThickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle((borderThickness / 2),
                                                          (borderThickness / 2),
                                                          pnlBackground.ClientSize.Width - borderThickness,
                                                          pnlBackground.ClientSize.Height - borderThickness));
            }
        }

        //'X' icon used to close current form
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
