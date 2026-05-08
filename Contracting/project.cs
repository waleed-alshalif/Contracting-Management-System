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
    public partial class project : Form
    {
        public project()
        {
            InitializeComponent();

            contractor_name();
            workfoce_name();
            employee_name();
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
                    string query = "select * from  projects";

                    MySqlCommand comm = new MySqlCommand(query, conn);

                    using (MySqlDataAdapter adp = new MySqlDataAdapter(comm))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        infor_pro.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void contractor_name()
        {
            string connectionString = "server=localhost; user=root; database=contracting; password=";


            string query = "select Contractor_Name from contractors";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        contr_pro.Items.Add(reader.GetString(0));
                    }
                }
            }
        }
        private void workfoce_name()
        {
            string connectionString = "server=localhost; user=root; database=contracting; password=";


            string query = "select Workforce_Name from workforces";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        work_pro.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void employee_name()
        {
            string connectionString = "server=localhost; user=root; database=contracting; password=";


            string query = "select Employee_Name from employees";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        emp_pro.Items.Add(reader.GetString(0));
                    }
                }
            }
        }
        private void project_Load(object sender, EventArgs e)
        {
            if (Session.AdminID == 0)
            {
                
            }
            else
            {
                sessionid.Text = $"Admin ID: {Session.AdminID}";
                back_pro.Visible = false;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void add_pro_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user=root; database=contracting; password=";

            string name_project = name_pro.Text;
            string cost_project = cost_pro.Text;
            string supporting_project = supp_pro.Text;
            string period_project = per_pro.Text;
            string location_project = loca_pro.Text;
            string contractors_names = contr_pro.Text;
            string workforces_names = work_pro.Text;
            string employees_names = emp_pro.Text;

            if (name_pro.Text == string.Empty || cost_pro.Text == string.Empty ||
               supp_pro.Text == string.Empty || per_pro.Text == string.Empty || loca_pro.Text == string.Empty ||
               contr_pro.Text == string.Empty || work_pro.Text == string.Empty || emp_pro.Text == string.Empty)
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
                        string query = "INSERT INTO  projects ( Project_Name , Suppporting_Entity , Location , Project_Period , Cost, Workforce_Name , Employee_Name, Contractor_Name )"
                                                              + "VALUES (@n_p ,@s_p,@L_p ,  @p_p, @c_p , @w_p, @e_p, @co_p)";

                        MySqlCommand command = new MySqlCommand(query, conn);

                        command.Parameters.AddWithValue("@n_p", name_project);
                        command.Parameters.AddWithValue("@s_p", supporting_project);
                        command.Parameters.AddWithValue("@L_p", location_project);
                        command.Parameters.AddWithValue("@p_p", period_project);
                        command.Parameters.AddWithValue("@c_p", cost_project);
                        command.Parameters.AddWithValue("@w_p", workforces_names);
                        command.Parameters.AddWithValue("@e_p", employees_names);
                        command.Parameters.AddWithValue("@co_p", contractors_names);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show($"Ok: Add Your Project is Successfully (*_*)");
                    LoadData();

                }
                catch
                {
                    MessageBox.Show("No : Insert Your Project (-_-)");
                }

            }
        }

        private void name_pro_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cost_pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void supp_pro_TextChanged(object sender, EventArgs e)
        {

        }

        private void contr_pro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void supp_pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void update_pro_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user=root; database=contracting; password=";

            string id_project = id_pro.Text;
            string name_project = name_pro.Text;
            string cost_project = cost_pro.Text;
            string supporting_project = supp_pro.Text;
            string location_project = loca_pro.Text;
            string period_project = per_pro.Text;
            string contractors_names = contr_pro.Text;
            string workforces_names = work_pro.Text;
            string employees_names = emp_pro.Text;

            if (name_pro.Text == string.Empty || cost_pro.Text == string.Empty ||
                supp_pro.Text == string.Empty || per_pro.Text == string.Empty || per_pro.Text == string.Empty || 
                contr_pro.Text == string.Empty || work_pro.Text == string.Empty || emp_pro.Text == string.Empty)
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
                        string query = "UPDATE projects SET Project_Name = @n_p, Suppporting_Entity = @s_p, Location = @L_p,  Project_Period = @p_p, Cost = @c_p, Workforce_Name = @w_p, Employee_Name = @e_p, Contractor_Name = @co_p WHERE Id_project  = @i_p";

                        MySqlCommand command = new MySqlCommand(query, conn);


                        command.Parameters.AddWithValue("@i_p", id_project);
                        command.Parameters.AddWithValue("@n_p", name_project);
                        command.Parameters.AddWithValue("@s_p", supporting_project);
                        command.Parameters.AddWithValue("@L_p", location_project);
                        command.Parameters.AddWithValue("@p_p", period_project);
                        command.Parameters.AddWithValue("@c_p", cost_project);
                        command.Parameters.AddWithValue("@w_p", workforces_names);
                        command.Parameters.AddWithValue("@e_p", employees_names);
                        command.Parameters.AddWithValue("@co_p", contractors_names);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Ok: Update Your Project is Successfully (*_*)");
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("No : Update Your Project (-_-)");
                }
            }
        }

        private void infor_pro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < infor_pro.Rows.Count)
            {

                DataGridViewRow row = infor_pro.Rows[e.RowIndex];

                id_pro.Text = row.Cells["Id_project"].Value.ToString();
                name_pro.Text = row.Cells["Project_Name"].Value.ToString();
                cost_pro.Text = row.Cells["Cost"].Value.ToString();
                supp_pro.Text = row.Cells["Suppporting_Entity"].Value.ToString();
                loca_pro.Text = row.Cells["Location"].Value.ToString();
                per_pro.Text = row.Cells["Project_Period"].Value.ToString();
                contr_pro.Text = row.Cells["Contractor_Name"].Value.ToString();
                work_pro.Text = row.Cells["Employee_Name"].Value.ToString();
                emp_pro.Text = row.Cells["Workforce_Name"].Value.ToString();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            id_pro.Text = string.Empty;
            name_pro.Text = string.Empty;
            cost_pro.Text = string.Empty;
            supp_pro.Text = string.Empty;
            loca_pro.Text = string.Empty;
            per_pro.Text = string.Empty;
            cost_pro.Text = string.Empty;
            emp_pro.Text = string.Empty;
            work_pro.Text = string.Empty;

        }

        private void re_pro_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void delete_pro_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user=root; database=contracting; password="; // Ensure the password is correct
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    string query = "DELETE FROM projects WHERE Project_Name  = @name_de";
                    using (MySqlCommand comm = new MySqlCommand(query, conn))
                    {
                        comm.Parameters.AddWithValue("@name_de", name_pro.Text);

                        conn.Open();
                        int rowsAffected = comm.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Deletion of prject: { name_pro.Text} was successful.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show($"No project found (-_-) ");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                }
            }
        }

        private void per_pro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void infor_pro_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < infor_pro.Rows.Count)
            {

                DataGridViewRow row = infor_pro.Rows[e.RowIndex];

                id_pro.Text = row.Cells["Id_project"].Value.ToString();
                name_pro.Text = row.Cells["Project_Name"].Value.ToString();
                cost_pro.Text = row.Cells["Cost"].Value.ToString();
                supp_pro.Text = row.Cells["Suppporting_Entity"].Value.ToString();
                loca_pro.Text = row.Cells["Location"].Value.ToString();
                per_pro.Text = row.Cells["Project_Period"].Value.ToString();
                contr_pro.Text = row.Cells["Contractor_Name"].Value.ToString();
                work_pro.Text = row.Cells["Workforce_Name"].Value.ToString();
                emp_pro.Text = row.Cells["Employee_Name"].Value.ToString();
            }
        }

        private void back_pro_Click(object sender, EventArgs e)
        {
            main_data_user ma_back = new main_data_user();
            ma_back.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void infor_pro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < infor_pro.Rows.Count)
            {
                
                DataGridViewRow row = infor_pro.Rows[e.RowIndex];

                id_pro.Text = row.Cells["Id_project"].Value.ToString();
                name_pro.Text = row.Cells["Project_Name"].Value.ToString();
                cost_pro.Text = row.Cells["Cost"].Value.ToString();
                supp_pro.Text = row.Cells["Suppporting_Entity"].Value.ToString();
                loca_pro.Text = row.Cells["Location"].Value.ToString();
                per_pro.Text = row.Cells["Project_Period"].Value.ToString();
                contr_pro.Text = row.Cells["Contractor_Name"].Value.ToString();
                work_pro.Text = row.Cells["Employee_Name"].Value.ToString();
                emp_pro.Text = row.Cells["Workforce_Name"].Value.ToString();
            }
        }

        private void emp_pro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void name_pro_TextChanged(object sender, EventArgs e)
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
                back_pro.Visible = false;
                mainform admin = new mainform();
                admin.Show();
                this.Hide();
            }
        }
    }
}
