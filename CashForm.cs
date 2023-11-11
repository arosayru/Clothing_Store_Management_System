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
    public partial class CashForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string title = "Trendy Threads Management System";
        MainForm main;
        private object removeitem;

        public CashForm(MainForm form)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.connection());
            main = form;
            getTransno();
            loadCash();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            CashProduct product = new CashProduct(this);
            product.uname = main.lbl_username.Text;
            product.ShowDialog();
        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            CashCustomer customer = new CashCustomer(this);
            customer.ShowDialog();

            if (MessageBox.Show("Are you sure, you want to cash this product?","Cashing",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                getTransno();
                for (int i=0; i < dataGridView_Cash.Rows.Count; i++)
                {
                    dbcon.executeQuery("Update [Product_table] set pro_qty = pro_qty - " + int.Parse(dataGridView_Cash.Rows[i].Cells[4].Value.ToString()) + " where pro_code like " + dataGridView_Cash.Rows[i].Cells[2].Value.ToString() + " ");
                }
                dataGridView_Cash.Rows.Clear();
            }
        }

        private void dataGridView_Cash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView_Cash.Columns[e.ColumnIndex].Name;
            removeitem:
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure, you want to delete this cash?", "Delete Cash", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.executeQuery("Delete from [Cash_table] where cash_id like '" + dataGridView_Cash.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ");
                    MessageBox.Show("Cash has been deleted!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (colName == "Increase")
            {
                int i = checkProqty(dataGridView_Cash.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (int.Parse(dataGridView_Cash.Rows[e.RowIndex].Cells[4].Value.ToString()) < i)
                {
                    dbcon.executeQuery("Update [Cash_table] set qty = qty + " + 1 + " where cash_id like '" + dataGridView_Cash.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ");
                }
                else
                {
                    MessageBox.Show("Reamaining quantity on hand is" +i+ "!", "Out of stock", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (colName == "Decrease")
            {
                if (int.Parse(dataGridView_Cash.Rows[e.RowIndex].Cells[4].Value.ToString()) == 1)
                {
                    colName = "Delete";
                    goto removeitem;
                }
                dbcon.executeQuery("Update [Cash_table] set qty = qty - " + 1 + " where cash_id like '" + dataGridView_Cash.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ");
            }
            loadCash();
        }

        #region Method
        public void getTransno()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                int count;
                string transno;

                con.Open();
                cmd = new SqlCommand("Select top 1 trans_no from [Cash_table] where trans_no like '" + sdate + "%' order by cash_id DESC", con);
                dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lbl_trans_no.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lbl_trans_no.Text = transno;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, title);
            }
        }

        public void loadCash()
        {
            try
            {
                int i = 0;
                double total = 0;
                dataGridView_Cash.Rows.Clear();
                cmd = new SqlCommand("select cash_id, pro_code, pro_name, qty, price, total, c.cus_name, cashier from [Cash_table] as cash LEFT JOIN [Customer_table] c ON cash.cus_id = c.cus_id where trans_no like " + lbl_trans_no.Text + " ", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView_Cash.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                    total += double.Parse(dr[5].ToString());
                }
                dr.Close();
                con.Close();
                lbl_total.Text = total.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        public int checkProqty(string pcode)
        {
            int i = 0;
            try
            {
                con.Open();
                cmd = new SqlCommand("Select pro_qty from [Product_table] where pro_code like '" + pcode + "' ", con);
                i = int.Parse(cmd.ExecuteScalar().ToString());
                con.Close();
            }
            catch (Exception ex) 
            {
                con.Close();
                MessageBox.Show(ex.Message, title);
            }
            return i;
        }

        #endregion Method
    }
}
