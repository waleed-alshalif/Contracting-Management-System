using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Contracting
{
    public partial class contractors : Form
    {
        public contractors()
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
                    string query = "select id_contractor, Contractor_Name , Phone_Number , Email , Major from contractors";

                    MySqlCommand comm = new MySqlCommand(query, conn);

                    using (MySqlDataAdapter adp = new MySqlDataAdapter(comm))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        infor_contr.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occurred while loading data : ", ex.Message);
            }
        }
        private void contractors_Load(object sender, EventArgs e)
        {
            if (Session.AdminID == 0)
            {
            }
            else
            {
                sessionid.Text = $"Admin ID: {Session.AdminID}";
                guna2Button2.Visible = false;
            }
        }

        // save the file in the folder
        private string filePath = string.Empty;
        private string folderPath = "D:\\السنة ثالثة\\Sem ( 5 )\\Virual Programming\\Contracting\\Files\\Contractors\\";
        private void cv_cont_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                cv_cont.Text = filePath;

            }
        }

        private bool IsVaildEmailAddress(string email_val)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@(gmail|yahoo)\.com$");
            return regex.IsMatch(email_val);
        }


        private void add_cont_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {

                string name_contractor = name_cont.Text;
                string majer_contractor = majer_cont.Text;
                string email_contractor = email_cont.Text;
                string phone_contractor = phone_cont.Text;
                string fileName = Path.GetFileName(filePath);
                string destinationPath = Path.Combine(folderPath, fileName);

                if (!IsVaildEmailAddress(email_contractor))
                {
                    MessageBox.Show("The email must contain @ simple also must 'gmail' or yahoo or com ");
                    return;
                }

                if (name_cont.Text == string.Empty || majer_cont.Text == string.Empty ||
                  email_cont.Text == string.Empty || phone_cont.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Full Your Data");
                }

                else
                {
                    try
                    {
                        File.Copy(filePath, destinationPath);

                        // Insert file path into database
                        string connectionString = "server=localhost; user=root; database=contracting; password=";

                        string query = "INSERT INTO contractors ( Contractor_Name, Major, Phone_Number, Email, Document) " +
                                      "   VALUES ( @n_c, @m_c , @p_c , @em_c , @file_path)";

                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            MySqlCommand command = new MySqlCommand(query, connection);
                           
                            command.Parameters.AddWithValue("@n_c", name_contractor);
                            command.Parameters.AddWithValue("@m_c", majer_contractor);
                            command.Parameters.AddWithValue("@p_c", phone_contractor);
                            command.Parameters.AddWithValue("@em_c", email_contractor);
                            command.Parameters.AddWithValue("@file_path", destinationPath);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("File uploaded and Record are  successfully!");
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error :No Add Employee {name_cont.Text} Sorry (-_-)  " + ex.Message);
                    }

                    string senderEmail = "walshalif@gmail.com";
                    string senderPassword = "tuhftmgavcaxzkst"; // Your Gmail password

                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(senderEmail);
                    message.To.Add(new MailAddress(email_contractor)); // Replace with the recipient's email address

                    message.Subject = "Welcome to the contracting application !";
                    message.Body = $"Welcome: {name_cont.Text} \n\nto our family at Contracting Company! \n\n" +
                        $" We look forward to working with you to achieve outstanding projects and shared successes.";


                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    smtp.EnableSsl = true;

                    smtp.Send(message);

                    Console.WriteLine("Email sent successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Your CV to upload.");
            }
            LoadData();
            reset_input();
        }

        private void infor_contr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < infor_contr.Rows.Count)
            {

                DataGridViewRow row = infor_contr.Rows[e.RowIndex];

                id_contr.Text = row.Cells["id_contractor"].Value.ToString();
                name_cont.Text = row.Cells["Contractor_Name"].Value.ToString();
                majer_cont.Text = row.Cells["Major"].Value.ToString();
                email_cont.Text = row.Cells["Email"].Value.ToString();
               //cv_cont.Text = row.Cells["Document"].Value.ToString();
                phone_cont.Text = row.Cells["Phone_Number"].Value.ToString();
            }
        }






        private void delete_cont_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user=root; database=contracting; password="; // Ensure the password is correct
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    string query = "DELETE FROM contractors WHERE Contractor_Name  = @name_contr";
                    using (MySqlCommand comm = new MySqlCommand(query, conn))
                    {
                        comm.Parameters.AddWithValue("@name_contr", name_cont.Text);

                        conn.Open();
                        int rowsAffected = comm.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Deletion of contractor : { name_cont.Text} was successful.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show($"No contractor found (-_-) ");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                }
            }
            LoadData();
        }

        private void reset_input()
        {
            
        }
        private void back_cont_Click(object sender, EventArgs e)
        {
            id_contr.Text = string.Empty;
            name_cont.Text = string.Empty;
            cv_cont.Text = string.Empty;
            majer_cont.Text = string.Empty;
            email_cont.Text = string.Empty;
            phone_cont.Text = string.Empty;
        }

        private void update_cont_Click(object sender, EventArgs e)
        {

            string id_contrctor = id_contr.Text;
            string name_contrctor = name_cont.Text;
            string majer_contractor = majer_cont.Text;
            string email_contractor = email_cont.Text;
            string phone_contractor = phone_cont.Text;

            string fileName = Path.GetFileName(filePath);
            string destinationPath = Path.Combine(folderPath, fileName);

            if (!IsVaildEmailAddress(email_contractor))
            {
                MessageBox.Show("The email must contain @ and be of valid format (e.g., gmail, yahoo, etc.)");
                return;
            }

            if (name_cont.Text == string.Empty || majer_cont.Text == string.Empty ||
                email_cont.Text == string.Empty || phone_cont.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Full Your Data");
            }
            else
            {
                try
                {
                    File.Copy(filePath, destinationPath);
                    MessageBox.Show("File uploaded successfully!");
                    string connectionString = "server=localhost; user=root; database=contracting; password=";

                    string query = "UPDATE contractors SET Contractor_Name = @n_c, Major = @m_c, Phone_Number = @p_c, " +
                                   "Email = @em_c, Document = @file_path WHERE id_contractor = @i_c";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(query, connection);

                        command.Parameters.AddWithValue("@i_c", id_contrctor);
                        command.Parameters.AddWithValue("@n_c", name_contrctor);
                        command.Parameters.AddWithValue("@m_c", majer_contractor);
                        command.Parameters.AddWithValue("@p_c", phone_contractor);
                        command.Parameters.AddWithValue("@em_c", email_contractor);
                        command.Parameters.AddWithValue("@file_path", destinationPath);

                        command.ExecuteNonQuery();

                        File.Copy(filePath, destinationPath, true);
                        MessageBox.Show("Contractor record updated successfully!");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Updating Contractor : => :  {name_cont.Text}: {ex.Message}");
                }
                LoadData();
                reset_input();
            }
        }


        private void name_cont_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phone_cont_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            main_data_user ma_back = new main_data_user();
            ma_back.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
        }

        private void infor_contr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < infor_contr.Rows.Count)
            {

                DataGridViewRow row = infor_contr.Rows[e.RowIndex];

                id_contr.Text = row.Cells["id_contractor"].Value.ToString();
                name_cont.Text = row.Cells["Contractor_Name"].Value.ToString();
                majer_cont.Text = row.Cells["Major"].Value.ToString();
                email_cont.Text = row.Cells["Email"].Value.ToString();
               // cv_cont.Text = row.Cells["Document"].Value.ToString();
                phone_cont.Text = row.Cells["Phone_Number"].Value.ToString();
            }
        }





        private void guna2Button1_Click(object sender, EventArgs e)
        {

            string connectionString = "server=localhost; user=root; database=contracting; password=";
            string pdfFilePath = null;

            // Validate that an ID is entered
            if (string.IsNullOrEmpty(id_contr.Text))
            {
                MessageBox.Show("Please enter a valid contractor ID.");
                return;
            }

            // Establish connection to the MySQL database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to get the document (PDF path) based on the contractor ID
                    string query = "SELECT Document FROM contractors WHERE id_contractor = @cont_id";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add the contractor ID as a parameter
                        command.Parameters.AddWithValue("@cont_id", id_contr.Text);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if a result is returned
                            if (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    // Get the PDF file path from the database
                                    pdfFilePath = reader.GetString(0);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No document found for the specified contractor ID.");
                                return;
                            }
                        }
                    }

                    // Now attempt to open the document
                    if (!string.IsNullOrEmpty(pdfFilePath))
                    {
                        OpenPDFFile(pdfFilePath);
                    }
                    else
                    {
                        MessageBox.Show("The document path is empty or invalid.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving the document: " + ex.Message);
                }
            }
        }

        private void OpenPDFFile(string filePath)
        {
            try
            {
                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Open the PDF using the default PDF viewer
                    Process.Start(filePath);
                }
                else
                {
                    MessageBox.Show("The file does not exist at the specified path.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exception (e.g., issues with file opening or file format)
                MessageBox.Show("Failed to open the file: " + ex.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void name_cont_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
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
    }
}
