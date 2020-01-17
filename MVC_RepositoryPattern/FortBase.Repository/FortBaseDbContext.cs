using FortBase.Repository.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace FortBase.Repository
{
    public class FortBaseDbContext : DbContext
    {
        public FortBaseDbContext(DbContextOptions<FortBaseDbContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
    }
}
