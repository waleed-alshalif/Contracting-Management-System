using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Contracting
{
    public partial class workforce : Form
    {
        public workforce()
        {
            InitializeComponent();
            LoadData();
        }

        

        private void workforce_Load(object sender, EventArgs e)
        {
            if (Session.AdminID == 0)
            {
               
            }
            else
            {
                sessionid.Text = $"Admin ID: {Session.AdminID}";
                back_work.Visible = false;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void LoadData()
        {
            string connection = "server=localhost; user=root; database=contracting; password=";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "select * from workforces";

                    MySqlCommand comm = new MySqlCommand(query, conn);

                    using (MySqlDataAdapter adp = new MySqlDataAdapter(comm))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        infor_workforce.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occurred while loading data : ", ex.Message);
            }
        }

        private void infor_workforce_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearInputFields()
        {
            id_work.Text = string.Empty;
            name_work.Text = string.Empty;
            majer_work.Text = string.Empty;
            phone_work.Text = string.Empty;
        }

       
        private void id_workforce_TextChanged(object sender, EventArgs e)
        {

            


        }
        private void add_work_Click(object sender, EventArgs e)
        {
 
            string connection = "server=localhost; user=root; database=contracting; password=";

            
            string name_force = name_work.Text;
            string majer_force = majer_work.Text;
            string phone_force = phone_work.Text;

            
         
         if (name_work.Text == string.Empty || majer_work.Text == string.Empty || phone_work.Text == string.Empty)
         {
              MessageBox.Show("Please Enter All Your Data");
         }
         else
         {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connection))
                    {
                        conn.Open();
                        string query = "INSERT INTO workforces (Workforce_Name, Majer, Phone_Number) VALUES (@work, @maj, @pho)";

                        MySqlCommand command = new MySqlCommand(query, conn);

                       
                        command.Parameters.AddWithValue("@work", name_force);
                        command.Parameters.AddWithValue("@maj", majer_force);
                        command.Parameters.AddWithValue("@pho", phone_force);

                        command.ExecuteNonQuery();

                    }

                    MessageBox.Show($"Welcome. {name_work.Text} => Registration Successful (*_*)");
                      LoadData();
                    ClearInputFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Sorry. {name_work.Text} => Registration Failed (-_-)\nError: {ex.Message}");
                }

            }
        }   

        private void delete_work_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user=root; database=contracting; password="; // Ensure the password is correct
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    string query = "DELETE FROM workforces WHERE Workforce_Name = @workforce";
                    using (MySqlCommand comm = new MySqlCommand(query, conn))
                    {
                        comm.Parameters.AddWithValue("@workforce", name_work.Text);
                        conn.Open();
                        int rowsAffected = comm.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Deletion of user: {name_work.Text} was successful.");
                            LoadData();
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show($"No user found with username: {name_work.Text}.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}");
                }

                ClearInputFields();
            }
        }

        private void update_work_Click(object sender, EventArgs e)
        {

            string connection = "server=localhost; user=root; database=contracting; password=";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();

                    string query = $"UPDATE workforces SET Workforce_Name=@name, Majer=@maj, Phone_Number=@pho where id_workforce=@id";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", id_work.Text);
                        command.Parameters.AddWithValue("@name", name_work.Text);
                        command.Parameters.AddWithValue("@maj", majer_work.Text);
                        command.Parameters.AddWithValue("@pho", phone_work.Text);



                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Welcome, {name_work.Text} => Registration Successfully (*_*)");
                LoadData();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void infor_workforce_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < infor_workforce.Rows.Count)
            {
                DataGridViewRow row = infor_workforce.Rows[e.RowIndex];
                id_work.Text = row.Cells["id_workforce"].Value.ToString();
                name_work.Text = row.Cells["Workforce_Name"].Value.ToString();
                majer_work.Text = row.Cells["Majer"].Value.ToString();
                phone_work.Text = row.Cells["Phone_Number"].Value.ToString();

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void back_work_Click(object sender, EventArgs e)
        {
            main_data_user ma_back = new main_data_user();
            ma_back.Show();
            this.Hide();

        }

        private void name_work_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_work_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void majer_work_TextChanged(object sender, EventArgs e)
        {

        }

        private void majer_work_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phone_work_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void infor_workforce_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < infor_workforce.Rows.Count)
            {
                DataGridViewRow row = infor_workforce.Rows[e.RowIndex];
                id_work.Text = row.Cells["id_workforce"].Value.ToString();
                name_work.Text = row.Cells["Workforce_Name"].Value.ToString();
                majer_work.Text = row.Cells["Majer"].Value.ToString();
                phone_work.Text = row.Cells["Phone_Number"].Value.ToString();
            }
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
