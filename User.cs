using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
     public class User
    {
        private static int _idseed = 0;
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int ID { get; private set; }
        protected string Password { get; set; }
        public User(string name, string address, string email, int phoneNumber, string password)
        {
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            ID = _idseed++;
            Password = password;
        }

    }
}
