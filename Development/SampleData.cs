using Microsoft.EntityFrameworkCore;

namespace NookpostBackend.Development;
/// <summary>
/// Creates some sample database entries, when running in the development mode.
/// </summary>
public static class ModelBuilderExtensions
{
    /// <summary>
    /// Populates the database with the sample data for testing and development.
    /// </summary>
    public static void Seed(this ModelBuilder modelBuilder)
    {
        SeedUsers(modelBuilder);
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
                PasswordHash = Cryptography.PasswordHashing.HashPassword("Test123", passwordSalt)
            });
    }
}
