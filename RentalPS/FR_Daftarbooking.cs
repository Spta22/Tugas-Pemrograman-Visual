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
    public partial class FR_Daftarbooking : Form
    {
        Koneksi koneksi;
        public FR_Daftarbooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //edit
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FR_Dashboard FR_Dashboard = new FR_Dashboard(); // Buat form login baru
            FR_Dashboard.Show(); // Tampilkan form login
            this.Hide(); // Sembunyikan form saat ini (FR_Buatakun)
        }

        private void FR_Daftarbooking_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            try
            {
                koneksi = new Koneksi();
                DataSet ds = new DataSet();
                DataTable dt;
                koneksi.buka();
                var con = koneksi.koneksi;
                string sql = "select * from booking";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                koneksi.tutup();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
