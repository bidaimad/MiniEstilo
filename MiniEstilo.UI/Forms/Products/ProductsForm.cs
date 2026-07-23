using System;
using System.Windows.Forms;
using MiniEstilo.Business.Services;
using MiniEstilo.Data.Repositories;
using MiniEstilo.Models.Entities;

namespace MiniEstilo.UI.Forms.Products
{
    public partial class ProductsForm : Form
    {
        private readonly ProductService _productService;

        public ProductsForm()
        {
            InitializeComponent();

            _productService = new ProductService(new ProductRepository());
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = _productService.GetAll();

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;

            lblCount.Text = $"Products : {products.Count}";

            if (dgvProducts.Columns.Count == 0)
                return;

            if (dgvProducts.Columns.Contains("Id"))
                dgvProducts.Columns["Id"].Visible = false;

            if (dgvProducts.Columns.Contains("CategoryId"))
                dgvProducts.Columns["CategoryId"].Visible = false;

            if (dgvProducts.Columns.Contains("BrandId"))
                dgvProducts.Columns["BrandId"].Visible = false;

            if (dgvProducts.Columns.Contains("GenderId"))
                dgvProducts.Columns["GenderId"].Visible = false;

            if (dgvProducts.Columns.Contains("AgeGroupId"))
                dgvProducts.Columns["AgeGroupId"].Visible = false;

            if (dgvProducts.Columns.Contains("Description"))
                dgvProducts.Columns["Description"].Visible = false;

            if (dgvProducts.Columns.Contains("ImagePath"))
                dgvProducts.Columns["ImagePath"].Visible = false;

            if (dgvProducts.Columns.Contains("Barcode"))
                dgvProducts.Columns["Barcode"].HeaderText = "Barcode";

            if (dgvProducts.Columns.Contains("ProductCode"))
                dgvProducts.Columns["ProductCode"].HeaderText = "Product Code";

            if (dgvProducts.Columns.Contains("ProductName"))
                dgvProducts.Columns["ProductName"].HeaderText = "Product Name";

            if (dgvProducts.Columns.Contains("PurchasePrice"))
                dgvProducts.Columns["PurchasePrice"].HeaderText = "Purchase Price";

            if (dgvProducts.Columns.Contains("SellingPrice"))
                dgvProducts.Columns["SellingPrice"].HeaderText = "Selling Price";

            if (dgvProducts.Columns.Contains("Quantity"))
                dgvProducts.Columns["Quantity"].HeaderText = "Quantity";

            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.MultiSelect = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (ProductEditForm form = new ProductEditForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Product product = (Product)dgvProducts.Rows[e.RowIndex].DataBoundItem;

            using (ProductEditForm form = new ProductEditForm(product))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim().ToLower();

            var products = _productService.GetAll();

            if (!string.IsNullOrWhiteSpace(search))
            {
                products = products.FindAll(p =>
                    (!string.IsNullOrEmpty(p.ProductName) && p.ProductName.ToLower().Contains(search)) ||
                    (!string.IsNullOrEmpty(p.ProductCode) && p.ProductCode.ToLower().Contains(search)) ||
                    (!string.IsNullOrEmpty(p.Barcode) && p.Barcode.ToLower().Contains(search)));
            }

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;

            lblCount.Text = $"Products : {products.Count}";
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}