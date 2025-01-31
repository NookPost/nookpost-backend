using NookpostBackend.Models;
using Microsoft.EntityFrameworkCore;
using NookpostBackend.Development;

namespace NookpostBackend.Data;

#nullable disable

/// <summary>
/// Create a Context for the API
/// </summary>
public class DatabaseHandle : DbContext
{
    /// <summary>
    /// A table to save UserSecrets
    /// </summary>
    public DbSet<User> Users { get; set; }

    /// <summary>
    /// Set the DBPath to the ./database.db
    /// </summary>
    public DatabaseHandle(DbContextOptions<DatabaseHandle> Options) : base(Options)
    {
    }

    /// <summary>
    /// Initialization Method for the Database Handle.
    /// Initializes the DB with sample data in case the application is running in Dev mode.
    /// </summary>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
        {
                System.Console.WriteLine("Dev Environment");
            modelBuilder.Seed();
        }
    }
}

#nullable restore
