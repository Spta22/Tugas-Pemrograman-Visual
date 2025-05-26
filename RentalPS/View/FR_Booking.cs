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
using RentalPS.Model;
using RentalPS.Controller;
// view
namespace RentalPS
{
    public partial class FR_Booking : Form
    {
        BookingController bookingController = new BookingController();
        private string bookingid;

        public FR_Booking(string id_booking, string nama, string telepon, string meja, DateTime tanggal, TimeSpan jam_mulai, TimeSpan jam_selesai)
        {
            InitializeComponent();

            // Isi field dengan data dari form sebelumnya
            bookingid = id_booking;

            textNama.Text = nama;
            textTelepon.Text = telepon;
            comboMeja.SelectedItem = meja;
            dateTanggal.Value = tanggal;
            jamMulai.Value = DateTime.Today.Add(jam_mulai);
            jamSelesai.Value = DateTime.Today.Add(jam_selesai);

            button1.Visible = true;
        }

        public FR_Booking()
        {
            InitializeComponent();
            button2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kembaliData()
        {
            FR_Daftarbooking FR_Daftarbooking = new FR_Daftarbooking(); // Buat form login baru
            FR_Daftarbooking.Show(); 
            this.Hide(); 
        }

        private void kembaliDashboard()
        {
            FR_Dashboard FR_Dashboard = new FR_Dashboard(); 
            FR_Dashboard.Show(); 
            this.Hide(); 
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            if (bookingid != null)
            {
                kembaliData();
            }
            else
            {
                kembaliDashboard();
            }
        }
        //panggil
        private void button1_Click(object sender, EventArgs e)
        {
            bool sukses = bookingController.BuatBooking(
                textNama.Text,
                textTelepon.Text,
                comboMeja.SelectedItem.ToString(),
                dateTanggal.Value,
                jamMulai.Value.TimeOfDay,
                jamSelesai.Value.TimeOfDay
            );

            if (sukses)
            {
                MessageBox.Show("Booking berhasil ditambahkan!");
                FR_Dashboard dashboard = new FR_Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Gagal menambahkan booking. Silakan coba lagi.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool sukses = bookingController.UpdateBooking(
                bookingid,
                textNama.Text,
                textTelepon.Text,
                comboMeja.SelectedItem.ToString(),
                dateTanggal.Value,
                jamMulai.Value.TimeOfDay,
                jamSelesai.Value.TimeOfDay
            );

            if (sukses)
            {
                MessageBox.Show("Booking berhasil diperbarui!");
                FR_Daftarbooking daftarbooking = new FR_Daftarbooking();
                daftarbooking.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Gagal memperbarui booking. Silakan coba lagi.");
            }
        }
    }
}
