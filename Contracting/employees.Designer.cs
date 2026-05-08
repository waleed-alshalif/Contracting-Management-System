namespace Contracting
{
    partial class employees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employees));
            this.cv_emp = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name_emp = new System.Windows.Forms.TextBox();
            this.phone_emp = new System.Windows.Forms.TextBox();
            this.email_emp = new System.Windows.Forms.TextBox();
            this.reset_emp = new Guna.UI2.WinForms.Guna2Button();
            this.refresh_emp = new Guna.UI2.WinForms.Guna2Button();
            this.update_emp = new Guna.UI2.WinForms.Guna2Button();
            this.delete_emp = new Guna.UI2.WinForms.Guna2Button();
            this.back_emp = new Guna.UI2.WinForms.Guna2Button();
            this.add_emp = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.majer_emp = new System.Windows.Forms.ComboBox();
            this.infor_emp = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.id_emp = new System.Windows.Forms.Label();
            this.sessionid = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infor_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // cv_emp
            // 
            this.cv_emp.BackColor = System.Drawing.Color.Transparent;
            this.cv_emp.BorderColor = System.Drawing.Color.Brown;
            this.cv_emp.BorderRadius = 12;
            this.cv_emp.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.cv_emp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.cv_emp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cv_emp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cv_emp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cv_emp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cv_emp.FillColor = System.Drawing.Color.Silver;
            this.cv_emp.FocusedColor = System.Drawing.Color.Green;
            this.cv_emp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cv_emp.ForeColor = System.Drawing.Color.Black;
            this.cv_emp.Location = new System.Drawing.Point(118, 364);
            this.cv_emp.Name = "cv_emp";
            this.cv_emp.Size = new System.Drawing.Size(318, 47);
            this.cv_emp.TabIndex = 4;
            this.cv_emp.Tag = "4";
            this.cv_emp.Text = "add cv employee";
            this.cv_emp.Click += new System.EventHandler(this.cv_emp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(550, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 58);
            this.label1.TabIndex = 23;
            this.label1.Text = "Employees Informations";
            // 
            // name_emp
            // 
            this.name_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_emp.Location = new System.Drawing.Point(118, 215);
            this.name_emp.Name = "name_emp";
            this.name_emp.Size = new System.Drawing.Size(318, 32);
            this.name_emp.TabIndex = 1;
            this.name_emp.Tag = "1";
            this.name_emp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.name_emp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_emp_KeyPress_1);
            // 
            // phone_emp
            // 
            this.phone_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_emp.Location = new System.Drawing.Point(118, 430);
            this.phone_emp.MaxLength = 9;
            this.phone_emp.Name = "phone_emp";
            this.phone_emp.Size = new System.Drawing.Size(318, 32);
            this.phone_emp.TabIndex = 5;
            this.phone_emp.Tag = "5";
            this.phone_emp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_emp_KeyPress_1);
            // 
            // email_emp
            // 
            this.email_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_emp.Location = new System.Drawing.Point(118, 315);
            this.email_emp.Name = "email_emp";
            this.email_emp.Size = new System.Drawing.Size(318, 32);
            this.email_emp.TabIndex = 3;
            this.email_emp.Tag = "3";
            // 
            // reset_emp
            // 
            this.reset_emp.BackColor = System.Drawing.Color.Transparent;
            this.reset_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reset_emp.BorderColor = System.Drawing.Color.Brown;
            this.reset_emp.BorderRadius = 12;
            this.reset_emp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.reset_emp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.reset_emp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reset_emp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reset_emp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reset_emp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reset_emp.FillColor = System.Drawing.Color.Peru;
            this.reset_emp.FocusedColor = System.Drawing.Color.Green;
            this.reset_emp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_emp.ForeColor = System.Drawing.Color.Black;
            this.reset_emp.Location = new System.Drawing.Point(1099, 482);
            this.reset_emp.Name = "reset_emp";
            this.reset_emp.Size = new System.Drawing.Size(197, 41);
            this.reset_emp.TabIndex = 34;
            this.reset_emp.Tag = "9";
            this.reset_emp.Text = "Reset";
            this.reset_emp.Click += new System.EventHandler(this.reset_emp_Click);
            // 
            // refresh_emp
            // 
            this.refresh_emp.BackColor = System.Drawing.Color.Transparent;
            this.refresh_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refresh_emp.BorderColor = System.Drawing.Color.Brown;
            this.refresh_emp.BorderRadius = 12;
            this.refresh_emp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.refresh_emp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.refresh_emp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refresh_emp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refresh_emp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refresh_emp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refresh_emp.FillColor = System.Drawing.Color.Peru;
            this.refresh_emp.FocusedColor = System.Drawing.Color.Green;
            this.refresh_emp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_emp.ForeColor = System.Drawing.Color.Black;
            this.refresh_emp.Location = new System.Drawing.Point(1312, 482);
            this.refresh_emp.Name = "refresh_emp";
            this.refresh_emp.Size = new System.Drawing.Size(197, 41);
            this.refresh_emp.TabIndex = 36;
            this.refresh_emp.Tag = "10";
            this.refresh_emp.Text = "View CV";
            this.refresh_emp.Click += new System.EventHandler(this.refresh_emp_Click);
            // 
            // update_emp
            // 
            this.update_emp.BackColor = System.Drawing.Color.Transparent;
            this.update_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.update_emp.BorderColor = System.Drawing.Color.Brown;
            this.update_emp.BorderRadius = 12;
            this.update_emp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.update_emp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.update_emp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_emp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_emp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_emp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_emp.FillColor = System.Drawing.Color.Peru;
            this.update_emp.FocusedColor = System.Drawing.Color.Green;
            this.update_emp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_emp.ForeColor = System.Drawing.Color.Black;
            this.update_emp.Location = new System.Drawing.Point(673, 482);
            this.update_emp.Name = "update_emp";
            this.update_emp.Size = new System.Drawing.Size(197, 41);
            this.update_emp.TabIndex = 32;
            this.update_emp.Tag = "7";
            this.update_emp.Text = "Update";
            this.update_emp.Click += new System.EventHandler(this.update_emp_Click);
            // 
            // delete_emp
            // 
            this.delete_emp.BackColor = System.Drawing.Color.Transparent;
            this.delete_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.delete_emp.BorderColor = System.Drawing.Color.Brown;
            this.delete_emp.BorderRadius = 12;
            this.delete_emp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.delete_emp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.delete_emp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_emp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_emp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_emp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_emp.FillColor = System.Drawing.Color.Peru;
            this.delete_emp.FocusedColor = System.Drawing.Color.Green;
            this.delete_emp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_emp.ForeColor = System.Drawing.Color.Black;
            this.delete_emp.Location = new System.Drawing.Point(886, 482);
            this.delete_emp.Name = "delete_emp";
            this.delete_emp.Size = new System.Drawing.Size(197, 41);
            this.delete_emp.TabIndex = 33;
            this.delete_emp.Tag = "8";
            this.delete_emp.Text = "Delete";
            this.delete_emp.Click += new System.EventHandler(this.delete_emp_Click);
            // 
            // back_emp
            // 
            this.back_emp.BackColor = System.Drawing.Color.Transparent;
            this.back_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.back_emp.BorderColor = System.Drawing.Color.Brown;
            this.back_emp.BorderRadius = 12;
            this.back_emp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.back_emp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.back_emp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back_emp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back_emp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back_emp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back_emp.FillColor = System.Drawing.Color.Peru;
            this.back_emp.FocusedColor = System.Drawing.Color.Green;
            this.back_emp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_emp.ForeColor = System.Drawing.Color.Black;
            this.back_emp.Location = new System.Drawing.Point(1525, 482);
            this.back_emp.Name = "back_emp";
            this.back_emp.Size = new System.Drawing.Size(197, 41);
            this.back_emp.TabIndex = 35;
            this.back_emp.Text = "Back";
            this.back_emp.Click += new System.EventHandler(this.back_emp_Click);
            // 
            // add_emp
            // 
            this.add_emp.BackColor = System.Drawing.Color.Transparent;
            this.add_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add_emp.BorderColor = System.Drawing.Color.Brown;
            this.add_emp.BorderRadius = 12;
            this.add_emp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.add_emp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.add_emp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_emp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_emp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_emp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_emp.FillColor = System.Drawing.Color.Peru;
            this.add_emp.FocusedColor = System.Drawing.Color.Green;
            this.add_emp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_emp.ForeColor = System.Drawing.Color.Black;
            this.add_emp.Location = new System.Drawing.Point(460, 482);
            this.add_emp.Name = "add_emp";
            this.add_emp.Size = new System.Drawing.Size(197, 41);
            this.add_emp.TabIndex = 6;
            this.add_emp.Tag = "6";
            this.add_emp.Text = "Add";
            this.add_emp.Click += new System.EventHandler(this.add_emp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "CV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 39;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 40;
            this.label5.Text = "Majer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 29);
            this.label6.TabIndex = 41;
            this.label6.Text = "Phone";
            // 
            // majer_emp
            // 
            this.majer_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.majer_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majer_emp.FormattingEnabled = true;
            this.majer_emp.Items.AddRange(new object[] {
            "Engineer",
            "Accountant",
            "Manager"});
            this.majer_emp.Location = new System.Drawing.Point(118, 270);
            this.majer_emp.Name = "majer_emp";
            this.majer_emp.Size = new System.Drawing.Size(318, 30);
            this.majer_emp.TabIndex = 2;
            this.majer_emp.Tag = "2";
            // 
            // infor_emp
            // 
            this.infor_emp.AllowUserToAddRows = false;
            this.infor_emp.AllowUserToDeleteRows = false;
            this.infor_emp.AllowUserToResizeColumns = false;
            this.infor_emp.AllowUserToResizeRows = false;
            this.infor_emp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infor_emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infor_emp.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.infor_emp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infor_emp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.infor_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.infor_emp.DefaultCellStyle = dataGridViewCellStyle1;
            this.infor_emp.Location = new System.Drawing.Point(460, 191);
            this.infor_emp.MultiSelect = false;
            this.infor_emp.Name = "infor_emp";
            this.infor_emp.ReadOnly = true;
            this.infor_emp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.infor_emp.RowHeadersWidth = 55;
            this.infor_emp.RowTemplate.Height = 28;
            this.infor_emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.infor_emp.Size = new System.Drawing.Size(1209, 271);
            this.infor_emp.TabIndex = 40;
            this.infor_emp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infor_emp_CellClick);
            this.infor_emp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infor_emp_CellContentClick_1);
            this.infor_emp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infor_emp_CellDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 29);
            this.label8.TabIndex = 52;
            this.label8.Text = "ID";
            // 
            // id_emp
            // 
            this.id_emp.AutoSize = true;
            this.id_emp.BackColor = System.Drawing.Color.Transparent;
            this.id_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_emp.Location = new System.Drawing.Point(123, 167);
            this.id_emp.Name = "id_emp";
            this.id_emp.Size = new System.Drawing.Size(37, 29);
            this.id_emp.TabIndex = 53;
            this.id_emp.Text = "---";
            // 
            // sessionid
            // 
            this.sessionid.AutoSize = true;
            this.sessionid.BackColor = System.Drawing.Color.Transparent;
            this.sessionid.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionid.ForeColor = System.Drawing.Color.Black;
            this.sessionid.Location = new System.Drawing.Point(285, 0);
            this.sessionid.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.sessionid.Name = "sessionid";
            this.sessionid.Padding = new System.Windows.Forms.Padding(5);
            this.sessionid.Size = new System.Drawing.Size(52, 54);
            this.sessionid.TabIndex = 55;
            this.sessionid.Text = "--";
            this.sessionid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sessionid.Click += new System.EventHandler(this.sessionid_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Button4.BorderColor = System.Drawing.Color.Brown;
            this.guna2Button4.BorderRadius = 12;
            this.guna2Button4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2Button4.FocusedColor = System.Drawing.Color.Green;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.Location = new System.Drawing.Point(213, 57);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(147, 36);
            this.guna2Button4.TabIndex = 60;
            this.guna2Button4.Text = "Mainform";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(90, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 29);
            this.label9.TabIndex = 59;
            this.label9.Text = "To Show";
            // 
            // employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1681, 576);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sessionid);
            this.Controls.Add(this.id_emp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.infor_emp);
            this.Controls.Add(this.majer_emp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reset_emp);
            this.Controls.Add(this.refresh_emp);
            this.Controls.Add(this.update_emp);
            this.Controls.Add(this.delete_emp);
            this.Controls.Add(this.back_emp);
            this.Controls.Add(this.add_emp);
            this.Controls.Add(this.email_emp);
            this.Controls.Add(this.phone_emp);
            this.Controls.Add(this.name_emp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cv_emp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "employees";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infor_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button cv_emp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_emp;
        private System.Windows.Forms.TextBox phone_emp;
        private System.Windows.Forms.TextBox email_emp;
        private Guna.UI2.WinForms.Guna2Button reset_emp;
        private Guna.UI2.WinForms.Guna2Button refresh_emp;
        private Guna.UI2.WinForms.Guna2Button update_emp;
        private Guna.UI2.WinForms.Guna2Button delete_emp;
        private Guna.UI2.WinForms.Guna2Button back_emp;
        private Guna.UI2.WinForms.Guna2Button add_emp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox majer_emp;
        private System.Windows.Forms.DataGridView infor_emp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label id_emp;
        private System.Windows.Forms.Label sessionid;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.Label label9;
    }
}