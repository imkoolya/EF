using Microsoft.EntityFrameworkCore;

public class AppContext : DbContext
{

    public DbSet<User> Users { get; set; }

    public AppContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=VIBIN\SQLEXPRESS;Database=EF;Trusted_Connection=True");
    }
}