namespace Contracting
{
    partial class user_signin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_signin));
            this.label1 = new System.Windows.Forms.Label();
            this.update_user = new Guna.UI2.WinForms.Guna2Button();
            this.delete_user = new Guna.UI2.WinForms.Guna2Button();
            this.add_user = new Guna.UI2.WinForms.Guna2Button();
            this.infor_user = new System.Windows.Forms.DataGridView();
            this.reset = new Guna.UI2.WinForms.Guna2Button();
            this.email_user = new System.Windows.Forms.TextBox();
            this.name_user = new System.Windows.Forms.TextBox();
            this.phone_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.category_user = new System.Windows.Forms.ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.back = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.id_user = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pass_user = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sessionid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infor_user)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(23, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "Users Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // update_user
            // 
            this.update_user.BackColor = System.Drawing.Color.Transparent;
            this.update_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.update_user.BorderColor = System.Drawing.Color.White;
            this.update_user.BorderRadius = 12;
            this.update_user.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.update_user.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.update_user.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_user.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_user.FillColor = System.Drawing.Color.Orange;
            this.update_user.FocusedColor = System.Drawing.Color.SaddleBrown;
            this.update_user.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_user.ForeColor = System.Drawing.Color.Black;
            this.update_user.Location = new System.Drawing.Point(515, 204);
            this.update_user.Name = "update_user";
            this.update_user.Size = new System.Drawing.Size(172, 57);
            this.update_user.TabIndex = 8;
            this.update_user.Text = "Update";
            this.update_user.Click += new System.EventHandler(this.update_user_Click);
            // 
            // delete_user
            // 
            this.delete_user.BackColor = System.Drawing.Color.Transparent;
            this.delete_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.delete_user.BorderColor = System.Drawing.Color.White;
            this.delete_user.BorderRadius = 12;
            this.delete_user.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.delete_user.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.delete_user.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_user.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_user.FillColor = System.Drawing.Color.Orange;
            this.delete_user.FocusedColor = System.Drawing.Color.SaddleBrown;
            this.delete_user.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_user.ForeColor = System.Drawing.Color.Black;
            this.delete_user.Location = new System.Drawing.Point(294, 204);
            this.delete_user.Name = "delete_user";
            this.delete_user.Size = new System.Drawing.Size(172, 57);
            this.delete_user.TabIndex = 7;
            this.delete_user.Text = "Delete";
            this.delete_user.Click += new System.EventHandler(this.delete_user_Click);
            // 
            // add_user
            // 
            this.add_user.BackColor = System.Drawing.Color.Transparent;
            this.add_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add_user.BorderColor = System.Drawing.Color.White;
            this.add_user.BorderRadius = 12;
            this.add_user.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.add_user.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.add_user.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_user.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_user.FillColor = System.Drawing.Color.Orange;
            this.add_user.FocusedColor = System.Drawing.Color.SaddleBrown;
            this.add_user.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_user.ForeColor = System.Drawing.Color.Black;
            this.add_user.Location = new System.Drawing.Point(73, 204);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(172, 57);
            this.add_user.TabIndex = 6;
            this.add_user.Text = "Add";
            this.add_user.Click += new System.EventHandler(this.add_user_Click);
            // 
            // infor_user
            // 
            this.infor_user.AllowUserToAddRows = false;
            this.infor_user.AllowUserToDeleteRows = false;
            this.infor_user.AllowUserToResizeColumns = false;
            this.infor_user.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.infor_user.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.infor_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infor_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infor_user.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.infor_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infor_user.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.infor_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.infor_user.DefaultCellStyle = dataGridViewCellStyle2;
            this.infor_user.Location = new System.Drawing.Point(12, 498);
            this.infor_user.MultiSelect = false;
            this.infor_user.Name = "infor_user";
            this.infor_user.ReadOnly = true;
            this.infor_user.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.infor_user.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.infor_user.RowHeadersWidth = 55;
            this.infor_user.RowTemplate.Height = 28;
            this.infor_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.infor_user.Size = new System.Drawing.Size(1449, 99);
            this.infor_user.TabIndex = 40;
            this.infor_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infor_user_CellContentClick_3);
            this.infor_user.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infor_user_CellDoubleClick);
            this.infor_user.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.infor_user_RowHeaderMouseClick);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Transparent;
            this.reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reset.BorderColor = System.Drawing.Color.White;
            this.reset.BorderRadius = 12;
            this.reset.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.reset.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reset.FillColor = System.Drawing.Color.Orange;
            this.reset.FocusedColor = System.Drawing.Color.SaddleBrown;
            this.reset.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.Black;
            this.reset.Location = new System.Drawing.Point(736, 204);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(172, 57);
            this.reset.TabIndex = 9;
            this.reset.Text = "Reset";
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // email_user
            // 
            this.email_user.BackColor = System.Drawing.Color.NavajoWhite;
            this.email_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_user.Location = new System.Drawing.Point(172, 98);
            this.email_user.Name = "email_user";
            this.email_user.Size = new System.Drawing.Size(322, 35);
            this.email_user.TabIndex = 2;
            // 
            // name_user
            // 
            this.name_user.BackColor = System.Drawing.Color.NavajoWhite;
            this.name_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_user.Location = new System.Drawing.Point(172, 39);
            this.name_user.Name = "name_user";
            this.name_user.Size = new System.Drawing.Size(322, 35);
            this.name_user.TabIndex = 1;
            this.name_user.TextChanged += new System.EventHandler(this.name_user_TextChanged);
            this.name_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_user_KeyPress);
            // 
            // phone_user
            // 
            this.phone_user.BackColor = System.Drawing.Color.NavajoWhite;
            this.phone_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_user.Location = new System.Drawing.Point(668, 39);
            this.phone_user.MaxLength = 9;
            this.phone_user.Name = "phone_user";
            this.phone_user.Size = new System.Drawing.Size(322, 35);
            this.phone_user.TabIndex = 3;
            this.phone_user.TextChanged += new System.EventHandler(this.phone_user_TextChanged);
            this.phone_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_user_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(48, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(539, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(531, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Category";
            // 
            // category_user
            // 
            this.category_user.BackColor = System.Drawing.Color.NavajoWhite;
            this.category_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_user.FormattingEnabled = true;
            this.category_user.Items.AddRange(new object[] {
            "HR",
            "Data Entry"});
            this.category_user.Location = new System.Drawing.Point(668, 98);
            this.category_user.Name = "category_user";
            this.category_user.Size = new System.Drawing.Size(322, 30);
            this.category_user.TabIndex = 5;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Orange;
            this.guna2Button1.FocusedColor = System.Drawing.Color.SandyBrown;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(957, 204);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(172, 57);
            this.guna2Button1.TabIndex = 55;
            this.guna2Button1.Text = "Refresh";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.back.BorderColor = System.Drawing.Color.White;
            this.back.BorderRadius = 12;
            this.back.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.back.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back.FillColor = System.Drawing.Color.Orange;
            this.back.FocusedColor = System.Drawing.Color.SandyBrown;
            this.back.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(1178, 204);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(172, 57);
            this.back.TabIndex = 56;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(48, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 25);
            this.label8.TabIndex = 59;
            this.label8.Text = "ID";
            this.label8.Visible = false;
            // 
            // id_user
            // 
            this.id_user.AutoSize = true;
            this.id_user.BackColor = System.Drawing.Color.White;
            this.id_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_user.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id_user.Location = new System.Drawing.Point(167, 9);
            this.id_user.Name = "id_user";
            this.id_user.Size = new System.Drawing.Size(44, 25);
            this.id_user.TabIndex = 60;
            this.id_user.Text = "----";
            this.id_user.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1023, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Password";
            this.label5.Visible = false;
            // 
            // pass_user
            // 
            this.pass_user.BackColor = System.Drawing.Color.NavajoWhite;
            this.pass_user.Enabled = false;
            this.pass_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_user.Location = new System.Drawing.Point(1139, 35);
            this.pass_user.Name = "pass_user";
            this.pass_user.PasswordChar = '*';
            this.pass_user.Size = new System.Drawing.Size(211, 35);
            this.pass_user.TabIndex = 4;
            this.pass_user.Visible = false;
            this.pass_user.TextChanged += new System.EventHandler(this.pass_user_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(1164, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "Password is Random";
            this.label9.Visible = false;
            // 
            // sessionid
            // 
            this.sessionid.AutoSize = true;
            this.sessionid.BackColor = System.Drawing.Color.Transparent;
            this.sessionid.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionid.ForeColor = System.Drawing.Color.Black;
            this.sessionid.Location = new System.Drawing.Point(839, -6);
            this.sessionid.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.sessionid.Name = "sessionid";
            this.sessionid.Padding = new System.Windows.Forms.Padding(5);
            this.sessionid.Size = new System.Drawing.Size(34, 36);
            this.sessionid.TabIndex = 62;
            this.sessionid.Text = "--";
            this.sessionid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1443, 609);
            this.Controls.Add(this.sessionid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.id_user);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.back);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.category_user);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phone_user);
            this.Controls.Add(this.name_user);
            this.Controls.Add(this.email_user);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.pass_user);
            this.Controls.Add(this.infor_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_user);
            this.Controls.Add(this.delete_user);
            this.Controls.Add(this.add_user);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "user_signin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user_signin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.user_signin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infor_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button update_user;
        private Guna.UI2.WinForms.Guna2Button delete_user;
        private Guna.UI2.WinForms.Guna2Button add_user;
        private System.Windows.Forms.DataGridView infor_user;
        private Guna.UI2.WinForms.Guna2Button reset;
        private System.Windows.Forms.TextBox email_user;
        private System.Windows.Forms.TextBox name_user;
        private System.Windows.Forms.TextBox phone_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox category_user;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button back;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label id_user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pass_user;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label sessionid;
    }
}