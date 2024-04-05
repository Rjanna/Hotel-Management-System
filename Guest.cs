using HotelSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Guest : User
    {
        public int TotalRoomsBooked { get; set; }

        public Guest(int id, string name, string address, string email, string phoneNumber, string password) : base(id, name, address, email, phoneNumber, password)
        {
            TotalRoomsBooked = 0;
        }

        public void BookRoom(Hotel hotel, Room room, DateTime startDate, DateTime endDate)
        {
            
            if (hotel.GetAvailableRooms(startDate, endDate).Contains(room))
            {
                room.IsAvailable = false;
                TotalRoomsBooked++;
                Console.WriteLine("Your room reservation is successful!"); 
            }
            else
            {
                Console.WriteLine("Room unavailable for selected dates.");
            }
        }
    }
}
