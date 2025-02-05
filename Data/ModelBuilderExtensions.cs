using Microsoft.EntityFrameworkCore;

namespace NookpostBackend.Data;
/// <summary>
/// Creates some sample database entries, when running in the development mode.
/// </summary>
public static class ModelBuilderExtensions
{
    /// <summary>
    /// Populates the database with the sample data for testing and development.
    /// </summary>
    public static void SeedTestData(this ModelBuilder modelBuilder)
    {
        SeedUsers(modelBuilder);
    }

    /// <summary>
    /// Seeds the database with data
    /// </summary>
    public static void Seed(this ModelBuilder modelBuilder)
    {
        SeedCategories(modelBuilder);
    }

    private static void SeedUsers(this ModelBuilder modelBuilder)
    {
        string passwordSalt = Cryptography.Generators.NewRandomString(Configuration.Settings.UserPasswordSaltLength);
        modelBuilder.Entity<NookpostBackend.Models.User>().HasData(
            new Models.User()
            {
                Uuid = "110b9079-a902-4e6c-9544-15a7ce7e01dc",
                Username = "Test123",
                PasswordSalt = passwordSalt,
                PasswordHash = Cryptography.PasswordHashing.HashPassword("Test123", passwordSalt),
                UserSettings = new()
            });
    }

    private static void SeedCategories(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NookpostBackend.Models.Category>().HasData(new Models.Category[]
                {
                    new Models.Category()
                    {
                        Uuid = "35dbaec3-6738-42e5-bfd8-79e5877e3ffd",
                        Name = "Technology",
                        Icon = "pi pi-microchip"
                    },
                    new Models.Category()
                    {
                        Uuid = "b2ad2f84-8a8f-4006-ab62-35b9a09cb6d7",
                        Name = "Food",
                        Icon = "pi pi-face-smile"
                    },
                    new Models.Category()
                    {
                        Uuid = "eaed12a2-562e-4115-96e8-fd5f9c19c37b",
                        Name = "Politics",
                        Icon = "pi pi-hammer"
                    },
                    new Models.Category()
                    {
                        Uuid = "56a1fa66-afde-4041-8e80-96b794bafdef",
                        Name = "Economics",
                        Icon = "pi pi-dollar"
                    },
                }
                );
    }
}
