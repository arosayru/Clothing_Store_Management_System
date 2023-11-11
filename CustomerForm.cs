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
    public partial class CustomerForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string title = "Trendy Threads Management System";
        public CustomerForm()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.connection());
            LoadCustomer(GetDr());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            CustomerModule module = new CustomerModule(this);
            module.ShowDialog();
        }
        public SqlDataReader GetDr()
        {
            return dr;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer(GetDr());
        }

        private void dataGridView_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView_Customer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CustomerModule module = new CustomerModule(this);
                module.lbl_cusid.Text = dataGridView_Customer.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txt_cname.Text = dataGridView_Customer.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txt_caddress.Text = dataGridView_Customer.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txt_cphone.Text = dataGridView_Customer.Rows[e.RowIndex].Cells[4].Value.ToString();

                module.btn_save.Enabled = false;
                module.btn_update.Enabled = true;
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure, you want to delete this customer record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.executeQuery("Delete from [Customer_table] where cus_id like '" + dataGridView_Customer.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ");
                    MessageBox.Show("Customer data has been deleted!", title, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            LoadCustomer(GetDr());
        }

        #region Method
        public void LoadCustomer(SqlDataReader dr)
        {
            int i = 0;
            dataGridView_Customer.Rows.Clear();
            cmd = new SqlCommand("select * from [Customer_table] where concat (cus_name, cus_address, cus_phone) like '%" + txt_search.Text + "%' ", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView_Customer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }
        #endregion Method
    }
}
