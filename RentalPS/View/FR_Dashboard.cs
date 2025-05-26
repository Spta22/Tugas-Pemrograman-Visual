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
            FR_Booking.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FR_Promo FR_Promo = new FR_Promo(); // Buat instance dari form baru
            FR_Promo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FR_Daftarharga FR_Daftarharga = new FR_Daftarharga(); // Buat instance dari form baru
            FR_Daftarharga.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FR_Kontakwa FR_Kontakwa = new FR_Kontakwa(); // Buat instance dari form baru
            FR_Kontakwa.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formlogin loginForm = new Formlogin(); // Buat form login baru
            loginForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FR_Daftarbooking FR_Daftarbooking = new FR_Daftarbooking(); // Buat form login baru
            FR_Daftarbooking.Show();
            this.Hide();
        }
    }
}
