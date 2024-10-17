namespace WindowsApp.FORMS
{
    partial class Productform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RefreshBTN = new System.Windows.Forms.Button();
            this.ProAddBtn = new System.Windows.Forms.Button();
            this.flowLayoutProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutProduct);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 707);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(831, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "DAJAM\'S INVENTORY";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(72, 18);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(349, 30);
            this.Search.TabIndex = 19;
       
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.RefreshBTN);
            this.panel2.Controls.Add(this.ProAddBtn);
            this.panel2.Location = new System.Drawing.Point(1174, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 103);
            this.panel2.TabIndex = 20;
            // 
            // RefreshBTN
            // 
            this.RefreshBTN.BackColor = System.Drawing.Color.Transparent;
            this.RefreshBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RefreshBTN.FlatAppearance.BorderSize = 0;
            this.RefreshBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBTN.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBTN.ForeColor = System.Drawing.Color.Black;
            this.RefreshBTN.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBTN.Image")));
            this.RefreshBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshBTN.Location = new System.Drawing.Point(11, 56);
            this.RefreshBTN.Name = "RefreshBTN";
            this.RefreshBTN.Size = new System.Drawing.Size(150, 30);
            this.RefreshBTN.TabIndex = 17;
            this.RefreshBTN.Text = "     Refresh All";
            this.RefreshBTN.UseVisualStyleBackColor = false;
            this.RefreshBTN.Click += new System.EventHandler(this.RefreshBTN_Click);
            // 
            // ProAddBtn
            // 
            this.ProAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProAddBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ProAddBtn.FlatAppearance.BorderSize = 0;
            this.ProAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProAddBtn.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProAddBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProAddBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProAddBtn.Image")));
            this.ProAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProAddBtn.Location = new System.Drawing.Point(11, 12);
            this.ProAddBtn.Name = "ProAddBtn";
            this.ProAddBtn.Size = new System.Drawing.Size(150, 38);
            this.ProAddBtn.TabIndex = 16;
            this.ProAddBtn.Text = "      Add Product";
            this.ProAddBtn.UseVisualStyleBackColor = false;
            this.ProAddBtn.Click += new System.EventHandler(this.ProAddBtn_Click);
            // 
            // flowLayoutProduct
            // 
            this.flowLayoutProduct.AutoScroll = true;
            this.flowLayoutProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutProduct.Location = new System.Drawing.Point(13, 57);
            this.flowLayoutProduct.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutProduct.Name = "flowLayoutProduct";
            this.flowLayoutProduct.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutProduct.Size = new System.Drawing.Size(1154, 617);
            this.flowLayoutProduct.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(36, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Productform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1350, 701);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCTS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutProduct;
        private System.Windows.Forms.Button ProAddBtn;
        private System.Windows.Forms.Button RefreshBTN;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}