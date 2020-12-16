using Microsoft.EntityFrameworkCore;
using testInspiro.Models;

namespace testInspiro.Persistance
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Foods> Foods { get; set; }
    }
}