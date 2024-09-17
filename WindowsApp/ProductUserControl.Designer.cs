namespace WindowsApp
{
    partial class ProductUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUserControl));
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.pb_ProductImage = new System.Windows.Forms.PictureBox();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_ProductName.Location = new System.Drawing.Point(18, 158);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(56, 21);
            this.lbl_ProductName.TabIndex = 1;
            this.lbl_ProductName.Text = " NAME";
            this.lbl_ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_ProductImage
            // 
            this.pb_ProductImage.Location = new System.Drawing.Point(22, 22);
            this.pb_ProductImage.Name = "pb_ProductImage";
            this.pb_ProductImage.Size = new System.Drawing.Size(136, 123);
            this.pb_ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ProductImage.TabIndex = 0;
            this.pb_ProductImage.TabStop = false;
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductPrice.Location = new System.Drawing.Point(23, 189);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(61, 23);
            this.lbl_ProductPrice.TabIndex = 2;
            this.lbl_ProductPrice.Text = "150.00";
            this.lbl_ProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(144, 191);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(25, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.pb_ProductImage);
            this.Controls.Add(this.lbl_ProductName);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(182, 227);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.PictureBox pb_ProductImage;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.Button DeleteButton;
    }
}
