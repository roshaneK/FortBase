using Microsoft.EntityFrameworkCore;
using FortBase.Model;

namespace FortBase.Data
{
    public class FortBaseDbContext : DbContext
    {
        public FortBaseDbContext(DbContextOptions<FortBaseDbContext> options) : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
    }
}
