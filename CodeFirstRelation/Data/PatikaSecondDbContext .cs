using CodeFirstRelation.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

public class PatikaSecondDbContext : DbContext
{
    // Constructor to configure the options
    public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options)
        : base(options) { }

    // DbSet properties for the tables
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }

    // Configuring the database schema
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // User-Post relationship: One-to-Many
        modelBuilder.Entity<User>()
            .HasMany(u => u.Posts)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId);

        base.OnModelCreating(modelBuilder);
    }

    // Configure database connection
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=PatikaCodeFirstDb2.db");
        }
    }
}
