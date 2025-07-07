using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RentalPS.View
{
    public partial class FR_FotoRoom : Form
    {
        public FR_FotoRoom()
        {
            InitializeComponent();
        }

        /* ---------- Tombol Foto 1 ---------- */
        private void button1_Click(object sender, EventArgs e)
        {
            TampilkanGambar("pps1.jpg");
        }

        /* ---------- Tombol Foto 2 ---------- */
        private void button2_Click(object sender, EventArgs e)
        {
            TampilkanGambar("pps2.jpg");
        }

        /* ---------- Tombol Foto 3 ---------- */
        private void button3_Click(object sender, EventArgs e)
        {
            TampilkanGambar("pps3.jpg");
        }

        /* ---------- Tombol Foto 4 ---------- */
        private void button4_Click(object sender, EventArgs e)
        {
            TampilkanGambar("pps4.jpg");
        }

        /* ---------- Tombol Foto 5 ---------- */
        private void button5_Click(object sender, EventArgs e)
        {
            TampilkanGambar("pps5.jpg");
        }

        /* ---------- Tombol Foto 6 ---------- */
        private void button6_Click(object sender, EventArgs e)
        {
            TampilkanGambar("pps6.jpg");
        }

        /* ---------- Tombol Kembali ---------- */
        private void button7_Click(object sender, EventArgs e)
        {
            FR_Dashboard FR_Dashboard = new FR_Dashboard();
            FR_Dashboard.Show();
            this.Hide();
        }

        /* ---------- Fungsi bantu ---------- */
        private void TampilkanGambar(string namaFile)
        {
            string fullPath = @"C:\Users\SEPTAASIKK\Documents\Pemrograman visual smt 6\RentalPIES\RentalPS\Foto\" + namaFile;

            if (File.Exists(fullPath))
            {
                picturePreview.Image?.Dispose();           // bebasin gambar lama
                picturePreview.Image = Image.FromFile(fullPath);
                picturePreview.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show($"Gambar '{namaFile}' tidak ditemukan di folder Foto.");
            }
        }
    }
}
