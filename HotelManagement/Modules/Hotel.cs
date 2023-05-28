using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Modules
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        public string? HName { get; set; }
        public string? HPlace { get; set; }
        public int? HCost { get;set; }
        public string HType { get; set; }
        public ICollection<Room> Rooms { get; set; }

    }
}
