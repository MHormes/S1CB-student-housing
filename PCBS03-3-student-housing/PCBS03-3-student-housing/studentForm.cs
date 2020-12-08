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
    public partial class studentForm : Form
    {
        //create news list, this is the same list adminForm uses.
        List<News> newsStudentList = adminForm.newsList;

        //create complaint list, this list will be used in the adminForm. 
        List<Complaint> complaintStudentList = new List<Complaint>();
        Complaint complaint;

        //mouse coords which are needed for GUI drag bar functionality
        public Point mouseLocation;

        public studentForm()
        {
            InitializeComponent();
            UpdateNewsList();
            UpdateComplaintList();
        }

        // Method for updating the news listbox. 
        private void UpdateNewsList()
        {
            //clear it to fill it again
            lbxStudentNews.Items.Clear();

            //take all items and add them 1 by 1 in the Listbox.
            foreach (News news in newsStudentList)
            {
                //THIS NEEDS AN EDIT. LISTBOX DOES NOT SUPPORT NEW LINES. THIS IS NEEDED!!!!!!!!!!!!!!!!!!
                lbxStudentNews.Items.Add(news.GetNews());
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

        private void btnSubmitComplaint_Click_1(object sender, EventArgs e)
        {
            //check if the complaint is not empty
            if (!String.IsNullOrWhiteSpace(tbxStudentComplaint.Text))
            {
                complaint = new Complaint(tbxStudentComplaint.Text, Form1.studentName);
                complaintStudentList.Add(complaint);
                UpdateComplaintList();
            }
            else
            {
                MessageBox.Show("Please fill in the complaint before submitting");
            }
        }

        private void UpdateComplaintList()
        {
            //clear it to fill it again
            lbxStudentComplaint.Items.Clear();

            //take all items and check if this user submitted them. if so add to listbox
            foreach(Complaint comp in complaintStudentList)
            {
                if (comp.GetStName() == Form1.studentName)
                {
                    lbxStudentComplaint.Items.Add(comp.GetComplaint());
                }
            }
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
    }
}
