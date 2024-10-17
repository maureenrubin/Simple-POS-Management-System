namespace WindowsApp.FORMS
{
    partial class ForgotPassForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCaancel = new System.Windows.Forms.Button();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtResetToken = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtNewPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ResetPasswordBTN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowPassCheck = new System.Windows.Forms.CheckBox();
            this.RequestResetPassBTN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(182, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "RESET PASSWORD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCaancel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 108);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(240, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "ADMIN";
            // 
            // btnCaancel
            // 
            this.btnCaancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCaancel.FlatAppearance.BorderSize = 0;
            this.btnCaancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaancel.Location = new System.Drawing.Point(549, 3);
            this.btnCaancel.Name = "btnCaancel";
            this.btnCaancel.Size = new System.Drawing.Size(14, 20);
            this.btnCaancel.TabIndex = 11;
            this.btnCaancel.Text = "X";
            this.btnCaancel.UseVisualStyleBackColor = false;
            this.btnCaancel.Click += new System.EventHandler(this.btnCaancel_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Location = new System.Drawing.Point(143, 164);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(276, 29);
            this.txtUsername.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateCommon.Border.Rounding = 7;
            this.txtUsername.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.TabIndex = 8;
            // 
            // txtResetToken
            // 
            this.txtResetToken.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResetToken.Location = new System.Drawing.Point(143, 241);
            this.txtResetToken.Name = "txtResetToken";
            this.txtResetToken.PasswordChar = '•';
            this.txtResetToken.Size = new System.Drawing.Size(276, 29);
            this.txtResetToken.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtResetToken.StateCommon.Border.Rounding = 7;
            this.txtResetToken.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtResetToken.StateCommon.Content.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResetToken.TabIndex = 9;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.Location = new System.Drawing.Point(143, 328);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '•';
            this.txtNewPassword.Size = new System.Drawing.Size(276, 29);
            this.txtNewPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNewPassword.StateCommon.Border.Rounding = 7;
            this.txtNewPassword.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtNewPassword.StateCommon.Content.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.TabIndex = 10;
            // 
            // ResetPasswordBTN
            // 
            this.ResetPasswordBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetPasswordBTN.Location = new System.Drawing.Point(294, 438);
            this.ResetPasswordBTN.Name = "ResetPasswordBTN";
            this.ResetPasswordBTN.Size = new System.Drawing.Size(212, 32);
            this.ResetPasswordBTN.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResetPasswordBTN.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResetPasswordBTN.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.ResetPasswordBTN.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.ResetPasswordBTN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ResetPasswordBTN.StateCommon.Border.Rounding = 7;
            this.ResetPasswordBTN.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.ResetPasswordBTN.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPasswordBTN.TabIndex = 11;
            this.ResetPasswordBTN.Values.Text = "Save Changes";
            this.ResetPasswordBTN.Click += new System.EventHandler(this.ResetPasswordBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "new password";
            // 
            // ShowPassCheck
            // 
            this.ShowPassCheck.AutoSize = true;
            this.ShowPassCheck.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassCheck.Location = new System.Drawing.Point(154, 364);
            this.ShowPassCheck.Name = "ShowPassCheck";
            this.ShowPassCheck.Size = new System.Drawing.Size(107, 18);
            this.ShowPassCheck.TabIndex = 15;
            this.ShowPassCheck.Text = "show password";
            this.ShowPassCheck.UseVisualStyleBackColor = true;
            this.ShowPassCheck.CheckedChanged += new System.EventHandler(this.ShowPassCheck_CheckedChanged);
            // 
            // RequestResetPassBTN
            // 
            this.RequestResetPassBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RequestResetPassBTN.Location = new System.Drawing.Point(49, 438);
            this.RequestResetPassBTN.Name = "RequestResetPassBTN";
            this.RequestResetPassBTN.Size = new System.Drawing.Size(212, 32);
            this.RequestResetPassBTN.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RequestResetPassBTN.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RequestResetPassBTN.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.RequestResetPassBTN.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.RequestResetPassBTN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.RequestResetPassBTN.StateCommon.Border.Rounding = 7;
            this.RequestResetPassBTN.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.RequestResetPassBTN.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestResetPassBTN.TabIndex = 16;
            this.RequestResetPassBTN.Values.Text = "Request Reset";
            this.RequestResetPassBTN.Click += new System.EventHandler(this.RequestResetPassBTN_Click);
            // 
            // ForgotPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 522);
            this.Controls.Add(this.RequestResetPassBTN);
            this.Controls.Add(this.ShowPassCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResetPasswordBTN);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtResetToken);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCaancel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtResetToken;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNewPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ResetPasswordBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ShowPassCheck;
        private ComponentFactory.Krypton.Toolkit.KryptonButton RequestResetPassBTN;
        private System.Windows.Forms.Label label5;
    }
}