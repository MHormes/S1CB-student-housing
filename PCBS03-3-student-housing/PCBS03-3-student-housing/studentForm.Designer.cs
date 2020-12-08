
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
            this.tpStudentComplaint = new System.Windows.Forms.TabPage();
            this.btnSubmitComplaint = new System.Windows.Forms.Button();
            this.tbxStudentComplaint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxStudentComplaint = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tpStudentNews.SuspendLayout();
            this.tpStudentComplaint.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpStudentNews);
            this.tabControl1.Controls.Add(this.tpStudentComplaint);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 344);
            this.tabControl1.TabIndex = 0;
            // 
            // tpStudentNews
            // 
            this.tpStudentNews.Controls.Add(this.lbxStudentNews);
            this.tpStudentNews.Location = new System.Drawing.Point(4, 22);
            this.tpStudentNews.Margin = new System.Windows.Forms.Padding(2);
            this.tpStudentNews.Name = "tpStudentNews";
            this.tpStudentNews.Padding = new System.Windows.Forms.Padding(2);
            this.tpStudentNews.Size = new System.Drawing.Size(570, 318);
            this.tpStudentNews.TabIndex = 0;
            this.tpStudentNews.Text = "Newsletter";
            this.tpStudentNews.UseVisualStyleBackColor = true;
            // 
            // lbxStudentNews
            // 
            this.lbxStudentNews.FormattingEnabled = true;
            this.lbxStudentNews.Location = new System.Drawing.Point(6, 4);
            this.lbxStudentNews.Name = "lbxStudentNews";
            this.lbxStudentNews.Size = new System.Drawing.Size(559, 303);
            this.lbxStudentNews.TabIndex = 0;
            // 
            // tpStudentComplaint
            // 
            this.tpStudentComplaint.Controls.Add(this.lbxStudentComplaint);
            this.tpStudentComplaint.Controls.Add(this.label2);
            this.tpStudentComplaint.Controls.Add(this.btnSubmitComplaint);
            this.tpStudentComplaint.Controls.Add(this.tbxStudentComplaint);
            this.tpStudentComplaint.Controls.Add(this.label1);
            this.tpStudentComplaint.Location = new System.Drawing.Point(4, 22);
            this.tpStudentComplaint.Margin = new System.Windows.Forms.Padding(2);
            this.tpStudentComplaint.Name = "tpStudentComplaint";
            this.tpStudentComplaint.Padding = new System.Windows.Forms.Padding(2);
            this.tpStudentComplaint.Size = new System.Drawing.Size(570, 318);
            this.tpStudentComplaint.TabIndex = 1;
            this.tpStudentComplaint.Text = "Complaints";
            this.tpStudentComplaint.UseVisualStyleBackColor = true;
            // 
            // btnSubmitComplaint
            // 
            this.btnSubmitComplaint.Location = new System.Drawing.Point(346, 90);
            this.btnSubmitComplaint.Name = "btnSubmitComplaint";
            this.btnSubmitComplaint.Size = new System.Drawing.Size(219, 30);
            this.btnSubmitComplaint.TabIndex = 2;
            this.btnSubmitComplaint.Text = "Submit your complaint for revision";
            this.btnSubmitComplaint.UseVisualStyleBackColor = true;
            this.btnSubmitComplaint.Click += new System.EventHandler(this.btnSubmitComplaint_Click_1);
            // 
            // tbxStudentComplaint
            // 
            this.tbxStudentComplaint.Location = new System.Drawing.Point(9, 23);
            this.tbxStudentComplaint.Multiline = true;
            this.tbxStudentComplaint.Name = "tbxStudentComplaint";
            this.tbxStudentComplaint.Size = new System.Drawing.Size(556, 61);
            this.tbxStudentComplaint.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write your complaint below:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your complaints still under revision";
            // 
            // lbxStudentComplaint
            // 
            this.lbxStudentComplaint.FormattingEnabled = true;
            this.lbxStudentComplaint.Location = new System.Drawing.Point(9, 155);
            this.lbxStudentComplaint.Name = "lbxStudentComplaint";
            this.lbxStudentComplaint.Size = new System.Drawing.Size(556, 160);
            this.lbxStudentComplaint.TabIndex = 4;
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "studentForm";
            this.Text = "studentForm";
            this.tabControl1.ResumeLayout(false);
            this.tpStudentNews.ResumeLayout(false);
            this.tpStudentComplaint.ResumeLayout(false);
            this.tpStudentComplaint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpStudentNews;
        private System.Windows.Forms.TabPage tpStudentComplaint;
        private System.Windows.Forms.ListBox lbxStudentNews;
        private System.Windows.Forms.Button btnSubmitComplaint;
        private System.Windows.Forms.TextBox tbxStudentComplaint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxStudentComplaint;
        private System.Windows.Forms.Label label2;
    }
}