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
    public class aQuiz
    {
	    private List<aQuestion> _quiz;
        private List<String> _choices;
        private int _cid;
        private int _correct = 0;
        private int _total = 10;

        public aQuiz(int cid)
        {
            chapter = cid;
            quiz = new List<aQuestion>();
            choices = new List<String>();
            
            makequiz();
            makechoices();

            quiz.Shuffle();
            choices.Shuffle();
        }

        public void makequiz()
        {
            // connection string for the database
            string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
            // query strings for adding into the login and user db
            string query1 = "SELECT * FROM vocab WHERE cid = @chapter";
            // connection and command objects

            SqlConnection con = new SqlConnection(connection);

            SqlDataAdapter da = new SqlDataAdapter();

            DataSet ds = new DataSet();

            con.Open();
            SqlCommand comm = new SqlCommand(query1, con);
            comm.Parameters.AddWithValue("@chapter", chapter);
            da.SelectCommand = comm;

            da.Fill(ds);
            da.Dispose();
            comm.Dispose();
            con.Close();

            DataTable datatable = new DataTable();
            datatable = ds.Tables[0];

            foreach(DataRow row in datatable.Rows)
            {
                int i = 0;
                // creates a new question object
                aQuestion aQuestion = new aQuestion(Convert.ToInt32(row[0]), Convert.ToString(row[1]), Convert.ToString(row[2]), Convert.ToInt32(row[3]));
                
                // inserts question into the quiz datatable
                quiz.Insert(i, aQuestion);
                i++;
            }
        }

        public void makechoices()
        {
            // connection string for the database
            string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
            // query strings for adding into the login and user db
            string query1 = "SELECT * FROM vocab WHERE cid != @chapter";
            // connection and command objects

            SqlConnection con = new SqlConnection(connection);
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            con.Open();
            SqlCommand comm = new SqlCommand(query1, con);
            comm.Parameters.AddWithValue("@chapter", chapter);
            da.SelectCommand = comm;

            da.Fill(ds);
            da.Dispose();
            comm.Dispose();
            con.Close();

            DataTable datatable = new DataTable();
            datatable = ds.Tables[0];

            string word;
            foreach (DataRow row in datatable.Rows)
            {
                int i = 0;
                word = Convert.ToString(row[1]);
                choices.Insert(i, word);
                i++;
            }
        }



        public List<aQuestion> quiz
        {
            set { _quiz = value; }
            get { return _quiz; }
        }

        public List<String> choices
        {
            set { _choices = value; }
            get { return _choices; }
        }

        public int cid
        {
            set { _cid = value; }
            get { return _cid; }
        }

        public int correct
        {
            set { _correct = value; }
            get { return _correct; }
        }

        public int total
        {
            get { return _total; }
        }

        public int chapter
        {
            set { _cid = value; }
            get { return _cid; }
        }
    }
}
