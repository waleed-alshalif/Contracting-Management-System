namespace Contracting
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_cont_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.main_emp_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.main_work_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.main_project_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.main_admin_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.main_user_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.count_cont = new System.Windows.Forms.Label();
            this.emp_count = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.work_count = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.user_count = new System.Windows.Forms.Label();
            this.admin_count = new System.Windows.Forms.Label();
            this.pro_count = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sessionid = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(387, 638);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(26, 22, 26, 22);
            this.label4.Size = new System.Drawing.Size(52, 84);
            this.label4.TabIndex = 5;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(210, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(26, 22, 26, 22);
            this.label5.Size = new System.Drawing.Size(527, 88);
            this.label5.TabIndex = 6;
            this.label5.Text = "Welcome In The Contracting Application";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.main_cont_admin,
            this.main_emp_admin,
            this.main_work_admin,
            this.main_project_admin,
            this.main_admin_admin,
            this.main_user_admin});
            this.menuStrip1.Location = new System.Drawing.Point(28, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(21, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(1386, 60);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(96, 48);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // main_cont_admin
            // 
            this.main_cont_admin.ForeColor = System.Drawing.Color.White;
            this.main_cont_admin.Name = "main_cont_admin";
            this.main_cont_admin.Size = new System.Drawing.Size(164, 48);
            this.main_cont_admin.Text = "Contractors";
            this.main_cont_admin.Click += new System.EventHandler(this.contractorsToolStripMenuItem_Click_1);
            // 
            // main_emp_admin
            // 
            this.main_emp_admin.ForeColor = System.Drawing.Color.White;
            this.main_emp_admin.Name = "main_emp_admin";
            this.main_emp_admin.Size = new System.Drawing.Size(149, 48);
            this.main_emp_admin.Text = "Employees";
            this.main_emp_admin.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click_1);
            // 
            // main_work_admin
            // 
            this.main_work_admin.ForeColor = System.Drawing.Color.White;
            this.main_work_admin.Name = "main_work_admin";
            this.main_work_admin.Size = new System.Drawing.Size(159, 48);
            this.main_work_admin.Text = "Workforces";
            this.main_work_admin.Click += new System.EventHandler(this.workforceToolStripMenuItem_Click);
            // 
            // main_project_admin
            // 
            this.main_project_admin.ForeColor = System.Drawing.Color.White;
            this.main_project_admin.Name = "main_project_admin";
            this.main_project_admin.Size = new System.Drawing.Size(126, 48);
            this.main_project_admin.Text = "Projects";
            this.main_project_admin.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click_1);
            // 
            // main_admin_admin
            // 
            this.main_admin_admin.ForeColor = System.Drawing.Color.White;
            this.main_admin_admin.Name = "main_admin_admin";
            this.main_admin_admin.Size = new System.Drawing.Size(126, 48);
            this.main_admin_admin.Text = "Admines";
            this.main_admin_admin.Click += new System.EventHandler(this.adminesToolStripMenuItem_Click);
            // 
            // main_user_admin
            // 
            this.main_user_admin.ForeColor = System.Drawing.Color.White;
            this.main_user_admin.Name = "main_user_admin";
            this.main_user_admin.Size = new System.Drawing.Size(100, 48);
            this.main_user_admin.Text = "Users";
            this.main_user_admin.Click += new System.EventHandler(this.usersToolStripMenuItem_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(599, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(178, 54);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contractors : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // count_cont
            // 
            this.count_cont.AutoSize = true;
            this.count_cont.BackColor = System.Drawing.Color.Transparent;
            this.count_cont.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_cont.ForeColor = System.Drawing.Color.Black;
            this.count_cont.Location = new System.Drawing.Point(770, 227);
            this.count_cont.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.count_cont.Name = "count_cont";
            this.count_cont.Padding = new System.Windows.Forms.Padding(5);
            this.count_cont.Size = new System.Drawing.Size(42, 54);
            this.count_cont.TabIndex = 9;
            this.count_cont.Text = "..";
            this.count_cont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.count_cont.Click += new System.EventHandler(this.count_cont_Click);
            // 
            // emp_count
            // 
            this.emp_count.AutoSize = true;
            this.emp_count.BackColor = System.Drawing.Color.Transparent;
            this.emp_count.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_count.ForeColor = System.Drawing.Color.Black;
            this.emp_count.Location = new System.Drawing.Point(770, 281);
            this.emp_count.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.emp_count.Name = "emp_count";
            this.emp_count.Padding = new System.Windows.Forms.Padding(5);
            this.emp_count.Size = new System.Drawing.Size(42, 54);
            this.emp_count.TabIndex = 11;
            this.emp_count.Text = "..";
            this.emp_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emp_count.Click += new System.EventHandler(this.emp_count_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(598, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(156, 54);
            this.label7.TabIndex = 10;
            this.label7.Text = "Employees: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // work_count
            // 
            this.work_count.AutoSize = true;
            this.work_count.BackColor = System.Drawing.Color.Transparent;
            this.work_count.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.work_count.ForeColor = System.Drawing.Color.Black;
            this.work_count.Location = new System.Drawing.Point(770, 335);
            this.work_count.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.work_count.Name = "work_count";
            this.work_count.Padding = new System.Windows.Forms.Padding(5);
            this.work_count.Size = new System.Drawing.Size(42, 54);
            this.work_count.TabIndex = 13;
            this.work_count.Text = "..";
            this.work_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.work_count.Click += new System.EventHandler(this.work_count_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(598, 335);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(157, 54);
            this.label9.TabIndex = 12;
            this.label9.Text = "WorkForce :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(599, 494);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(114, 54);
            this.label6.TabIndex = 16;
            this.label6.Text = "Users : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(599, 440);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(94, 54);
            this.label8.TabIndex = 15;
            this.label8.Text = "Admin";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(599, 386);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5);
            this.label10.Size = new System.Drawing.Size(127, 54);
            this.label10.TabIndex = 14;
            this.label10.Text = "Project : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_count
            // 
            this.user_count.AutoSize = true;
            this.user_count.BackColor = System.Drawing.Color.Transparent;
            this.user_count.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_count.ForeColor = System.Drawing.Color.Black;
            this.user_count.Location = new System.Drawing.Point(770, 494);
            this.user_count.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.user_count.Name = "user_count";
            this.user_count.Padding = new System.Windows.Forms.Padding(5);
            this.user_count.Size = new System.Drawing.Size(42, 54);
            this.user_count.TabIndex = 19;
            this.user_count.Text = "..";
            this.user_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user_count.Click += new System.EventHandler(this.user_count_Click);
            // 
            // admin_count
            // 
            this.admin_count.AutoSize = true;
            this.admin_count.BackColor = System.Drawing.Color.Transparent;
            this.admin_count.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_count.ForeColor = System.Drawing.Color.Black;
            this.admin_count.Location = new System.Drawing.Point(770, 440);
            this.admin_count.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.admin_count.Name = "admin_count";
            this.admin_count.Padding = new System.Windows.Forms.Padding(5);
            this.admin_count.Size = new System.Drawing.Size(42, 54);
            this.admin_count.TabIndex = 18;
            this.admin_count.Text = "..";
            this.admin_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.admin_count.Click += new System.EventHandler(this.admin_count_Click);
            // 
            // pro_count
            // 
            this.pro_count.AutoSize = true;
            this.pro_count.BackColor = System.Drawing.Color.Transparent;
            this.pro_count.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_count.ForeColor = System.Drawing.Color.Black;
            this.pro_count.Location = new System.Drawing.Point(770, 386);
            this.pro_count.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.pro_count.Name = "pro_count";
            this.pro_count.Padding = new System.Windows.Forms.Padding(5);
            this.pro_count.Size = new System.Drawing.Size(42, 54);
            this.pro_count.TabIndex = 17;
            this.pro_count.Text = "..";
            this.pro_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pro_count.Click += new System.EventHandler(this.pro_count_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(365, 185);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5);
            this.label11.Size = new System.Drawing.Size(411, 54);
            this.label11.TabIndex = 20;
            this.label11.Text = "The Contacting Application Include : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sessionid
            // 
            this.sessionid.AutoSize = true;
            this.sessionid.BackColor = System.Drawing.Color.Transparent;
            this.sessionid.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionid.ForeColor = System.Drawing.Color.Black;
            this.sessionid.Location = new System.Drawing.Point(829, 112);
            this.sessionid.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.sessionid.Name = "sessionid";
            this.sessionid.Padding = new System.Windows.Forms.Padding(5);
            this.sessionid.Size = new System.Drawing.Size(36, 38);
            this.sessionid.TabIndex = 22;
            this.sessionid.Text = "--";
            this.sessionid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sessionid.Click += new System.EventHandler(this.sessionid_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(173, 227);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 29);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log-out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(218, 50);
            this.label1.TabIndex = 24;
            this.label1.Text = "For Exit Application ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1442, 764);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.sessionid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.user_count);
            this.Controls.Add(this.admin_count);
            this.Controls.Add(this.pro_count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.work_count);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.emp_count);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.count_cont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainform";
            this.Padding = new System.Windows.Forms.Padding(28, 24, 28, 24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem main_cont_admin;
        private System.Windows.Forms.ToolStripMenuItem main_emp_admin;
        private System.Windows.Forms.ToolStripMenuItem main_work_admin;
        private System.Windows.Forms.ToolStripMenuItem main_project_admin;
        private System.Windows.Forms.ToolStripMenuItem main_admin_admin;
        private System.Windows.Forms.ToolStripMenuItem main_user_admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label count_cont;
        private System.Windows.Forms.Label emp_count;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label work_count;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label user_count;
        private System.Windows.Forms.Label admin_count;
        private System.Windows.Forms.Label pro_count;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label sessionid;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}