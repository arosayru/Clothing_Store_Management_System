using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clothing_Store_Management_System
{
    public partial class UserModule : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string title = "Trendy Threads Management System";

        bool check = false;
        UserForm userForm;
        public UserModule(UserForm user)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.connection());
            userForm = user;
            cmb_role.SelectedIndex = 1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check) 
                {
                    if (MessageBox.Show("Are you sure, you want to register this user?", "User Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("Insert into [User_table] (u_name, u_address, u_phone, u_role, u_dob, u_password) values (@name, @address, @phone, @role, @dob, @password)", con);
                        cmd.Parameters.AddWithValue("@name", txt_name.Text);
                        cmd.Parameters.AddWithValue("@address", txt_address.Text);
                        cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                        cmd.Parameters.AddWithValue("@role", cmb_role.Text);
                        cmd.Parameters.AddWithValue("@dob", dateOfBirth.Value);
                        cmd.Parameters.AddWithValue("@password", txt_password.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("User has been successfully registered!", title);
                        Clear();
                        userForm.LoadUser(userForm.GetDr());
                    }
                }
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure, you want to update this record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("Update [User_table] set u_name = @name, u_address = @address, u_phone = @phone, u_role = @role, u_dob = @dob, u_password = @password where u_id = @id", con);
                        cmd.Parameters.AddWithValue("@id", lbl_uid.Text);
                        cmd.Parameters.AddWithValue("@name", txt_name.Text);
                        cmd.Parameters.AddWithValue("@address", txt_address.Text);
                        cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                        cmd.Parameters.AddWithValue("@role", cmb_role.Text);
                        cmd.Parameters.AddWithValue("@dob", dateOfBirth.Value);
                        cmd.Parameters.AddWithValue("@password", txt_password.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("User data has been successfully updated!", title);
                        Clear();
                        userForm.LoadUser(userForm.GetDr());
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region Method

        public void Clear()
        {
            txt_name.Clear();
            txt_address.Clear();
            txt_phone.Clear();
            txt_password.Clear();
            cmb_role.SelectedIndex = 0;
            dateOfBirth.Value = DateTime.Now;

            btn_update.Enabled = false;
        }

        // to check field and date of birth
        public void CheckField()
        {
            if(string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_address.Text) || string.IsNullOrEmpty(txt_phone.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Required data field!", "Warning");
                return;
            }
            else if (txt_name.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot be number", "Error");
                txt_name.Focus();
                return;
            }
            else if (txt_phone.Text.Length != 10 || txt_phone.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Phone number must have 10 numbers", "Error");
                txt_phone.Focus();
                return;
            }

            if (CheckAge(dateOfBirth.Value) < 18)
            {
                MessageBox.Show("User is under 18 years old!", "Warning");
                return;
            }
            
            

            check = true;
        }

        // to calculate age for under 18
        private static int CheckAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;
            return age;
        }

        #endregion Method
    }
}
