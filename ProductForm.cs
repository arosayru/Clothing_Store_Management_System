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
    public partial class ProductForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string title = "Trendy Threads Management System";
        public ProductForm()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.connection());
            LoadProduct(GetDr());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ProductModule module = new ProductModule(this);
            module.ShowDialog();
        }
        public SqlDataReader GetDr()
        {
            return dr;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadProduct(GetDr());
        }

        private void dataGridView_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView_Product.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                ProductModule module = new ProductModule(this);
                module.lbl_pro_code.Text = dataGridView_Product.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txt_pname.Text = dataGridView_Product.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txt_type.Text = dataGridView_Product.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.cmb_category.Text = dataGridView_Product.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.txt_qty.Text = dataGridView_Product.Rows[e.RowIndex].Cells[5].Value.ToString();
                module.txt_price.Text = dataGridView_Product.Rows[e.RowIndex].Cells[6].Value.ToString();

                module.btn_save.Enabled = false;
                module.btn_update.Enabled = true;
                module.ShowDialog();
            }
            else if(colName == "Delete")
            {
                if(MessageBox.Show("Are you sure, you want to delete this item?","Delete Record", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.executeQuery("Delete from [Product_table] where pro_code like '" + dataGridView_Product.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ");
                    MessageBox.Show("Item has been deleted!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            LoadProduct(GetDr());
        }

        #region Method
        public void LoadProduct(SqlDataReader dr)
        {
            int i = 0;
            dataGridView_Product.Rows.Clear();
            cmd = new SqlCommand("select * from [Product_table] where concat (pro_name, pro_type, pro_category, pro_qty, pro_price) like '%" + txt_search.Text + "%' ", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView_Product.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        #endregion Method
    }
}
