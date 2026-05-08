using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Contracting
{
    public partial class admin_signin : Form
    {
        public admin_signin()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {
            string connection = "server=localhost; user=root; database=contracting; password=";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "select * from admines";

                    MySqlCommand comm = new MySqlCommand(query, conn);

                    using (MySqlDataAdapter adp = new MySqlDataAdapter(comm))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        infor_admin.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occurred while loading data : ", ex.Message);
            }
        }


        private bool IsVaildEmailAddress(string email_val)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@(gmail|yahoo)\.com$");
            return regex.IsMatch(email_val);
        }


        private string Generatepasswordrandom(int length)
        {
            const string chars = "123456789";
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



        private void ClearInputFields()
        {
            name_admin.Text = string.Empty;
            pass_admin.Text = string.Empty;
            email_admin.Text = string.Empty;
            phone_admin.Text = string.Empty;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void add_admin_Click(object sender, EventArgs e)
        {

            string connection = "server=localhost; user=root; database=contracting; password=";

            string name = name_admin.Text;
            string pho = phone_admin.Text;
            string email = email_admin.Text;

            string password_admin = Generatepasswordrandom(10);
            string encryptpass_user = EncryptPassword(password_admin);

            if (!IsVaildEmailAddress(email))
            {
                MessageBox.Show("The email must contain @ simple also must 'gmail' or yahoo or com ");
                return;
            }

            string encryptedPassword = EncryptPassword(encryptpass_user);

            if (encryptedPassword == null)
            {
                return;
            }

            if (name_admin.Text == string.Empty || phone_admin.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Full Your Data");
            }
            else
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connection))
                    {
                        conn.Open();
                        string query = "INSERT INTO  admines ( Username , Email , Password , Phone_Number )"
                                                     + "VALUES (  @name ,@ema, @pas, @pho )";

                        MySqlCommand command = new MySqlCommand(query, conn);

                       
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@ema", email);
                        command.Parameters.AddWithValue("@pas", encryptedPassword);
                        command.Parameters.AddWithValue("@pho", pho);

                        command.ExecuteNonQuery();
                    }


                    MessageBox.Show($"Welcome.{name_admin.Text} =>  Registrarion Successfully (*_*)");
                    ClearInputFields();
                    LoadData();
                }
                catch
                {
                    MessageBox.Show($"Sorry .{name_admin.Text} =>  Registrarion Failed (-_-)");
                }
                string senderEmail = "walshalif@gmail.com";
                string senderPassword = "tuhftmgavcaxzkst"; // Your Gmail password

                MailMessage message = new MailMessage();
                message.From = new MailAddress(senderEmail);
                message.To.Add(new MailAddress(email)); // Replace with the recipient's email address


                message.Subject = "Successfully register a Admin in your application";
                message.Body = $"The Add Admin To Your Contracting Application (*_*) , \n\n " +
                               $"There are His Information =>  " +
                               $"\n\n His Name is : {name} . " +
                               $"\n\n His NumberPhone is : {pho} " +
                               $"\n\n His Password is : {password_admin} " +
                               $"\n\n Your Email is : {email} " +
                               $" Thank You Dear ";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = true;

                smtp.Send(message);

                Console.WriteLine("Email sent successfully.");
            }
            ClearInputFields();
            LoadData();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            name_admin.Text = string.Empty;
            pass_admin.Text = string.Empty;
            email_admin.Text = string.Empty;
            phone_admin.Text = string.Empty;
        }

        private void update_admin_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user=root; database=contracting; password=";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "UPDATE admines SET  Username=@name, Phone_Number=@pho, Password=@pass, Email=@ema WHERE Id = @admin_id";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", name_admin.Text);
                        command.Parameters.AddWithValue("@pho", phone_admin.Text);
                        command.Parameters.AddWithValue("@ema", email_admin.Text);
                        command.Parameters.AddWithValue("@pass", pass_admin.Text);
                        command.Parameters.AddWithValue("@admin_id", id_admin.Text);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Welcome, {name_admin.Text} => Registration Successfully (*_*)");

                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            ClearInputFields();
            LoadData();
        }

        private void delete_admin_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user=root; database=contracting; password="; // Ensure the password is correct
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    string query = "DELETE FROM admines WHERE Username = @username";
                    using (MySqlCommand comm = new MySqlCommand(query, conn))
                    {
                        comm.Parameters.AddWithValue("@username", name_admin.Text);

                        conn.Open();
                        int rowsAffected = comm.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Deletion of user: {name_admin.Text} was successful.");
                        }
                        else
                        {
                            MessageBox.Show($"No user found with username: {name_admin.Text}.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                }
                ClearInputFields();
                LoadData();
            }
        }

        private void name_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_admin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phone_admin_TextChanged(object sender, EventArgs e)
        {
        }

        private void phone_admin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void infor_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < infor_admin.Rows.Count)
            {

                DataGridViewRow row = infor_admin.Rows[e.RowIndex];
                name_admin.Text = row.Cells["Username"].Value.ToString();
                email_admin.Text = row.Cells["Email"].Value.ToString();
                phone_admin.Text = row.Cells["Phone_Number"].Value.ToString();
                pass_admin.Text = row.Cells["Password"].Value.ToString();
               
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (Session.AdminID == 0)
            {
                MessageBox.Show(" You Cannot cause you not admin");
            }
            else
            {
                sessionid.Text = $"Admin ID: {Session.AdminID}";
                mainform admin = new mainform();
                admin.Show();
                this.Hide();
            }
        }

        private void infor_admin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < infor_admin.Rows.Count)
            {

                DataGridViewRow row = infor_admin.Rows[e.RowIndex];

                id_admin.Text = row.Cells["Id"].Value.ToString();
                name_admin.Text = row.Cells["Username"].Value.ToString();
                email_admin.Text = row.Cells["Email"].Value.ToString();
                phone_admin.Text = row.Cells["Phone_Number"].Value.ToString();
                pass_admin.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void id_admin_Click(object sender, EventArgs e)
        {

        }

        private void pass_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_signin_Load(object sender, EventArgs e)
        {
            if (Session.AdminID == 0)
            {
            }
            else
            {
                sessionid.Text = $"Admin ID: {Session.AdminID}";
            }
        }
    }
}
