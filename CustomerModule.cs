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
    public partial class CustomerModule : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string title = "Trendy Threads Management System";

        bool check = false;
        CustomerForm customer;
        public CustomerModule(CustomerForm form)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.connection());
            customer = form;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure, you want to register this customer?", "Customer Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("Insert into [Customer_table] (cus_name, cus_address, cus_phone) values (@cname, @caddress, @cphone)", con);
                        cmd.Parameters.AddWithValue("@cname", txt_cname.Text);
                        cmd.Parameters.AddWithValue("@caddress", txt_caddress.Text);
                        cmd.Parameters.AddWithValue("@cphone", txt_cphone.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Customer has been successfully registered!", title);
                        Clear();
                        customer.LoadCustomer(customer.GetDr());
                    }
                }
            }
            catch (Exception ex)
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
                    if (MessageBox.Show("Are you sure, you want to update record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("Update [Customer_table] set cus_name = @cname, cus_address = @caddress, cus_phone = @cphone where cus_id = @cid", con);
                        cmd.Parameters.AddWithValue("@cid", lbl_cusid.Text);
                        cmd.Parameters.AddWithValue("@cname", txt_cname.Text);
                        cmd.Parameters.AddWithValue("@caddress", txt_caddress.Text);
                        cmd.Parameters.AddWithValue("@cphone", txt_cphone.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Customer data has been successfully updated!", title);
                        Clear();
                        customer.LoadCustomer(customer.GetDr());
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
        public void CheckField()
        {
            if (string.IsNullOrEmpty(txt_cname.Text) || string.IsNullOrEmpty(txt_caddress.Text) || string.IsNullOrEmpty(txt_cphone.Text))
            {
                MessageBox.Show("Required data field!", "Warning");
                return;
            }
            else if (txt_cname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot be number", "Error");
                txt_cname.Focus();
                return;
            }
            else if (txt_cphone.Text.Length != 10 || txt_cphone.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Phone number must have 10 numbers", "Error");
                txt_cphone.Focus();
                return;
            }

            check = true;
        }

        public void Clear()
        {
            txt_cname.Clear();
            txt_caddress.Clear();
            txt_cphone.Clear();

            btn_save.Enabled = true;
            btn_update.Enabled = false;
        }
        #endregion Method
    }
}
