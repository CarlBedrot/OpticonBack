using Microsoft.EntityFrameworkCore;

public class TopologiEditorContext : DbContext
{   
    public DbSet<Picture> Pictures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=testdb;User Id=testuser;Password=1234;trustservercertificate=true;");
    }

} 