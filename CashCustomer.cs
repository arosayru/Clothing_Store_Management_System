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
    public partial class CashCustomer : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string title = "Trendy Threads Management System";
        CashForm cash;
        public CashCustomer(CashForm form)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.connection());
            cash = form;
            LoadCustomer(GetDr());
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
            if (colName == "Choice")
            {
                dbcon.executeQuery("Update [Cash_table] set cus_id = " + dataGridView_Customer.Rows[e.RowIndex].Cells[1].Value.ToString() + " where trans_no = " + cash.lbl_trans_no.Text + " ");
                cash.loadCash();
                this.Dispose();
            }
        }

        #region Method
        public void LoadCustomer(SqlDataReader dr)
        {
            try
            {
                int i = 0;
                dataGridView_Customer.Rows.Clear();
                cmd = new SqlCommand("select cus_id, cus_name, cus_phone from [Customer_table] where cus_name like '%" + txt_search.Text + "%' ", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView_Customer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion Method
    }
}
