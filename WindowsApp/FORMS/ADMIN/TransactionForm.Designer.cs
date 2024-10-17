namespace WindowsApp.FORMS
{
    partial class TransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.datagridPurchase = new System.Windows.Forms.DataGridView();
            this.purchaseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addeddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newAppDataSet1 = new WindowsApp.NewAppDataSet();
            this.purchaseTableAdapter = new WindowsApp.NewAppDataSetTableAdapters.PurchaseTableAdapter();
            this.SearchTransac = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAppDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DAJAM\'S PURCHASES TRANSACTIONS";
            // 
            // datagridPurchase
            // 
            this.datagridPurchase.AllowUserToAddRows = false;
            this.datagridPurchase.AllowUserToDeleteRows = false;
            this.datagridPurchase.AllowUserToResizeColumns = false;
            this.datagridPurchase.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.datagridPurchase.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridPurchase.AutoGenerateColumns = false;
            this.datagridPurchase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.datagridPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridPurchase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridPurchase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridPurchase.ColumnHeadersHeight = 35;
            this.datagridPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.cPnoDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.taxDataGridViewTextBoxColumn,
            this.addeddateDataGridViewTextBoxColumn});
            this.datagridPurchase.DataSource = this.purchaseBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridPurchase.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridPurchase.EnableHeadersVisualStyles = false;
            this.datagridPurchase.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.datagridPurchase.Location = new System.Drawing.Point(90, 67);
            this.datagridPurchase.Name = "datagridPurchase";
            this.datagridPurchase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagridPurchase.RowTemplate.Height = 35;
            this.datagridPurchase.RowTemplate.ReadOnly = true;
            this.datagridPurchase.Size = new System.Drawing.Size(1159, 622);
            this.datagridPurchase.TabIndex = 1;
            // 
            // purchaseIDDataGridViewTextBoxColumn
            // 
            this.purchaseIDDataGridViewTextBoxColumn.DataPropertyName = "PurchaseID";
            this.purchaseIDDataGridViewTextBoxColumn.HeaderText = "Purchase ID";
            this.purchaseIDDataGridViewTextBoxColumn.Name = "purchaseIDDataGridViewTextBoxColumn";
            this.purchaseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "Payment Method";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            this.paymentMethodDataGridViewTextBoxColumn.Width = 140;
            // 
            // cPnoDataGridViewTextBoxColumn
            // 
            this.cPnoDataGridViewTextBoxColumn.DataPropertyName = "CPno";
            this.cPnoDataGridViewTextBoxColumn.HeaderText = "Account";
            this.cPnoDataGridViewTextBoxColumn.Name = "cPnoDataGridViewTextBoxColumn";
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "Product Price";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.Width = 110;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // taxDataGridViewTextBoxColumn
            // 
            this.taxDataGridViewTextBoxColumn.DataPropertyName = "Tax";
            this.taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            this.taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            // 
            // addeddateDataGridViewTextBoxColumn
            // 
            this.addeddateDataGridViewTextBoxColumn.DataPropertyName = "added_date";
            this.addeddateDataGridViewTextBoxColumn.HeaderText = "Date Ordered";
            this.addeddateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.addeddateDataGridViewTextBoxColumn.Name = "addeddateDataGridViewTextBoxColumn";
            this.addeddateDataGridViewTextBoxColumn.Width = 140;
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataMember = "Purchase";
            this.purchaseBindingSource.DataSource = this.newAppDataSet1;
            // 
            // newAppDataSet1
            // 
            this.newAppDataSet1.DataSetName = "NewAppDataSet1";
            this.newAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // SearchTransac
            // 
            this.SearchTransac.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTransac.Location = new System.Drawing.Point(854, 25);
            this.SearchTransac.Name = "SearchTransac";
            this.SearchTransac.Size = new System.Drawing.Size(369, 27);
            this.SearchTransac.TabIndex = 2;
            this.SearchTransac.TextChanged += new System.EventHandler(this.SearchTransac_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1217, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 27);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 701);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchTransac);
            this.Controls.Add(this.datagridPurchase);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionForm";
            this.Text = "TransacrionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.datagridPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAppDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addeddateDataGridViewTextBoxColumn;
        private NewAppDataSet newAppDataSet1;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private NewAppDataSetTableAdapters.PurchaseTableAdapter purchaseTableAdapter;
        private System.Windows.Forms.TextBox SearchTransac;
        private System.Windows.Forms.Button button1;
    }
}