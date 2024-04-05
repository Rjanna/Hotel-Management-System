using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class Hotel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Room> Rooms { get; set; }

        public Hotel(string name, string location)
        {
            Name = name;
            Location = location;
            Rooms = new List<Room>();
        }

        public List<Room> GetAvailableRooms(DateTime startDate, DateTime endDate)
        {
            List<Room> availableRooms = new List<Room>();
            foreach (Room room in Rooms)
            {
                if (room.IsAvailable && !IsRoomBooked(room, startDate, endDate))
                {
                    availableRooms.Add(room);
                }
            }
            return availableRooms;
        }

        private bool IsRoomBooked(Room room, DateTime startDate, DateTime endDate) => false;
    }
}
