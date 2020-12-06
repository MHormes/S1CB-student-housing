
namespace PCBS03_3_student_housing
{
    partial class Form1
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
            this.label_loginTitle = new System.Windows.Forms.Label();
            this.textBox_accountName = new System.Windows.Forms.TextBox();
            this.label_accountName = new System.Windows.Forms.Label();
            this.label_accountPassword = new System.Windows.Forms.Label();
            this.textBox_accountPassword = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_loginTitle
            // 
            this.label_loginTitle.AutoSize = true;
            this.label_loginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_loginTitle.Location = new System.Drawing.Point(267, 76);
            this.label_loginTitle.Name = "label_loginTitle";
            this.label_loginTitle.Size = new System.Drawing.Size(253, 29);
            this.label_loginTitle.TabIndex = 0;
            this.label_loginTitle.Text = "STUDENT HOUSING";
            // 
            // textBox_accountName
            // 
            this.textBox_accountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_accountName.Location = new System.Drawing.Point(424, 141);
            this.textBox_accountName.Name = "textBox_accountName";
            this.textBox_accountName.Size = new System.Drawing.Size(134, 30);
            this.textBox_accountName.TabIndex = 1;
            // 
            // label_accountName
            // 
            this.label_accountName.AutoSize = true;
            this.label_accountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_accountName.Location = new System.Drawing.Point(228, 140);
            this.label_accountName.Name = "label_accountName";
            this.label_accountName.Size = new System.Drawing.Size(183, 29);
            this.label_accountName.TabIndex = 2;
            this.label_accountName.Text = "Account name:";
            // 
            // label_accountPassword
            // 
            this.label_accountPassword.AutoSize = true;
            this.label_accountPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_accountPassword.Location = new System.Drawing.Point(228, 188);
            this.label_accountPassword.Name = "label_accountPassword";
            this.label_accountPassword.Size = new System.Drawing.Size(131, 29);
            this.label_accountPassword.TabIndex = 3;
            this.label_accountPassword.Text = "Password:";
            // 
            // textBox_accountPassword
            // 
            this.textBox_accountPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_accountPassword.Location = new System.Drawing.Point(424, 189);
            this.textBox_accountPassword.Name = "textBox_accountPassword";
            this.textBox_accountPassword.Size = new System.Drawing.Size(134, 30);
            this.textBox_accountPassword.TabIndex = 4;
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_login.Location = new System.Drawing.Point(335, 248);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(123, 35);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_accountPassword);
            this.Controls.Add(this.label_accountPassword);
            this.Controls.Add(this.label_accountName);
            this.Controls.Add(this.textBox_accountName);
            this.Controls.Add(this.label_loginTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_loginTitle;
        private System.Windows.Forms.TextBox textBox_accountName;
        private System.Windows.Forms.Label label_accountName;
        private System.Windows.Forms.Label label_accountPassword;
        private System.Windows.Forms.TextBox textBox_accountPassword;
        private System.Windows.Forms.Button button_login;
    }
}

