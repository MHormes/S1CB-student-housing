
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
            this.btnStudentRemoveComplaint = new System.Windows.Forms.Button();
            this.lbxStudentComplaint = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmitComplaint = new System.Windows.Forms.Button();
            this.tbxStudentComplaint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpStudentRules = new System.Windows.Forms.TabPage();
            this.button_logout = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.pnlDragBar = new System.Windows.Forms.Panel();
            this.tpStudentAnnouncements = new System.Windows.Forms.TabPage();
            this.tbxAuthorNameAnnouncements = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNews = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMessageAnnouncements = new System.Windows.Forms.TextBox();
            this.lbxStudentAnnouncements = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tpStudentNews.SuspendLayout();
            this.tpStudentComplaint.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.pnlBar.SuspendLayout();
            this.tpStudentAnnouncements.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpStudentNews);
            this.tabControl1.Controls.Add(this.tpStudentComplaint);
            this.tabControl1.Controls.Add(this.tpStudentRules);
            this.tabControl1.Controls.Add(this.tpStudentAnnouncements);
            this.tabControl1.Location = new System.Drawing.Point(12, 127);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // tpStudentNews
            // 
            this.tpStudentNews.Controls.Add(this.lbxStudentNews);
            this.tpStudentNews.Location = new System.Drawing.Point(4, 25);
            this.tpStudentNews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStudentNews.Name = "tpStudentNews";
            this.tpStudentNews.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStudentNews.Size = new System.Drawing.Size(763, 321);
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
            this.lbxStudentNews.Size = new System.Drawing.Size(744, 308);
            this.lbxStudentNews.TabIndex = 0;
            // 
            // tpStudentComplaint
            // 
            this.tpStudentComplaint.BackColor = System.Drawing.Color.Transparent;
            this.tpStudentComplaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tpStudentComplaint.Controls.Add(this.btnStudentRemoveComplaint);
            this.tpStudentComplaint.Controls.Add(this.lbxStudentComplaint);
            this.tpStudentComplaint.Controls.Add(this.label2);
            this.tpStudentComplaint.Controls.Add(this.btnSubmitComplaint);
            this.tpStudentComplaint.Controls.Add(this.tbxStudentComplaint);
            this.tpStudentComplaint.Controls.Add(this.label1);
            this.tpStudentComplaint.Location = new System.Drawing.Point(4, 25);
            this.tpStudentComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStudentComplaint.Name = "tpStudentComplaint";
            this.tpStudentComplaint.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStudentComplaint.Size = new System.Drawing.Size(763, 321);
            this.tpStudentComplaint.TabIndex = 1;
            this.tpStudentComplaint.Text = "Complaints";
            this.tpStudentComplaint.Paint += new System.Windows.Forms.PaintEventHandler(this.tpStudentComplaint_Paint);
            // 
            // btnStudentRemoveComplaint
            // 
            this.btnStudentRemoveComplaint.Location = new System.Drawing.Point(289, 92);
            this.btnStudentRemoveComplaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudentRemoveComplaint.Name = "btnStudentRemoveComplaint";
            this.btnStudentRemoveComplaint.Size = new System.Drawing.Size(275, 30);
            this.btnStudentRemoveComplaint.TabIndex = 5;
            this.btnStudentRemoveComplaint.Text = "Remove your complaint";
            this.btnStudentRemoveComplaint.UseVisualStyleBackColor = true;
            this.btnStudentRemoveComplaint.Click += new System.EventHandler(this.btnStudentRemoveComplaint_Click);
            // 
            // lbxStudentComplaint
            // 
            this.lbxStudentComplaint.FormattingEnabled = true;
            this.lbxStudentComplaint.ItemHeight = 16;
            this.lbxStudentComplaint.Location = new System.Drawing.Point(9, 163);
            this.lbxStudentComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxStudentComplaint.Name = "lbxStudentComplaint";
            this.lbxStudentComplaint.Size = new System.Drawing.Size(559, 148);
            this.lbxStudentComplaint.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your complaints still under revision";
            // 
            // btnSubmitComplaint
            // 
            this.btnSubmitComplaint.Location = new System.Drawing.Point(9, 92);
            this.btnSubmitComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitComplaint.Name = "btnSubmitComplaint";
            this.btnSubmitComplaint.Size = new System.Drawing.Size(275, 30);
            this.btnSubmitComplaint.TabIndex = 2;
            this.btnSubmitComplaint.Text = "Submit your complaint for revision";
            this.btnSubmitComplaint.UseVisualStyleBackColor = true;
            this.btnSubmitComplaint.Click += new System.EventHandler(this.btnSubmitComplaint_Click_1);
            // 
            // tbxStudentComplaint
            // 
            this.tbxStudentComplaint.Location = new System.Drawing.Point(9, 23);
            this.tbxStudentComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStudentComplaint.Multiline = true;
            this.tbxStudentComplaint.Name = "tbxStudentComplaint";
            this.tbxStudentComplaint.Size = new System.Drawing.Size(556, 61);
            this.tbxStudentComplaint.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write your complaint below:";
            // 
            // tpStudentRules
            // 
            this.tpStudentRules.Location = new System.Drawing.Point(4, 25);
            this.tpStudentRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpStudentRules.Name = "tpStudentRules";
            this.tpStudentRules.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpStudentRules.Size = new System.Drawing.Size(763, 321);
            this.tpStudentRules.TabIndex = 2;
            this.tpStudentRules.Text = "Rules";
            this.tpStudentRules.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            this.button_logout.Font = new System.Drawing.Font("Arial", 8.25F);
            this.button_logout.Location = new System.Drawing.Point(688, 45);
            this.button_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(103, 29);
            this.button_logout.TabIndex = 1;
            this.button_logout.TabStop = false;
            this.button_logout.Text = "Logout ➔";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackground.Controls.Add(this.button_logout);
            this.pnlBackground.Controls.Add(this.lblHeader);
            this.pnlBackground.Controls.Add(this.pnlBar);
            this.pnlBackground.Controls.Add(this.tabControl1);
            this.pnlBackground.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(803, 496);
            this.pnlBackground.TabIndex = 8;
            this.pnlBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBackground_Paint);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(15, 55);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(530, 62);
            this.lblHeader.TabIndex = 10;
            this.lblHeader.Text = "Welcome, student";
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlBar.Controls.Add(this.lblClose);
            this.pnlBar.Controls.Add(this.pnlDragBar);
            this.pnlBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(812, 41);
            this.pnlBar.TabIndex = 8;
            // 
            // lblClose
            // 
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(760, 2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(40, 33);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "✖";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // pnlDragBar
            // 
            this.pnlDragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlDragBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDragBar.Location = new System.Drawing.Point(0, 0);
            this.pnlDragBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDragBar.Name = "pnlDragBar";
            this.pnlDragBar.Size = new System.Drawing.Size(757, 39);
            this.pnlDragBar.TabIndex = 9;
            this.pnlDragBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseDown);
            this.pnlDragBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseMove);
            // 
            // tpStudentAnnouncements
            // 
            this.tpStudentAnnouncements.Controls.Add(this.tbxAuthorNameAnnouncements);
            this.tpStudentAnnouncements.Controls.Add(this.label3);
            this.tpStudentAnnouncements.Controls.Add(this.btnAddNews);
            this.tpStudentAnnouncements.Controls.Add(this.label4);
            this.tpStudentAnnouncements.Controls.Add(this.tbxMessageAnnouncements);
            this.tpStudentAnnouncements.Controls.Add(this.lbxStudentAnnouncements);
            this.tpStudentAnnouncements.Location = new System.Drawing.Point(4, 25);
            this.tpStudentAnnouncements.Name = "tpStudentAnnouncements";
            this.tpStudentAnnouncements.Padding = new System.Windows.Forms.Padding(3);
            this.tpStudentAnnouncements.Size = new System.Drawing.Size(763, 321);
            this.tpStudentAnnouncements.TabIndex = 3;
            this.tpStudentAnnouncements.Text = "Announcements";
            this.tpStudentAnnouncements.UseVisualStyleBackColor = true;
            // 
            // tbxAuthorNameAnnouncements
            // 
            this.tbxAuthorNameAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAuthorNameAnnouncements.Location = new System.Drawing.Point(442, 218);
            this.tbxAuthorNameAnnouncements.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAuthorNameAnnouncements.Name = "tbxAuthorNameAnnouncements";
            this.tbxAuthorNameAnnouncements.Size = new System.Drawing.Size(311, 34);
            this.tbxAuthorNameAnnouncements.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Message written by";
            // 
            // btnAddNews
            // 
            this.btnAddNews.Location = new System.Drawing.Point(442, 277);
            this.btnAddNews.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNews.Name = "btnAddNews";
            this.btnAddNews.Size = new System.Drawing.Size(309, 28);
            this.btnAddNews.TabIndex = 9;
            this.btnAddNews.Text = "Add your announcement";
            this.btnAddNews.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Write your announcement below";
            // 
            // tbxMessageAnnouncements
            // 
            this.tbxMessageAnnouncements.AcceptsReturn = true;
            this.tbxMessageAnnouncements.Location = new System.Drawing.Point(441, 26);
            this.tbxMessageAnnouncements.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMessageAnnouncements.Multiline = true;
            this.tbxMessageAnnouncements.Name = "tbxMessageAnnouncements";
            this.tbxMessageAnnouncements.Size = new System.Drawing.Size(312, 162);
            this.tbxMessageAnnouncements.TabIndex = 6;
            // 
            // lbxStudentAnnouncements
            // 
            this.lbxStudentAnnouncements.FormattingEnabled = true;
            this.lbxStudentAnnouncements.ItemHeight = 16;
            this.lbxStudentAnnouncements.Location = new System.Drawing.Point(9, 6);
            this.lbxStudentAnnouncements.Margin = new System.Windows.Forms.Padding(4);
            this.lbxStudentAnnouncements.Name = "lbxStudentAnnouncements";
            this.lbxStudentAnnouncements.Size = new System.Drawing.Size(424, 308);
            this.lbxStudentAnnouncements.TabIndex = 5;
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(76)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(800, 495);
            this.Name = "studentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentForm";
            this.tabControl1.ResumeLayout(false);
            this.tpStudentNews.ResumeLayout(false);
            this.tpStudentComplaint.ResumeLayout(false);
            this.tpStudentComplaint.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            this.pnlBar.ResumeLayout(false);
            this.tpStudentAnnouncements.ResumeLayout(false);
            this.tpStudentAnnouncements.PerformLayout();
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
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Panel pnlDragBar;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnStudentRemoveComplaint;
        private System.Windows.Forms.TabPage tpStudentRules;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TabPage tpStudentAnnouncements;
        private System.Windows.Forms.TextBox tbxAuthorNameAnnouncements;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNews;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMessageAnnouncements;
        private System.Windows.Forms.ListBox lbxStudentAnnouncements;
    }
}