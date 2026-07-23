namespace MiniEstilo.UI.Forms
{
    partial class DashboardForm
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
            lblWelcome = new Label();
            pnlProducts = new Panel();
            lblProductsTitle = new Label();
            lblProductsCount = new Label();
            pnlCategories = new Panel();
            lblCategoriesCount = new Label();
            lblCategoriesTitle = new Label();
            pnlCustomers = new Panel();
            lblCustomersCount = new Label();
            lblCustomersTitle = new Label();
            pnlSales = new Panel();
            lblSalesCount = new Label();
            lblSalesTitle = new Label();
            grpLatestSales = new GroupBox();
            dgvLatestSales = new DataGridView();
            grpLowStock = new GroupBox();
            dgvLowStock = new DataGridView();
            pnlProducts.SuspendLayout();
            pnlCategories.SuspendLayout();
            pnlCustomers.SuspendLayout();
            pnlSales.SuspendLayout();
            grpLatestSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLatestSales).BeginInit();
            grpLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(190, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(362, 37);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to MiniEstilo ERP";
            // 
            // pnlProducts
            // 
            pnlProducts.BorderStyle = BorderStyle.FixedSingle;
            pnlProducts.Controls.Add(lblProductsCount);
            pnlProducts.Controls.Add(lblProductsTitle);
            pnlProducts.Location = new Point(12, 130);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(180, 100);
            pnlProducts.TabIndex = 1;
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.AutoSize = true;
            lblProductsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProductsTitle.Location = new Point(3, 9);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(68, 19);
            lblProductsTitle.TabIndex = 0;
            lblProductsTitle.Text = "Products";
            // 
            // lblProductsCount
            // 
            lblProductsCount.AutoSize = true;
            lblProductsCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblProductsCount.Location = new Point(75, 34);
            lblProductsCount.Name = "lblProductsCount";
            lblProductsCount.Size = new Size(35, 41);
            lblProductsCount.TabIndex = 1;
            lblProductsCount.Text = "0";
            lblProductsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCategories
            // 
            pnlCategories.BorderStyle = BorderStyle.FixedSingle;
            pnlCategories.Controls.Add(lblCategoriesCount);
            pnlCategories.Controls.Add(lblCategoriesTitle);
            pnlCategories.Location = new Point(210, 130);
            pnlCategories.Name = "pnlCategories";
            pnlCategories.Size = new Size(180, 100);
            pnlCategories.TabIndex = 2;
            // 
            // lblCategoriesCount
            // 
            lblCategoriesCount.AutoSize = true;
            lblCategoriesCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblCategoriesCount.Location = new Point(81, 34);
            lblCategoriesCount.Name = "lblCategoriesCount";
            lblCategoriesCount.Size = new Size(35, 41);
            lblCategoriesCount.TabIndex = 1;
            lblCategoriesCount.Text = "0";
            lblCategoriesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCategoriesTitle
            // 
            lblCategoriesTitle.AutoSize = true;
            lblCategoriesTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCategoriesTitle.Location = new Point(3, 9);
            lblCategoriesTitle.Name = "lblCategoriesTitle";
            lblCategoriesTitle.Size = new Size(81, 19);
            lblCategoriesTitle.TabIndex = 0;
            lblCategoriesTitle.Text = "Categories";
            // 
            // pnlCustomers
            // 
            pnlCustomers.BorderStyle = BorderStyle.FixedSingle;
            pnlCustomers.Controls.Add(lblCustomersCount);
            pnlCustomers.Controls.Add(lblCustomersTitle);
            pnlCustomers.Location = new Point(408, 130);
            pnlCustomers.Name = "pnlCustomers";
            pnlCustomers.Size = new Size(180, 100);
            pnlCustomers.TabIndex = 3;
            // 
            // lblCustomersCount
            // 
            lblCustomersCount.AutoSize = true;
            lblCustomersCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblCustomersCount.Location = new Point(75, 34);
            lblCustomersCount.Name = "lblCustomersCount";
            lblCustomersCount.Size = new Size(35, 41);
            lblCustomersCount.TabIndex = 1;
            lblCustomersCount.Text = "0";
            lblCustomersCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCustomersTitle
            // 
            lblCustomersTitle.AutoSize = true;
            lblCustomersTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCustomersTitle.Location = new Point(3, 9);
            lblCustomersTitle.Name = "lblCustomersTitle";
            lblCustomersTitle.Size = new Size(79, 19);
            lblCustomersTitle.TabIndex = 0;
            lblCustomersTitle.Text = "Customers";
            // 
            // pnlSales
            // 
            pnlSales.BorderStyle = BorderStyle.FixedSingle;
            pnlSales.Controls.Add(lblSalesCount);
            pnlSales.Controls.Add(lblSalesTitle);
            pnlSales.Location = new Point(608, 130);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(180, 100);
            pnlSales.TabIndex = 4;
            // 
            // lblSalesCount
            // 
            lblSalesCount.AutoSize = true;
            lblSalesCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblSalesCount.Location = new Point(75, 34);
            lblSalesCount.Name = "lblSalesCount";
            lblSalesCount.Size = new Size(35, 41);
            lblSalesCount.TabIndex = 1;
            lblSalesCount.Text = "0";
            lblSalesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSalesTitle
            // 
            lblSalesTitle.AutoSize = true;
            lblSalesTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSalesTitle.Location = new Point(3, 9);
            lblSalesTitle.Name = "lblSalesTitle";
            lblSalesTitle.Size = new Size(43, 19);
            lblSalesTitle.TabIndex = 0;
            lblSalesTitle.Text = "Sales";
            // 
            // grpLatestSales
            // 
            grpLatestSales.Controls.Add(dgvLatestSales);
            grpLatestSales.Location = new Point(16, 285);
            grpLatestSales.Name = "grpLatestSales";
            grpLatestSales.Size = new Size(250, 520);
            grpLatestSales.TabIndex = 5;
            grpLatestSales.TabStop = false;
            grpLatestSales.Text = "Latest Sales";
            // 
            // dgvLatestSales
            // 
            dgvLatestSales.AllowUserToAddRows = false;
            dgvLatestSales.AllowUserToDeleteRows = false;
            dgvLatestSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLatestSales.Dock = DockStyle.Fill;
            dgvLatestSales.Location = new Point(3, 19);
            dgvLatestSales.Name = "dgvLatestSales";
            dgvLatestSales.RowHeadersVisible = false;
            dgvLatestSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLatestSales.Size = new Size(244, 498);
            dgvLatestSales.TabIndex = 0;
            // 
            // grpLowStock
            // 
            grpLowStock.Controls.Add(dgvLowStock);
            grpLowStock.Location = new Point(316, 285);
            grpLowStock.Name = "grpLowStock";
            grpLowStock.Size = new Size(250, 520);
            grpLowStock.TabIndex = 6;
            grpLowStock.TabStop = false;
            grpLowStock.Text = "Low Stock Products";
            // 
            // dgvLowStock
            // 
            dgvLowStock.AllowUserToAddRows = false;
            dgvLowStock.AllowUserToDeleteRows = false;
            dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStock.Dock = DockStyle.Fill;
            dgvLowStock.Location = new Point(3, 19);
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.RowHeadersVisible = false;
            dgvLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLowStock.Size = new Size(244, 498);
            dgvLowStock.TabIndex = 0;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpLowStock);
            Controls.Add(grpLatestSales);
            Controls.Add(pnlSales);
            Controls.Add(pnlCustomers);
            Controls.Add(pnlCategories);
            Controls.Add(pnlProducts);
            Controls.Add(lblWelcome);
            Location = new Point(20, 20);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            pnlProducts.ResumeLayout(false);
            pnlProducts.PerformLayout();
            pnlCategories.ResumeLayout(false);
            pnlCategories.PerformLayout();
            pnlCustomers.ResumeLayout(false);
            pnlCustomers.PerformLayout();
            pnlSales.ResumeLayout(false);
            pnlSales.PerformLayout();
            grpLatestSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLatestSales).EndInit();
            grpLowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Panel pnlProducts;
        private Label lblProductsTitle;
        private Label lblProductsCount;
        private Panel pnlCategories;
        private Label lblCategoriesCount;
        private Label lblCategoriesTitle;
        private Panel pnlCustomers;
        private Label lblCustomersCount;
        private Label lblCustomersTitle;
        private Panel pnlSales;
        private Label lblSalesCount;
        private Label lblSalesTitle;
        private GroupBox grpLatestSales;
        private DataGridView dgvLatestSales;
        private GroupBox grpLowStock;
        private DataGridView dgvLowStock;
    }
}