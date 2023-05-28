using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Modules
{
    public class Room
    {
        [Key]
        public int RId { get; set; }
        public string? Name { get; set; }
        public bool ? IsActive { get; set; }
        public string? RoomNumber { get;set; }


        public int Price { get; set; }
        public int? Id { get; set; }
        public Hotel?Hotel { get; set; }

    }
}
