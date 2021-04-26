
using Microsoft.EntityFrameworkCore;
using PAI_Projet_1._0.Models;

namespace PAI_Projet_1._0.dal
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
