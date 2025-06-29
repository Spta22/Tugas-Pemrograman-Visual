using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace RentalPS.Model
{
    public class UserManajemenQuery
    {
        private Koneksi kon = new Koneksi();

        public bool Login(string username, string password)
        {
            try
            {
                kon.buka();
                string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, kon.koneksi);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                MySqlDataReader reader = cmd.ExecuteReader();

                bool berhasilogin = reader.HasRows;

                kon.tutup();

                return berhasilogin;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Gagal login: " + ex.Message);
                return false;
            }
        }

        public bool BuatAkun(string username, string password, string nama)
        {
            try
            {
                kon.buka();
                string query = "INSERT INTO users (username, password, nama) VALUES (@username, @password, @nama)";
                MySqlCommand cmd = new MySqlCommand(query, kon.koneksi);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@nama", nama);

                cmd.ExecuteNonQuery();
                kon.tutup();
                    
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal daftar: " + ex.Message);
                return false;
            }
        }
    }
}
