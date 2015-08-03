namespace QuizProject
{
    partial class User
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
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.chgLastName = new System.Windows.Forms.TextBox();
            this.chgFirstName = new System.Windows.Forms.TextBox();
            this.chgPass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.passwd1 = new System.Windows.Forms.TextBox();
            this.passwd2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.Label();
            this.progressComboBox = new System.Windows.Forms.ComboBox();
            this.chapterLabel = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(15, 301);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(101, 23);
            this.update.TabIndex = 0;
            this.update.Text = "Update Profile";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(79, 94);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(17, 13);
            this.lastName.TabIndex = 6;
            this.lastName.Text = "ss";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(79, 68);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(17, 13);
            this.firstName.TabIndex = 5;
            this.firstName.Text = "ss";
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(79, 43);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(17, 13);
            this.UserID.TabIndex = 4;
            this.UserID.Text = "ss";
            // 
            // chgLastName
            // 
            this.chgLastName.Location = new System.Drawing.Point(81, 258);
            this.chgLastName.Name = "chgLastName";
            this.chgLastName.Size = new System.Drawing.Size(100, 20);
            this.chgLastName.TabIndex = 8;
            // 
            // chgFirstName
            // 
            this.chgFirstName.Location = new System.Drawing.Point(81, 232);
            this.chgFirstName.Name = "chgFirstName";
            this.chgFirstName.Size = new System.Drawing.Size(100, 20);
            this.chgFirstName.TabIndex = 9;
            // 
            // chgPass
            // 
            this.chgPass.Location = new System.Drawing.Point(15, 408);
            this.chgPass.Name = "chgPass";
            this.chgPass.Size = new System.Drawing.Size(126, 23);
            this.chgPass.TabIndex = 10;
            this.chgPass.Text = "Change password";
            this.chgPass.UseVisualStyleBackColor = true;
            this.chgPass.Click += new System.EventHandler(this.chgPass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Change First or Lastname";
            // 
            // passwd1
            // 
            this.passwd1.Location = new System.Drawing.Point(15, 374);
            this.passwd1.Name = "passwd1";
            this.passwd1.PasswordChar = '*';
            this.passwd1.Size = new System.Drawing.Size(100, 20);
            this.passwd1.TabIndex = 12;
            // 
            // passwd2
            // 
            this.passwd2.Location = new System.Drawing.Point(139, 370);
            this.passwd2.Name = "passwd2";
            this.passwd2.PasswordChar = '*';
            this.passwd2.Size = new System.Drawing.Size(100, 20);
            this.passwd2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Enter new password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Reenter password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "First Name: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Progress: ";
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.Location = new System.Drawing.Point(79, 121);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(17, 13);
            this.progress.TabIndex = 20;
            this.progress.Text = "ss";
            // 
            // progressComboBox
            // 
            this.progressComboBox.FormattingEnabled = true;
            this.progressComboBox.Location = new System.Drawing.Point(220, 66);
            this.progressComboBox.Name = "progressComboBox";
            this.progressComboBox.Size = new System.Drawing.Size(121, 21);
            this.progressComboBox.TabIndex = 21;
            this.progressComboBox.SelectionChangeCommitted += new System.EventHandler(this.progressComboBox_SelectionChangeCommitted);
            // 
            // chapterLabel
            // 
            this.chapterLabel.AutoSize = true;
            this.chapterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chapterLabel.Location = new System.Drawing.Point(216, 43);
            this.chapterLabel.Name = "chapterLabel";
            this.chapterLabel.Size = new System.Drawing.Size(137, 20);
            this.chapterLabel.TabIndex = 22;
            this.chapterLabel.Text = "Chapter Progress:";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressLabel.Location = new System.Drawing.Point(216, 94);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 20);
            this.progressLabel.TabIndex = 23;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 439);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.chapterLabel);
            this.Controls.Add(this.progressComboBox);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwd2);
            this.Controls.Add(this.passwd1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chgPass);
            this.Controls.Add(this.chgFirstName);
            this.Controls.Add(this.chgLastName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.TextBox chgLastName;
        private System.Windows.Forms.TextBox chgFirstName;
        private System.Windows.Forms.Button chgPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwd1;
        private System.Windows.Forms.TextBox passwd2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.ComboBox progressComboBox;
        private System.Windows.Forms.Label chapterLabel;
        private System.Windows.Forms.Label progressLabel;
    }
}