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
    public partial class CashProduct : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string title = "Trendy Threads Management System";
        public string uname;
        CashForm cash;
        public CashProduct(CashForm form)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.connection());
            cash = form;
            LoadProduct(GetDr());
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dr in dataGridView_Product.Rows)
            {
                bool chkbox = Convert.ToBoolean(dr.Cells["Select"].Value);
                if (chkbox)
                {
                    try
                    {
                        cmd = new SqlCommand("Insert into [Cash_table] (trans_no, pro_code, pro_name, qty, price, cashier) values (@trans_no, @pro_code, @pro_name, @qty, @price, @cashier)", con);
                        cmd.Parameters.AddWithValue("@trans_no",cash.lbl_trans_no.Text);
                        cmd.Parameters.AddWithValue("@pro_code", dr.Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@pro_name", dr.Cells[2].Value.ToString());
                        cmd.Parameters.AddWithValue("@qty", 1);
                        cmd.Parameters.AddWithValue("@price", Convert.ToDouble( dr.Cells[5].Value.ToString()));
                        cmd.Parameters.AddWithValue("@cashier", uname);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex) 
                    {
                        con.Close();
                        MessageBox.Show(ex.Message, title);
                    }
                }
            }
            cash.loadCash();
            this.Dispose();
        }
        public SqlDataReader GetDr()
        {
            return dr;
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadProduct(GetDr());
        }

        #region Method
        public void LoadProduct(SqlDataReader dr)
        {
            int i = 0;
            dataGridView_Product.Rows.Clear();
            cmd = new SqlCommand("select pro_code, pro_name, pro_type, pro_category, pro_price from [Product_table] where concat (pro_name, pro_type, pro_category, pro_qty, pro_price) like '%" + txt_search.Text + "%' and pro_qty > "+0+" ", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView_Product.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            con.Close();
        }

        #endregion Method
    }
}
