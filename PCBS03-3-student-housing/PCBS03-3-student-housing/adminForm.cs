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
    public partial class adminForm : Form
    {
        //Define class and List for admin newspage tab
        News news;
        public static List<News> newsList = new List<News>();

        //get studentComplaint list
        List<Complaint> adminComplaints = studentForm.complaintStudentList;

        Student student = new Student();

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
    }
}
