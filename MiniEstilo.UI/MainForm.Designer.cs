namespace MiniEstilo.UI
{
    partial class MainForm
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
            panelTop = new Panel();
            lblDateTime = new Label();
            lblBranch = new Label();
            lblUser = new Label();
            panel1 = new Panel();
            lblLogo = new Label();
            panelMenu = new Panel();
            btnLogout = new Button();
            btnUsers = new Button();
            btnSettings = new Button();
            btnReports = new Button();
            btnInventory = new Button();
            btnPurchases = new Button();
            btnSales = new Button();
            Suppliers = new Button();
            btnCustomers = new Button();
            btnCategories = new Button();
            btnProducts = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            panelContent = new Panel();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblDateTime);
            panelTop.Controls.Add(lblBranch);
            panelTop.Controls.Add(lblUser);
            panelTop.Controls.Add(panel1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(800, 60);
            panelTop.TabIndex = 0;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(603, 26);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(58, 15);
            lblDateTime.TabIndex = 4;
            lblDateTime.Text = "DateTime";
            // 
            // lblBranch
            // 
            lblBranch.AutoSize = true;
            lblBranch.Location = new Point(482, 26);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new Size(44, 15);
            lblBranch.TabIndex = 3;
            lblBranch.Text = "Branch";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(400, 26);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(30, 15);
            lblUser.TabIndex = 2;
            lblUser.Text = "User";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblLogo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 447);
            panel1.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Dock = DockStyle.Fill;
            lblLogo.FlatStyle = FlatStyle.Flat;
            lblLogo.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(76, 13);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "MiniEstilo ERP";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnUsers);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnReports);
            panelMenu.Controls.Add(btnInventory);
            panelMenu.Controls.Add(btnPurchases);
            panelMenu.Controls.Add(btnSales);
            panelMenu.Controls.Add(Suppliers);
            panelMenu.Controls.Add(btnCustomers);
            panelMenu.Controls.Add(btnCategories);
            panelMenu.Controls.Add(btnProducts);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 60);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 390);
            panelMenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(0, 400);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 45);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Location = new Point(0, 360);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(220, 40);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Location = new Point(0, 320);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(220, 40);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Location = new Point(0, 280);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(220, 40);
            btnReports.TabIndex = 0;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            btnInventory.Dock = DockStyle.Top;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Location = new Point(0, 240);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(220, 40);
            btnInventory.TabIndex = 6;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnPurchases
            // 
            btnPurchases.Dock = DockStyle.Top;
            btnPurchases.FlatAppearance.BorderSize = 0;
            btnPurchases.FlatStyle = FlatStyle.Flat;
            btnPurchases.Location = new Point(0, 200);
            btnPurchases.Name = "btnPurchases";
            btnPurchases.Size = new Size(220, 40);
            btnPurchases.TabIndex = 5;
            btnPurchases.Text = "Purchases";
            btnPurchases.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            btnSales.Dock = DockStyle.Top;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Location = new Point(0, 160);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(220, 40);
            btnSales.TabIndex = 4;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = true;
            // 
            // Suppliers
            // 
            Suppliers.FlatAppearance.BorderSize = 0;
            Suppliers.FlatStyle = FlatStyle.Flat;
            Suppliers.Location = new Point(0, 180);
            Suppliers.Name = "Suppliers";
            Suppliers.Size = new Size(220, 45);
            Suppliers.TabIndex = 2;
            Suppliers.Text = "Suppliers";
            Suppliers.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            btnCustomers.Dock = DockStyle.Top;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Location = new Point(0, 120);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(220, 40);
            btnCustomers.TabIndex = 0;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnCategories
            // 
            btnCategories.Dock = DockStyle.Top;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Location = new Point(0, 80);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(220, 40);
            btnCategories.TabIndex = 3;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnProducts
            // 
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Location = new Point(0, 40);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(220, 40);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click_1;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 40);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(216, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(581, 390);
            panel2.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(220, 60);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(580, 390);
            panelContent.TabIndex = 2;
            panelContent.Paint += panelContent_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Controls.Add(panelTop);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniEstilo ERP";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panel1;
        private Panel panelMenu;
        private Panel panel2;
        private Panel panelContent;
        private Button btnDashboard;
        private Button btnProducts;
        private Button btnCustomers;
        private Button btnCategories;
        private Label lblLogo;
        private Button btnSales;
        private Button Suppliers;
        private Button btnInventory;
        private Button btnPurchases;
        private Button btnSettings;
        private Button btnReports;
        private Button btnUsers;
        private Button btnLogout;
        private Label lblDateTime;
        private Label lblBranch;
        private Label lblUser;
    }
}