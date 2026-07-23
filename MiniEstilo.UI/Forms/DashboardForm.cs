using System;
using System.Windows.Forms;
using Npgsql;
using MiniEstilo.UI.Data;

namespace MiniEstilo.UI.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            LoadProductsCount();
        }

        /// <summary>
        /// تحميل عدد المنتجات
        /// </summary>
        private void LoadProductsCount()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    string sql = "SELECT COUNT(*) FROM mini_estilo.products";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        object? result = cmd.ExecuteScalar();

                        lblProductsCount.Text = result?.ToString() ?? "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading products count:\n\n" + ex.Message,
                    "MiniEstilo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
