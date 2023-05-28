using HotelManagement.Modules;

namespace HotelManagement.Repositories
{
    public interface IFilter
    {
        IEnumerable<Hotel> GetFilteredHotels(string? Place, decimal? minPrice, decimal? maxPrice);
        int Results(int id);
    }
}
