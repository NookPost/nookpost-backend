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
    }
}
