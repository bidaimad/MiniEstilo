using MiniEstilo.UI.Data;
using Npgsql;
namespace MiniEstilo.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("يرجى إدخال اسم المستخدم.");
                txtUsername.Focus();
                return;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("يرجى إدخال كلمة المرور.");
                txtPassword.Focus();
                return;
            }

            try
            {
                using (NpgsqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    string sql = @"
        SELECT COUNT(*)
        FROM mini_estilo.users
        WHERE username = @username
          AND password_hash = @password";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MainForm mainForm = new MainForm();

                            this.Hide();

                            mainForm.Show();
                            mainForm.BringToFront();
                            mainForm.Activate();

                            return;
                        

                        // سنفتح MainForm في الخطوة التالية
                    }
                        else
                        {
                            MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة.");
                        }
                    }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل الاتصال بقاعدة البيانات:\n\n" + ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}