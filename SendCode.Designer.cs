namespace Clothing_Store_Management_System
{
    partial class SendCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendCode));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_verify_code = new System.Windows.Forms.Label();
            this.txt_verify_code = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_verify = new System.Windows.Forms.Button();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 15);
            this.panel1.TabIndex = 17;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(273, 92);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(534, 30);
            this.txt_email.TabIndex = 33;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(29, 92);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(55, 21);
            this.lbl_email.TabIndex = 34;
            this.lbl_email.Text = "Email";
            // 
            // lbl_verify_code
            // 
            this.lbl_verify_code.AutoSize = true;
            this.lbl_verify_code.Location = new System.Drawing.Point(29, 222);
            this.lbl_verify_code.Name = "lbl_verify_code";
            this.lbl_verify_code.Size = new System.Drawing.Size(118, 21);
            this.lbl_verify_code.TabIndex = 34;
            this.lbl_verify_code.Text = "Verify Code";
            // 
            // txt_verify_code
            // 
            this.txt_verify_code.Location = new System.Drawing.Point(273, 222);
            this.txt_verify_code.Name = "txt_verify_code";
            this.txt_verify_code.Size = new System.Drawing.Size(534, 30);
            this.txt_verify_code.TabIndex = 33;
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Location = new System.Drawing.Point(646, 138);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(161, 53);
            this.btn_send.TabIndex = 35;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_verify
            // 
            this.btn_verify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_verify.BackColor = System.Drawing.Color.Red;
            this.btn_verify.FlatAppearance.BorderSize = 0;
            this.btn_verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verify.ForeColor = System.Drawing.Color.White;
            this.btn_verify.Location = new System.Drawing.Point(646, 270);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(161, 53);
            this.btn_verify.TabIndex = 35;
            this.btn_verify.Text = "Verify";
            this.btn_verify.UseVisualStyleBackColor = false;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
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
            this.btn_close.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_close.Location = new System.Drawing.Point(795, 20);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 33);
            this.btn_close.TabIndex = 32;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // SendCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 364);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_verify_code);
            this.Controls.Add(this.lbl_verify_code);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SendCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        public System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_verify_code;
        public System.Windows.Forms.TextBox txt_verify_code;
        public System.Windows.Forms.Button btn_send;
        public System.Windows.Forms.Button btn_verify;
    }
}