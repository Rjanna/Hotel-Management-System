using HotelSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HotelRoom> ewankonaRooms = new List<HotelRoom>();
            HotelRoom room1 = new HotelRoom(101, RoomStyle.Twin, 1500);
            HotelRoom room2 = new HotelRoom(102, RoomStyle.King, 3000);
            yananRooms.Add(room1);
            yananRooms.Add(room2);
            Hotel hotelYanan = new Hotel("Hotel Yanan", "123 GStreet, Takaw City", yananRooms);

            List<HotelRoom> hotel456Rooms = new List<HotelRoom>();
            HotelRoom hotel456Room1 = new HotelRoom(101, RoomStyle.Queen, 2000);
            HotelRoom hotel456Room2 = new HotelRoom(102, RoomStyle.Queen, 2000);
            hotel456Rooms.Add(hotel456Room1);
            hotel456Rooms.Add(hotel456Room2);
            Hotel hotel456 = new Hotel("Hotel 456", "Session Road, Baguio City", hotel456Rooms);

            HotelManagementSystem hms = new HotelManagementSystem();
            hms.AddHotel(hotelYanan);
            hms.AddHotel(hotel456);

            hms.DisplayHotels();

            hotelYanan.DisplayAvailableRooms();

            Guest terry = new Guest("Terry", "Addr 1", "terry@email.com", 63919129, "rawrhehe1");
            hms.RegisterUser(terry);

            hms.CreateBooking(hotelYanan, room1, terry, DateTime.Now, new DateTime(2024, 04, 16));
            hotelYanan.DisplayBookedRooms();
            terry.DisplayBookings();

            Receptionist anna = new Receptionist("Anna", "Addr 2", "anna@email.com", 67890, "rawrhehe<3");
            hms.RegisterUser(anna);

            Booking res = new Booking(new DateTime(2024, 05, 01), new DateTime(2024, 05, 06), hotel456Room2);
            anna.BookReservation(terry, res);

            terry.DisplayBookings();
            hms.DisplayBookingDetails(1234567890);
            Console.WriteLine(terry.TotalRoomCount);
        }
    }
}

