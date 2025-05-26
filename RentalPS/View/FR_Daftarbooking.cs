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
using RentalPS.Controller;
using RentalPS.Model;
// view
namespace RentalPS
{
    public partial class FR_Daftarbooking : Form
    {
        Koneksi koneksi;
        private DaftarBookingController daftarBookingController = new DaftarBookingController();
        public FR_Daftarbooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //edit
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Ambil data dari baris yang dipilih
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string id_booking = row.Cells["id_booking"].Value.ToString();
                string nama = row.Cells["nama"].Value.ToString();
                string meja = row.Cells["meja"].Value.ToString();
                string telepon = row.Cells["telepon"].Value.ToString();
                DateTime tanggal = Convert.ToDateTime(row.Cells["tanggal"].Value);
                TimeSpan jam_mulai = TimeSpan.Parse(row.Cells["jam_mulai"].Value.ToString());
                TimeSpan jam_selesai = TimeSpan.Parse(row.Cells["jam_selesai"].Value.ToString());

                // Buka form booking dan isi data
                FR_Booking formBooking = new FR_Booking(id_booking, nama, telepon, meja, tanggal, jam_mulai, jam_selesai);
                formBooking.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pilih satu baris untuk diedit.");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FR_Dashboard FR_Dashboard = new FR_Dashboard(); // Buat form login baru
            FR_Dashboard.Show(); 
            this.Hide(); 
        }

        private void FR_Daftarbooking_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            textBox1.Text = "Search...  ";
            textBox1.ForeColor = Color.Gray;
            DataTable dt = daftarBookingController.AmbilDaftarBooking();

            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Gagal memuat data booking.");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            //hapus
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string id_booking = dataGridView1.SelectedRows[0].Cells["id_booking"].Value.ToString();
                    
                    bool sukses = daftarBookingController.HapusBooking(id_booking);

                    if (sukses)
                    {
                        MessageBox.Show("Data berhasil dihapus.");
                        FR_Daftarbooking_Load(sender, e); // Refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data. Silakan coba lagi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih satu baris untuk dihapus.");
            }
        }
        //view
        public void CariData(string keyword)
        {
            dataGridView1.DataSource = daftarBookingController.CariData(keyword);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Search...  ")
            {
                this.ControlBox = false;
                DataTable dt = daftarBookingController.AmbilDaftarBooking();

                if (dt != null)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Gagal memuat data booking.");
                }
            }
            else
            {
                CariData(textBox1.Text);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search...  ")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Search...  ";
                textBox1.ForeColor = Color.Gray;
            }
        }
    }
}
