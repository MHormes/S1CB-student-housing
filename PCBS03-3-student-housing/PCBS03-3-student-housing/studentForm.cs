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
        List<News> newsStudentList = adminForm.newsList;
        public studentForm()
        {
            InitializeComponent();
        }

        // Method for updating the news listbox when the form gets loaded. 
        private void studentForm_Load(object sender, EventArgs e)
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
    }
}
