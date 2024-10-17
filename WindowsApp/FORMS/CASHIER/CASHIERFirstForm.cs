using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp.FORMS.CASHIER
{
    public partial class CASHIERFirstForm : Form
    {
        public CASHIERFirstForm()
        {
            InitializeComponent();
            Cashierdashboard.Visible = true;
        }

        public void LoadCashierForms(object Form)
        {
            if (this.Cashierdashboard.Controls.Count > 0)
                this.Cashierdashboard.Controls.Clear();

            Form f = (Form)Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Cashierdashboard.Controls.Add(f);
            this.Cashierdashboard.Tag = f;
            f.Show();
        }

        private void BTNPOS_Click(object sender, EventArgs e)
        {
            LoadCashierForms(new MainForm());
        }

        private void BTNTRANSAC_Click(object sender, EventArgs e)
        {
            LoadCashierForms(new TransactionForm());
        }

        private void BTNPRODUCTS_Click(object sender, EventArgs e)
        {
            LoadCashierForms(new Productform());
        }

        private void BTNLOGOUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
