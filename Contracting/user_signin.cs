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
    public partial class user_signin : Form
    {
        public void ShowUserButtons(bool visible)
        {
            back.Visible = visible;
        }

        public user_signin()
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
                    string query = "select * from users";

                    MySqlCommand comm = new MySqlCommand(query, conn);

                    using (MySqlDataAdapter adp = new MySqlDataAdapter(comm))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        infor_user.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occurred while loading data : ", ex.Message);
            }
        }

        // Show Data in the Infor_user
        private void infor_user_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < infor_user.Rows.Count)
            {

                DataGridViewRow row = infor_user.Rows[e.RowIndex];

                id_user.Text = row.Cells["Id"].Value.ToString();
                name_user.Text = row.Cells["Username"].Value.ToString();
                category_user.Text = row.Cells["Password"].Value.ToString();
                email_user.Text = row.Cells["Email"].Value.ToString();
                pass_user.Text = row.Cells["Category"].Value.ToString();
                phone_user.Text = row.Cells["Phone_Number"].Value.ToString();
            }
        }

        private void infor_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private bool IsVaildEmailAddress(string email_val)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@(gmail|yahoo)\.com$");
            return regex.IsMatch(email_val);
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



        private void ClearInputFields()
        {
            name_user.Text = string.Empty;
            category_user.Text = string.Empty;
            pass_user.Text = string.Empty;
            email_user.Text = string.Empty;
            phone_user.Text = string.Empty;
        }


        private void add_user_Click(object sender, EventArgs e)
        {

            string connection = "server=localhost; user=root; database=contracting; password=";


            string name = name_user.Text;
            string cate = category_user.Text;
            string pho = phone_user.Text;
            string email = email_user.Text;

            string password_user = Generatepasswordrandom(10);
            string encryptpass_user = EncryptPassword(password_user);

            if (!IsVaildEmailAddress(email))
            {
                MessageBox.Show("The email must contain @ simple also must 'gmail' or yahoo or com ");
                return;
            }


            if (encryptpass_user == null)
            {
                return;
            }

            if (name_user.Text == string.Empty || category_user.Text == string.Empty || phone_user.Text == string.Empty)
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
                        string query = "INSERT INTO  users ( Username, Category , Email , Password , Phone_Number )"
                           + "VALUES (@name,@cate ,@ema, @pas, @pho )";

                        MySqlCommand command = new MySqlCommand(query, conn);


                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@cate", cate);
                        command.Parameters.AddWithValue("@ema", email);
                        command.Parameters.AddWithValue("@pas", encryptpass_user);
                        command.Parameters.AddWithValue("@pho", pho);

                        command.ExecuteNonQuery();

                        MessageBox.Show($"Welcome.{name_user.Text} =>  Registrarion Successfully (*_*)");
                        LoadData();
                        ClearInputFields();
                    }

                }
                catch
                {
                    MessageBox.Show($"Sorry .{name_user.Text} =>  Registrarion Failed (-_-)");
                }


                string senderEmail = "walshalif@gmail.com";
                string senderPassword = "tuhftmgavcaxzkst"; // Your Gmail password

                MailMessage message = new MailMessage();
                message.From = new MailAddress(senderEmail);
                message.To.Add(new MailAddress(email)); // Replace with the recipient's email address


                message.Subject = "Successfully register a user in your application";
                message.Body = $"The Add User To Your Contracting Application (*_*) , \n\n " +
                               $"There are His Information =>  " +
                               $"\n\n His Name is : {name} . " +
                               $"\n\n His NumberPhone is : {pho} " +
                               $"\n\n.His Category is : {cate} . " +
                               $"\n\n His Password is : {password_user} ." +
                               $"\n\n His Eamil is : {email} " +
                               $"thank you dear ";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = true;

                smtp.Send(message);

                Console.WriteLine("Email sent successfully.");

            }
        }



        private void user_signin_Load(object sender, EventArgs e)
        {
            if (Session.AdminID == 0)
            {
              
            }
            else
            {
                sessionid.Text = $"Admin ID: {Session.AdminID}";
    

            }
        }




        private void back_user_Click(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {

            name_user.Text = string.Empty;
            category_user.Text = string.Empty;
            pass_user.Text = string.Empty;
            email_user.Text = string.Empty;
            phone_user.Text = string.Empty;

        }

        private void delete_user_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user=root; database=contracting; password="; // Ensure the password is correct
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    string query = "DELETE FROM users WHERE Username = @username";
                    using (MySqlCommand comm = new MySqlCommand(query, conn))
                    {
                        comm.Parameters.AddWithValue("@username", name_user.Text);

                        conn.Open();
                        int rowsAffected = comm.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Deletion of user: {name_user.Text} was successful.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show($"No user found with username: {name_user.Text}.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                }
            }
        }
        private void infor_user_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void update_user_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user=root; database=contracting; password=";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "UPDATE users SET Username=@name, Category=@cate, Phone_Number=@pho, Password=@pass, Email=@ema WHERE Id=@user_id";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", name_user.Text);
                        command.Parameters.AddWithValue("@cate", category_user.Text);
                        command.Parameters.AddWithValue("@pho", phone_user.Text);
                        command.Parameters.AddWithValue("@pass", pass_user.Text);
                        command.Parameters.AddWithValue("@ema", email_user.Text);
                        command.Parameters.AddWithValue("@user_id", id_user.Text); // Make sure userId is properly set

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Welcome, {name_user.Text} => Registration Successfully (*_*)");
                LoadData();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void name_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phone_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void infor_user_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < infor_user.Rows.Count)
            {

                DataGridViewRow row = infor_user.Rows[e.RowIndex];

                id_user.Text = row.Cells["Id"].Value.ToString();
                name_user.Text = row.Cells["Username"].Value.ToString();
                category_user.Text = row.Cells["Category"].Value.ToString();
                email_user.Text = row.Cells["Email"].Value.ToString();
                pass_user.Text = row.Cells["Password"].Value.ToString();
                phone_user.Text = row.Cells["Phone_Number"].Value.ToString();
            }
        }


        private void pass_user_TextChanged(object sender, EventArgs e)
        {


        }
    }
}

