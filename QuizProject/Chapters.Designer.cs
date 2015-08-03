namespace QuizProject
{
    partial class Chapters
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
            this.components = new System.ComponentModel.Container();
            this.chapSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.takeQuizBtn = new System.Windows.Forms.Button();
            this.studyBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.quizDatabaseDataSet = new QuizProject.QuizDatabaseDataSet();
            this.vocabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vocabTableAdapter = new QuizProject.QuizDatabaseDataSetTableAdapters.vocabTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quizDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocabBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chapSelect
            // 
            this.chapSelect.FormattingEnabled = true;
            this.chapSelect.Location = new System.Drawing.Point(12, 50);
            this.chapSelect.Name = "chapSelect";
            this.chapSelect.Size = new System.Drawing.Size(268, 21);
            this.chapSelect.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chapter Select";
            // 
            // takeQuizBtn
            // 
            this.takeQuizBtn.Location = new System.Drawing.Point(12, 77);
            this.takeQuizBtn.Name = "takeQuizBtn";
            this.takeQuizBtn.Size = new System.Drawing.Size(75, 23);
            this.takeQuizBtn.TabIndex = 2;
            this.takeQuizBtn.Text = "Take Quiz";
            this.takeQuizBtn.UseVisualStyleBackColor = true;
            this.takeQuizBtn.Click += new System.EventHandler(this.takeQuizBtn_Click);
            // 
            // studyBtn
            // 
            this.studyBtn.Location = new System.Drawing.Point(110, 77);
            this.studyBtn.Name = "studyBtn";
            this.studyBtn.Size = new System.Drawing.Size(75, 23);
            this.studyBtn.TabIndex = 3;
            this.studyBtn.Text = "Study";
            this.studyBtn.UseVisualStyleBackColor = true;
            this.studyBtn.Click += new System.EventHandler(this.studyBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(205, 77);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // quizDatabaseDataSet
            // 
            this.quizDatabaseDataSet.DataSetName = "QuizDatabaseDataSet";
            this.quizDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vocabBindingSource
            // 
            this.vocabBindingSource.DataMember = "vocab";
            this.vocabBindingSource.DataSource = this.quizDatabaseDataSet;
            // 
            // vocabTableAdapter
            // 
            this.vocabTableAdapter.ClearBeforeFill = true;
            // 
            // Chapters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 138);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.studyBtn);
            this.Controls.Add(this.takeQuizBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chapSelect);
            this.Name = "Chapters";
            this.Text = "Chapters";
            this.Load += new System.EventHandler(this.Chapters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocabBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox chapSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button takeQuizBtn;
        private System.Windows.Forms.Button studyBtn;
        private System.Windows.Forms.Button backBtn;
        private QuizDatabaseDataSet quizDatabaseDataSet;
        private System.Windows.Forms.BindingSource vocabBindingSource;
        private QuizDatabaseDataSetTableAdapters.vocabTableAdapter vocabTableAdapter;
    }
}