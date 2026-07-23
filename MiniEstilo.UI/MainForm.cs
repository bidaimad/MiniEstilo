using MiniEstilo.UI.Forms;
using MiniEstilo.UI.Forms.Products;
using System;
using System.Windows.Forms;

namespace MiniEstilo.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void OpenForm(Form childForm)
        {
            panelContent.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;

            childForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenForm(new DashboardForm());
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenForm(new ProductsForm());
        }

        private void btnProducts_Click_1(object sender, EventArgs e)
        {
            OpenForm(new ProductsForm());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            OpenForm(new CategoryForm());
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenForm(new DashboardForm());
        }
    }
}







