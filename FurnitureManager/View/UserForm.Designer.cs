namespace FurnitureManager.View
{
    partial class UserForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textusername = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textaddress = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textreport = new System.Windows.Forms.TextBox();
            this.addReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "User name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Password";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(115, 235);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(100, 20);
            this.textpassword.TabIndex = 37;
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(115, 191);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(100, 20);
            this.textusername.TabIndex = 36;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(564, 275);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 35;
            this.deleteBtn.Text = "Delete User";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteclk);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(440, 275);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 34;
            this.editBtn.Text = "Edit User";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editclk);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(687, 275);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 33;
            this.viewBtn.Text = "Retrieve";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.retrieveclk);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(319, 275);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 32;
            this.addBtn.Text = "Add User";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addclk);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID";
            // 
            // textaddress
            // 
            this.textaddress.Location = new System.Drawing.Point(115, 143);
            this.textaddress.Name = "textaddress";
            this.textaddress.Size = new System.Drawing.Size(100, 20);
            this.textaddress.TabIndex = 27;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(115, 102);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 26;
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(115, 57);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 25;
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(297, 57);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(500, 186);
            this.userListBox.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Type of report";
            // 
            // textreport
            // 
            this.textreport.Location = new System.Drawing.Point(115, 298);
            this.textreport.Name = "textreport";
            this.textreport.Size = new System.Drawing.Size(100, 20);
            this.textreport.TabIndex = 42;
            // 
            // addReport
            // 
            this.addReport.Location = new System.Drawing.Point(226, 288);
            this.addReport.Name = "addReport";
            this.addReport.Size = new System.Drawing.Size(75, 38);
            this.addReport.TabIndex = 41;
            this.addReport.Text = " Generate report";
            this.addReport.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 350);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textreport);
            this.Controls.Add(this.addReport);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textaddress);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textid);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textaddress;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textreport;
        private System.Windows.Forms.Button addReport;
    }
}