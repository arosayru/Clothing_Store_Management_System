using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_Store_Management_System
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string title = "Trendy Threads Management System";
        public LoginForm()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.connection());
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?","Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string _name = "", _role = "";
                con.Open();
                cmd = new SqlCommand("Select u_name, u_role from [User_table] where u_name = @name and u_password = @password", con);
                cmd.Parameters.AddWithValue("@name", txt_username.Text);
                cmd.Parameters.AddWithValue("@password", txt_password.Text);
                dr = cmd.ExecuteReader();
                dr.Read();

                if(dr.HasRows)
                {
                    _name = dr["u_name"].ToString();
                    _role = dr["u_role"].ToString();
                    MessageBox.Show("Welcome " +_name+ " !", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm main = new MainForm();
                    main.lbl_username.Text = _name;
                    main.lbl_role.Text = _role;
                    if (_role == "Admin")
                        main.btn_user.Enabled = true;
                    else if (_role == "Accountant")
                    {
                        main.btn_cash.Enabled = false;
                        main.btn_customers.Enabled = false;
                        main.btn_product.Enabled = false;
                    }
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username and password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) 
            {
                con.Close();
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btn_forgetpassword_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Please contact your HR", "FORGET PASSWORD",MessageBoxButtons.OK, MessageBoxIcon.Information);

            SendCode sendCode = new SendCode(txt_username.Text);
            this.Hide();
            sendCode.ShowDialog();
        }
    }
}
