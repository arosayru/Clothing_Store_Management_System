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
using System.Net;
using System.Net.Mail;

namespace Clothing_Store_Management_System
{
    public partial class SendCode : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string title = "Trendy Threads Management System";
        string randomCode;
        public static string to;
        string u_name;
        public SendCode(string uname)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.connection());
            u_name = uname;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage mailMessage = new MailMessage();
            to = (txt_email.Text).ToString();
            from = "rosayruwp@gmail.com";
            pass = "aBqwVhSdCGQvPFIN";
            messageBody = "Your reset code is " + randomCode;
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Body = messageBody;
            mailMessage.Subject = "Password reset code";
            SmtpClient smtpClient = new SmtpClient("smtp-relay.brevo.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("Code send successfully", title);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            if (randomCode == (txt_verify_code.Text).ToString()) 
            {
                to = txt_email.Text;
                ResetPassword resetPassword = new ResetPassword(u_name);
                this.Hide();
                resetPassword.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong code", title);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
