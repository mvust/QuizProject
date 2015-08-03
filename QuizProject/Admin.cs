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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void isAdminChk_CheckedChanged(object sender, EventArgs e)
        {
            // confirmation dialouge for giving admin
            MessageBox.Show("Are you sure you want to make this user an administrator?");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // connection string for the database
            string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
            // connection and command objects
            SqlConnection con = new SqlConnection(connection);
            SqlCommand comm = null;

            string query = null;

            // call the quereies to update informationin the database
            if (userID.Text != null)
            {
                if (fname.Text != null)
                {
                    con.Open();

                    query = "UPDATE users SET First_name = @First_name WHERE uid = @uid";
                    comm = new SqlCommand(query, con);

                    comm.Parameters.AddWithValue("@First_name", fname.Text);
                    comm.Parameters.AddWithValue("@uid", userID.Text);

                    comm.ExecuteNonQuery();

                    con.Close();

                }
                if (lname.Text != null)
                {
                    con.Open();

                    query = "UPDATE users SET Last_name = @Last_name WHERE uid = @uid";
                    comm = new SqlCommand(query, con);

                    comm.Parameters.AddWithValue("@Last_name", lname.Text);
                    comm.Parameters.AddWithValue("@uid", userID.Text);

                    comm.ExecuteNonQuery();

                    con.Close();
                }

                if (passwd1.Text != null && passwd2.Text != null)
                {
                    if (passwd2.Text == passwd1.Text)
                    {
                        query = "UPDATE login SET password = @password WHERE uid = @uid";
                        comm = new SqlCommand(query, con);

                        comm.Parameters.AddWithValue("@password", passwd1.Text);
                        comm.Parameters.AddWithValue("@uid", userID.Text);
                    }
                    else
                        MessageBox.Show("Passwords do not match");

                }
                passwd1.Clear();
                passwd2.Clear();
                fname.Clear();
                lname.Clear();
                isAdminChk.Checked = false;
            }
            else
                MessageBox.Show("Please enter the user ID of the user you wish to update.");


        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            // connection string for the database
            string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
            // query strings for adding into the login and user db
            string query1 = "INSERT into login (uid, password, access_level) VALUES (@uid, @password, @access_level)";
            string query2 = " INSERT into users (uid, First_name, Last_name, progress) VALUES (@uid, @fname, @lname, 0)";
            // connection and command objects
            SqlConnection con = new SqlConnection(connection);
            SqlCommand comm = null;
            
            // add user to the database
            // take first initial and last name to make the uid
            try
            {
                string userID = fname.Text[0] + lname.Text;

                if (passwd1.Text == passwd2.Text)
                {
                    comm = new SqlCommand(query1, con);
                    con.Open();
                    comm.Parameters.AddWithValue("@uid", userID);
                    comm.Parameters.AddWithValue("@password", passwd1.Text);
                    comm.Parameters.AddWithValue("@access_level", isAdminChk.CheckState);
                    comm.ExecuteNonQuery();

                    comm = new SqlCommand(query2, con);
                    comm.Parameters.AddWithValue("@uid", userID);
                    comm.Parameters.AddWithValue("@fname", fname.Text);
                    comm.Parameters.AddWithValue("@lname", lname.Text);
                    comm.ExecuteNonQuery();
                    con.Close();

                    passwd1.Clear();
                    passwd2.Clear();
                    fname.Clear();
                    lname.Clear();
                    isAdminChk.Checked = false;


                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            catch
            {
                MessageBox.Show("User already exsists");
            }
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String userid = specificComboBox.Text;
                User userPage = new User(userid);
                userPage.Show();
            }
            catch
            {
                MessageBox.Show("User Doesn't Exist");
            }


        }

        private void Admin_Load(object sender, EventArgs e)
        {
            try
            {
                // connection string for the database
                string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
                // query strings for adding into the login and user db
                string query1 = "SELECT uid FROM login";
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

                if (ds.Tables[0].Rows.Count > 0)
                {
                    specificComboBox.DataSource = ds.Tables[0];
                    specificComboBox.ValueMember = "uid";
                    specificComboBox.DisplayMember = "uid";
                }

                specificComboBox.Text = "";
            }

            catch
            {

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(specificComboBox.Text != userID.Text)
            {
                // connection string for the database
                string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
                // connection and command objects
                SqlConnection con = new SqlConnection(connection);
                SqlCommand comm = null;
                String query = null;

                // call the quereies to update informationin the database
                con.Open();
          
                try
                {
                    query = "DELETE FROM users WHERE uid = @uid";
                    comm = new SqlCommand(query, con);
                    comm.Parameters.AddWithValue("@uid", specificComboBox.Text);
                    comm.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Unable to Delete User");
                }

                try
                {
                    query = "DELETE FROM scores WHERE uid = @uid";
                    comm = new SqlCommand(query, con);

                    comm.Parameters.AddWithValue("@uid", specificComboBox.Text);
                    comm.ExecuteNonQuery();
                }
                catch
                {
                }

                try
                {
                    query = "DELETE FROM login WHERE uid = @uid";
                    comm = new SqlCommand(query, con);
                    comm.Parameters.AddWithValue("@uid", specificComboBox.Text);
                    comm.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Unable to Delete User");
                }

                con.Close();
            }

            else
            {
                MessageBox.Show("Unable to delete your own account");
            }
        }

        private void specificComboBox_DropDown(object sender, EventArgs e)
        {
            try
            {
                // connection string for the database
                string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin Vust\Google Drive\QuizProj\QuizProject\QuizProject\QuizDatabase.mdf;Integrated Security=True";
                // query strings for adding into the login and user db
                string query1 = "SELECT uid FROM login";
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

                if (ds.Tables[0].Rows.Count > 0)
                {
                    specificComboBox.DataSource = ds.Tables[0];
                    specificComboBox.ValueMember = "uid";
                    specificComboBox.DisplayMember = "uid";
                }

                specificComboBox.Text = "";
            }

            catch
            {

            }

        }
    }
}
