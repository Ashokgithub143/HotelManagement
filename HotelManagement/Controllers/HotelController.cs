using HotelManagement.Modules;
using HotelManagement.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelRepository _hRepository;

        public HotelController(IHotelRepository HRepository)
        {
            _hRepository = HRepository;
        }

        [HttpGet]
        public IActionResult GetAllHotels()
        {
            var hotels = _hRepository.GetAllHotels();
            return Ok(hotels);
        }

        [HttpGet("{id}")]
        public IActionResult GetHotelById(int id)
        {
            var hotel = _hRepository.GetHotelById(id);
            if (hotel == null)
                return NotFound();

            return Ok(hotel);
        }

        [HttpPost]
        public IActionResult CreateHotel([FromBody] Hotel hotel)
        {
            _hRepository.AddHotel(hotel);
            return CreatedAtAction(nameof(GetHotelById), new { id = hotel.Id }, hotel);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateHotel(int id, [FromBody] Hotel hotel)
        {
            if (id != hotel.Id)
                return BadRequest();

            _hRepository.UpdateHotel(hotel);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHotel(int id)
        {
            _hRepository.DeleteHotel(id);
            return NoContent();
        }
    }
}
