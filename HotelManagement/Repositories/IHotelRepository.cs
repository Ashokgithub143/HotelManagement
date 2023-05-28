using HotelManagement.Modules;

namespace HotelManagement.Repositories
{
    public interface IHotelRepository
    {
        Hotel GetHotelById(int id);
        IEnumerable<Hotel> GetAllHotels();
        void AddHotel(Hotel hotel);
        void UpdateHotel(Hotel hotel);
        void DeleteHotel(int id);
    }
}
