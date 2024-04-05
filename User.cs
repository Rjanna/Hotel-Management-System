using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class User
    {
        private static int s_UserIDSeed = 6;
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        public User(int ID, string name, string address, string email, string phoneNumber, string password)
        {
            this.ID = s_UserIDSeed++;
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
        }

        public static User Register(string name, string address, string email, string phoneNumber, string password)
        {
            int userID = 1; 
            return new User(userID, name, address, email, phoneNumber, password);
        }
    }
}
