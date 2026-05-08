using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Contracting
{
    public partial class Reset_Password : Form
    {
        public Reset_Password()
        {
            InitializeComponent();
        }

        private string Generatepasswordrandom(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefjhijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
            var random = new Random();
            return new
                string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //  Encryption the password 
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

        // the button click 
        private void add_admin_Click(object sender, EventArgs e)
        {
            string email = reset_pass.Text;
            updatepassword(email);
            MessageBox.Show("The Password updated and sent seccessfully");
        }

        // move to the form2 
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                user_login ur = new user_login();
                ur.Show();
                this.Hide();
            }
        }
        // check where the email (user || admin) and resert an update the password 
        private void updatepassword(string email)
        {

            string connectionString = "server=localhost; user=root; database=contracting; password=";

            string newpassword = Generatepasswordrandom(10);
            string encryptedPassword = EncryptPassword(newpassword);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string userQuery = $"SELECT COUNT(*) FROM users WHERE Email = '{email}'";
                MySqlCommand userCommand = new MySqlCommand(userQuery, connection);
                object userResult = userCommand.ExecuteScalar();
                int userCount = userResult == DBNull.Value ? 0 : Convert.ToInt32(userResult);


                string adminQuery = $"SELECT COUNT(*) FROM admines WHERE Email = '{email}'";
                MySqlCommand adminCommand = new MySqlCommand(adminQuery, connection);
                object adminResult = adminCommand.ExecuteScalar();
                int adminCount = adminResult == DBNull.Value ? 0 : Convert.ToInt32(adminResult);

                if (userCount > 0)
                {

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = "update users set Password = @newpassword where Email = @email";
                        MySqlCommand comm = new MySqlCommand(query, conn);

                        comm.Parameters.AddWithValue("@newpassword", encryptedPassword);

                        comm.Parameters.AddWithValue("@email", email);


                        try
                        {
                            int rowsAffected = comm.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password updated successfully");
                            }
                            else
                            {
                                MessageBox.Show("No admin found with the provided email.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
                else if (adminCount > 0)
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {

                        conn.Open();

                        string query = "Update  admines set Password = @newpassword where Email = @email";
                        MySqlCommand comm = new MySqlCommand(query, conn);

                        comm.Parameters.AddWithValue("@newpassword", encryptedPassword);

                        comm.Parameters.AddWithValue("@email", email);

                        try
                        {
                            int rowsAffected = comm.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password updated successfully");
                            }
                            else
                            {
                                MessageBox.Show("No admin found with the provided email.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Email Not Found in Users or Admin In Our Application. Exiting application.");
                }

                string senderEmail = "walshalif@gmail.com";
                string senderPassword = "tuhftmgavcaxzkst"; // Your Gmail password

                MailMessage message = new MailMessage();
                message.From = new MailAddress(senderEmail);
                message.To.Add(new MailAddress(email));

                message.Subject = "This is Your New Password (*_*) ";
                message.Body = $"Hi  , \n\n You have been secceefully registered Your New Password is : \n \n {newpassword} \n\n With You Contracting Office";


                // create a new SMTP client and configure it
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = true;

                smtp.Send(message);
            }
        }



        private void new_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void reset_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
