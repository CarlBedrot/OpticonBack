using Microsoft.EntityFrameworkCore;
using OpticonBackend.Models;

namespace OpticonBackend.Data
{

    public class TopologiEditorContext : DbContext
    {
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<PictureAccess> PictureAccesses { get; set; }

        public DbSet<Component> Components { get; set; }
        public DbSet<ComponentType> ComponentTypes { get; set; }

        public DbSet<ProductionUnit> ProductionUnits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=OpticonBackend.db");
        }

    }
}