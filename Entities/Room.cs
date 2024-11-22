﻿namespace HotelBookingAPI.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        // Például: Egyágyas, Kétágyas, Lakosztály
        public string Type { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

    }
}
