using cobaKoneksiDatabase;
using MySql.Data.MySqlClient;
namespace RentalPS
{
    public partial class Formlogin : Form
    {
        Koneksi kon = new Koneksi();  // instance koneksi
        public Formlogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "")
                MessageBox.Show("Username atau Password tidak boleh kosong");
            else
            if (textUsername.Text == "" && textPassword.Text == "")

                MessageBox.Show("Anda Berhasil Login");

            else
                // Pengecekan login di database
                try
                {
                    kon.buka();
                    string query = "SELECT * FROM users WHERE username = @username AND password = @password";

                    MySqlCommand cmd = new MySqlCommand(query, kon.koneksi);
                    cmd.Parameters.AddWithValue("@username", textUsername.Text);
                    cmd.Parameters.AddWithValue("@password", textPassword.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Login sukses, buka Form2
                        MessageBox.Show("Login berhasil!");
                        FR_Dashboard FR_Dasboard = new FR_Dashboard();
                        FR_Dasboard.Show();
                        this.Hide(); // menyembunyikan Form1
                    }
                    else
                    {
                        MessageBox.Show("Username atau password salah.");
                    }

                    // Menutup koneksi ke database
                    kon.tutup();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal login: " + ex.Message);
                }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Contoh: cek apakah ada teks
            // string input = textBox1.Text;
        }

        private void btnBuatakun_Click(object sender, EventArgs e)
        {
            FR_Buatakun FR_Buatakun = new FR_Buatakun(); // Buat instance dari form baru
            FR_Buatakun.Show(); // Tampilkan form
            this.Hide(); // Sembunyikan form login (opsional)
        }
    }
}
