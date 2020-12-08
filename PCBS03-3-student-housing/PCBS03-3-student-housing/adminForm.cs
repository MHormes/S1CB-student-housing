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
        List<News> newsList = new List<News>();
        public adminForm()
        {
            InitializeComponent();
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
                //THIS NEEDS AN EDIT. LISTBOX DOES NOT SUPPORT NEW LINES. THIS IS NEEDED!!!!!!!!!!!!!!!!!!
                lbxAdminNews.Items.Add(news.GetNews());
            }
        }
    }
}
