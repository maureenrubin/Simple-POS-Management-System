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
            this.panel2 = new System.Windows.Forms.Panel();
            this.RefreshBTN = new System.Windows.Forms.Button();
            this.ProAddBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchBOX = new System.Windows.Forms.TextBox();
            this.flowLayoutProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flowLayoutProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 669);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.RefreshBTN);
            this.panel2.Controls.Add(this.ProAddBtn);
            this.panel2.Location = new System.Drawing.Point(25, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 103);
            this.panel2.TabIndex = 20;
            // 
            // RefreshBTN
            // 
            this.RefreshBTN.BackColor = System.Drawing.Color.Transparent;
            this.RefreshBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RefreshBTN.FlatAppearance.BorderSize = 0;
            this.RefreshBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBTN.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBTN.ForeColor = System.Drawing.Color.Black;
            this.RefreshBTN.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBTN.Image")));
            this.RefreshBTN.Location = new System.Drawing.Point(14, 59);
            this.RefreshBTN.Name = "RefreshBTN";
            this.RefreshBTN.Size = new System.Drawing.Size(30, 30);
            this.RefreshBTN.TabIndex = 17;
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
            this.ProAddBtn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProAddBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProAddBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProAddBtn.Image")));
            this.ProAddBtn.Location = new System.Drawing.Point(14, 12);
            this.ProAddBtn.Name = "ProAddBtn";
            this.ProAddBtn.Size = new System.Drawing.Size(30, 28);
            this.ProAddBtn.TabIndex = 16;
            this.ProAddBtn.UseVisualStyleBackColor = false;
            this.ProAddBtn.Click += new System.EventHandler(this.ProAddBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.SearchBOX);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1169, 61);
            this.panel3.TabIndex = 21;
            // 
            // SearchBOX
            // 
            this.SearchBOX.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBOX.Location = new System.Drawing.Point(834, 22);
            this.SearchBOX.Name = "SearchBOX";
            this.SearchBOX.Size = new System.Drawing.Size(298, 25);
            this.SearchBOX.TabIndex = 19;
            // 
            // flowLayoutProduct
            // 
            this.flowLayoutProduct.AutoScroll = true;
            this.flowLayoutProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutProduct.Location = new System.Drawing.Point(90, 71);
            this.flowLayoutProduct.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutProduct.Name = "flowLayoutProduct";
            this.flowLayoutProduct.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutProduct.Size = new System.Drawing.Size(1043, 573);
            this.flowLayoutProduct.TabIndex = 15;
            // 
            // Productform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1169, 669);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCTS";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutProduct;
        private System.Windows.Forms.Button ProAddBtn;
        private System.Windows.Forms.Button RefreshBTN;
        private System.Windows.Forms.TextBox SearchBOX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}