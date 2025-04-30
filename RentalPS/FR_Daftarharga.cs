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
    public partial class FR_Daftarharga : Form
    {
        public FR_Daftarharga()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FR_Dashboard FR_Dashboard = new FR_Dashboard(); // Buat form login baru
            FR_Dashboard.Show(); // Tampilkan form login
            this.Hide(); // Sembunyikan form saat ini (FR_Buatakun)
        }
    }
}
