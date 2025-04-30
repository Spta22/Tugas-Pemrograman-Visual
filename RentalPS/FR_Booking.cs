using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cobaKoneksiDatabase;
using MySql.Data.MySqlClient;

namespace RentalPS
{
    public partial class FR_Booking : Form
    {
        Koneksi kon = new Koneksi();  // instance koneksi
        public FR_Booking()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            FR_Dashboard FR_Dashboard = new FR_Dashboard(); // Buat form login baru
            FR_Dashboard.Show(); // Tampilkan form login
            this.Hide(); // Sembunyikan form saat ini (FR_Buatakun)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                kon.buka();

                string query = "INSERT INTO booking (nama, telepon, meja, tanggal, jam_mulai, jam_selesai) VALUES (@nama, @telepon, @meja, @tanggal, @jam_mulai, @jam_selesai)";
                MySqlCommand cmd = new MySqlCommand(query, kon.koneksi);
                cmd.Parameters.AddWithValue("@nama", textNama.Text);
                cmd.Parameters.AddWithValue("@telepon", textTelepon.Text);
                cmd.Parameters.AddWithValue("@meja", comboMeja.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@tanggal", dateTanggal.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@jam_mulai", jamMulai.Value.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@jam_selesai", jamSelesai.Value.ToString("HH:mm:ss"));



                cmd.ExecuteNonQuery();

                MessageBox.Show("Booking berhasil didaftarkan!");

                kon.tutup();

                // Opsional: Kembali ke form login
                FR_Dashboard FR_Dashboard = new FR_Dashboard();
                FR_Dashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal daftar: " + ex.Message);
            }
        }
    }
}
