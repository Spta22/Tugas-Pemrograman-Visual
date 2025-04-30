using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace cobaKoneksiDatabase
{
    public class Koneksi
    {
        string mysqlCon = "server=127.0.0.1;user=root;database=rentalps;password=";
        public MySqlConnection koneksi;

        public void buka()
        {
            koneksi = new MySqlConnection(mysqlCon);
            koneksi.Open();
        }

        public void tutup()
        {
            koneksi = new MySqlConnection(mysqlCon);
            koneksi.Close();
        }
    }
}

