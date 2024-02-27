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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Component>()
                .HasMany(c => c.RelatedComponents)
                .WithMany(c => c.ComponentsRelatedTo)
                .UsingEntity<Dictionary<string, object>>(
                    "ComponentRelation", // Name of the join table
                    j => j.HasOne<Component>().WithMany().HasForeignKey("RelatedComponentId"), // Configure the first part of the relation
                    j => j.HasOne<Component>().WithMany().HasForeignKey("ComponentId") // Configure the second part of the relation
                );

            modelBuilder.Entity<Component>()
   .HasMany(c => c.EnergyFlows)
   .WithMany() // Since it's a self-referencing relationship, the second part refers to the same entity.
   .UsingEntity<Dictionary<string, object>>(
       "ComponentEnergyFlow", // Name of the join table for EnergyFlows
       left => left.HasOne<Component>().WithMany().HasForeignKey("ComponentId"), // Configuration for the entity on the left side of the relationship
       right => right.HasOne<Component>().WithMany().HasForeignKey("EnergyFlowId") // Configuration for the entity on the right side of the relationship
   );
        }

    }
}