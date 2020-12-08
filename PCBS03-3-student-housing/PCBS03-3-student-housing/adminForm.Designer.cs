
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
            this.button_logout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpAdminNews.SuspendLayout();
            this.tpAdminAddTenant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAdminNews);
            this.tabControl1.Controls.Add(this.tpAdminAddTenant);
            this.tabControl1.Controls.Add(this.tpAdminComplaints);
            this.tabControl1.Location = new System.Drawing.Point(15, 32);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 405);
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
            this.tpAdminNews.Location = new System.Drawing.Point(4, 25);
            this.tpAdminNews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAdminNews.Name = "tpAdminNews";
            this.tpAdminNews.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAdminNews.Size = new System.Drawing.Size(763, 376);
            this.tpAdminNews.TabIndex = 0;
            this.tpAdminNews.Text = "Newsletter";
            this.tpAdminNews.UseVisualStyleBackColor = true;
            // 
            // tbxAuthorName
            // 
            this.tbxAuthorName.Location = new System.Drawing.Point(441, 219);
            this.tbxAuthorName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAuthorName.Name = "tbxAuthorName";
            this.tbxAuthorName.Size = new System.Drawing.Size(311, 22);
            this.tbxAuthorName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message written by";
            // 
            // btnAddNews
            // 
            this.btnAddNews.Location = new System.Drawing.Point(444, 334);
            this.btnAddNews.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNews.Name = "btnAddNews";
            this.btnAddNews.Size = new System.Drawing.Size(309, 28);
            this.btnAddNews.TabIndex = 3;
            this.btnAddNews.Text = "Add your message to the news board";
            this.btnAddNews.UseVisualStyleBackColor = true;
            this.btnAddNews.Click += new System.EventHandler(this.btnAddNews_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Write your message below";
            // 
            // tbxMessage
            // 
            this.tbxMessage.AcceptsReturn = true;
            this.tbxMessage.Location = new System.Drawing.Point(440, 27);
            this.tbxMessage.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(312, 162);
            this.tbxMessage.TabIndex = 1;
            // 
            // lbxAdminNews
            // 
            this.lbxAdminNews.FormattingEnabled = true;
            this.lbxAdminNews.ItemHeight = 16;
            this.lbxAdminNews.Location = new System.Drawing.Point(8, 7);
            this.lbxAdminNews.Margin = new System.Windows.Forms.Padding(4);
            this.lbxAdminNews.Name = "lbxAdminNews";
            this.lbxAdminNews.Size = new System.Drawing.Size(424, 356);
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
            this.tpAdminAddTenant.Location = new System.Drawing.Point(4, 25);
            this.tpAdminAddTenant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAdminAddTenant.Name = "tpAdminAddTenant";
            this.tpAdminAddTenant.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAdminAddTenant.Size = new System.Drawing.Size(763, 376);
            this.tpAdminAddTenant.TabIndex = 1;
            this.tpAdminAddTenant.Text = "Add tenant";
            this.tpAdminAddTenant.UseVisualStyleBackColor = true;
            // 
            // button_removeTenant
            // 
            this.button_removeTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_removeTenant.Location = new System.Drawing.Point(531, 225);
            this.button_removeTenant.Margin = new System.Windows.Forms.Padding(4);
            this.button_removeTenant.Name = "button_removeTenant";
            this.button_removeTenant.Size = new System.Drawing.Size(137, 28);
            this.button_removeTenant.TabIndex = 7;
            this.button_removeTenant.Text = "Remove tenant";
            this.button_removeTenant.UseVisualStyleBackColor = true;
            this.button_removeTenant.Click += new System.EventHandler(this.button_removeTenant_Click);
            // 
            // button_addTenant
            // 
            this.button_addTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_addTenant.Location = new System.Drawing.Point(531, 189);
            this.button_addTenant.Margin = new System.Windows.Forms.Padding(4);
            this.button_addTenant.Name = "button_addTenant";
            this.button_addTenant.Size = new System.Drawing.Size(137, 28);
            this.button_addTenant.TabIndex = 6;
            this.button_addTenant.Text = "Add tenant";
            this.button_addTenant.UseVisualStyleBackColor = true;
            this.button_addTenant.Click += new System.EventHandler(this.button_addTenant_Click);
            // 
            // textBox_tenantPassword
            // 
            this.textBox_tenantPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_tenantPassword.Location = new System.Drawing.Point(589, 140);
            this.textBox_tenantPassword.Name = "textBox_tenantPassword";
            this.textBox_tenantPassword.Size = new System.Drawing.Size(111, 26);
            this.textBox_tenantPassword.TabIndex = 5;
            // 
            // textBox_tenantName
            // 
            this.textBox_tenantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_tenantName.Location = new System.Drawing.Point(589, 102);
            this.textBox_tenantName.Name = "textBox_tenantName";
            this.textBox_tenantName.Size = new System.Drawing.Size(111, 26);
            this.textBox_tenantName.TabIndex = 4;
            // 
            // label_tenantPassword
            // 
            this.label_tenantPassword.AutoSize = true;
            this.label_tenantPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_tenantPassword.Location = new System.Drawing.Point(493, 143);
            this.label_tenantPassword.Name = "label_tenantPassword";
            this.label_tenantPassword.Size = new System.Drawing.Size(88, 20);
            this.label_tenantPassword.TabIndex = 3;
            this.label_tenantPassword.Text = "Password:";
            // 
            // label_tenantName
            // 
            this.label_tenantName.AutoSize = true;
            this.label_tenantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_tenantName.Location = new System.Drawing.Point(493, 105);
            this.label_tenantName.Name = "label_tenantName";
            this.label_tenantName.Size = new System.Drawing.Size(58, 20);
            this.label_tenantName.TabIndex = 2;
            this.label_tenantName.Text = "Name:";
            // 
            // listBox_tenants
            // 
            this.listBox_tenants.FormattingEnabled = true;
            this.listBox_tenants.ItemHeight = 16;
            this.listBox_tenants.Location = new System.Drawing.Point(7, 6);
            this.listBox_tenants.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_tenants.Name = "listBox_tenants";
            this.listBox_tenants.Size = new System.Drawing.Size(424, 356);
            this.listBox_tenants.TabIndex = 1;
            // 
            // tpAdminComplaints
            // 
            this.tpAdminComplaints.Location = new System.Drawing.Point(4, 25);
            this.tpAdminComplaints.Margin = new System.Windows.Forms.Padding(4);
            this.tpAdminComplaints.Name = "tpAdminComplaints";
            this.tpAdminComplaints.Padding = new System.Windows.Forms.Padding(4);
            this.tpAdminComplaints.Size = new System.Drawing.Size(763, 376);
            this.tpAdminComplaints.TabIndex = 2;
            this.tpAdminComplaints.Text = "Complaints";
            this.tpAdminComplaints.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_logout.Location = new System.Drawing.Point(651, 12);
            this.button_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(123, 30);
            this.button_logout.TabIndex = 2;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.tabControl1.ResumeLayout(false);
            this.tpAdminNews.ResumeLayout(false);
            this.tpAdminNews.PerformLayout();
            this.tpAdminAddTenant.ResumeLayout(false);
            this.tpAdminAddTenant.PerformLayout();
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
    }
}