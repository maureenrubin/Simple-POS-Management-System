﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.DATA_ACCESS;
using WindowsApp.MODEL;

namespace WindowsApp.FORMS
{
    public partial class TransactionForm : Form
    {


        public TransactionForm()
        {
            InitializeComponent();
           
            
        }

        private void TransactionForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newAppDataSet1.Purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.newAppDataSet1.Purchase);
            // TODO: This line of code loads data into the 'newAppDataSet1.Purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.newAppDataSet1.Purchase);

        }

    }
   
}
