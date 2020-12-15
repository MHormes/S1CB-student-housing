
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
            this.lbxStudentComplaint = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmitComplaint = new System.Windows.Forms.Button();
            this.tbxStudentComplaint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.pnlDragBar = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tpStudentNews.SuspendLayout();
            this.tpStudentComplaint.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.pnlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpStudentNews);
            this.tabControl1.Controls.Add(this.tpStudentComplaint);
            this.tabControl1.Location = new System.Drawing.Point(9, 58);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 330);
            this.tabControl1.TabIndex = 0;
            // 
            // tpStudentNews
            // 
            this.tpStudentNews.Controls.Add(this.lbxStudentNews);
            this.tpStudentNews.Location = new System.Drawing.Point(4, 22);
            this.tpStudentNews.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpStudentNews.Name = "tpStudentNews";
            this.tpStudentNews.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpStudentNews.Size = new System.Drawing.Size(570, 304);
            this.tpStudentNews.TabIndex = 0;
            this.tpStudentNews.Text = "Newsletter";
            this.tpStudentNews.UseVisualStyleBackColor = true;
            // 
            // lbxStudentNews
            // 
            this.lbxStudentNews.FormattingEnabled = true;
            this.lbxStudentNews.Location = new System.Drawing.Point(6, 4);
            this.lbxStudentNews.Name = "lbxStudentNews";
            this.lbxStudentNews.Size = new System.Drawing.Size(559, 290);
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
            this.tpStudentComplaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpStudentComplaint.Name = "tpStudentComplaint";
            this.tpStudentComplaint.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpStudentComplaint.Size = new System.Drawing.Size(570, 304);
            this.tpStudentComplaint.TabIndex = 1;
            this.tpStudentComplaint.Text = "Complaints";
            this.tpStudentComplaint.UseVisualStyleBackColor = true;
            // 
            // lbxStudentComplaint
            // 
            this.lbxStudentComplaint.FormattingEnabled = true;
            this.lbxStudentComplaint.Location = new System.Drawing.Point(7, 126);
            this.lbxStudentComplaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxStudentComplaint.Name = "lbxStudentComplaint";
            this.lbxStudentComplaint.Size = new System.Drawing.Size(418, 121);
            this.lbxStudentComplaint.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your complaints still under revision";
            // 
            // btnSubmitComplaint
            // 
            this.btnSubmitComplaint.Location = new System.Drawing.Point(218, 73);
            this.btnSubmitComplaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmitComplaint.Name = "btnSubmitComplaint";
            this.btnSubmitComplaint.Size = new System.Drawing.Size(206, 24);
            this.btnSubmitComplaint.TabIndex = 2;
            this.btnSubmitComplaint.Text = "Submit your complaint for revision";
            this.btnSubmitComplaint.UseVisualStyleBackColor = true;
            this.btnSubmitComplaint.Click += new System.EventHandler(this.btnSubmitComplaint_Click_1);
            // 
            // tbxStudentComplaint
            // 
            this.tbxStudentComplaint.Location = new System.Drawing.Point(7, 19);
            this.tbxStudentComplaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxStudentComplaint.Multiline = true;
            this.tbxStudentComplaint.Name = "tbxStudentComplaint";
            this.tbxStudentComplaint.Size = new System.Drawing.Size(418, 50);
            this.tbxStudentComplaint.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write your complaint below:";
            // 
            // button_logout
            // 
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_logout.Location = new System.Drawing.Point(491, 45);
            this.button_logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(92, 24);
            this.button_logout.TabIndex = 1;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackground.Controls.Add(this.button_logout);
            this.pnlBackground.Controls.Add(this.pnlBar);
            this.pnlBackground.Controls.Add(this.tabControl1);
            this.pnlBackground.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(602, 397);
            this.pnlBackground.TabIndex = 8;
            this.pnlBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBackground_Paint);
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlBar.Controls.Add(this.lblClose);
            this.pnlBar.Controls.Add(this.pnlDragBar);
            this.pnlBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(609, 33);
            this.pnlBar.TabIndex = 8;
            // 
            // lblClose
            // 
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(570, 2);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(30, 27);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "✖";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pnlDragBar
            // 
            this.pnlDragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlDragBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDragBar.Location = new System.Drawing.Point(0, 0);
            this.pnlDragBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDragBar.Name = "pnlDragBar";
            this.pnlDragBar.Size = new System.Drawing.Size(568, 32);
            this.pnlDragBar.TabIndex = 9;
            this.pnlDragBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseDown);
            this.pnlDragBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseMove);
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(76)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(600, 402);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(600, 402);
            this.Name = "studentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentForm";
            this.tabControl1.ResumeLayout(false);
            this.tpStudentNews.ResumeLayout(false);
            this.tpStudentComplaint.ResumeLayout(false);
            this.tpStudentComplaint.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            this.pnlBar.ResumeLayout(false);
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
    }
}