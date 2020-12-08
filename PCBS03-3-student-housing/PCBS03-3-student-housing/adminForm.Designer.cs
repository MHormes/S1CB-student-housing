
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tpAdminNews.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAdminNews);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 344);
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
            this.tpAdminNews.Location = new System.Drawing.Point(4, 22);
            this.tpAdminNews.Margin = new System.Windows.Forms.Padding(2);
            this.tpAdminNews.Name = "tpAdminNews";
            this.tpAdminNews.Padding = new System.Windows.Forms.Padding(2);
            this.tpAdminNews.Size = new System.Drawing.Size(570, 318);
            this.tpAdminNews.TabIndex = 0;
            this.tpAdminNews.Text = "Newsletter";
            this.tpAdminNews.UseVisualStyleBackColor = true;
            // 
            // tbxAuthorName
            // 
            this.tbxAuthorName.Location = new System.Drawing.Point(331, 178);
            this.tbxAuthorName.Name = "tbxAuthorName";
            this.tbxAuthorName.Size = new System.Drawing.Size(234, 20);
            this.tbxAuthorName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message written by";
            // 
            // btnAddNews
            // 
            this.btnAddNews.Location = new System.Drawing.Point(333, 286);
            this.btnAddNews.Name = "btnAddNews";
            this.btnAddNews.Size = new System.Drawing.Size(232, 23);
            this.btnAddNews.TabIndex = 3;
            this.btnAddNews.Text = "Add your message to the news board";
            this.btnAddNews.UseVisualStyleBackColor = true;
            this.btnAddNews.Click += new System.EventHandler(this.btnAddNews_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Write your message below";
            // 
            // tbxMessage
            // 
            this.tbxMessage.AcceptsReturn = true;
            this.tbxMessage.Location = new System.Drawing.Point(330, 22);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(235, 132);
            this.tbxMessage.TabIndex = 1;
            // 
            // lbxAdminNews
            // 
            this.lbxAdminNews.FormattingEnabled = true;
            this.lbxAdminNews.Location = new System.Drawing.Point(6, 6);
            this.lbxAdminNews.Name = "lbxAdminNews";
            this.lbxAdminNews.Size = new System.Drawing.Size(318, 303);
            this.lbxAdminNews.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(570, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.tabControl1.ResumeLayout(false);
            this.tpAdminNews.ResumeLayout(false);
            this.tpAdminNews.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAdminNews;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbxAuthorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNews;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.ListBox lbxAdminNews;
    }
}