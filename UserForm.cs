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
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string title = "Trendy Threads Management System";
        public UserForm()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.connection());
            LoadUser(GetDr());
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadUser(GetDr());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            UserModule module = new UserModule(this);
            module.ShowDialog();
        }

        public SqlDataReader GetDr()
        {
            return dr;
        }
        private void dataGridView_User_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView_User.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                UserModule module = new UserModule(this);
                module.lbl_uid.Text = dataGridView_User.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txt_name.Text = dataGridView_User.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txt_address.Text = dataGridView_User.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txt_phone.Text = dataGridView_User.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.cmb_role.Text = dataGridView_User.Rows[e.RowIndex].Cells[5].Value.ToString();
                module.dateOfBirth.Text = dataGridView_User.Rows[e.RowIndex].Cells[6].Value.ToString();
                module.txt_password.Text = dataGridView_User.Rows[e.RowIndex].Cells[7].Value.ToString();

                module.btn_save.Enabled = false;
                module.btn_update.Enabled = true;
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure, you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.executeQuery("Delete from [User_table] where u_id like '" + dataGridView_User.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ");
                    MessageBox.Show("User data has been deleted!", title, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            LoadUser(GetDr());
        }

        #region Method
        public void LoadUser(SqlDataReader dr)
        {
            int i = 0;
            dataGridView_User.Rows.Clear();
            cmd = new SqlCommand("select * from [User_table] where concat (u_name, u_address, u_phone, u_dob, u_role) like '%" + txt_search.Text + "%' ", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView_User.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString());
            }
            dr.Close();
            con.Close();
        }

        #endregion Method

        
    }
}
