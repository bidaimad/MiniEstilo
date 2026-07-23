using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MiniEstilo.Business.Services;
using MiniEstilo.Data.Repositories;
using MiniEstilo.Models.Entities;


namespace MiniEstilo.UI.Forms
{
    public partial class ProductEditForm : Form
    {
        private readonly BrandRepository _brandRepository;
        private readonly ProductService _productService;
        private readonly CategoryRepository _categoryRepository;
        private readonly AgeGroupRepository _ageGroupRepository;

        private Product? _product;
        private bool _isEditMode = false;
        public ProductEditForm()
        {
            InitializeComponent();
            _brandRepository = new BrandRepository();
            _productService = new ProductService(new ProductRepository());
            _categoryRepository = new CategoryRepository();
            _ageGroupRepository = new AgeGroupRepository();
        }

        public ProductEditForm(Product product)
        {
            InitializeComponent();
            _brandRepository = new BrandRepository();
            _productService = new ProductService(new ProductRepository());
            _categoryRepository = new CategoryRepository();
            _ageGroupRepository = new AgeGroupRepository();

            _product = product;
            _isEditMode = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpProduct_Enter(object sender, EventArgs e)
        {

        }
        private void LoadCategories()
        {
            var categories = _categoryRepository.GetAll();

            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "Id";
            cmbCategory.SelectedIndex = -1;
        }
        private void LoadBrands()
        {
            var brands = _brandRepository.GetAll();

            cmbBrand.DataSource = brands;
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "Id";
            cmbBrand.SelectedIndex = -1;
        }
        private void LoadAgeGroups()
        {
            var ageGroups = _ageGroupRepository.GetAll();

            cmbAgeGroup.DataSource = ageGroups;
            cmbAgeGroup.DisplayMember = "AgeGroupName";
            cmbAgeGroup.ValueMember = "Id";
            cmbAgeGroup.SelectedIndex = -1;
        }
        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadBrands();
            LoadAgeGroups();

            if (_isEditMode && _product != null)
            {
                btnSave.Text = "Update";

                txtBarcode.Text = _product.Barcode;
                txtProductCode.Text = _product.ProductCode;
                txtProductName.Text = _product.ProductName;

                txtPurchasePrice.Text = _product.PurchasePrice.ToString();
                txtSellingPrice.Text = _product.SellingPrice.ToString();
                txtQuantity.Text = _product.Quantity.ToString();

                txtDescription.Text = _product.Description;

                if (!string.IsNullOrWhiteSpace(_product.ImagePath))
                {
                    picProduct.ImageLocation = _product.ImagePath;
                }
            }
        }

        private void lblBqrcode_Click(object sender, EventArgs e)
        {

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProductcod_Click(object sender, EventArgs e)
        {

        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblBrand_Click(object sender, EventArgs e)
        {

        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        

        private void lblAgeGroup_Click(object sender, EventArgs e)
        {

        }

        private void cmbAgeGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPurchasePrice_Click(object sender, EventArgs e)
        {

        }

        private void txtPurchasePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSellingPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtSellingPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void picProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Select Product Image";
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picProduct.ImageLocation = dialog.FileName;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            picProduct.Image = null;
            picProduct.ImageLocation = null;
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    Barcode = txtBarcode.Text.Trim(),
                    ProductCode = txtProductCode.Text.Trim(),
                    ProductName = txtProductName.Text.Trim(),

                    CategoryId = cmbCategory.SelectedValue == null
    ? null
    : Convert.ToInt32(cmbCategory.SelectedValue),

                    BrandId = cmbBrand.SelectedValue == null
    ? null
    : Convert.ToInt32(cmbBrand.SelectedValue),

                    

                    AgeGroupId = cmbAgeGroup.SelectedValue == null
    ? null
    : Convert.ToInt32(cmbAgeGroup.SelectedValue),

                    PurchasePrice = decimal.Parse(txtPurchasePrice.Text),

                    SellingPrice = decimal.Parse(txtSellingPrice.Text),

                    Quantity = int.Parse(txtQuantity.Text),

                    Description = txtDescription.Text.Trim(),

                    ImagePath = string.IsNullOrWhiteSpace(picProduct.ImageLocation)
                        ? null
                        : picProduct.ImageLocation
                };

                bool result;

                if (_isEditMode)
                {
                    product.Id = _product!.Id;
                    result = _productService.Update(product);
                }
                else
                {
                    result = _productService.Add(product);
                }

                if (result)
                {
                    MessageBox.Show(
                        "Product saved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txtBarcode.Clear();
                    txtProductCode.Clear();
                    txtProductName.Clear();
                    txtPurchasePrice.Clear();
                    txtSellingPrice.Clear();
                    txtQuantity.Clear();
                    txtDescription.Clear();

                    cmbCategory.SelectedIndex = -1;
                    cmbBrand.SelectedIndex = -1;
                    cmbAgeGroup.SelectedIndex = -1;

                    picProduct.Image = null;
                    picProduct.ImageLocation = null;

                    txtBarcode.Focus();
                    if (_isEditMode)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Failed to save product.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }




        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!_isEditMode || _product == null)
            {
                MessageBox.Show(
                    "Please open an existing product first.",
                    "MiniEstilo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult answer = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
                return;

            bool result = _productService.Delete(_product.Id);

            if (result)
            {
                MessageBox.Show(
                    "Product deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(
                    "Failed to delete product.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}








