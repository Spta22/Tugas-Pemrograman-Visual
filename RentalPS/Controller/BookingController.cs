using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalPS.Model;

namespace RentalPS.Controller
{
    public class BookingController
    {
        private readonly BookingManajemenQuery bookingQuery = new BookingManajemenQuery();

        public bool BuatBooking(string nama, string telepon, string meja, DateTime tanggal, TimeSpan jamMulai, TimeSpan jamSelesai)
        {
            // Bisa tambah validasi di sini
            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(telepon))
                return false;

            return bookingQuery.BuatBooking(nama, telepon, meja, tanggal, jamMulai, jamSelesai);
        }

        public bool UpdateBooking(string id, string nama, string telepon, string meja, DateTime tanggal, TimeSpan jamMulai, TimeSpan jamSelesai)
        {
            return bookingQuery.UpdateBooking(id, nama, telepon, meja, tanggal, jamMulai, jamSelesai);
        }
    }
}
