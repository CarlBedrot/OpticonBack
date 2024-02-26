using Microsoft.EntityFrameworkCore;

public class TopologiEditorContext : DbContext
{   
    public DbSet<Picture> Pictures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=yourdatabase.db");
    }

} 