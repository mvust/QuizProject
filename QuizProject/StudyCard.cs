using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizProject
{
    public partial class StudyCard : Form
    {
        private int _cid;
        private aQuiz myStudyQuiz;
        private int _counter = 0;

        public StudyCard(int cid)
        {
            chapter = cid;
            myStudyQuiz = new aQuiz(chapter);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        private void StudyCard_Load(object sender, EventArgs e)
        {
            chapternumLabel.Text = chapter.ToString();
            wordLabel.Text = myStudyQuiz.quiz[counter].word;
            definitionLabel.Text = myStudyQuiz.quiz[counter].definition;
        }
         
        private void flipButton_Click(object sender, EventArgs e)
        {
            if(wordLabel.Visible)
            {
                englishLabel.Visible = true;
                germanLabel.Visible = false;
                wordLabel.Visible = false;
                definitionLabel.Visible = true;
            }
            
            else
            {
                englishLabel.Visible = false;
                germanLabel.Visible = true;
                definitionLabel.Visible = false;
                wordLabel.Visible = true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (counter != myStudyQuiz.quiz.Count - 1)
            {
                counter++;
                definitionLabel.Visible = false;
                wordLabel.Visible = true;
                englishLabel.Visible = false;
                germanLabel.Visible = true;
                wordLabel.Text = myStudyQuiz.quiz[counter].word;
                definitionLabel.Text = myStudyQuiz.quiz[counter].definition;
            }
        }
        
        public int chapter
        {
            set { _cid = value; }
            get { return _cid; }
        }

        public int counter
        {
            set { _counter = value; }
            get { return _counter; }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
