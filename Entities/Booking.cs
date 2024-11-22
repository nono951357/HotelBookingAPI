using System.Text.Json.Serialization;

namespace HotelBookingAPI.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        // Navigációs tulajdonságok
        [JsonIgnore]
        public virtual Guest Guest { get; set; }
        [JsonIgnore]
        public virtual Room Room { get; set; }

    }
}
