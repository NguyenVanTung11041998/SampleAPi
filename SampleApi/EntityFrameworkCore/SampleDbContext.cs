using Microsoft.EntityFrameworkCore;
using SampleApi.Entities;

namespace SampleApi.EntityFrameworkCore
{
    public class SampleDbContext : DbContext
    {
        public DbSet<ClassRoom> ClassRooms { get; set; }

        public DbSet<Student> Students { get; set; }

        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options)
        {

        }
    }
}
