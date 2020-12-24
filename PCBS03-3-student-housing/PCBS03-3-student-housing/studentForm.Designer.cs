
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
            this.tabControl1.Controls.Add(this.tpStudentRules);
            this.tabControl1.Location = new System.Drawing.Point(21, 230);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1349, 635);
            this.tabControl1.TabIndex = 0;
            // 
            // tpStudentNews
            // 
            this.tpStudentNews.Controls.Add(this.lbxStudentNews);
            this.tpStudentNews.Location = new System.Drawing.Point(10, 47);
            this.tpStudentNews.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpStudentNews.Name = "tpStudentNews";
            this.tpStudentNews.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpStudentNews.Size = new System.Drawing.Size(1329, 578);
            this.tpStudentNews.TabIndex = 0;
            this.tpStudentNews.Text = "Newsletter";
            this.tpStudentNews.UseVisualStyleBackColor = true;
            // 
            // lbxStudentNews
            // 
            this.lbxStudentNews.FormattingEnabled = true;
            this.lbxStudentNews.ItemHeight = 29;
            this.lbxStudentNews.Location = new System.Drawing.Point(14, 9);
            this.lbxStudentNews.Margin = new System.Windows.Forms.Padding(7);
            this.lbxStudentNews.Name = "lbxStudentNews";
            this.lbxStudentNews.Size = new System.Drawing.Size(1299, 555);
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
            this.tpStudentComplaint.Location = new System.Drawing.Point(10, 47);
            this.tpStudentComplaint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpStudentComplaint.Name = "tpStudentComplaint";
            this.tpStudentComplaint.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpStudentComplaint.Size = new System.Drawing.Size(1329, 578);
            this.tpStudentComplaint.TabIndex = 1;
            this.tpStudentComplaint.Text = "Complaints";
            this.tpStudentComplaint.Paint += new System.Windows.Forms.PaintEventHandler(this.tpStudentComplaint_Paint);
            // 
            // btnStudentRemoveComplaint
            // 
            this.btnStudentRemoveComplaint.Location = new System.Drawing.Point(505, 166);
            this.btnStudentRemoveComplaint.Name = "btnStudentRemoveComplaint";
            this.btnStudentRemoveComplaint.Size = new System.Drawing.Size(481, 54);
            this.btnStudentRemoveComplaint.TabIndex = 5;
            this.btnStudentRemoveComplaint.Text = "Remove your complaint";
            this.btnStudentRemoveComplaint.UseVisualStyleBackColor = true;
            this.btnStudentRemoveComplaint.Click += new System.EventHandler(this.btnStudentRemoveComplaint_Click);
            // 
            // lbxStudentComplaint
            // 
            this.lbxStudentComplaint.FormattingEnabled = true;
            this.lbxStudentComplaint.ItemHeight = 29;
            this.lbxStudentComplaint.Location = new System.Drawing.Point(16, 295);
            this.lbxStudentComplaint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbxStudentComplaint.Name = "lbxStudentComplaint";
            this.lbxStudentComplaint.Size = new System.Drawing.Size(976, 265);
            this.lbxStudentComplaint.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your complaints still under revision";
            // 
            // btnSubmitComplaint
            // 
            this.btnSubmitComplaint.Location = new System.Drawing.Point(16, 166);
            this.btnSubmitComplaint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSubmitComplaint.Name = "btnSubmitComplaint";
            this.btnSubmitComplaint.Size = new System.Drawing.Size(481, 54);
            this.btnSubmitComplaint.TabIndex = 2;
            this.btnSubmitComplaint.Text = "Submit your complaint for revision";
            this.btnSubmitComplaint.UseVisualStyleBackColor = true;
            this.btnSubmitComplaint.Click += new System.EventHandler(this.btnSubmitComplaint_Click_1);
            // 
            // tbxStudentComplaint
            // 
            this.tbxStudentComplaint.Location = new System.Drawing.Point(16, 42);
            this.tbxStudentComplaint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxStudentComplaint.Multiline = true;
            this.tbxStudentComplaint.Name = "tbxStudentComplaint";
            this.tbxStudentComplaint.Size = new System.Drawing.Size(970, 107);
            this.tbxStudentComplaint.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write your complaint below:";
            // 
            // tpStudentRules
            // 
            this.tpStudentRules.Location = new System.Drawing.Point(10, 47);
            this.tpStudentRules.Name = "tpStudentRules";
            this.tpStudentRules.Padding = new System.Windows.Forms.Padding(3);
            this.tpStudentRules.Size = new System.Drawing.Size(1329, 578);
            this.tpStudentRules.TabIndex = 2;
            this.tpStudentRules.Text = "Rules";
            this.tpStudentRules.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            this.button_logout.Font = new System.Drawing.Font("Arial", 8.25F);
            this.button_logout.Location = new System.Drawing.Point(1204, 82);
            this.button_logout.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(181, 53);
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
            this.pnlBackground.Size = new System.Drawing.Size(1403, 898);
            this.pnlBackground.TabIndex = 8;
            this.pnlBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBackground_Paint);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(26, 100);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(928, 112);
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
            this.pnlBar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(1421, 74);
            this.pnlBar.TabIndex = 8;
            // 
            // lblClose
            // 
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1330, 4);
            this.lblClose.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(70, 60);
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
            this.pnlDragBar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlDragBar.Name = "pnlDragBar";
            this.pnlDragBar.Size = new System.Drawing.Size(1325, 71);
            this.pnlDragBar.TabIndex = 9;
            this.pnlDragBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseDown);
            this.pnlDragBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseMove);
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(76)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(1400, 897);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(1400, 897);
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
        private System.Windows.Forms.Button btnStudentRemoveComplaint;
        private System.Windows.Forms.TabPage tpStudentRules;
        private System.Windows.Forms.Label lblHeader;
    }
}