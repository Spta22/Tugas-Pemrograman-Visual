using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalPS.Model;

namespace RentalPS.Controller
{
    public class DaftarBookingController
    {
        private readonly BookingManajemenQuery bookingQuery = new BookingManajemenQuery();

        // Ambil semua data booking
        public DataTable AmbilDaftarBooking()
        {
            return bookingQuery.AmbilDaftarBooking();
        }

        // Hapus booking berdasarkan id
        public bool HapusBooking(string id_booking)
        {
            if (string.IsNullOrWhiteSpace(id_booking))
                return false;

            return bookingQuery.HapusBooking(id_booking);
        }

        // Cari booking
        public DataTable CariData(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return AmbilDaftarBooking();

            return bookingQuery.Cari(keyword);
        }
    }
}
