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

namespace RentalPS
{
    public partial class FR_Buatakun : Form
    {
        private UserController userController = new UserController();
        public FR_Buatakun()
        {
            InitializeComponent();
        }

        private void btndaftar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string nama = txtNama.Text;
            string role = cmboRole.SelectedItem?.ToString();

            // Validasi input kosong
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Semua field harus diisi!");
                return;
            }
            //buat akun
            bool sukses = userController.BuatAkun(username, password, role, nama);
            if (sukses)
            {
                MessageBox.Show("Akun berhasil didaftarkan!");
                Formlogin loginForm = new Formlogin();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Gagal mendaftarkan akun. Silakan coba lagi.");
            }
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
             Formlogin loginForm = new Formlogin(); // Buat form login baru
             loginForm.Show(); 
             this.Hide(); 
        }
    }
}
