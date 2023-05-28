
using HotelManagement.Modules;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Repositories
{
    public class RoomRepository : IRoom
    {
        private readonly HotelDbContext _dbContext;

        public RoomRepository(HotelDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public Room GetRoomById(int id)
        {
            var userobj = _dbContext.Rooms.Find(id);
            return userobj;
        }

        public IEnumerable<Room> GetAllRoom()
        {
            return _dbContext.Rooms.ToList();
        }

        public void AddRoom(Room rooms)
        {
            _dbContext.Rooms.Add(rooms);
            _dbContext.SaveChanges();
        }

        public void UpdateRoom(Room rooms, int id)
        {
            var ress = _dbContext.Rooms.Find(id);
            ress.IsActive = rooms.IsActive;
            _dbContext.Rooms.Update(ress);
            _dbContext.SaveChanges();
        }

        public void DeleteRoom(int id)
        {
            var Rooms = _dbContext.Rooms.Find(id);
            _dbContext.Rooms.Remove(Rooms);
            _dbContext.SaveChanges();
        }
    }
}