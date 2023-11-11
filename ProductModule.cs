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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Clothing_Store_Management_System
{
    public partial class ProductModule : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string title = "Trendy Threads Management System";
        bool check = false;
        ProductForm product;
        public ProductModule(ProductForm form)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.connection());
            product = form;
            cmb_category.SelectedIndex = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure, you want to register this product?", "Product Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("Insert into [Product_table] (pro_name, pro_type, pro_category, pro_qty, pro_price) values (@pname, @type, @category, @qty, @price)", con);
                        cmd.Parameters.AddWithValue("@pname", txt_pname.Text);
                        cmd.Parameters.AddWithValue("@type", txt_type.Text);
                        cmd.Parameters.AddWithValue("@category", cmb_category.Text);
                        cmd.Parameters.AddWithValue("@qty", int.Parse(txt_qty.Text));
                        cmd.Parameters.AddWithValue("@price", double.Parse(txt_price.Text));

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Product has been successfully registered!", title);
                        Clear();
                        product.LoadProduct(product.GetDr());
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
                    if (MessageBox.Show("Are you sure, you want to update this product?", "Product Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("Update [Product_table] set pro_name = @pname, pro_type = @type, pro_category = @category, pro_qty = @qty, pro_price = @price where pro_code = @code", con);
                        cmd.Parameters.AddWithValue("@code", lbl_pro_code.Text);
                        cmd.Parameters.AddWithValue("@pname", txt_pname.Text);
                        cmd.Parameters.AddWithValue("@type", txt_type.Text);
                        cmd.Parameters.AddWithValue("@category", cmb_category.Text);
                        cmd.Parameters.AddWithValue("@qty", int.Parse(txt_qty.Text));
                        cmd.Parameters.AddWithValue("@price", double.Parse(txt_price.Text));

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Product has been successfully updated!", title);
                        product.LoadProduct(product.GetDr());
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

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow digit number
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow digit number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') >= 1))
            {
                e.Handled = true;
            }
        }

        #region Method
        public void Clear()
        {
            txt_pname.Clear();
            txt_price.Clear();
            txt_qty.Clear();
            txt_type.Clear();
            cmb_category.SelectedIndex = 0;

            btn_update.Enabled = false;
        }

        public void CheckField()
        {
            if (string.IsNullOrEmpty(txt_pname.Text) || string.IsNullOrEmpty(txt_price.Text) || string.IsNullOrEmpty(txt_qty.Text) || string.IsNullOrEmpty(txt_type.Text))
            {
                MessageBox.Show("Required data field!", "Warning");
                return;
            }
            else if (txt_pname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot be number", "Error");
                txt_pname.Focus();
                return;
            }
            else if (txt_type.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Tyoe cannot be number", "Error");
                txt_type.Focus();
                return;
            }

            check = true;
        }

        #endregion Method
    }
}
