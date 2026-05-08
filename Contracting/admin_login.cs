using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Contracting
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }
        private int adminID;
        public admin_login(int adminID)
        {
            InitializeComponent();
            this.adminID = adminID;
        }

        private string EncryptPassword(string ecn_pass)
        {
            // using the SHA-236 encryption 
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(ecn_pass);
                byte[] hash = sha256.ComputeHash(bytes);

                return BitConverter.ToString(hash).Replace("-", "");
            }
        }
        private bool IsVaildEmailAddress(string email_val)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@(gmail|yahoo)\.com$");
            return regex.IsMatch(email_val);
        }
           
    private void guna2Button2_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user=root; database=contracting; password=";
            string Email = email_admin.Text;
            string Password = pass_admin.Text;


            if (!IsVaildEmailAddress(Email))
            {
                MessageBox.Show("The email must contain @ simple also must 'gmail' or yahoo or com ");
                return;
            }


            if (email_admin.Text == string.Empty || pass_admin.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Your Data");
            }
            else
            {
                try
                {
                    MessageBox.Show("part one ");
                    string encrptedPassword = EncryptPassword(Password); // Ensure this works
                    using (MySqlConnection conn = new MySqlConnection(connection))
                    {
                        conn.Open();
                      

                        string query = "SELECT Id  FROM admines WHERE Email = @email AND Password = @pass";
                        MySqlCommand comm = new MySqlCommand(query, conn);
                        comm.Parameters.AddWithValue("@email", Email);
                        comm.Parameters.AddWithValue("@pass", encrptedPassword);
                        MessageBox.Show("part two ");

                        object resultObj = comm.ExecuteScalar(); // Fetch AdminID

                        if (resultObj != null && resultObj != DBNull.Value)
                        {

                            MessageBox.Show("part theww");
                            // Successful login, retrieve the AdminID from resultObj
                            if (int.TryParse(resultObj.ToString(), out int adminId))
                            {
                                MessageBox.Show("Login successful! \n\n Welcome Dear...");

                                // Store the AdminID in the session
                                Session.SetAdminID(adminId);

                                // Navigate to the main form
                                this.Hide();
                                using (mainform mf = new mainform())
                                {
                                    mf.ShowDialog();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error: Failed to retrieve Admin ID.");
                            }
                    }
                    else
                    {
                        MessageBox.Show("Error: Incorrect Email or Password. Please try again.");
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
            user_login u_lo = new user_login();
            u_lo.Show();
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

        private void email_admin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
