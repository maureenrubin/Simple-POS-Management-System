namespace WindowsApp.CRUDFORMS.PRODUCTEDITFORM
{
    partial class EDITproductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EDITproductsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelBTN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SaveProductBTN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.BrowseBTN = new System.Windows.Forms.Button();
            this.txt_ProductPrice = new System.Windows.Forms.TextBox();
            this.pic_ProductImage = new System.Windows.Forms.PictureBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.CancelBTN);
            this.panel1.Controls.Add(this.SaveProductBTN);
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.BrowseBTN);
            this.panel1.Controls.Add(this.txt_ProductPrice);
            this.panel1.Controls.Add(this.pic_ProductImage);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 361);
            this.panel1.TabIndex = 0;
            // 
            // CancelBTN
            // 
            this.CancelBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBTN.Location = new System.Drawing.Point(454, 246);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(160, 34);
            this.CancelBTN.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CancelBTN.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelBTN.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.CancelBTN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CancelBTN.StateCommon.Border.Rounding = 10;
            this.CancelBTN.StatePressed.Back.Color1 = System.Drawing.Color.Red;
            this.CancelBTN.TabIndex = 14;
            this.CancelBTN.Values.Text = "CANCEL";
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click_1);
            // 
            // SaveProductBTN
            // 
            this.SaveProductBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveProductBTN.Location = new System.Drawing.Point(273, 246);
            this.SaveProductBTN.Name = "SaveProductBTN";
            this.SaveProductBTN.Size = new System.Drawing.Size(160, 34);
            this.SaveProductBTN.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.SaveProductBTN.StateCommon.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.SaveProductBTN.StateCommon.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.SaveProductBTN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SaveProductBTN.StateCommon.Border.Rounding = 10;
            this.SaveProductBTN.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.SaveProductBTN.StatePressed.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.SaveProductBTN.TabIndex = 13;
            this.SaveProductBTN.Values.Text = "SAVE";
            this.SaveProductBTN.Click += new System.EventHandler(this.SaveProductBTN_Click_2);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Image")));
            this.RefreshBtn.Location = new System.Drawing.Point(584, 32);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(30, 23);
            this.RefreshBtn.TabIndex = 12;
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // BrowseBTN
            // 
            this.BrowseBTN.BackColor = System.Drawing.Color.Transparent;
            this.BrowseBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BrowseBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BrowseBTN.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BrowseBTN.Location = new System.Drawing.Point(27, 254);
            this.BrowseBTN.Name = "BrowseBTN";
            this.BrowseBTN.Size = new System.Drawing.Size(213, 26);
            this.BrowseBTN.TabIndex = 11;
            this.BrowseBTN.Text = "OPEN FILE";
            this.BrowseBTN.UseVisualStyleBackColor = false;
            this.BrowseBTN.Click += new System.EventHandler(this.BrowseBTN_Click);
            // 
            // txt_ProductPrice
            // 
            this.txt_ProductPrice.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductPrice.Location = new System.Drawing.Point(395, 149);
            this.txt_ProductPrice.Name = "txt_ProductPrice";
            this.txt_ProductPrice.Size = new System.Drawing.Size(209, 25);
            this.txt_ProductPrice.TabIndex = 8;
            // 
            // pic_ProductImage
            // 
            this.pic_ProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_ProductImage.Location = new System.Drawing.Point(27, 32);
            this.pic_ProductImage.Name = "pic_ProductImage";
            this.pic_ProductImage.Size = new System.Drawing.Size(213, 204);
            this.pic_ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ProductImage.TabIndex = 0;
            this.pic_ProductImage.TabStop = false;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(395, 98);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(209, 25);
            this.txtProductName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "PRODUCT PRICE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRODUCT NAME:";
            // 
            // EDITproductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 361);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EDITproductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_ProductImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txt_ProductPrice;
        private System.Windows.Forms.Button BrowseBTN;
        private System.Windows.Forms.Button RefreshBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SaveProductBTN;
        private ComponentFactory.Krypton.Toolkit.KryptonButton CancelBTN;
    }
}