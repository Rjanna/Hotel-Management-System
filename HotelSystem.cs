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
        private List<Booking> _allBookings = new List<Booking>();
        private List<Hotel> _allHotels = new List<Hotel>();
        private List<User> _allUsers = new List<User>();
        public void AddHotel(Hotel hotel)
        {
            _allHotels.Add(hotel);
        }
        public void RegisterUser(User user)
        {
            _allUsers.Add(user);
        }
        public void DisplayBookingDetails(int reservationNumber)
        {
            Console.WriteLine($"\nDetails of Reservation {reservationNumber}:");
            foreach (var booking in _allBookings)
            {
                if (booking.ReservationNumber == reservationNumber)
                {
                    Console.WriteLine($"{booking.ReservationNumber} Start Time: {booking.CheckIn}, End Time {booking.CheckOut}, Duration: {booking.Duration}, Total: {booking.Price} ");
                }
            }
        }
        public Booking CreateBooking(Hotel hotel, HotelRoom room, Guest guest, DateTime checkInDate, DateTime checkOutDate)
        {
            guest.TotalRoomCount++;
            var booking = new Booking(checkInDate, checkOutDate, room);
            guest.Booking.Add(booking);
            _allBookings.Add(booking);
            return booking;
        }
        public void DisplayHotels()
        {
            Console.WriteLine("List of Hotels:");
            foreach (var hotel in _allHotels)
            {
                Console.WriteLine(hotel.Name +", "+ hotel.Address);
            }
        }
    }
}
