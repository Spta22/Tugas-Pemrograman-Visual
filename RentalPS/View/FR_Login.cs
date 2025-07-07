using MySql.Data.MySqlClient;
using RentalPS.Controller;
using RentalPS.Model;
namespace RentalPS
{
    public partial class Formlogin : Form
    {
        private UserController userController = new UserController();
        public Formlogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username atau Password tidak boleh kosong");
                return;
            }

            bool loginBerhasil = userController.Login(username, password);
            if (loginBerhasil)
            {
                // ─── Tambahan: ambil nama sesuai akun ──────────────────────
                string namaPengguna = username;                     
                try
                {
                    string connStr = "server=localhost;user id=root;password=...;database=rentalps;";
                    using var conn = new MySqlConnection(connStr);
                    conn.Open();

                    string sql = "SELECT nama FROM users WHERE username = @u LIMIT 1";
                    using var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@u", username);

                    using var rdr = cmd.ExecuteReader();
                    if (rdr.Read()) namaPengguna = rdr.GetString("nama");
                }
                catch {  }

                MessageBox.Show(
                    $"Selamat Datang {namaPengguna} Di Aplikasi Rental PS Meiinsyaallah",
                    "Login Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                FR_Dashboard dashboard = new FR_Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah.");
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuatakun_Click(object sender, EventArgs e)
        {
            FR_Buatakun FR_Buatakun = new FR_Buatakun();
            FR_Buatakun.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
