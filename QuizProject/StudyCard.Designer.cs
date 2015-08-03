namespace QuizProject
{
    partial class StudyCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyCard));
            this.chapternumLabel = new System.Windows.Forms.Label();
            this.chapterLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.flipButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.wordLabel = new System.Windows.Forms.Label();
            this.definitionLabel = new System.Windows.Forms.Label();
            this.englishLabel = new System.Windows.Forms.Label();
            this.germanLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chapternumLabel
            // 
            this.chapternumLabel.AutoSize = true;
            this.chapternumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chapternumLabel.Location = new System.Drawing.Point(95, 9);
            this.chapternumLabel.Name = "chapternumLabel";
            this.chapternumLabel.Size = new System.Drawing.Size(51, 20);
            this.chapternumLabel.TabIndex = 74;
            this.chapternumLabel.Text = "label1";
            // 
            // chapterLabel
            // 
            this.chapterLabel.AutoSize = true;
            this.chapterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chapterLabel.Location = new System.Drawing.Point(19, 9);
            this.chapterLabel.Name = "chapterLabel";
            this.chapterLabel.Size = new System.Drawing.Size(70, 20);
            this.chapterLabel.TabIndex = 73;
            this.chapterLabel.Text = "Chapter:";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(289, 240);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 118;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // flipButton
            // 
            this.flipButton.Location = new System.Drawing.Point(165, 240);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(75, 23);
            this.flipButton.TabIndex = 119;
            this.flipButton.Text = "Flip";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(427, 285);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 120;
            this.finishButton.Text = "Finished";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.wordLabel.Location = new System.Drawing.Point(218, 110);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(79, 29);
            this.wordLabel.TabIndex = 121;
            this.wordLabel.Text = "label1";
            this.wordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // definitionLabel
            // 
            this.definitionLabel.AutoSize = true;
            this.definitionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.definitionLabel.Location = new System.Drawing.Point(218, 110);
            this.definitionLabel.Name = "definitionLabel";
            this.definitionLabel.Size = new System.Drawing.Size(79, 29);
            this.definitionLabel.TabIndex = 122;
            this.definitionLabel.Text = "label2";
            this.definitionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.definitionLabel.Visible = false;
            // 
            // englishLabel
            // 
            this.englishLabel.AutoSize = true;
            this.englishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.englishLabel.Location = new System.Drawing.Point(211, 55);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(93, 29);
            this.englishLabel.TabIndex = 123;
            this.englishLabel.Text = "English";
            this.englishLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.englishLabel.Visible = false;
            // 
            // germanLabel
            // 
            this.germanLabel.AutoSize = true;
            this.germanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.germanLabel.Location = new System.Drawing.Point(211, 55);
            this.germanLabel.Name = "germanLabel";
            this.germanLabel.Size = new System.Drawing.Size(99, 29);
            this.germanLabel.TabIndex = 124;
            this.germanLabel.Text = "German";
            this.germanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudyCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 320);
            this.Controls.Add(this.germanLabel);
            this.Controls.Add(this.englishLabel);
            this.Controls.Add(this.definitionLabel);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.flipButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.chapternumLabel);
            this.Controls.Add(this.chapterLabel);
            this.Name = "StudyCard";
            this.Text = "Study";
            this.Load += new System.EventHandler(this.StudyCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chapternumLabel;
        private System.Windows.Forms.Label chapterLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label definitionLabel;
        private System.Windows.Forms.Label englishLabel;
        private System.Windows.Forms.Label germanLabel;
    }
}