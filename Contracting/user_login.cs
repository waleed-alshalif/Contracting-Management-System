using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Contracting
{
    public partial class user_login : Form
    {
        public user_login()
        {
            InitializeComponent();
        }

        private void user_login_Load(object sender, EventArgs e)
        {

        }
        private string EncryptPassword(string Password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(Password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "");
            }

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user=root; database=contracting; password=";
            string Email = email_user.Text;
            string Password = pass_user.Text;

            if (email_user.Text == string.Empty || pass_user.Text == string.Empty || category_user.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Your Data");
            }
            else
            {
                try
                {
                    string encryptedPassword = EncryptPassword(Password);
                    using (MySqlConnection conn = new MySqlConnection(connection))
                    {
                        conn.Open();

                        string query = "SELECT  COUNT(*)  FROM users WHERE Email = @email AND Password = @pass";

                        MySqlCommand comm = new MySqlCommand(query, conn);

                        comm.Parameters.AddWithValue("@email", Email);

                        comm.Parameters.AddWithValue("@pass", encryptedPassword);

                        object resultObj = comm.ExecuteScalar();

                        if (resultObj != null && resultObj != DBNull.Value)
                        {
                            int result = Convert.ToInt32(resultObj);

                            if (result > 0)
                            {
                                if (category_user.Text == "HR")
                                {
                                    this.Hide();
                                    employees mf = new employees();
                                    mf.ShowDialog();
                                }
                                else if (category_user.Text == "Data Entry")
                                {
                                    this.Hide();
                                    main_data_user mf = new main_data_user();
                                    mf.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("No : select Your Category (-_-)");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error: Password Or Email is Incorrect in the sql code ");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }












        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_login ad_lo = new admin_login();

            ad_lo.Show();

            this.Hide();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To Change The Password ?", "Change Password ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Reset_Password re = new Reset_Password();
                re.Show();
                this.Hide();
            }
        }
    }
}


