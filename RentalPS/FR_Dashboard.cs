using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalPS
{
    public partial class FR_Dashboard : Form
    {
        public FR_Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FR_Booking FR_Booking = new FR_Booking(); // Buat instance dari form baru
            FR_Booking.Show(); // Tampilkan form
            this.Hide(); // Sembunyikan form login (opsional)
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FR_Promo FR_Promo = new FR_Promo(); // Buat instance dari form baru
            FR_Promo.Show(); // Tampilkan form
            this.Hide(); // Sembunyikan form login (opsional)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FR_Daftarharga FR_Daftarharga = new FR_Daftarharga(); // Buat instance dari form baru
            FR_Daftarharga.Show(); // Tampilkan form
            this.Hide(); // Sembunyikan form login (opsional)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FR_Kontakwa FR_Kontakwa = new FR_Kontakwa(); // Buat instance dari form baru
            FR_Kontakwa.Show(); // Tampilkan form
            this.Hide(); // Sembunyikan form login (opsional)
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formlogin loginForm = new Formlogin(); // Buat form login baru
            loginForm.Show(); // Tampilkan form login
            this.Hide(); // Sembunyikan form saat ini (FR_Buatakun)
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FR_Daftarbooking FR_Daftarbooking = new FR_Daftarbooking(); // Buat form login baru
            FR_Daftarbooking.Show(); // Tampilkan form login
            this.Hide(); // Sembunyikan form saat ini (FR_Buatakun)
        }
    }
}
