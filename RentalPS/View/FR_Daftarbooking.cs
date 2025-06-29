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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System.IO;
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
            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
        }
        private void DataGridView1_DataBindingComplete(object sender,
                          DataGridViewBindingCompleteEventArgs e)

        {
            //kolom harga 
            if (dataGridView1.Columns.Contains("harga"))
            {
                var col = dataGridView1.Columns["harga"];
                col.HeaderText = "Harga (Rp)";
                col.DefaultCellStyle.Format = "N0";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih dulu 1 booking yang ingin dicetak.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string id = row.Cells["id_booking"].Value.ToString();
            string nama = row.Cells["nama"].Value.ToString();
            string telepon = row.Cells["telepon"].Value.ToString();
            string meja = row.Cells["meja"].Value.ToString();
            DateTime tanggal = Convert.ToDateTime(row.Cells["tanggal"].Value);
            string jamMulai = row.Cells["jam_mulai"].Value.ToString();
            string jamSelesai = row.Cells["jam_selesai"].Value.ToString();
            string hargaText = row.Cells["harga"].Value?.ToString() ?? "0";

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Simpan Struk Booking";
            sfd.Filter = "PDF files (*.pdf)|*.pdf";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            string filePath = sfd.FileName;

            Document doc = new Document(PageSize.A5, 36, 36, 36, 36);
            PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
            doc.Open();

            //Font
            var titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
            var headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
            var cellFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11);
            var footerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.ITALIC);

            string logoPath = @"C:\Users\SEPTAASIKK\Documents\Pemrograman visual smt 6\ikon\PlayStation.png";
            if (File.Exists(logoPath))
            {
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                logo.Alignment = Element.ALIGN_CENTER;
                logo.ScaleToFit(80f, 80f);
                logo.SpacingAfter = 10f;
                doc.Add(logo);
            }
            //Judul
            Paragraph title = new Paragraph("STRUK PEMBAYARAN BOOKING PLAYSTATION",titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 10f;
            doc.Add(title);

            Paragraph Tempat = new Paragraph("~MEIINSYAALLAH PS5~", titleFont);
            Tempat.Alignment = Element.ALIGN_CENTER;
            Tempat.SpacingAfter = 10f;
            doc.Add(Tempat);

            Paragraph subText = new Paragraph("Dsn, Mojorejo Ds, Plosoharjo Kec, Pace Kab, Nganjuk\nNo telp : 081654902946",
            new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL));
            subText.Alignment = Element.ALIGN_CENTER;
            subText.SpacingAfter = 15f; 
            doc.Add(subText);

            LineSeparator line = new LineSeparator(1f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, -1);
            doc.Add(new Chunk(line));
            doc.Add(new Paragraph("\n"));

            // Tabel 
            PdfPTable tbl = new PdfPTable(2);
            tbl.WidthPercentage = 100;
            tbl.SpacingBefore = 10f;
            tbl.SpacingAfter = 10f;
            tbl.HorizontalAlignment = Element.ALIGN_LEFT;

            float[] widths = { 35f, 65f }; //lebar kolom
            tbl.SetWidths(widths);

            //border
            void AddRow(string label, string value)
            {
                PdfPCell cell1 = new PdfPCell(new Phrase(label, headerFont));
                cell1.Border = PdfPCell.BOTTOM_BORDER;
                cell1.PaddingBottom = 10;
                cell1.PaddingTop = 5;
                cell1.BackgroundColor = new BaseColor(240, 240, 240);

                PdfPCell cell2 = new PdfPCell(new Phrase(value, cellFont));
                cell2.Border = PdfPCell.BOTTOM_BORDER;
                cell2.PaddingBottom = 10;
                cell1.PaddingTop = 5;

                tbl.AddCell(cell1);
                tbl.AddCell(cell2);
            }

            AddRow("ID Booking", id);
            AddRow("Nama", nama);
            AddRow("Telepon", telepon);
            AddRow("Meja", meja);
            AddRow("Tanggal", tanggal.ToString("dd MMMM yyyy"));
            AddRow("Jam Mulai", jamMulai);
            AddRow("Jam Selesai", jamSelesai);
            AddRow("Total Harga", int.Parse(hargaText).ToString("C0", new System.Globalization.CultureInfo("id-ID")));

            doc.Add(tbl);

            Paragraph footer = new Paragraph("\nTerima kasih telah menggunakan layanan kami.", footerFont);
            footer.Alignment = Element.ALIGN_CENTER;
            doc.Add(footer);

            doc.Close();

            MessageBox.Show("Struk berhasil disimpan.", "Sukses");
        }
    }
}
