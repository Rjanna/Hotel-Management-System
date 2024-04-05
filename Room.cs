using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string Style { get; set; }
        public bool IsAvailable { get; set; }
        public double Price { get; set; }
        public bool GetDetails { get; internal set; }

        public Room(int roomNumber, string style, bool isAvailable, double price)
        {
            RoomNumber = roomNumber;
            Style = style;
            IsAvailable = isAvailable;
            Price = price;
        }

    }
}
