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
    public partial class ResetPassword : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string title = "Trendy Threads Management System";
        string u_name;
        public ResetPassword(string uname)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.connection());
            u_name = uname;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try 
            {
                if (txt_new_password.Text == txt_con_password.Text)
                {
                    cmd = new SqlCommand("Update [User_table] set u_password = @password where u_name = @uname ", con);
                    cmd.Parameters.AddWithValue("@uname", u_name);
                    cmd.Parameters.AddWithValue("@password", txt_con_password.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password successfully reset", title);

                    LoginForm loginForm = new LoginForm();
                    this.Hide();
                    loginForm.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, title);
            }
            
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
