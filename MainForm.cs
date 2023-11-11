using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_Store_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btn_dashboard.PerformClick();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gunaBtn_dashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm());
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            openChildForm(new CashForm(this));
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                this.Dispose();
                login.ShowDialog();
            }
        }

        #region Method
        private Form activeForm =null;
        public void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lbl_title.Text = childForm.Text;
            panel_child.Controls.Add(childForm);
            panel_child.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion Method

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesReport.Cash_table' table. You can move, or remove it, as needed.
            this.cash_tableTableAdapter.Fill(this.salesReport.Cash_table);

            this.reportViewer1.RefreshReport();

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            progress.Invoke((MethodInvoker)delegate
            {
                progress.Text = DateTime.Now.ToString("hh:mm:ss");
                progress.Value = Convert.ToInt32(DateTime.Now.Second);
            });
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
