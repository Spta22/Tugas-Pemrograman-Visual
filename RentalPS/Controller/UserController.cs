using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalPS.Model;

namespace RentalPS.Controller
{
    public class UserController
    {
        private readonly UserManajemenQuery userQuery = new UserManajemenQuery();

        public bool Login(string username, string password)
        {
            return userQuery.Login(username, password);
        }

        public bool BuatAkun(string username, string password, string role, string nama)
        {
            return userQuery.BuatAkun(username, password, role, nama);
        }
    }
}
