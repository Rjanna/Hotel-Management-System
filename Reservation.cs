﻿using HotelManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class Reservation
    {
        public int ReservationNumber { get; set; }
        public Guest Guest { get; set; }
        public Hotel Hotel { get; set; }
        public Room Room { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DurationInDays { get; set; }

        public Reservation(int reservationNumber, Guest guest, Hotel hotel, Room room, DateTime startDate, DateTime endDate)
        {
            ReservationNumber = reservationNumber;
            Guest = guest;
            Hotel = hotel;
            Room = room;
            StartDate = startDate;
            EndDate = endDate;
            DurationInDays = (EndDate - StartDate).Days + 1;
        }

        public string GetDetails()
        {
            return $"Reservation Number: {ReservationNumber}\n" +
                   $"Guest: {Guest.Name}\n" +
                   $"Hotel: {Hotel.Name} ({Hotel.Location})\n" +
                   $"Room: {Room.RoomNumber} ({Room.Style})\n" +
                   $"Start Date: {StartDate:yyyy-MM-dd}\n" +
                   $"End Date: {EndDate:yyyy-MM-dd}\n" +
                   $"Duration: {DurationInDays} days";
        }
    }
}
