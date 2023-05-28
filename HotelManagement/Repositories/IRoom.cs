using HotelManagement.Modules;

namespace HotelManagement.Repositories
{
    public interface IRoom
    {
        Room GetRoomById(int id);
        IEnumerable<Room> GetAllRoom();
        void AddRoom(Room Rooms);
        void UpdateRoom(Room Rooms, int id);
        void DeleteRoom(int id);
    }
}
