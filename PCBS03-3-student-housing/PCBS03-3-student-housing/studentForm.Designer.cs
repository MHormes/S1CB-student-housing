
namespace PCBS03_3_student_housing
{
    partial class studentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpStudentNews = new System.Windows.Forms.TabPage();
            this.lbxStudentNews = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_logout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpStudentNews.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpStudentNews);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 406);
            this.tabControl1.TabIndex = 0;
            // 
            // tpStudentNews
            // 
            this.tpStudentNews.Controls.Add(this.lbxStudentNews);
            this.tpStudentNews.Location = new System.Drawing.Point(4, 25);
            this.tpStudentNews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStudentNews.Name = "tpStudentNews";
            this.tpStudentNews.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStudentNews.Size = new System.Drawing.Size(763, 377);
            this.tpStudentNews.TabIndex = 0;
            this.tpStudentNews.Text = "Newsletter";
            this.tpStudentNews.UseVisualStyleBackColor = true;
            // 
            // lbxStudentNews
            // 
            this.lbxStudentNews.FormattingEnabled = true;
            this.lbxStudentNews.ItemHeight = 16;
            this.lbxStudentNews.Location = new System.Drawing.Point(8, 5);
            this.lbxStudentNews.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxStudentNews.Name = "lbxStudentNews";
            this.lbxStudentNews.Size = new System.Drawing.Size(744, 372);
            this.lbxStudentNews.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(763, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_logout.Location = new System.Drawing.Point(650, 12);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(122, 30);
            this.button_logout.TabIndex = 1;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "studentForm";
            this.Text = "studentForm";
            this.Load += new System.EventHandler(this.studentForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpStudentNews.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpStudentNews;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbxStudentNews;
        private System.Windows.Forms.Button button_logout;
    }
}