using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Receptionist: User
    {
        public Receptionist(string name, string address, string email, int phoneNumber, string password) : 
            base(name, address, email, phoneNumber, password)
        {
        }
        public void BookReservation(Guest guest, Booking booking)
        {
            guest.TotalRoomCount++;
            guest.Booking.Add(booking);
        }
    }
}
