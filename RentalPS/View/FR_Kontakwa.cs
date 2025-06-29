using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RentalPS
{
    public partial class FR_Kontakwa : Form
    {
        public FR_Kontakwa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FR_Dashboard FR_Dashboard = new FR_Dashboard(); 
            FR_Dashboard.Show(); 
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string phone = "6281654902946";  
            string message = Uri.EscapeDataString("Halo, saya ingin booking PS.");
            string url = $"https://wa.me/6281654902946?text={message}";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true      
            });
        }
    }
}
