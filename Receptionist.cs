using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Receptionist : User
    {
        public Receptionist(int id, string name, string address, string email, string phoneNumber, string password) : base(id, name, address, email, phoneNumber, password)
        {
        }
    }
}
