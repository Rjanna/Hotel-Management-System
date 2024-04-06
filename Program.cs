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
            Room room1 = new Room(101, RoomStyle.Twin, 1500);
            Room room2 = new Room(102, RoomStyle.King, 3000);
            ewankonaRooms.Add(room1);
            ewankonaRooms.Add(room2);
            Hotel hotelHakdog = new Hotel("Hotel Hakdog", "145 Iyak, Bangag City", ewankonaRooms);

            List<Room> itlogRooms = new List<Room>();
            Room itlogRoom1 = new Room(101, RoomStyle.Queen, 2000);
            Room itlogRoom2 = new Room(102, RoomStyle.Queen, 2000);
            itlogRooms.Add(itlogRoom1);
            itlogRooms.Add(itlogRoom2);
            Hotel hotelItlog = new Hotel("Bangus Residence", "Session Road, Baguio City", itlogRooms);

            HotelSystem hms = new HotelSystem();
            hms.AddHotel(hotelHakdog);
            hms.AddHotel(hotelItlog);

            hms.DisplayHotels();

            hotelHakdog.DisplayAvailableRooms();

            Guest who = new Guest("Who", "SaKanal Street", "Whoknows@email.com", 63919129, "okay");
            hms.RegisterUser(who);

            hms.CreateBooking(hotelHakdog, room1, who, DateTime.Now, new DateTime(2024, 04, 16));
            hotelHakdog.DisplayBookedRooms();
            who.DisplayBookings();

            Receptionist anna = new Receptionist("Anna", "Addr 2", "anna@email.com", 67890, "boompanes");
            hms.RegisterUser(anna);

            Booking res = new Booking(new DateTime(2024, 05, 01), new DateTime(2024, 05, 06), itlogRoom2);
            anna.BookReservation(who, res);

            who.DisplayBookings();
            hms.DisplayBookingDetails(1234567890);
            Console.WriteLine(who.TotalRoomCount);
        }
    }
}

