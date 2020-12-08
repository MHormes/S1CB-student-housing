
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbxStudentNews = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tpStudentNews.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpStudentNews);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 344);
            this.tabControl1.TabIndex = 0;
            // 
            // tpStudentNews
            // 
            this.tpStudentNews.Controls.Add(this.lbxStudentNews);
            this.tpStudentNews.Location = new System.Drawing.Point(4, 22);
            this.tpStudentNews.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpStudentNews.Name = "tpStudentNews";
            this.tpStudentNews.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpStudentNews.Size = new System.Drawing.Size(570, 318);
            this.tpStudentNews.TabIndex = 0;
            this.tpStudentNews.Text = "Newsletter";
            this.tpStudentNews.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(570, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbxStudentNews
            // 
            this.lbxStudentNews.FormattingEnabled = true;
            this.lbxStudentNews.Location = new System.Drawing.Point(6, 4);
            this.lbxStudentNews.Name = "lbxStudentNews";
            this.lbxStudentNews.Size = new System.Drawing.Size(559, 303);
            this.lbxStudentNews.TabIndex = 0;
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}