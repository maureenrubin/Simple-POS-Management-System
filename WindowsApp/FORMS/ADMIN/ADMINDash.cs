using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp.FORMS
{
    public partial class ADMINDash : Form
    {
        public ADMINDash()
        {
            InitializeComponent();
        }

        private void ADMINDash_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newAppDataSet.Purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.newAppDataSet.Purchase);

        }
    }
}
