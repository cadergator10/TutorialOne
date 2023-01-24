using Microsoft.EntityFrameworkCore;
using TutorialOne.Models;

namespace TutorialOne.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<CoverType> CoverType { get; set; }
    }
}
