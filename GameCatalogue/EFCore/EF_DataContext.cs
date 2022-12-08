using Microsoft.EntityFrameworkCore;

namespace GameCatalogue.EFCore
{
    public class EF_DataContext : DbContext
    {
        // Constructor inheriting base class and passing options 
        public EF_DataContext(DbContextOptions<EF_DataContext> options): base(options) { }

        // Adding DbSet tables
        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
