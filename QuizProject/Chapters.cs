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
    public partial class Chapters : Form
    {
        public Chapters()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void takeQuizBtn_Click(object sender, EventArgs e)
        {
            Quiz quizPage = new Quiz(Convert.ToInt16(chapSelect.Text));
            quizPage.Show();
        }

        private void studyBtn_Click(object sender, EventArgs e)
        {
            StudyCard cardPage = new StudyCard(Convert.ToInt16(chapSelect.Text));
            cardPage.Show();
        }

        private void Chapters_Load(object sender, EventArgs e)
        {
            // connection string for the database
            string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
            // query strings for adding into the login and user db
            string query1 = "SELECT DISTINCT cid FROM vocab";
            // connection and command objects
            
            SqlConnection con = new SqlConnection(connection);
           
            SqlDataAdapter da = new SqlDataAdapter();
            
            DataSet ds = new DataSet();
            
            con.Open();
            SqlCommand comm = new SqlCommand(query1, con);
            da.SelectCommand = comm;
       
            
            da.Fill(ds);
            da.Dispose();
            comm.Dispose();
            con.Close();

            if (ds.Tables[0].Rows.Count > 0 )
            {
                chapSelect.DataSource = ds.Tables[0];
                chapSelect.ValueMember = "cid";
                chapSelect.DisplayMember = "cid";
            }
        }

        
    }
}
