using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contracting
{
    public partial class main_data_user : Form
    {
        public main_data_user()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            contractors con = new contractors();

            con.Show();

            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            workforce wr = new workforce();
            wr.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            project pr = new project();
            pr.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            user_login ur = new user_login();
            ur.Show();
            this.Hide();
        }
    }
}
