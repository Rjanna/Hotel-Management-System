using HotelSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class HotelSystem
    {
        private List<Hotel> _hotels = new List<Hotel>();

        public void AddHotel(Hotel hotel)
        {
            _hotels.Add(hotel);
        }

        public List<Room> GetAvailableRooms(DateTime startDate, DateTime endDate)
        {
            return _hotels.SelectMany(h => h.GetAvailableRooms(startDate, endDate)).ToList();
        }

        public void BookRoom(Guest guest, Hotel hotel, Room room, DateTime startDate, DateTime endDate)
        {
            guest.BookRoom(hotel, room, startDate, endDate);
        }

       
    }

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
            return Rooms.Where(room => room.IsAvailable && !IsRoomBooked(room, startDate, endDate)).ToList();
        }

        private bool IsRoomBooked(Room room, DateTime startDate, DateTime endDate)
        {

            return false;
        }
    }
}
