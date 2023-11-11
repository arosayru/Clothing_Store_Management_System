namespace Clothing_Store_Management_System
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.txt_new_password = new System.Windows.Forms.TextBox();
            this.lbl_new_password = new System.Windows.Forms.Label();
            this.lbl_con_password = new System.Windows.Forms.Label();
            this.txt_con_password = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 20);
            this.panel1.TabIndex = 18;
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
            this.btn_close.Location = new System.Drawing.Point(792, 27);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 33);
            this.btn_close.TabIndex = 33;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_new_password
            // 
            this.txt_new_password.Location = new System.Drawing.Point(273, 109);
            this.txt_new_password.Name = "txt_new_password";
            this.txt_new_password.PasswordChar = '*';
            this.txt_new_password.Size = new System.Drawing.Size(534, 30);
            this.txt_new_password.TabIndex = 35;
            // 
            // lbl_new_password
            // 
            this.lbl_new_password.AutoSize = true;
            this.lbl_new_password.Location = new System.Drawing.Point(29, 109);
            this.lbl_new_password.Name = "lbl_new_password";
            this.lbl_new_password.Size = new System.Drawing.Size(134, 21);
            this.lbl_new_password.TabIndex = 36;
            this.lbl_new_password.Text = "New Password";
            // 
            // lbl_con_password
            // 
            this.lbl_con_password.AutoSize = true;
            this.lbl_con_password.Location = new System.Drawing.Point(29, 182);
            this.lbl_con_password.Name = "lbl_con_password";
            this.lbl_con_password.Size = new System.Drawing.Size(164, 21);
            this.lbl_con_password.TabIndex = 36;
            this.lbl_con_password.Text = "Confirm Password";
            // 
            // txt_con_password
            // 
            this.txt_con_password.Location = new System.Drawing.Point(273, 182);
            this.txt_con_password.Name = "txt_con_password";
            this.txt_con_password.PasswordChar = '*';
            this.txt_con_password.Size = new System.Drawing.Size(534, 30);
            this.txt_con_password.TabIndex = 35;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(646, 259);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(161, 53);
            this.btn_save.TabIndex = 37;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 364);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_con_password);
            this.Controls.Add(this.lbl_con_password);
            this.Controls.Add(this.txt_new_password);
            this.Controls.Add(this.lbl_new_password);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        public System.Windows.Forms.TextBox txt_new_password;
        private System.Windows.Forms.Label lbl_new_password;
        private System.Windows.Forms.Label lbl_con_password;
        public System.Windows.Forms.TextBox txt_con_password;
        public System.Windows.Forms.Button btn_save;
    }
}