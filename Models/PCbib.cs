using Microsoft.EntityFrameworkCore;
using AZapp;

public class PCbibDbContext : DbContext
{
    public PCbibDbContext(DbContextOptions<PCbibDbContext> options) : base(options)
    {
    }

    public DbSet<PCs> PCs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PCs>().ToTable("pcsbib"); // Nom exact de ta table
    }
}