namespace MiniEstilo.UI.Forms.Products
{
    partial class ProductsForm
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
            lblTitle = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnRefresh = new Button();
            dgvProducts = new DataGridView();
            lblCount = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblTitle.Location = new Point(12, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(49, 13);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Products";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(152, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(205, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(387, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(60, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(624, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "New Product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(495, 20);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(67, 22);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(0, 72);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(773, 332);
            dgvProducts.TabIndex = 7;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(12, 407);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(69, 15);
            lblCount.TabIndex = 8;
            lblCount.Text = "Products : 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(98, 25);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 9;
            label1.Text = "Search :";
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblCount);
            Controls.Add(dgvProducts);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductsForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Products";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
           
        }

        #endregion

        private Label lblTitle;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnRefresh;
        private DataGridView dgvProducts;
        private Label lblCount;
        private Label label1;
    }
}