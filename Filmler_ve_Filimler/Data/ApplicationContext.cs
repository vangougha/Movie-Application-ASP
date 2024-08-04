using Microsoft.EntityFrameworkCore;
using Filmler_ve_Filimler.Models;

namespace Filmler_ve_Filimler.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<MovieViewModel> Movies { get; set; }
    }
}
