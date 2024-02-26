using Microsoft.EntityFrameworkCore;
using OpticonBackend.Models;
namespace OpticonBackend.Data
{

    public class TopologiEditorContext : DbContext
    {
        public DbSet<Picture> Pictures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=OpticonBackend.db");
        }

    }
}