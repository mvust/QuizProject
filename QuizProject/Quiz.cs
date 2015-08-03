using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizProject
{
    public partial class Quiz : Form
    {
        private int _cid;
        private aQuiz myQuiz;

        public Quiz(int cid)
        {
            chapter = cid;
            myQuiz = new aQuiz(chapter);
            InitializeComponent();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            chapternumLabel.Text = chapter.ToString();

            label11.Text = myQuiz.quiz[0].definition;
            radioButton1.Text = myQuiz.choices[0];
            radioButton2.Text = myQuiz.quiz[0].word;
            radioButton3.Text = myQuiz.choices[1];
            radioButton4.Text = myQuiz.choices[2];
            
            label12.Text = myQuiz.quiz[1].definition;
            radioButton5.Text = myQuiz.quiz[1].word;
            radioButton6.Text = myQuiz.choices[3];
            radioButton7.Text = myQuiz.choices[4];
            radioButton8.Text = myQuiz.choices[5];
            
            label13.Text = myQuiz.quiz[2].definition;
            radioButton9.Text = myQuiz.choices[6];
            radioButton10.Text = myQuiz.choices[7];
            radioButton11.Text = myQuiz.quiz[2].word;
            radioButton12.Text = myQuiz.choices[8];
            
            label14.Text = myQuiz.quiz[3].definition;
            radioButton13.Text = myQuiz.choices[9];
            radioButton14.Text = myQuiz.choices[10];
            radioButton15.Text = myQuiz.choices[11];
            radioButton16.Text = myQuiz.quiz[3].word;

            label15.Text = myQuiz.quiz[4].definition;
            radioButton17.Text = myQuiz.choices[12];
            radioButton18.Text = myQuiz.choices[13];
            radioButton19.Text = myQuiz.choices[14];
            radioButton20.Text = myQuiz.quiz[4].word;
            
            label16.Text = myQuiz.quiz[5].definition;
            radioButton21.Text = myQuiz.quiz[5].word;
            radioButton22.Text = myQuiz.choices[15];
            radioButton23.Text = myQuiz.choices[16];
            radioButton24.Text = myQuiz.choices[17];
            
            label17.Text = myQuiz.quiz[6].definition;
            radioButton25.Text = myQuiz.choices[18];
            radioButton26.Text = myQuiz.quiz[6].word;
            radioButton27.Text = myQuiz.choices[19];
            radioButton28.Text = myQuiz.choices[20];

            label18.Text = myQuiz.quiz[7].definition;
            radioButton29.Text = myQuiz.choices[21];
            radioButton30.Text = myQuiz.choices[22];
            radioButton31.Text = myQuiz.quiz[7].word;
            radioButton32.Text = myQuiz.choices[23];

            label19.Text = myQuiz.quiz[8].definition;
            radioButton33.Text = myQuiz.quiz[8].word;
            radioButton34.Text = myQuiz.choices[24];
            radioButton35.Text = myQuiz.choices[25];
            radioButton36.Text = myQuiz.choices[26];
            
            label20.Text = myQuiz.quiz[9].definition;
            radioButton37.Text = myQuiz.choices[27];
            radioButton38.Text = myQuiz.choices[28];
            radioButton39.Text = myQuiz.choices[29];
            radioButton40.Text = myQuiz.quiz[9].word;
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                myQuiz.correct = myQuiz.correct + 1;
            if (radioButton5.Checked)
                myQuiz.correct = myQuiz.correct + 1;
            if (radioButton11.Checked)
                myQuiz.correct = myQuiz.correct + 1;
            if (radioButton16.Checked)
                myQuiz.correct = myQuiz.correct + 1;
            if (radioButton20.Checked)
                myQuiz.correct = myQuiz.correct + 1;
            if (radioButton21.Checked)
                myQuiz.correct = myQuiz.correct + 1;
            if (radioButton26.Checked)
                myQuiz.correct = myQuiz.correct + 1;
            if (radioButton31.Checked)
                myQuiz.correct = myQuiz.correct + 1;
            if (radioButton33.Checked)
                myQuiz.correct = myQuiz.correct + 1;
            if (radioButton40.Checked)
                myQuiz.correct = myQuiz.correct + 1;

            // insert results page here
            decimal result = ((decimal)myQuiz.correct / (decimal)myQuiz.total);

            MessageBox.Show("You got " + myQuiz.correct + "/10 Correct!");
            
            // connection string for the database
            string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
            // query strings for adding into the login and user db
            string query1 = null;
            // connection and command objects

            SqlConnection con = new SqlConnection(connection);

            con.Open();

            try
            {
                query1 = "INSERT into scores (uid, cid, avg) VALUES (@uid, @cid, @avg)";
                SqlCommand comm = new SqlCommand(query1, con);
                comm.Parameters.AddWithValue("@uid", login.temp);
                comm.Parameters.AddWithValue("@cid", myQuiz.cid);
                comm.Parameters.AddWithValue("@avg", result);
                comm.ExecuteNonQuery();
            }

            catch
            {
                query1 = "UPDATE scores SET avg = @avg WHERE uid = @uid and cid = @cid";
                SqlCommand comm = new SqlCommand(query1, con);
                comm.Parameters.AddWithValue("@uid", login.temp);
                comm.Parameters.AddWithValue("@cid", myQuiz.cid);
                comm.Parameters.AddWithValue("@avg", result);
                comm.ExecuteNonQuery();
            }
            con.Close();
            this.Close();
        }

        public int chapter
        {
            set { _cid = value; }
            get { return _cid; }
        }

    }
}
