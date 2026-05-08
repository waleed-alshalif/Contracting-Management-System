using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Contracting
{
    public partial class mainform : Form
    {
     

        
        public mainform()
        {
            InitializeComponent();

            contractors_count();
            employee_count();
            workforce_count();
            project_count();
            admin_cont();
            user_cont();

        }

        private void contractorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contractors con = new contractors();
            con.Show();
            this.Hide();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employees emp = new employees();
            emp.Show();
            this.Hide();
        }

        private void workforcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workforce wof = new workforce();
            wof.Show();
            this.Hide();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            project pro = new project();
            pro.Show();
            this.Hide();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_signin user = new user_signin();
            user.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void contractorsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            contractors cont = new contractors();
            cont.Show();
            this.Hide();
        }

        private void employeesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            employees emp = new employees();
            emp.Show();
            this.Hide();
        }

        private void workforceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workforce work = new workforce();
            work.Show();
            this.Hide();
        }

        private void projectsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            project pro = new project();
            pro.Show();
            this.Hide();
        }

        private void adminesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_signin admin = new admin_signin();
            admin.Show();
            this.Hide();
        }



       
        private void usersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            user_signin user = new user_signin();
            user.Show();
            this.Hide();
        }


        // Dashbaord 




            //Contractors 
        private void contractors_count()
        {
            string connectionString = "server=localhost; user=root; database=contracting; password=";


            string query = "SELECT  COUNT(Contractor_Name) AS NameCount FROM contractors";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int count = Convert.ToInt32(reader["NameCount"]);
                        count_cont.Text = count.ToString();
                    }
                    reader.Close();
                }
            }
        }

        // Emplooyees  
        private void employee_count()
        {
            string connectionString = "server=localhost; user=root; database=contracting; password=";

            string query = "SELECT  COUNT(Employee_Name) AS NameCount FROM employees";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int count = Convert.ToInt32(reader["NameCount"]);
                        emp_count.Text = count.ToString();
                    }
                    reader.Close();

                }
            }
        }

        // WorkForce  
        private void workforce_count()
        {
            string connectionString = "server=localhost; user=root; database=contracting; password=";

            string query = "SELECT  COUNT(Workforce_Name) AS NameCount FROM workforces";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int count = Convert.ToInt32(reader["NameCount"]);
                        work_count.Text = count.ToString();
                    }
                    reader.Close();
                }
            }
        }


        // Projects  
        private void project_count()
        {
            string connectionString = "server=localhost; user=root; database=contracting; password=";

            string query = "SELECT  COUNT(Project_Name) AS NameCount FROM projects";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int count = Convert.ToInt32(reader["NameCount"]);
                        pro_count.Text = count.ToString();
                    }
                    reader.Close();
                }
            }
        }

        // Admines  
        private void admin_cont()
        {
            string connectionString = "server=localhost; user=root; database=contracting; password=";

            string query = "SELECT  COUNT(Username) AS NameCount FROM admines";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int count = Convert.ToInt32(reader["NameCount"]);
                        admin_count.Text = count.ToString();
                    }
                    reader.Close();
                }
            }
        }
        // users  
        private void user_cont()
        {
            string connectionString = "server=localhost; user=root; database=contracting; password=";

            string query = "SELECT  COUNT(Username) AS NameCount FROM users";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int count = Convert.ToInt32(reader["NameCount"]);
                        user_count.Text = count.ToString();
                    }
                    reader.Close();
                }
            }
        }

        private void count_cont_Click(object sender, EventArgs e)
        {
            contractors_count();
        }

        private void emp_count_Click(object sender, EventArgs e)
        {
            employee_count();
        }

        private void work_count_Click(object sender, EventArgs e)
        {
            workforce_count();
        }

        private void pro_count_Click(object sender, EventArgs e)
        {
            project_count();
        }

        private void admin_count_Click(object sender, EventArgs e)
        {
            admin_cont();
        }

        private void user_count_Click(object sender, EventArgs e)
        {
            user_cont();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            if (Session.AdminID == 0)
            {
                MessageBox.Show("No valid session. Please log in.to the admin login ");
            }
            else
            {
                sessionid.Text = $"Logged in as Admin ID: {Session.AdminID}";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.ClearSession();
            this.Hide();
            admin_login outlog = new admin_login();
            outlog.ShowDialog();
        }

        private void sessionid_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
