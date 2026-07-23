using System;
using System.Collections.Generic;
using System.Windows.Forms;

using MiniEstilo.Business.Interfaces;
using MiniEstilo.Business.Services;
using MiniEstilo.Data.Interfaces;
using MiniEstilo.Data.Repositories;
using MiniEstilo.Models.Entities;

namespace MiniEstilo.UI.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly ICategoryService _categoryService;
        private int _selectedCategoryId = 0;

        public CategoryForm()
        {
            InitializeComponent();

            ICategoryRepository repository = new CategoryRepository();
            _categoryService = new CategoryService(repository);
        }

        private void LoadCategories()
        {
            List<Category> categories = _categoryService.GetAll();

            dgvCategories.DataSource = null;
            dgvCategories.DataSource = categories;

            dgvCategories.Columns["Id"]?.Visible = false;
            dgvCategories.Columns["ParentId"]?.Visible = false;

            dgvCategories.Columns["Code"]?.HeaderText = "Code";
            dgvCategories.Columns["CategoryName"]?.HeaderText = "Category Name";
            dgvCategories.Columns["Description"]?.HeaderText = "Description";
            dgvCategories.Columns["IsActive"]?.HeaderText = "Active";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show(
                    "Please enter category name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCategoryName.Focus();
                return;
            }

            Category category = new Category
            {
                CategoryName = txtCategoryName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                ParentId = null,
                IsActive = true
            };

            bool result = _categoryService.Add(category);

            if (result)
            {
                MessageBox.Show(
                    "Category saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtCategoryName.Clear();
                txtDescription.Clear();

                LoadCategories();

                txtCategoryName.Focus();
            }
            else
            {
                MessageBox.Show(
                    "Failed to save category.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void grpCategory_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvCategories.Rows[e.RowIndex];

            _selectedCategoryId = Convert.ToInt32(row.Cells["Id"].Value);

            txtCategoryName.Text = row.Cells["CategoryName"].Value?.ToString() ?? "";
            txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? "";
        }

        private void lblCategoryName_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedCategoryId == 0)
            {
                MessageBox.Show(
                    "Please select a category first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show(
                    "Please enter category name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCategoryName.Focus();
                return;
            }

            Category category = new Category
            {
                Id = _selectedCategoryId,
                Code = dgvCategories.CurrentRow?.Cells["Code"].Value?.ToString() ?? "",
                CategoryName = txtCategoryName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                ParentId = null,
                IsActive = true
            };

            bool result = _categoryService.Update(category);

            if (result)
            {
                MessageBox.Show(
                    "Category updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadCategories();

                txtCategoryName.Clear();
                txtDescription.Clear();

                _selectedCategoryId = 0;
            }
            else
            {
                MessageBox.Show(
                    "Failed to update category.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCategoryId == 0)
            {
                MessageBox.Show(
                    "Please select a category first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this category?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            bool deleted = _categoryService.Delete(_selectedCategoryId);

            if (deleted)
            {
                MessageBox.Show(
                    "Category deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtCategoryName.Clear();
                txtDescription.Clear();

                _selectedCategoryId = 0;

                LoadCategories();
            }
            else
            {
                MessageBox.Show(
                    "Failed to delete category.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            _selectedCategoryId = 0;

            txtCategoryName.Clear();
            txtDescription.Clear();

            txtCategoryName.Focus();

            dgvCategories.ClearSelection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
