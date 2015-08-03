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
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
        }
    
        private void FrontPage_Load(object sender, EventArgs e)
        {
            // set the username label text
            nameLbl.Text = login.temp;

            // connection string for the database
            string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
            // query strings for adding into the login and user db
            string query1 = "SELECT access_level FROM login WHERE uid = @uid";
            // connection and command objects
            SqlConnection con = new SqlConnection(connection);
            SqlCommand comm = null;

            con.Open();
            comm = new SqlCommand(query1, con);
            comm.Parameters.AddWithValue("@uid", login.temp);
     
            bool access = (bool)comm.ExecuteScalar();
            con.Close();
            
            if (access)
            {
                adminBtn.Visible = true;
            }

        }

        private void FrontPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            User userPage = new User(login.temp);
            userPage.Show();

        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            Admin adminPage = new Admin();
            adminPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chapters chapterPage = new Chapters();
            chapterPage.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

        
    }
}
