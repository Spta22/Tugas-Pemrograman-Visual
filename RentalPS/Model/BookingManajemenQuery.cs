using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RentalPS.Model
{
    public class BookingManajemenQuery
    {
        private Koneksi kon = new Koneksi();
        // bool = variable berisi true atau false
        public bool BuatBooking(string nama, string telepon, string meja, DateTime tanggal, TimeSpan jamMulai, TimeSpan jamSelesai)
        {
            try
            {
                kon.buka();

                string query = "INSERT INTO booking (nama, telepon, meja, tanggal, jam_mulai, jam_selesai) VALUES (@nama, @telepon, @meja, @tanggal, @jam_mulai, @jam_selesai)";
                MySqlCommand cmd = new MySqlCommand(query, kon.koneksi);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@telepon", telepon);
                cmd.Parameters.AddWithValue("@meja", meja);
                cmd.Parameters.AddWithValue("@tanggal", tanggal.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@jam_mulai", jamMulai.ToString(@"hh\:mm\:ss"));
                cmd.Parameters.AddWithValue("@jam_selesai", jamSelesai.ToString(@"hh\:mm\:ss"));

                cmd.ExecuteNonQuery();

                kon.tutup();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal daftar booking: " + ex.Message);
                return false;
            }
        }
            //edit
        public bool UpdateBooking(string bookingId, string nama, string telepon, string meja, DateTime tanggal, TimeSpan jamMulai, TimeSpan jamSelesai)
        {
            try
            {
                kon.buka();

                string query = "UPDATE booking SET nama = @nama, telepon = @telepon, meja = @meja, tanggal = @tanggal, jam_mulai = @jam_mulai, jam_selesai = @jam_selesai WHERE id_booking = @idbooking";
                MySqlCommand cmd = new MySqlCommand(query, kon.koneksi);
                cmd.Parameters.AddWithValue("@idbooking", bookingId);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@telepon", telepon);
                cmd.Parameters.AddWithValue("@meja", meja);
                cmd.Parameters.AddWithValue("@tanggal", tanggal.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@jam_mulai", jamMulai.ToString(@"hh\:mm\:ss"));
                cmd.Parameters.AddWithValue("@jam_selesai", jamSelesai.ToString(@"hh\:mm\:ss"));

                cmd.ExecuteNonQuery();

                kon.tutup();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal update booking: " + ex.Message);
                return false;
            }
        }

        public DataTable AmbilDaftarBooking()
        {
            try
            {
                kon.buka();
                DataSet ds = new DataSet();
                string sql = "SELECT * FROM booking";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, kon.koneksi);
                ds.Reset();
                da.Fill(ds);
                kon.tutup();
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal mengambil daftar booking: " + ex.Message);
                return null;
            }
        }

        public bool HapusBooking(string bookingId)
        {
            try
            {
                kon.buka();
                string sql = "DELETE FROM booking WHERE id_booking = @id";
                MySqlCommand cmd = new MySqlCommand(sql, kon.koneksi);
                cmd.Parameters.AddWithValue("@id", bookingId);
                cmd.ExecuteNonQuery();
                kon.tutup();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal menghapus booking: " + ex.Message);
                return false;
            }
        }

        public DataTable Cari(string keyword)

        {
            kon.buka();
            string sql = "SELECT * FROM booking WHERE nama LIKE @keyword OR tanggal LIKE @keyword OR id_booking LIKE @keyword";
            MySqlCommand cmd = new MySqlCommand(sql, kon.koneksi);
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            kon.tutup();
            return ds.Tables[0];

        }
    }
}
