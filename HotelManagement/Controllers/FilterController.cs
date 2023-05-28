using HotelManagement.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FilterController : ControllerBase
    {
        private readonly IFilter _hotelRepository;

        public FilterController(IFilter hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }
        [HttpGet]
        public IActionResult GetAllHotels(string Place = null, decimal? minPrice = null, decimal? maxPrice = null)
        {
            var hotels = _hotelRepository.GetFilteredHotels(Place, minPrice, maxPrice);
            return Ok(hotels);
        }

        [HttpGet("{id}")]
        public int GetCount(int id)
        {
            var res = _hotelRepository.Results(id);

            return res;
        }

    }
}
