namespace QuizProject
{
    partial class Admin
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
            this.addNewBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.isAdminChk = new System.Windows.Forms.CheckBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.passwd2 = new System.Windows.Forms.TextBox();
            this.passwd1 = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.userID = new System.Windows.Forms.TextBox();
            this.viewuserButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.specificComboBox = new System.Windows.Forms.ComboBox();
            this.deleteuserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewBtn
            // 
            this.addNewBtn.Location = new System.Drawing.Point(121, 187);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(97, 23);
            this.addNewBtn.TabIndex = 5;
            this.addNewBtn.Text = "Add New user";
            this.addNewBtn.UseVisualStyleBackColor = true;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(12, 187);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(100, 23);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Update User";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Reenter Password";
            // 
            // isAdminChk
            // 
            this.isAdminChk.AutoSize = true;
            this.isAdminChk.Location = new System.Drawing.Point(358, 94);
            this.isAdminChk.Name = "isAdminChk";
            this.isAdminChk.Size = new System.Drawing.Size(86, 17);
            this.isAdminChk.TabIndex = 9;
            this.isAdminChk.Text = "Administrator";
            this.isAdminChk.UseVisualStyleBackColor = true;
            this.isAdminChk.CheckedChanged += new System.EventHandler(this.isAdminChk_CheckedChanged);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(12, 92);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(100, 20);
            this.fname.TabIndex = 0;
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // passwd2
            // 
            this.passwd2.Location = new System.Drawing.Point(118, 147);
            this.passwd2.Name = "passwd2";
            this.passwd2.Size = new System.Drawing.Size(100, 20);
            this.passwd2.TabIndex = 3;
            // 
            // passwd1
            // 
            this.passwd1.Location = new System.Drawing.Point(12, 147);
            this.passwd1.Name = "passwd1";
            this.passwd1.Size = new System.Drawing.Size(100, 20);
            this.passwd1.TabIndex = 2;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(118, 92);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(100, 20);
            this.lname.TabIndex = 1;
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(224, 92);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(100, 20);
            this.userID.TabIndex = 10;
            // 
            // viewuserButton
            // 
            this.viewuserButton.Location = new System.Drawing.Point(12, 228);
            this.viewuserButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewuserButton.Name = "viewuserButton";
            this.viewuserButton.Size = new System.Drawing.Size(98, 25);
            this.viewuserButton.TabIndex = 12;
            this.viewuserButton.Text = "View User";
            this.viewuserButton.UseVisualStyleBackColor = true;
            this.viewuserButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 171);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(6, 20);
            this.textBox1.TabIndex = 13;
            // 
            // specificComboBox
            // 
            this.specificComboBox.FormattingEnabled = true;
            this.specificComboBox.Location = new System.Drawing.Point(127, 232);
            this.specificComboBox.Name = "specificComboBox";
            this.specificComboBox.Size = new System.Drawing.Size(121, 21);
            this.specificComboBox.TabIndex = 14;
            this.specificComboBox.DropDown += new System.EventHandler(this.specificComboBox_DropDown);
            // 
            // deleteuserButton
            // 
            this.deleteuserButton.Location = new System.Drawing.Point(268, 228);
            this.deleteuserButton.Name = "deleteuserButton";
            this.deleteuserButton.Size = new System.Drawing.Size(98, 25);
            this.deleteuserButton.TabIndex = 15;
            this.deleteuserButton.Text = "Delete User";
            this.deleteuserButton.UseVisualStyleBackColor = true;
            this.deleteuserButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 392);
            this.Controls.Add(this.deleteuserButton);
            this.Controls.Add(this.specificComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.viewuserButton);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.passwd1);
            this.Controls.Add(this.passwd2);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.isAdminChk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addNewBtn);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox isAdminChk;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox passwd2;
        private System.Windows.Forms.TextBox passwd1;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Button viewuserButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox specificComboBox;
        private System.Windows.Forms.Button deleteuserButton;
    }
}