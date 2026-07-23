namespace MiniEstilo.UI.Forms
{
    partial class ProductEditForm
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
            grpProduct = new GroupBox();
            btnDelete = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnRemove = new Button();
            btnBrowse = new Button();
            picProduct = new PictureBox();
            txtDescription = new RichTextBox();
            lblDescription = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            txtSellingPrice = new TextBox();
            lblSellingPrice = new Label();
            txtPurchasePrice = new TextBox();
            lblPurchasePrice = new Label();
            cmbAgeGroup = new ComboBox();
            lblAgeGroup = new Label();
            cmbBrand = new ComboBox();
            lblBrand = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            txtProductCode = new TextBox();
            lblProductcod = new Label();
            txtBarcode = new TextBox();
            lblBqrcode = new Label();
            grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            SuspendLayout();
            // 
            // grpProduct
            // 
            grpProduct.Controls.Add(btnDelete);
            grpProduct.Controls.Add(btnCancel);
            grpProduct.Controls.Add(btnSave);
            grpProduct.Controls.Add(btnRemove);
            grpProduct.Controls.Add(btnBrowse);
            grpProduct.Controls.Add(picProduct);
            grpProduct.Controls.Add(txtDescription);
            grpProduct.Controls.Add(lblDescription);
            grpProduct.Controls.Add(txtQuantity);
            grpProduct.Controls.Add(lblQuantity);
            grpProduct.Controls.Add(txtSellingPrice);
            grpProduct.Controls.Add(lblSellingPrice);
            grpProduct.Controls.Add(txtPurchasePrice);
            grpProduct.Controls.Add(lblPurchasePrice);
            grpProduct.Controls.Add(cmbAgeGroup);
            grpProduct.Controls.Add(lblAgeGroup);
            grpProduct.Controls.Add(cmbBrand);
            grpProduct.Controls.Add(lblBrand);
            grpProduct.Controls.Add(cmbCategory);
            grpProduct.Controls.Add(lblCategory);
            grpProduct.Controls.Add(txtProductName);
            grpProduct.Controls.Add(lblProductName);
            grpProduct.Controls.Add(txtProductCode);
            grpProduct.Controls.Add(lblProductcod);
            grpProduct.Controls.Add(txtBarcode);
            grpProduct.Controls.Add(lblBqrcode);
            grpProduct.Location = new Point(0, 0);
            grpProduct.Name = "grpProduct";
            grpProduct.Size = new Size(900, 700);
            grpProduct.TabIndex = 0;
            grpProduct.TabStop = false;
            grpProduct.Text = "Product Information";
            grpProduct.Enter += grpProduct_Enter;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(785, 439);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(665, 439);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(540, 439);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(603, 384);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(200, 23);
            btnRemove.TabIndex = 23;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(603, 350);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(200, 28);
            btnBrowse.TabIndex = 22;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // picProduct
            // 
            picProduct.BorderStyle = BorderStyle.FixedSingle;
            picProduct.Location = new Point(603, 109);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(200, 220);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.TabIndex = 21;
            picProduct.TabStop = false;
            picProduct.Click += picProduct_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(153, 372);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(338, 134);
            txtDescription.TabIndex = 20;
            txtDescription.Text = "";
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(27, 404);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 19;
            lblDescription.Text = "Description";
            lblDescription.Click += lblDescription_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(138, 332);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(162, 23);
            txtQuantity.TabIndex = 18;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(27, 335);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 17;
            lblQuantity.Text = "Quantity";
            lblQuantity.Click += lblQuantity_Click;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(138, 298);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(162, 23);
            txtSellingPrice.TabIndex = 16;
            txtSellingPrice.TextChanged += txtSellingPrice_TextChanged;
            // 
            // lblSellingPrice
            // 
            lblSellingPrice.AutoSize = true;
            lblSellingPrice.Location = new Point(27, 301);
            lblSellingPrice.Name = "lblSellingPrice";
            lblSellingPrice.Size = new Size(71, 15);
            lblSellingPrice.TabIndex = 15;
            lblSellingPrice.Text = "Selling Price";
            lblSellingPrice.Click += lblSellingPrice_Click;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(138, 256);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(162, 23);
            txtPurchasePrice.TabIndex = 14;
            txtPurchasePrice.TextChanged += txtPurchasePrice_TextChanged;
            // 
            // lblPurchasePrice
            // 
            lblPurchasePrice.AutoSize = true;
            lblPurchasePrice.Location = new Point(27, 259);
            lblPurchasePrice.Name = "lblPurchasePrice";
            lblPurchasePrice.Size = new Size(84, 15);
            lblPurchasePrice.TabIndex = 13;
            lblPurchasePrice.Text = "Purchase Price";
            lblPurchasePrice.Click += lblPurchasePrice_Click;
            // 
            // cmbAgeGroup
            // 
            cmbAgeGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAgeGroup.FormattingEnabled = true;
            cmbAgeGroup.Location = new Point(138, 217);
            cmbAgeGroup.Name = "cmbAgeGroup";
            cmbAgeGroup.Size = new Size(162, 23);
            cmbAgeGroup.TabIndex = 12;
            cmbAgeGroup.SelectedIndexChanged += cmbAgeGroup_SelectedIndexChanged;
            // 
            // lblAgeGroup
            // 
            lblAgeGroup.AutoSize = true;
            lblAgeGroup.Location = new Point(27, 220);
            lblAgeGroup.Name = "lblAgeGroup";
            lblAgeGroup.Size = new Size(64, 15);
            lblAgeGroup.TabIndex = 11;
            lblAgeGroup.Text = "Age Group";
            lblAgeGroup.Click += lblAgeGroup_Click;
            // 
            // cmbBrand
            // 
            cmbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(138, 179);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(162, 23);
            cmbBrand.TabIndex = 8;
            cmbBrand.SelectedIndexChanged += cmbBrand_SelectedIndexChanged;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(27, 182);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(38, 15);
            lblBrand.TabIndex = 7;
            lblBrand.Text = "Brand";
            lblBrand.Click += lblBrand_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(138, 145);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(162, 23);
            cmbCategory.TabIndex = 6;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(27, 148);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            lblCategory.Click += lblCategory_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(138, 109);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(162, 23);
            txtProductName.TabIndex = 4;
            txtProductName.TextChanged += textBox1_TextChanged;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(27, 117);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(84, 15);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product Name";
            lblProductName.Click += lblProductName_Click;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(138, 80);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(162, 23);
            txtProductCode.TabIndex = 3;
            txtProductCode.TextChanged += txtProductCode_TextChanged;
            // 
            // lblProductcod
            // 
            lblProductcod.AutoSize = true;
            lblProductcod.Location = new Point(27, 88);
            lblProductcod.Name = "lblProductcod";
            lblProductcod.Size = new Size(80, 15);
            lblProductcod.TabIndex = 2;
            lblProductcod.Text = "Product Code";
            lblProductcod.Click += lblProductcod_Click;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(138, 51);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(162, 23);
            txtBarcode.TabIndex = 1;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            // 
            // lblBqrcode
            // 
            lblBqrcode.AutoSize = true;
            lblBqrcode.Location = new Point(27, 59);
            lblBqrcode.Name = "lblBqrcode";
            lblBqrcode.Size = new Size(50, 15);
            lblBqrcode.TabIndex = 0;
            lblBqrcode.Text = "Barcode";
            lblBqrcode.Click += lblBqrcode_Click;
            // 
            // ProductEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 661);
            Controls.Add(grpProduct);
            Name = "ProductEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Product";
            Load += ProductEditForm_Load;
            grpProduct.ResumeLayout(false);
            grpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpProduct;
        private RichTextBox txtDescription;
        private Label lblDescription;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private TextBox txtSellingPrice;
        private Label lblSellingPrice;
        private TextBox txtPurchasePrice;
        private Label lblPurchasePrice;
        private ComboBox cmbAgeGroup;
        private Label lblAgeGroup;
        private ComboBox cmbBrand;
        private Label lblBrand;
        private ComboBox cmbCategory;
        private Label lblCategory;
        private TextBox txtProductName;
        private Label lblProductName;
        private TextBox txtProductCode;
        private Label lblProductcod;
        private TextBox txtBarcode;
        private Label lblBqrcode;
        private PictureBox picProduct;
        private Button btnBrowse;
        private Button btnRemove;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDelete;
    }
}