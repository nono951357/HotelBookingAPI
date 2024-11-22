using HotelBookingAPI.Context;
using HotelBookingAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuestsController(HotelContext context) : ControllerBase
    {
        private readonly HotelContext _context = context;

        [HttpGet]
        public IActionResult GetGuests()
        {
            return Ok(_context.Guests);
        }

        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var guest = _context.Guests.Find(id);
            if (guest == null)
            {
                return NotFound();
            }
            return Ok(guest);
        }

        [HttpPost]
        public IActionResult PostGuest(Guest guest)
        {
            _context.Guests.Add(guest);
            _context.SaveChanges();
            return CreatedAtAction("GetGuest", new { id = guest.Id }, guest);
        }

        [HttpPut("{id}")]

        public IActionResult PutGuest(int id, Guest guest)
        {
            guest.Id = id;
            _context.Entry(guest).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var guest = _context.Guests.Find(id);
            if (guest == null)
            {
                return NotFound();
            }
            _context.Guests.Remove(guest);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
