namespace WindowsApp.FORMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHam = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.Panel();
            this.POSBtn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.ProductsBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customerContainer = new System.Windows.Forms.Panel();
            this.EmployeeBtn = new System.Windows.Forms.Button();
            this.TransactionBtn = new System.Windows.Forms.Button();
            this.dashboardBTN = new System.Windows.Forms.Button();
            this.EmployeeTime = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dashboard_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customerContainer.SuspendLayout();
            this.dashboard_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Controls.Add(this.Closebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 51);
            this.panel1.TabIndex = 3;
            // 
            // btnHam
            // 
            this.btnHam.BackColor = System.Drawing.Color.Maroon;
            this.btnHam.FlatAppearance.BorderSize = 0;
            this.btnHam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHam.ForeColor = System.Drawing.Color.Transparent;
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(21, 10);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(26, 26);
            this.btnHam.TabIndex = 6;
            this.btnHam.UseVisualStyleBackColor = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.Image = ((System.Drawing.Image)(resources.GetObject("Closebtn.Image")));
            this.Closebtn.Location = new System.Drawing.Point(1214, 7);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(38, 41);
            this.Closebtn.TabIndex = 5;
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(125, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADMIN";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Firebrick;
            this.sidebar.Controls.Add(this.label1);
            this.sidebar.Controls.Add(this.POSBtn);
            this.sidebar.Controls.Add(this.Logout_btn);
            this.sidebar.Controls.Add(this.ProductsBtn);
            this.sidebar.Controls.Add(this.pictureBox1);
            this.sidebar.Controls.Add(this.customerContainer);
            this.sidebar.Controls.Add(this.dashboardBTN);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(289, 738);
            this.sidebar.TabIndex = 4;
            // 
            // POSBtn
            // 
            this.POSBtn.BackColor = System.Drawing.Color.Firebrick;
            this.POSBtn.FlatAppearance.BorderSize = 0;
            this.POSBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.POSBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POSBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.POSBtn.Image = ((System.Drawing.Image)(resources.GetObject("POSBtn.Image")));
            this.POSBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.POSBtn.Location = new System.Drawing.Point(4, 398);
            this.POSBtn.Margin = new System.Windows.Forms.Padding(5);
            this.POSBtn.Name = "POSBtn";
            this.POSBtn.Padding = new System.Windows.Forms.Padding(10);
            this.POSBtn.Size = new System.Drawing.Size(280, 48);
            this.POSBtn.TabIndex = 14;
            this.POSBtn.Text = "POS";
            this.POSBtn.UseVisualStyleBackColor = false;
            this.POSBtn.Click += new System.EventHandler(this.POSBtn_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.Firebrick;
            this.Logout_btn.FlatAppearance.BorderSize = 0;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("Logout_btn.Image")));
            this.Logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_btn.Location = new System.Drawing.Point(4, 673);
            this.Logout_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Padding = new System.Windows.Forms.Padding(10);
            this.Logout_btn.Size = new System.Drawing.Size(280, 48);
            this.Logout_btn.TabIndex = 13;
            this.Logout_btn.Text = "LOGOUT";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // ProductsBtn
            // 
            this.ProductsBtn.BackColor = System.Drawing.Color.Firebrick;
            this.ProductsBtn.FlatAppearance.BorderSize = 0;
            this.ProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProductsBtn.Image")));
            this.ProductsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductsBtn.Location = new System.Drawing.Point(3, 444);
            this.ProductsBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ProductsBtn.Name = "ProductsBtn";
            this.ProductsBtn.Padding = new System.Windows.Forms.Padding(10);
            this.ProductsBtn.Size = new System.Drawing.Size(280, 48);
            this.ProductsBtn.TabIndex = 9;
            this.ProductsBtn.Text = "PRODUCTS";
            this.ProductsBtn.UseVisualStyleBackColor = false;
            this.ProductsBtn.Click += new System.EventHandler(this.ProductsBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // customerContainer
            // 
            this.customerContainer.BackColor = System.Drawing.Color.Firebrick;
            this.customerContainer.Controls.Add(this.EmployeeBtn);
            this.customerContainer.Controls.Add(this.TransactionBtn);
            this.customerContainer.Location = new System.Drawing.Point(1, 497);
            this.customerContainer.Name = "customerContainer";
            this.customerContainer.Size = new System.Drawing.Size(282, 63);
            this.customerContainer.TabIndex = 11;
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.BackColor = System.Drawing.Color.Firebrick;
            this.EmployeeBtn.FlatAppearance.BorderSize = 0;
            this.EmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmployeeBtn.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeBtn.Image")));
            this.EmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeBtn.Location = new System.Drawing.Point(3, 3);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Padding = new System.Windows.Forms.Padding(10);
            this.EmployeeBtn.Size = new System.Drawing.Size(276, 51);
            this.EmployeeBtn.TabIndex = 7;
            this.EmployeeBtn.Text = "EMPLOYEES";
            this.EmployeeBtn.UseVisualStyleBackColor = false;
            this.EmployeeBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // TransactionBtn
            // 
            this.TransactionBtn.BackColor = System.Drawing.Color.Maroon;
            this.TransactionBtn.FlatAppearance.BorderSize = 0;
            this.TransactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TransactionBtn.Image = ((System.Drawing.Image)(resources.GetObject("TransactionBtn.Image")));
            this.TransactionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionBtn.Location = new System.Drawing.Point(3, 64);
            this.TransactionBtn.Name = "TransactionBtn";
            this.TransactionBtn.Padding = new System.Windows.Forms.Padding(10);
            this.TransactionBtn.Size = new System.Drawing.Size(276, 48);
            this.TransactionBtn.TabIndex = 8;
            this.TransactionBtn.Text = "TRANSACTION";
            this.TransactionBtn.UseVisualStyleBackColor = false;
            this.TransactionBtn.Click += new System.EventHandler(this.TransactionBtn_Click);
            // 
            // dashboardBTN
            // 
            this.dashboardBTN.BackColor = System.Drawing.Color.Firebrick;
            this.dashboardBTN.FlatAppearance.BorderSize = 0;
            this.dashboardBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBTN.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboardBTN.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBTN.Image")));
            this.dashboardBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBTN.Location = new System.Drawing.Point(1, 340);
            this.dashboardBTN.Margin = new System.Windows.Forms.Padding(5);
            this.dashboardBTN.Name = "dashboardBTN";
            this.dashboardBTN.Padding = new System.Windows.Forms.Padding(10);
            this.dashboardBTN.Size = new System.Drawing.Size(280, 48);
            this.dashboardBTN.TabIndex = 12;
            this.dashboardBTN.Text = "DASHBOARD";
            this.dashboardBTN.UseVisualStyleBackColor = false;
            this.dashboardBTN.Click += new System.EventHandler(this.dashboardBTN_Click);
            // 
            // EmployeeTime
            // 
            this.EmployeeTime.Interval = 10;
            this.EmployeeTime.Tick += new System.EventHandler(this.customerTimer_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 1;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "DAJAM\'S KITCHEN";
            // 
            // dashboard_panel
            // 
            this.dashboard_panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dashboard_panel.Controls.Add(this.label2);
            this.dashboard_panel.Location = new System.Drawing.Point(79, 57);
            this.dashboard_panel.Name = "dashboard_panel";
            this.dashboard_panel.Size = new System.Drawing.Size(1169, 669);
            this.dashboard_panel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 738);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.dashboard_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.panel1.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customerContainer.ResumeLayout(false);
            this.dashboard_panel.ResumeLayout(false);
            this.dashboard_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TransactionBtn;
        private System.Windows.Forms.Button EmployeeBtn;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button ProductsBtn;
        private System.Windows.Forms.Panel customerContainer;
        private System.Windows.Forms.Button dashboardBTN;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Timer EmployeeTime;
        private System.Windows.Forms.Button POSBtn;
        private System.Windows.Forms.Button btnHam;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel dashboard_panel;
    }
}