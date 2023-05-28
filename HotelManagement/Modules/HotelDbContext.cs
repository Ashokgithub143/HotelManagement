using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Modules
{
    public class HotelDbContext:DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>()
                .HasMany(h => h.Rooms)
                .WithOne(r => r.Hotel)
                .HasForeignKey(r => r.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
