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
    public partial class login : Form
    {
        public static String temp;

        public login()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // connection string for the database
            string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
            // query strings for adding into the login and user db
            string query = "SELECT uid FROM login WHERE uid = @uid AND password = @passwd";
            // connection and command objects
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand comm = null;

            comm = new SqlCommand(query, conn);

            conn.Open();
            comm.Parameters.AddWithValue("@uid", uName.Text);
            comm.Parameters.AddWithValue("@passwd", password.Text);
            
            temp = (string)comm.ExecuteScalar();
            conn.Close();
            if ( temp == uName.Text)
            {
                this.Hide();
                FrontPage FrontPage = new FrontPage();
                FrontPage.Show();
             
            }
            else
            {
                uName.Text = "";
                password.Text = "";
                MessageBox.Show("Incorrect Username or Password");
            } 
        }

                     
    }
}
