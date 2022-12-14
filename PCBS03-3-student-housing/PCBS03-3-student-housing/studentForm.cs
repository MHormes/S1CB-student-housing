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
    public partial class studentForm : Form
    {
        //create news list, this is the same list adminForm uses.
        List<News> newsStudentList = adminForm.newsList;

        //create complaint list, this list will be used in the adminForm. 
        public static List<Complaint> complaintStudentList = new List<Complaint>();
        Complaint complaint;


        //Define class and List for admin announcements tab
        Announcement announcement;
        public static List<Announcement> announcementList = new List<Announcement>();

        //create instance of class and List for admin rules tab
        public static List<Rule> ruleList = adminForm.ruleList;

        //mouse coords which are needed for GUI drag bar functionality
        public Point mouseLocation;

        public studentForm(string studentName)
        {
            InitializeComponent();
            UpdateNewsList();
            UpdateComplaintList();
            UpdateAnnouncementList();
            UpdateRulesList();
            lblHeader.Text = $"Welcome, {studentName}";
        }

        // Method for updating the news listbox. 
        private void UpdateNewsList()
        {
            //clear it to fill it again
            lbxStudentNews.Items.Clear();

            //take all items and add them 1 by 1 in the Listbox.
            foreach (News news in newsStudentList)
            {
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

        //method for submitting a complaint
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
                if (comp.StName == Form1.studentName)
                {
                    lbxStudentComplaint.Items.Add(comp.GetComplaint());
                }
            }
        }

        private void UpdateAnnouncementList()
        {
            //listbox cleared and announcements added
            lbxStudentAnnouncements.Items.Clear();

            foreach (Announcement ann in announcementList)
            {
                lbxStudentAnnouncements.Items.Add(ann.GetAnnouncement());
            }
        }

        private void UpdateRulesList()
        {
            //listbox cleared and rules added
            lbxStudentRules.Items.Clear();

            foreach (Rule r in ruleList)
            {
                lbxStudentRules.Items.Add(r.GetRule());
            }
        }

        //method for removing the selected complaint
        private void btnStudentRemoveComplaint_Click(object sender, EventArgs e)
        {
            foreach (Complaint com in complaintStudentList)
            {
                if (com.GetComplaint() == (string)lbxStudentComplaint.SelectedItem)
                {
                    complaintStudentList.Remove(com);
                    UpdateComplaintList();
                    return;
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

        //creates a border in order to better differenciate the form from any other applications behind it
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

        private void tpStudentComplaint_Paint(object sender, PaintEventArgs e)
        {
            ////creates a color gradient as the background to make the form more visually appealing
            //using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
            //                                               Color.FromArgb(138, 92, 251),
            //                                               Color.FromArgb(83, 47, 171),
            //                                               90F))
            //{
            //    e.Graphics.FillRectangle(brush, this.ClientRectangle);
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

        //Add announcement to the news tab
        private void btnAddNews_Click(object sender, EventArgs e)
        {
             //check if input is not empty
             if (!String.IsNullOrWhiteSpace(tbxMessageAnnouncements.Text) && !String.IsNullOrWhiteSpace(tbxAuthorNameAnnouncements.Text))
                {
                //add announcement object
                announcement = new Announcement(tbxMessageAnnouncements.Text, tbxAuthorNameAnnouncements.Text);
                //add to the announcement list
                announcementList.Add(announcement);
                //update the listbox
                UpdateAnnouncementList();
             }
             //one of 2 fields empty? show message
             else
             {
                MessageBox.Show("Please fill in both fields before pressing the add button");
             }
        }

        private void lblGarbage4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"- Make sure to use the bin marked with your house number.\n\n- Ensure that the garbage bags are closed to avoid accidental messes.\n\n- Please try to dispose of your garbage weekly to avoid any odors within the house.", "Garbage Collection Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblCardboard4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"- Make sure to leave the cardboard neatly on the side of the road.\n\n- Please try to dispose of your cardboard on this day of the week. Do not put the cardboard with the garbage", "Cardboard Collection Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblClean3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Please note that the cleaners will not be present on days which fall on public holidays", "Cleaning Service Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
