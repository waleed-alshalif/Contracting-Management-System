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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (press.Value < 100)
            {
                press.Value += 2;
                load.Text = press.Value.ToString() + " %";
            }
            else
            {
                timer1.Stop();

                user_login ma = new user_login();
                ma.Show();


                this.Hide();
            }
        }

        private void laoding_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
