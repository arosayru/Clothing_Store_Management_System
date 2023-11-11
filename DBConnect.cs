using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clothing_Store_Management_System
{
    class DBConnect
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private string cn;

        public string connection()
        {
            cn = @"Data Source=LAPTOP-EFLMRV8G\SQLEXPRESS;Initial Catalog=ClothingStore;Integrated Security=True; Connect Timeout = 30";
            return cn;
        }

        public void executeQuery(string sql) 
        {
            try
            {
                con.ConnectionString = connection();
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
