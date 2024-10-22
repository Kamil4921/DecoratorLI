using Microsoft.EntityFrameworkCore;

namespace DecoratorUseCase;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Weather> Weather { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Weather>().HasData(
            new Weather { Id = 1, Place = "Wroclaw", Temperature = 26 },
            new Weather { Id = 2, Place = "Warsaw", Temperature = 19}
        );
    }
}