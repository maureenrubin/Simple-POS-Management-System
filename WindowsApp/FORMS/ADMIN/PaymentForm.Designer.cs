namespace WindowsApp.FORMS
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbPaypal = new System.Windows.Forms.RadioButton();
            this.rbGcash = new System.Windows.Forms.RadioButton();
            this.PayBTN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.CancelPayBTN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(37, 251);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(249, 25);
            this.txtAmount.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 91);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "DAJAM\'S PAYMENT METHOD";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(358, 251);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(249, 25);
            this.txtAccountNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(34, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(355, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account Number:";
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCash.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.Location = new System.Drawing.Point(124, 329);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(55, 21);
            this.rbCash.TabIndex = 5;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbPaypal
            // 
            this.rbPaypal.AutoSize = true;
            this.rbPaypal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPaypal.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaypal.Image = ((System.Drawing.Image)(resources.GetObject("rbPaypal.Image")));
            this.rbPaypal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbPaypal.Location = new System.Drawing.Point(402, 320);
            this.rbPaypal.Name = "rbPaypal";
            this.rbPaypal.Size = new System.Drawing.Size(97, 30);
            this.rbPaypal.TabIndex = 6;
            this.rbPaypal.TabStop = true;
            this.rbPaypal.Text = "      PayPal";
            this.rbPaypal.UseVisualStyleBackColor = true;
            // 
            // rbGcash
            // 
            this.rbGcash.AutoSize = true;
            this.rbGcash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbGcash.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGcash.Image = ((System.Drawing.Image)(resources.GetObject("rbGcash.Image")));
            this.rbGcash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbGcash.Location = new System.Drawing.Point(254, 324);
            this.rbGcash.Name = "rbGcash";
            this.rbGcash.Size = new System.Drawing.Size(99, 30);
            this.rbGcash.TabIndex = 7;
            this.rbGcash.TabStop = true;
            this.rbGcash.Text = "       GCash";
            this.rbGcash.UseVisualStyleBackColor = true;
            // 
            // PayBTN
            // 
            this.PayBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayBTN.Location = new System.Drawing.Point(107, 401);
            this.PayBTN.Name = "PayBTN";
            this.PayBTN.Size = new System.Drawing.Size(198, 30);
            this.PayBTN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PayBTN.StateCommon.Border.Rounding = 10;
            this.PayBTN.TabIndex = 8;
            this.PayBTN.Values.Text = "Pay";
            this.PayBTN.Click += new System.EventHandler(this.PayBTN_Click);
            // 
            // CancelPayBTN
            // 
            this.CancelPayBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelPayBTN.Location = new System.Drawing.Point(335, 401);
            this.CancelPayBTN.Name = "CancelPayBTN";
            this.CancelPayBTN.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.CancelPayBTN.Size = new System.Drawing.Size(198, 30);
            this.CancelPayBTN.StateCommon.Border.Color1 = System.Drawing.Color.Red;
            this.CancelPayBTN.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.CancelPayBTN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CancelPayBTN.StateCommon.Border.Rounding = 10;
            this.CancelPayBTN.StateNormal.Back.Color1 = System.Drawing.Color.LightCoral;
            this.CancelPayBTN.StateNormal.Back.Color2 = System.Drawing.Color.LightCoral;
            this.CancelPayBTN.TabIndex = 9;
            this.CancelPayBTN.Values.Text = "Cancel";
            this.CancelPayBTN.Click += new System.EventHandler(this.CancelPayBTN_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(29, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Subtotal: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(29, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tax:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(29, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotal.Location = new System.Drawing.Point(126, 175);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 15);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "0000.00";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTax.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTax.Location = new System.Drawing.Point(126, 143);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(53, 15);
            this.lblTax.TabIndex = 14;
            this.lblTax.Text = "0000.00";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSubtotal.Location = new System.Drawing.Point(126, 117);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(53, 15);
            this.lblSubtotal.TabIndex = 13;
            this.lblSubtotal.Text = "0000.00";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 473);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelPayBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PayBTN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rbGcash);
            this.Controls.Add(this.rbPaypal);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAmount);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbPaypal;
        private System.Windows.Forms.RadioButton rbGcash;
        private ComponentFactory.Krypton.Toolkit.KryptonButton PayBTN;
        private ComponentFactory.Krypton.Toolkit.KryptonButton CancelPayBTN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
    }
}