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
    public partial class User : Form
    {
        private string userid = "";
        public static Decimal prog;

        public User()
        {
            InitializeComponent();
        }

        public User(string uid)
        {
            userid = uid;
            InitializeComponent();
        }

         private void update_Click(object sender, EventArgs e)
        {
            // connection string for the database
            string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
            // query strings for adding into the login and user db
            string query1 = null;
            // connection and command objects

            SqlConnection con = new SqlConnection(connection);

            con.Open();
            try
            {
                if (chgFirstName.Text != "")
                {
                    query1 = "UPDATE users SET First_name = @fname WHERE uid = @uid";
                    SqlCommand comm = new SqlCommand(query1, con);
                    comm.Parameters.AddWithValue("@fname", chgFirstName.Text);
                    comm.Parameters.AddWithValue("@uid", userid);
                    comm.ExecuteNonQuery();
                }
                
                if (chgLastName.Text != "")
                {
                    query1 = "UPDATE users SET Last_name = @lname WHERE uid = @uid";
                    SqlCommand comm = new SqlCommand(query1, con);
                    comm.Parameters.AddWithValue("@lname", chgLastName.Text);
                    comm.Parameters.AddWithValue("@uid", userid);
                    comm.ExecuteNonQuery();
                }
        
                MessageBox.Show("Update Successful");
                chgFirstName.Text = "";
                chgLastName.Text = "";
            }

            catch
            {
                MessageBox.Show("Unable to Update");
            }

            con.Close();
         
         }

        private void chgPass_Click(object sender, EventArgs e)
        {
            // connection string for the database
            string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
            // query strings for adding into the login and user db
            string query1 = null;
            // connection and command objects

            SqlConnection con = new SqlConnection(connection);

            con.Open();
            try
            {
                if (passwd1.Text == passwd2.Text)
                {
                    query1 = "UPDATE login SET password = @pass WHERE uid = @uid";
                    SqlCommand comm = new SqlCommand(query1, con);
                    comm.Parameters.AddWithValue("@pass", passwd1.Text);
                    comm.Parameters.AddWithValue("@uid", userid);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Update Successful");
                    passwd1.Text = null;
                    passwd2.Text = null;
                }
                else
                {
                    MessageBox.Show("Passwords do not match or are blank");
                }

            }

            catch
            {
                MessageBox.Show("Unable to Update");
            }

            con.Close();
        }

        private void User_Load_1(object sender, EventArgs e)
        {
            try
            {
                // connection string for the database
                string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
                // connection and command objects
                string query1 = "SELECT * FROM users WHERE uid = @uid";
                SqlConnection con = new SqlConnection(connection);
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                con.Open();
                SqlCommand comm = new SqlCommand(query1, con);
                if (userid == "")
                {
                    comm.Parameters.AddWithValue("@uid", login.temp);
                }
                else
                {
                    comm.Parameters.AddWithValue("@uid", userid);
                }
                da.SelectCommand = comm;
                da.Fill(ds);
                da.Dispose();
                comm.Dispose();
                con.Close();

                DataTable datatable = new DataTable();
                datatable = ds.Tables[0];

                DataRow row = datatable.Rows[0];
                UserID.Text = Convert.ToString(row[0]);
                firstName.Text = Convert.ToString(row[1]);
                lastName.Text = Convert.ToString(row[2]);
                progress.Text = Convert.ToString(row[3]);
            }

            catch
            {
                MessageBox.Show("User doesn't exist");
                this.Close();
            }

            try
            {
                // connection string for the database
                string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
                // query strings for adding into the login and user db
                string query1 = "SELECT * FROM scores WHERE uid = @uid";
                // connection and command objects
            
                SqlConnection con = new SqlConnection(connection);
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
            
                con.Open();
                SqlCommand comm = new SqlCommand(query1, con);
                comm.Parameters.AddWithValue("@uid", login.temp);

                da.SelectCommand = comm;
                da.Fill(ds);
                da.Dispose();
                comm.Dispose();
                con.Close();

                if (ds.Tables[0].Rows.Count > 0 )
                {
                    progressComboBox.DataSource = ds.Tables[0];
                    progressComboBox.ValueMember = "cid";
                    progressComboBox.DisplayMember = "cid";
                }

                progressComboBox.Text = "";
            }
            
            catch
            {

            }
        }

        private void progressComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                // connection string for the database
                string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
                // query strings for adding into the login and user db
                string query = "SELECT avg FROM scores WHERE uid = @uid AND cid = @cid";
                // connection and command objects
                SqlConnection conn = new SqlConnection(connection);
                SqlCommand comm = null;

                comm = new SqlCommand(query, conn);

                conn.Open();
                comm.Parameters.AddWithValue("@uid", userid);
                comm.Parameters.AddWithValue("@cid", progressComboBox.SelectedIndex);

                prog = Convert.ToDecimal(comm.ExecuteScalar());
                conn.Close();

                prog = prog * 100;

                progressLabel.Text = Convert.ToString(prog);
            }
            catch
            {
                MessageBox.Show("Unable to retrieve Progress");
            }


        }

       
    }
}
