
namespace PCBS03_3_student_housing
{
    partial class adminForm
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
            this.tpAdminNews = new System.Windows.Forms.TabPage();
            this.tbxAuthorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNews = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.lbxAdminNews = new System.Windows.Forms.ListBox();
            this.tpAdminAddTenant = new System.Windows.Forms.TabPage();
            this.button_removeTenant = new System.Windows.Forms.Button();
            this.button_addTenant = new System.Windows.Forms.Button();
            this.textBox_tenantPassword = new System.Windows.Forms.TextBox();
            this.textBox_tenantName = new System.Windows.Forms.TextBox();
            this.label_tenantPassword = new System.Windows.Forms.Label();
            this.label_tenantName = new System.Windows.Forms.Label();
            this.listBox_tenants = new System.Windows.Forms.ListBox();
            this.tpAdminComplaints = new System.Windows.Forms.TabPage();
            this.btnAddComplaintComment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxComplaintComment = new System.Windows.Forms.TextBox();
            this.btnCheckComplaint = new System.Windows.Forms.Button();
            this.btnRefreshComplaints = new System.Windows.Forms.Button();
            this.lbxAdminComplaint = new System.Windows.Forms.ListBox();
            this.button_logout = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.textBox_defocus = new System.Windows.Forms.TextBox();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pnlDragBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpAdminNews.SuspendLayout();
            this.tpAdminAddTenant.SuspendLayout();
            this.tpAdminComplaints.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.pnlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAdminNews);
            this.tabControl1.Controls.Add(this.tpAdminAddTenant);
            this.tabControl1.Controls.Add(this.tpAdminComplaints);
            this.tabControl1.Location = new System.Drawing.Point(25, 189);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1349, 637);
            this.tabControl1.TabIndex = 1;
            // 
            // tpAdminNews
            // 
            this.tpAdminNews.Controls.Add(this.tbxAuthorName);
            this.tpAdminNews.Controls.Add(this.label2);
            this.tpAdminNews.Controls.Add(this.btnAddNews);
            this.tpAdminNews.Controls.Add(this.label1);
            this.tpAdminNews.Controls.Add(this.tbxMessage);
            this.tpAdminNews.Controls.Add(this.lbxAdminNews);
            this.tpAdminNews.Location = new System.Drawing.Point(10, 47);
            this.tpAdminNews.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpAdminNews.Name = "tpAdminNews";
            this.tpAdminNews.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpAdminNews.Size = new System.Drawing.Size(1329, 580);
            this.tpAdminNews.TabIndex = 0;
            this.tpAdminNews.Text = "Newsletter";
            this.tpAdminNews.UseVisualStyleBackColor = true;
            // 
            // tbxAuthorName
            // 
            this.tbxAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAuthorName.Location = new System.Drawing.Point(772, 397);
            this.tbxAuthorName.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tbxAuthorName.Name = "tbxAuthorName";
            this.tbxAuthorName.Size = new System.Drawing.Size(541, 55);
            this.tbxAuthorName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(777, 359);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message written by";
            // 
            // btnAddNews
            // 
            this.btnAddNews.Location = new System.Drawing.Point(772, 504);
            this.btnAddNews.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnAddNews.Name = "btnAddNews";
            this.btnAddNews.Size = new System.Drawing.Size(541, 51);
            this.btnAddNews.TabIndex = 3;
            this.btnAddNews.Text = "Add your message to the news board";
            this.btnAddNews.UseVisualStyleBackColor = true;
            this.btnAddNews.Click += new System.EventHandler(this.btnAddNews_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(770, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Write your message below";
            // 
            // tbxMessage
            // 
            this.tbxMessage.AcceptsReturn = true;
            this.tbxMessage.Location = new System.Drawing.Point(770, 49);
            this.tbxMessage.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(543, 290);
            this.tbxMessage.TabIndex = 1;
            // 
            // lbxAdminNews
            // 
            this.lbxAdminNews.FormattingEnabled = true;
            this.lbxAdminNews.ItemHeight = 29;
            this.lbxAdminNews.Location = new System.Drawing.Point(14, 13);
            this.lbxAdminNews.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.lbxAdminNews.Name = "lbxAdminNews";
            this.lbxAdminNews.Size = new System.Drawing.Size(739, 555);
            this.lbxAdminNews.TabIndex = 0;
            // 
            // tpAdminAddTenant
            // 
            this.tpAdminAddTenant.Controls.Add(this.button_removeTenant);
            this.tpAdminAddTenant.Controls.Add(this.button_addTenant);
            this.tpAdminAddTenant.Controls.Add(this.textBox_tenantPassword);
            this.tpAdminAddTenant.Controls.Add(this.textBox_tenantName);
            this.tpAdminAddTenant.Controls.Add(this.label_tenantPassword);
            this.tpAdminAddTenant.Controls.Add(this.label_tenantName);
            this.tpAdminAddTenant.Controls.Add(this.listBox_tenants);
            this.tpAdminAddTenant.Location = new System.Drawing.Point(10, 47);
            this.tpAdminAddTenant.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpAdminAddTenant.Name = "tpAdminAddTenant";
            this.tpAdminAddTenant.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpAdminAddTenant.Size = new System.Drawing.Size(1329, 580);
            this.tpAdminAddTenant.TabIndex = 1;
            this.tpAdminAddTenant.Text = "Add tenant";
            this.tpAdminAddTenant.UseVisualStyleBackColor = true;
            // 
            // button_removeTenant
            // 
            this.button_removeTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_removeTenant.Location = new System.Drawing.Point(929, 408);
            this.button_removeTenant.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.button_removeTenant.Name = "button_removeTenant";
            this.button_removeTenant.Size = new System.Drawing.Size(240, 51);
            this.button_removeTenant.TabIndex = 7;
            this.button_removeTenant.Text = "Remove tenant";
            this.button_removeTenant.UseVisualStyleBackColor = true;
            this.button_removeTenant.Click += new System.EventHandler(this.button_removeTenant_Click);
            // 
            // button_addTenant
            // 
            this.button_addTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_addTenant.Location = new System.Drawing.Point(929, 344);
            this.button_addTenant.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.button_addTenant.Name = "button_addTenant";
            this.button_addTenant.Size = new System.Drawing.Size(240, 51);
            this.button_addTenant.TabIndex = 6;
            this.button_addTenant.Text = "Add tenant";
            this.button_addTenant.UseVisualStyleBackColor = true;
            this.button_addTenant.Click += new System.EventHandler(this.button_addTenant_Click);
            // 
            // textBox_tenantPassword
            // 
            this.textBox_tenantPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_tenantPassword.Location = new System.Drawing.Point(1031, 254);
            this.textBox_tenantPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox_tenantPassword.Name = "textBox_tenantPassword";
            this.textBox_tenantPassword.Size = new System.Drawing.Size(191, 41);
            this.textBox_tenantPassword.TabIndex = 5;
            // 
            // textBox_tenantName
            // 
            this.textBox_tenantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_tenantName.Location = new System.Drawing.Point(1031, 185);
            this.textBox_tenantName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox_tenantName.Name = "textBox_tenantName";
            this.textBox_tenantName.Size = new System.Drawing.Size(191, 41);
            this.textBox_tenantName.TabIndex = 4;
            // 
            // label_tenantPassword
            // 
            this.label_tenantPassword.AutoSize = true;
            this.label_tenantPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_tenantPassword.Location = new System.Drawing.Point(863, 259);
            this.label_tenantPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_tenantPassword.Name = "label_tenantPassword";
            this.label_tenantPassword.Size = new System.Drawing.Size(155, 36);
            this.label_tenantPassword.TabIndex = 3;
            this.label_tenantPassword.Text = "Password:";
            // 
            // label_tenantName
            // 
            this.label_tenantName.AutoSize = true;
            this.label_tenantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_tenantName.Location = new System.Drawing.Point(863, 190);
            this.label_tenantName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_tenantName.Name = "label_tenantName";
            this.label_tenantName.Size = new System.Drawing.Size(100, 36);
            this.label_tenantName.TabIndex = 2;
            this.label_tenantName.Text = "Name:";
            // 
            // listBox_tenants
            // 
            this.listBox_tenants.FormattingEnabled = true;
            this.listBox_tenants.ItemHeight = 29;
            this.listBox_tenants.Location = new System.Drawing.Point(12, 11);
            this.listBox_tenants.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.listBox_tenants.Name = "listBox_tenants";
            this.listBox_tenants.Size = new System.Drawing.Size(739, 555);
            this.listBox_tenants.TabIndex = 1;
            // 
            // tpAdminComplaints
            // 
            this.tpAdminComplaints.Controls.Add(this.btnAddComplaintComment);
            this.tpAdminComplaints.Controls.Add(this.label3);
            this.tpAdminComplaints.Controls.Add(this.tbxComplaintComment);
            this.tpAdminComplaints.Controls.Add(this.btnCheckComplaint);
            this.tpAdminComplaints.Controls.Add(this.btnRefreshComplaints);
            this.tpAdminComplaints.Controls.Add(this.lbxAdminComplaint);
            this.tpAdminComplaints.Location = new System.Drawing.Point(10, 47);
            this.tpAdminComplaints.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tpAdminComplaints.Name = "tpAdminComplaints";
            this.tpAdminComplaints.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tpAdminComplaints.Size = new System.Drawing.Size(1329, 580);
            this.tpAdminComplaints.TabIndex = 2;
            this.tpAdminComplaints.Text = "Complaints";
            this.tpAdminComplaints.UseVisualStyleBackColor = true;
            // 
            // btnAddComplaintComment
            // 
            this.btnAddComplaintComment.Location = new System.Drawing.Point(390, 486);
            this.btnAddComplaintComment.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnAddComplaintComment.Name = "btnAddComplaintComment";
            this.btnAddComplaintComment.Size = new System.Drawing.Size(338, 51);
            this.btnAddComplaintComment.TabIndex = 5;
            this.btnAddComplaintComment.Text = "Add comment to complaint";
            this.btnAddComplaintComment.UseVisualStyleBackColor = true;
            this.btnAddComplaintComment.Click += new System.EventHandler(this.btnAddComplaintComment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 352);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add a comment to the selected complaint";
            // 
            // tbxComplaintComment
            // 
            this.tbxComplaintComment.Location = new System.Drawing.Point(23, 388);
            this.tbxComplaintComment.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tbxComplaintComment.Multiline = true;
            this.tbxComplaintComment.Name = "tbxComplaintComment";
            this.tbxComplaintComment.Size = new System.Drawing.Size(702, 78);
            this.tbxComplaintComment.TabIndex = 3;
            // 
            // btnCheckComplaint
            // 
            this.btnCheckComplaint.Location = new System.Drawing.Point(1066, 611);
            this.btnCheckComplaint.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnCheckComplaint.Name = "btnCheckComplaint";
            this.btnCheckComplaint.Size = new System.Drawing.Size(252, 51);
            this.btnCheckComplaint.TabIndex = 2;
            this.btnCheckComplaint.Text = "Check as done";
            this.btnCheckComplaint.UseVisualStyleBackColor = true;
            this.btnCheckComplaint.Click += new System.EventHandler(this.btnCheckComplaint_Click);
            // 
            // btnRefreshComplaints
            // 
            this.btnRefreshComplaints.Font = new System.Drawing.Font("Arial", 25F);
            this.btnRefreshComplaints.Location = new System.Drawing.Point(1176, 346);
            this.btnRefreshComplaints.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnRefreshComplaints.Name = "btnRefreshComplaints";
            this.btnRefreshComplaints.Size = new System.Drawing.Size(134, 100);
            this.btnRefreshComplaints.TabIndex = 0;
            this.btnRefreshComplaints.TabStop = false;
            this.btnRefreshComplaints.Text = "⟳";
            this.btnRefreshComplaints.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefreshComplaints.UseVisualStyleBackColor = true;
            this.btnRefreshComplaints.Click += new System.EventHandler(this.btnRefreshComplaints_Click);
            // 
            // lbxAdminComplaint
            // 
            this.lbxAdminComplaint.FormattingEnabled = true;
            this.lbxAdminComplaint.ItemHeight = 29;
            this.lbxAdminComplaint.Location = new System.Drawing.Point(9, 9);
            this.lbxAdminComplaint.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.lbxAdminComplaint.Name = "lbxAdminComplaint";
            this.lbxAdminComplaint.Size = new System.Drawing.Size(1301, 323);
            this.lbxAdminComplaint.TabIndex = 0;
            // 
            // button_logout
            // 
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_logout.Location = new System.Drawing.Point(1133, 127);
            this.button_logout.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(215, 54);
            this.button_logout.TabIndex = 2;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(76)))), ((int)(((byte)(207)))));
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackground.Controls.Add(this.lblHeader);
            this.pnlBackground.Controls.Add(this.button_logout);
            this.pnlBackground.Controls.Add(this.textBox_defocus);
            this.pnlBackground.Controls.Add(this.tabControl1);
            this.pnlBackground.Controls.Add(this.pnlBar);
            this.pnlBackground.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBackground.Location = new System.Drawing.Point(0, 1);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1403, 856);
            this.pnlBackground.TabIndex = 8;
            this.pnlBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBackground_Paint);
            // 
            // textBox_defocus
            // 
            this.textBox_defocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox_defocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_defocus.Location = new System.Drawing.Point(0, 0);
            this.textBox_defocus.Name = "textBox_defocus";
            this.textBox_defocus.Size = new System.Drawing.Size(0, 11);
            this.textBox_defocus.TabIndex = 0;
            this.textBox_defocus.TabStop = false;
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlBar.Controls.Add(this.lblClose);
            this.pnlBar.Controls.Add(this.pnlDragBar);
            this.pnlBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBar.Location = new System.Drawing.Point(-2, -2);
            this.pnlBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(1399, 71);
            this.pnlBar.TabIndex = 8;
            // 
            // pnlDragBar
            // 
            this.pnlDragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlDragBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDragBar.Location = new System.Drawing.Point(-2, -2);
            this.pnlDragBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDragBar.Name = "pnlDragBar";
            this.pnlDragBar.Size = new System.Drawing.Size(1330, 69);
            this.pnlDragBar.TabIndex = 9;
            this.pnlDragBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseDown);
            this.pnlDragBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseMove);
            // 
            // lblClose
            // 
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1336, 2);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(63, 63);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "✖";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(91, 73);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(392, 112);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "Admin";
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1400, 853);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.tabControl1.ResumeLayout(false);
            this.tpAdminNews.ResumeLayout(false);
            this.tpAdminNews.PerformLayout();
            this.tpAdminAddTenant.ResumeLayout(false);
            this.tpAdminAddTenant.PerformLayout();
            this.tpAdminComplaints.ResumeLayout(false);
            this.tpAdminComplaints.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.pnlBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAdminNews;
        private System.Windows.Forms.TabPage tpAdminAddTenant;
        private System.Windows.Forms.TextBox tbxAuthorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNews;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.TabPage tpAdminComplaints;
        private System.Windows.Forms.ListBox lbxAdminNews;
        private System.Windows.Forms.ListBox listBox_tenants;
        private System.Windows.Forms.TextBox textBox_tenantPassword;
        private System.Windows.Forms.TextBox textBox_tenantName;
        private System.Windows.Forms.Label label_tenantPassword;
        private System.Windows.Forms.Label label_tenantName;
        private System.Windows.Forms.Button button_removeTenant;
        private System.Windows.Forms.Button button_addTenant;
        private System.Windows.Forms.ListBox lbxAdminComplaint;
        private System.Windows.Forms.Button btnRefreshComplaints;
        private System.Windows.Forms.Button btnCheckComplaint;
        private System.Windows.Forms.TextBox tbxComplaintComment;
        private System.Windows.Forms.Button btnAddComplaintComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.TextBox textBox_defocus;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel pnlDragBar;
        private System.Windows.Forms.Label lblHeader;
    }
}