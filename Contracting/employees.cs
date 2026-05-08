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
    public partial class employees : Form
    {
        public employees()
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
                    string query = "select 	id_employee , Employee_Name ,  Phone_Number , Email , Majer from employees";

                    MySqlCommand comm = new MySqlCommand(query, conn);

                    using (MySqlDataAdapter adp = new MySqlDataAdapter(comm))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        infor_emp.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occurred while loading data : ", ex.Message);
            }
        }

        private void name_emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void majer_emp_TextChanged(object sender, EventArgs e)
        {

        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void employees_Load(object sender, EventArgs e)
        {
            if (Session.AdminID == 0)
            {
              
            }
            else
            {
                sessionid.Text = $"Admin ID: {Session.AdminID}";
                back_emp.Visible = false;

            }
        }

        private bool IsVaildEmailAddress(string email_val)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@(gmail|yahoo)\.com$");
            return regex.IsMatch(email_val);
        }


        private string filePath = string.Empty;
        private string folderPath = "D:\\السنة ثالثة\\Sem ( 5 )\\Virual Programming\\Contracting\\Files\\Employees\\";

        private void cv_emp_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                cv_emp.Text = filePath;

            }
        }
        private void add_emp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {

                string name_employee = name_emp.Text;
                string majer_employee = majer_emp.Text;
                string email_employee = email_emp.Text;
                string phone_employee = phone_emp.Text;



                string fileName = Path.GetFileName(filePath);
                string destinationPath = Path.Combine(folderPath, fileName);



                if (!IsVaildEmailAddress(email_employee))
                {
                    MessageBox.Show("The email must contain @ simple also must 'gmail' or yahoo or com ");
                    return;
                }
                if (name_emp.Text == string.Empty || majer_emp.Text == string.Empty ||
                  email_emp.Text == string.Empty || phone_emp.Text == string.Empty)
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
                        string query = "INSERT INTO employees (Employee_Name, Majer, Phone_Number, Email, CV) " +
                                      "   VALUES (@n_e, @m_e , @p_e , @em_e , @file_path)";

                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            MySqlCommand command = new MySqlCommand(query, connection);


                            command.Parameters.AddWithValue("@n_e", name_employee);
                            command.Parameters.AddWithValue("@m_e", majer_employee);
                            command.Parameters.AddWithValue("@p_e", phone_employee);
                            command.Parameters.AddWithValue("@em_e", email_employee);
                            command.Parameters.AddWithValue("@file_path", destinationPath);
                            command.ExecuteNonQuery();
                            MessageBox.Show("File uploaded And Record are successfully!");
                            LoadData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error :No Add Employee {name_emp.Text} Sorry (-_-)  " + ex.Message);
                    }

                    string senderEmail = "walshalif@gmail.com";
                    string senderPassword = "tuhftmgavcaxzkst"; 

                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(senderEmail);
                    message.To.Add(new MailAddress(email_employee)); 

                    message.Subject = "Welcome to the contracting application !";
                    message.Body = $"Welcome: {name_emp.Text} \n\nto our family at Contracting Company! \n\n" +
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
        }

        private void phone_emp_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void name_emp_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void infor_emp_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void delete_emp_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user=root; database=contracting; password=";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    string query = "DELETE FROM employees WHERE Employee_Name  = @name_employee";
                    using (MySqlCommand comm = new MySqlCommand(query, conn))
                    {
                        comm.Parameters.AddWithValue("@name_employee", name_emp.Text);

                        conn.Open();
                        int rowsAffected = comm.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Deletion of prject: {name_emp.Text} was successful.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show($"No employee found (-_-) ");
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

        

        private void reset_emp_Click(object sender, EventArgs e)
        {
            id_emp.Text = string.Empty;
            name_emp.Text = string.Empty;
            majer_emp.Text = string.Empty;
            email_emp.Text = string.Empty;
            cv_emp.Text = string.Empty;
            phone_emp.Text = string.Empty;
        }

        private void update_emp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                string id_employee = id_emp.Text;
                string name_employee = name_emp.Text;
                string majer_employee = majer_emp.Text;
                string email_employee = email_emp.Text;
                string phone_employee = phone_emp.Text;

                string fileName = Path.GetFileName(filePath);
                string destinationPath = Path.Combine(folderPath, fileName);

                if (!IsVaildEmailAddress(email_employee))
                {
                    MessageBox.Show("The email must contain @ and be of valid format (e.g., gmail, yahoo, etc.)");
                    return;
                }

                if (name_emp.Text == string.Empty || majer_emp.Text == string.Empty ||
                    email_emp.Text == string.Empty || phone_emp.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Full Your Data");
                }
                else
                {
                    try
                    {

                        File.Copy(filePath, destinationPath);
                        string connectionString = "server=localhost; user=root; database=contracting; password=";

                        string query = "UPDATE employees SET Employee_Name = @n_e, Majer = @m_e, Phone_Number = @p_e, " +
                                       "Email = @em_e, CV = @file_path WHERE id_employee = @i_e";

                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            MySqlCommand command = new MySqlCommand(query, connection);

                            command.Parameters.AddWithValue("@n_e", name_employee);
                            command.Parameters.AddWithValue("@m_e", majer_employee);
                            command.Parameters.AddWithValue("@p_e", phone_employee);
                            command.Parameters.AddWithValue("@em_e", email_employee);
                            command.Parameters.AddWithValue("@file_path", destinationPath);
                            command.Parameters.AddWithValue("@i_e", id_employee);

                            command.ExecuteNonQuery();

                            File.Copy(filePath, destinationPath, true);
                            MessageBox.Show("Employee record updated successfully!");
                            LoadData();
                            //  MessageBox.Show("File uploaded successfully!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating employee {name_emp.Text}: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a CV to upload.");
            }

            LoadData();
        }

        private void back_emp_Click(object sender, EventArgs e)
        {
            user_login ul_lo = new user_login();
            ul_lo.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             
        }

        private void infor_emp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void infor_emp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < infor_emp.Rows.Count)
            {

                DataGridViewRow row = infor_emp.Rows[e.RowIndex];

                id_emp.Text = row.Cells["id_employee"].Value.ToString();
                name_emp.Text = row.Cells["Employee_Name"].Value.ToString();
                majer_emp.Text = row.Cells["Majer"].Value.ToString();
                email_emp.Text = row.Cells["Email"].Value.ToString();
               // cv_emp.Text = row.Cells["CV"].Value.ToString();
                phone_emp.Text = row.Cells["Phone_Number"].Value.ToString();
            }
        }

        private void refresh_emp_Click(object sender, EventArgs e)
        {

            string connectionString = "server=localhost; user=root; database=contracting; password=";
            string pdfFilePath = null;

            // Validate that an ID is entered
            if (string.IsNullOrEmpty(id_emp.Text))
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
                    string query = "SELECT CV FROM employees WHERE id_employee = @emp_id";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add the contractor ID as a parameter
                        command.Parameters.AddWithValue("@emp_id", id_emp.Text);

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

        private void sessionid_Click(object sender, EventArgs e)
        {

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




