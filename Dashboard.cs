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
    public partial class Dashboard : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string title = "Trendy Threads Management System";
        public Dashboard()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.connection());
        }

        #region Method
        public int extractData(string str)
        {
            int data = 0;
            try
            {
                con.Open();
                cmd = new SqlCommand("Select isnull(sum(pro_qty),0) as qty from [Product_table] where pro_category='"+str+"'", con);
                data = int.Parse(cmd.ExecuteScalar().ToString());
                con.Close();
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, title);
            }
            return data;
        }
        #endregion Method

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lbl_shirt.Text = extractData("Shirt").ToString();
            lbl_Tshirt.Text = extractData("T-Shirt").ToString();
            lbl_trouser.Text = extractData("Trouser").ToString();
            lbl_full_suit.Text = extractData("Full Suits").ToString();
            lbl_shoues.Text = extractData("Shoes").ToString();
        }
    }
}
