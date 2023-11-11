namespace Clothing_Store_Management_System
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Cash_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesReport = new Clothing_Store_Management_System.SalesReport();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cash = new Guna.UI2.WinForms.Guna2Button();
            this.btn_product = new Guna.UI2.WinForms.Guna2Button();
            this.btn_user = new Guna.UI2.WinForms.Guna2Button();
            this.btn_customers = new Guna.UI2.WinForms.Guna2Button();
            this.btn_dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_role = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel_child = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel_dash = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.salesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cash_tableTableAdapter = new Clothing_Store_Management_System.SalesReportTableAdapters.Cash_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Cash_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReport)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel_dash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cash_tableBindingSource
            // 
            this.Cash_tableBindingSource.DataMember = "Cash_table";
            this.Cash_tableBindingSource.DataSource = this.salesReport;
            // 
            // salesReport
            // 
            this.salesReport.DataSetName = "SalesReport";
            this.salesReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1241, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(9, 745);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbl_title);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1241, 65);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.lbl_title.Location = new System.Drawing.Point(231, 3);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(932, 50);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Welcome to Trendy Threads Management System";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_close.Location = new System.Drawing.Point(1198, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 42);
            this.btn_close.TabIndex = 0;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.progress);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btn_logout);
            this.panel3.Controls.Add(this.btn_cash);
            this.panel3.Controls.Add(this.btn_product);
            this.panel3.Controls.Add(this.btn_user);
            this.panel3.Controls.Add(this.btn_customers);
            this.panel3.Controls.Add(this.btn_dashboard);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 680);
            this.panel3.TabIndex = 2;
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.Transparent;
            this.progress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.progress.FillOffset = 5;
            this.progress.FillThickness = 15;
            this.progress.Font = new System.Drawing.Font("Century Schoolbook", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress.ForeColor = System.Drawing.Color.White;
            this.progress.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.progress.Location = new System.Drawing.Point(25, 460);
            this.progress.Maximum = 60;
            this.progress.Minimum = 0;
            this.progress.Name = "progress";
            this.progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.progress.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.progress.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.progress.ProgressOffset = 5;
            this.progress.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.progress.ProgressThickness = 15;
            this.progress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progress.ShowText = true;
            this.progress.Size = new System.Drawing.Size(164, 164);
            this.progress.TabIndex = 8;
            this.progress.Text = "00:00:00";
            this.progress.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            this.progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progress.Value = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 460);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(9, 170);
            this.panel5.TabIndex = 7;
            // 
            // btn_logout
            // 
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FillColor = System.Drawing.Color.Transparent;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_logout.ForeColor = System.Drawing.Color.DimGray;
            this.btn_logout.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btn_logout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btn_logout.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_logout.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_logout.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_logout.Location = new System.Drawing.Point(0, 630);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(212, 50);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_cash
            // 
            this.btn_cash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cash.FillColor = System.Drawing.Color.Transparent;
            this.btn_cash.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_cash.ForeColor = System.Drawing.Color.DimGray;
            this.btn_cash.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btn_cash.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btn_cash.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_cash.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_cash.Image = ((System.Drawing.Image)(resources.GetObject("btn_cash.Image")));
            this.btn_cash.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_cash.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_cash.Location = new System.Drawing.Point(0, 410);
            this.btn_cash.Name = "btn_cash";
            this.btn_cash.Size = new System.Drawing.Size(212, 50);
            this.btn_cash.TabIndex = 4;
            this.btn_cash.Text = "Bill";
            this.btn_cash.Click += new System.EventHandler(this.btn_cash_Click);
            // 
            // btn_product
            // 
            this.btn_product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_product.FillColor = System.Drawing.Color.Transparent;
            this.btn_product.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_product.ForeColor = System.Drawing.Color.DimGray;
            this.btn_product.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btn_product.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btn_product.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_product.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btn_product.Image = ((System.Drawing.Image)(resources.GetObject("btn_product.Image")));
            this.btn_product.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_product.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_product.Location = new System.Drawing.Point(0, 360);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(212, 50);
            this.btn_product.TabIndex = 3;
            this.btn_product.Text = "Product";
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_user
            // 
            this.btn_user.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_user.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_user.Enabled = false;
            this.btn_user.FillColor = System.Drawing.Color.Transparent;
            this.btn_user.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_user.ForeColor = System.Drawing.Color.DimGray;
            this.btn_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btn_user.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btn_user.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_user.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btn_user.Image = ((System.Drawing.Image)(resources.GetObject("btn_user.Image")));
            this.btn_user.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_user.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_user.Location = new System.Drawing.Point(0, 310);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(212, 50);
            this.btn_user.TabIndex = 2;
            this.btn_user.Text = "User";
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_customers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_customers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_customers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_customers.FillColor = System.Drawing.Color.Transparent;
            this.btn_customers.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_customers.ForeColor = System.Drawing.Color.DimGray;
            this.btn_customers.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btn_customers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btn_customers.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_customers.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btn_customers.Image = ((System.Drawing.Image)(resources.GetObject("btn_customers.Image")));
            this.btn_customers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_customers.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_customers.Location = new System.Drawing.Point(0, 260);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(212, 50);
            this.btn_customers.TabIndex = 1;
            this.btn_customers.Text = "Customers";
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.FillColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_dashboard.ForeColor = System.Drawing.Color.DimGray;
            this.btn_dashboard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btn_dashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btn_dashboard.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btn_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_dashboard.Image")));
            this.btn_dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_dashboard.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_dashboard.Location = new System.Drawing.Point(0, 210);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(212, 50);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.Click += new System.EventHandler(this.gunaBtn_dashboard_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_role);
            this.panel4.Controls.Add(this.lbl_username);
            this.panel4.Controls.Add(this.guna2CirclePictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 210);
            this.panel4.TabIndex = 0;
            // 
            // lbl_role
            // 
            this.lbl_role.Location = new System.Drawing.Point(21, 174);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(178, 24);
            this.lbl_role.TabIndex = 1;
            this.lbl_role.Text = "role";
            this.lbl_role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_username
            // 
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(21, 119);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(178, 24);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(55, 6);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(101, 96);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // panel_child
            // 
            this.panel_child.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_child.Location = new System.Drawing.Point(212, 65);
            this.panel_child.Name = "panel_child";
            this.panel_child.Size = new System.Drawing.Size(1029, 341);
            this.panel_child.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(212, 406);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1029, 6);
            this.panel6.TabIndex = 4;
            // 
            // panel_dash
            // 
            this.panel_dash.Controls.Add(this.reportViewer1);
            this.panel_dash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dash.Location = new System.Drawing.Point(212, 412);
            this.panel_dash.Name = "panel_dash";
            this.panel_dash.Padding = new System.Windows.Forms.Padding(10);
            this.panel_dash.Size = new System.Drawing.Size(1029, 333);
            this.panel_dash.TabIndex = 5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Cash_tableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Clothing_Store_Management_System.SalesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(149, 14);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(721, 307);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // salesReportBindingSource
            // 
            this.salesReportBindingSource.DataSource = this.salesReport;
            this.salesReportBindingSource.Position = 0;
            // 
            // cash_tableTableAdapter
            // 
            this.cash_tableTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1250, 745);
            this.Controls.Add(this.panel_dash);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel_child);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cash_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReport)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel_dash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel_child;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel_dash;
        private Guna.UI2.WinForms.Guna2Button btn_dashboard;
        public System.Windows.Forms.Label lbl_username;
        public System.Windows.Forms.Label lbl_role;
        public Guna.UI2.WinForms.Guna2Button btn_user;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SalesReport salesReport;
        private System.Windows.Forms.BindingSource salesReportBindingSource;
        private SalesReportTableAdapters.Cash_tableTableAdapter cash_tableTableAdapter;
        private System.Windows.Forms.BindingSource Cash_tableBindingSource;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progress;
        public Guna.UI2.WinForms.Guna2Button btn_cash;
        public Guna.UI2.WinForms.Guna2Button btn_product;
        public Guna.UI2.WinForms.Guna2Button btn_customers;
    }
}