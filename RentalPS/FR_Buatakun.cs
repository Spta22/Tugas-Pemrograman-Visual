using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using cobaKoneksiDatabase;

namespace RentalPS
{
    public partial class FR_Buatakun : Form
    {
        Koneksi kon = new Koneksi();

        public FR_Buatakun()
        {
            InitializeComponent();
        }

        private void btndaftar_Click(object sender, EventArgs e)
        {
            // Validasi input kosong
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtNama.Text == "" || cmboRole.SelectedItem == null)
            {
                MessageBox.Show("Semua field harus diisi!");
                return;
            }

            try
            {
                kon.buka();

                string query = "INSERT INTO users (username, password, role, nama) VALUES (@username, @password, @role, @nama)";
                MySqlCommand cmd = new MySqlCommand(query, kon.koneksi);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@role", cmboRole.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Akun berhasil didaftarkan!");

                kon.tutup();

                // Opsional: Kembali ke form login
                Formlogin loginForm = new Formlogin();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal daftar: " + ex.Message);
            }
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
             Formlogin loginForm = new Formlogin(); // Buat form login baru
            loginForm.Show(); // Tampilkan form login
            this.Hide(); // Sembunyikan form saat ini (FR_Buatakun)
        }
    }
}
