using AccuGazer.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AccuGazer.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<Rectangle> Rectangles { get; set; }
        public DbSet<GazePoint> GazePoints { get; set; }
    }
}