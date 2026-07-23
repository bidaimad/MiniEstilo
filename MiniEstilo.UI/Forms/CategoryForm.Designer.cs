using MiniEstilo.Models.Entities;

namespace MiniEstilo.UI.Forms
{
    partial class CategoryForm
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
            label1 = new Label();
            grpCategory = new GroupBox();
            btnExit = new Button();
            lblCategoryName = new Label();
            txtCategoryName = new TextBox();
            txtDescription = new TextBox();
            lblDescription = new Label();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            dgvCategories = new DataGridView();
            grpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 95);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // grpCategory
            // 
            grpCategory.Controls.Add(btnExit);
            grpCategory.Location = new Point(0, 10);
            grpCategory.Name = "grpCategory";
            grpCategory.Size = new Size(800, 259);
            grpCategory.TabIndex = 1;
            grpCategory.TabStop = false;
            grpCategory.Text = "Category Information";
            grpCategory.Enter += grpCategory_Enter;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(699, 236);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(12, 125);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(96, 15);
            lblCategoryName.TabIndex = 2;
            lblCategoryName.Text = "Category Name :";
            lblCategoryName.Click += lblCategoryName_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(114, 125);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(131, 23);
            txtCategoryName.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 179);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(776, 61);
            txtDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(21, 159);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(73, 15);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description :";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(114, 246);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(254, 246);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(374, 246);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(503, 246);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(87, 23);
            btnNew.TabIndex = 9;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToResizeRows = false;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Dock = DockStyle.Bottom;
            dgvCategories.Location = new Point(0, 281);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(800, 169);
            dgvCategories.TabIndex = 10;
            dgvCategories.CellClick += dgvCategories_CellClick;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCategories);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(lblCategoryName);
            Controls.Add(grpCategory);
            Controls.Add(label1);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            grpCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpCategory;
        private Label lblCategoryName;
        private TextBox txtCategoryName;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnNew;
        private DataGridView dgvCategories;
        private Button btnExit;
    }
}