using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RentalPS.View
{
    public partial class FR_Splash : Form
    {
        private System.Windows.Forms.Timer timer;
        private Label lblText;
        private int speed = 2; // Kecepatan gerak teks
        private DateTime startTime;
        public FR_Splash()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            lblText = new Label();
            lblText.Text = "Selamat Datang di Aplikasi Booking Playstation MeinsyaAllah";
            lblText.AutoSize = true;
            lblText.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblText.ForeColor = Color.Black;
            lblText.BackColor = Color.Transparent;
            lblText.Top = (this.ClientSize.Height / 2) - 20;
            lblText.Left = -lblText.Width; // mulai dari luar layar kiri

            this.Controls.Add(lblText);

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Gray;
            this.ClientSize = new Size(600, 200);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 20; // ~50fps
            timer.Tick += Timer_Tick;
            timer.Start();
            startTime = DateTime.Now;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Geser teks ke kanan
            lblText.Left += speed;

            // Reset ke kiri jika sudah keluar layar kanan
            if (lblText.Left > this.ClientSize.Width)
            {
                lblText.Left = -lblText.Width;
            }

            // Tutup splash setelah 5 detik
            if ((DateTime.Now - startTime).TotalMilliseconds >= 5000)
                timer.Stop();
            this.Hide();
            //new Formlogin().Show(); // Ganti ke nama form login kamu
        }

        private void FR_Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
