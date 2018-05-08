using AccuGazer.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AccuGazer.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<Settings> Settings { get; set; }
    }
}