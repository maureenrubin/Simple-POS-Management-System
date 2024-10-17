namespace WindowsApp.FORMS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Exitbtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Login_ShowPassword = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Loginbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_username = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Exitbtn
            // 
            this.Exitbtn.FlatAppearance.BorderSize = 0;
            this.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("Exitbtn.Image")));
            this.Exitbtn.Location = new System.Drawing.Point(970, 12);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(19, 20);
            this.Exitbtn.TabIndex = 2;
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.Location = new System.Drawing.Point(158, 375);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(118, 19);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password?";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login_ShowPassword
            // 
            this.Login_ShowPassword.AutoSize = true;
            this.Login_ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.Login_ShowPassword.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_ShowPassword.Location = new System.Drawing.Point(103, 260);
            this.Login_ShowPassword.Name = "Login_ShowPassword";
            this.Login_ShowPassword.Size = new System.Drawing.Size(107, 19);
            this.Login_ShowPassword.TabIndex = 10;
            this.Login_ShowPassword.Text = "show password";
            this.Login_ShowPassword.UseVisualStyleBackColor = false;
            this.Login_ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(78, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "PLEASE LOGIN YOUR ACCOUNT";
            // 
            // Loginbtn
            // 
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.Location = new System.Drawing.Point(81, 333);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Loginbtn.Size = new System.Drawing.Size(270, 30);
            this.Loginbtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Loginbtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Loginbtn.StateCommon.Back.ColorAngle = 45F;
            this.Loginbtn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.Loginbtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.Loginbtn.StateCommon.Border.ColorAngle = 45F;
            this.Loginbtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Loginbtn.StateCommon.Border.Rounding = 10;
            this.Loginbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.Loginbtn.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.Loginbtn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Loginbtn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Loginbtn.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.Loginbtn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Loginbtn.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.StatePressed.Back.Color1 = System.Drawing.Color.Maroon;
            this.Loginbtn.StatePressed.Back.Color2 = System.Drawing.Color.Maroon;
            this.Loginbtn.StatePressed.Back.ColorAngle = 13F;
            this.Loginbtn.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.Loginbtn.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.Loginbtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Loginbtn.TabIndex = 10;
            this.Loginbtn.Values.Text = "LOGIN";
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click_1);
            // 
            // txt_username
            // 
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.Location = new System.Drawing.Point(81, 139);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(270, 26);
            this.txt_username.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txt_username.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txt_username.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_username.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_username.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_username.StateCommon.Border.Rounding = 10;
            this.txt_username.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_username.StateCommon.Content.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_username.TabIndex = 15;
            // 
            // txt_password
            // 
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Location = new System.Drawing.Point(81, 226);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '•';
            this.txt_password.Size = new System.Drawing.Size(270, 26);
            this.txt_password.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txt_password.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txt_password.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_password.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_password.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_password.StateCommon.Border.Rounding = 10;
            this.txt_password.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_password.StateCommon.Content.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_password.StateNormal.Content.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.TabIndex = 16;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pictureBox2);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.label5);
            this.kryptonPanel1.Controls.Add(this.label4);
            this.kryptonPanel1.Controls.Add(this.Loginbtn);
            this.kryptonPanel1.Controls.Add(this.txt_password);
            this.kryptonPanel1.Controls.Add(this.Login_ShowPassword);
            this.kryptonPanel1.Controls.Add(this.txt_username);
            this.kryptonPanel1.Controls.Add(this.label2);
            this.kryptonPanel1.Controls.Add(this.linkLabel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(494, 97);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kryptonPanel1.Size = new System.Drawing.Size(438, 444);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.RosyBrown;
            this.kryptonPanel1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(357, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "username";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(83, 128);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(339, 330);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1001, 666);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.Exitbtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.CheckBox Login_ShowPassword;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Loginbtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_username;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_password;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}