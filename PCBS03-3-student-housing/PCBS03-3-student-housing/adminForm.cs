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
    public partial class adminForm : Form
    {
        //Define class and List for admin newspage tab
        News news;
        public static List<News> newsList = new List<News>();

        //create news list, this is the same list StudentForm uses.
        List<Announcement> announcementStudentList = studentForm.announcementList;

        //get studentComplaint list
        List<Complaint> adminComplaints = studentForm.complaintStudentList;

        List<Tuple<string, string>> studentList = Student.getStudentList();

        //create instance of class and List for admin rules tab
        Rule rule;
        public static List<Rule> ruleList = new List<Rule>();


        //mouse coords which are needed for GUI drag bar functionality
        public Point mouseLocation;

        //update lists
        public adminForm()
        {
            InitializeComponent();
            PopulateApp();
            UpdateNewsList();
            UpdateComplaintList();
            UpdateAnnouncementList();
            UpdateStudentList();
            UpdateRuleList();
        }

        //Population method
        public void PopulateApp()
        {
            //Only populatet once
            if(PopulateClass.Counter == 1)
            {
                return;
            }

            foreach (Rule rule in PopulateClass.SeedRule())
            {
                ruleList.Add(rule);
            }
            PopulateClass.SeedStudent();
            PopulateClass.SeedComplaint();
            PopulateClass.SeedNewsList();
            PopulateClass.SeedAnnouncements();
        }

        //Add news to the news tab
        private void btnAddNews_Click(object sender, EventArgs e)
        {

            //check if input is not empty
            if (!String.IsNullOrWhiteSpace(tbxMessage.Text) && !String.IsNullOrWhiteSpace(tbxAuthorName.Text))
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
            foreach (News news in newsList)
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
            Student.addStudent(textBox_tenantName.Text, textBox_tenantPassword.Text);
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
            if (String.IsNullOrEmpty(textBox_tenantName.Text) && listBox_tenants.SelectedIndex == -1)
            {
                MessageBox.Show("Account name or item required. Please retry.");
                return;
            }

            if (!String.IsNullOrEmpty(textBox_tenantName.Text) && listBox_tenants.SelectedIndex != -1)
            {
                MessageBox.Show("You inserted both the item on the list and a name. Please remove one of them.");
                return;
            }

            if (listBox_tenants.SelectedIndex != -1)
            {
                Student.removeStudent(studentList.ElementAt(listBox_tenants.SelectedIndex).Item1);
                //textbox cleared
                textBox_tenantName.Clear();
                //list updated
                UpdateStudentList();
                return;
            }

            //student present in the list?
            if (Student.itContainsStudent(textBox_tenantName.Text))
            {
                //yes -> remove
                Student.removeStudent(textBox_tenantName.Text);
                //textbox cleared
                textBox_tenantName.Clear();
                //list updated
                UpdateStudentList();
                return;
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

        //update announcements
        private void UpdateAnnouncementList()
        {
            //listbox cleared
            lbxAdminAnnouncement.Items.Clear();

            //items added
            foreach (Announcement ann in announcementStudentList)
            {
                lbxAdminAnnouncement.Items.Add(ann.GetAnnouncement());
            }
        }   

        private void UpdateRuleList()
        {
            lbxAdminRules.Items.Clear();

            foreach(Rule r in ruleList)
            {
                lbxAdminRules.Items.Add(r.GetRule());
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
                    MessageBox.Show("Complaint checked off as done");
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

        private void button_unselect_Click_1(object sender, EventArgs e)
        {
            listBox_tenants.SelectedIndex = -1;
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            //check if input is not empty
            if (!String.IsNullOrWhiteSpace(tbxRule.Text))
            {
                //add list object
                rule = new Rule(tbxRule.Text);
                //add to the rule list
                ruleList.Add(rule);
                //update the listbox
                UpdateRuleList();
                tbxRule.Clear();
            }
            //field empty? show message
            else
            {
                MessageBox.Show("Please fill in the field before pressing the add button");
            }
        }

        private void btnRemoveRule_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbxAdminRules.SelectedIndex;
            if(selectedIndex != -1)
            {
                ruleList.RemoveAt(selectedIndex);
                foreach(Rule r in ruleList)
                {
                    if(r.RuleCounter > selectedIndex)
                    {
                        r.RuleCounter--;
                    }
                }
                UpdateRuleList();
                Rule.CountSeeder--;
                MessageBox.Show("Rule has been removed");
                return;
            }
            MessageBox.Show("Please select a rule to remove");
        }

        private void btnEditRule_Click(object sender, EventArgs e)
        {
            if(lbxAdminRules.SelectedIndex != -1 && !String.IsNullOrEmpty(tbxRule.Text))
            {
                ruleList[lbxAdminRules.SelectedIndex].RuleText = tbxRule.Text;
                UpdateRuleList();
                return;
            }
            MessageBox.Show("Please select a rule and fill in the field before clicking the button");
        }

        private void lbxAdminRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lbxAdminRules.SelectedIndex;
            if(selectedIndex != -1)
            {
                tbxRule.Text = ruleList[selectedIndex].RuleText;
                btnAddRule.Enabled = false;
            }
            
        }

        private void tbxRule_TextChanged(object sender, EventArgs e)
        {
            btnAddRule.Enabled = true;
        }
    }
}
