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
        SeedPosts(modelBuilder);
    }

    /// <summary>
    /// Seeds the database with data
    /// </summary>
    public static void Seed(this ModelBuilder modelBuilder)
    {
        SeedCategories(modelBuilder);
    }

    private static void SeedPosts(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NookpostBackend.Models.Post>().HasData(new Models.Post()
        {
            Uuid = "749e1044-55e8-44c8-8a6f-9cb9a34345f2",
            Title = "Test Post 1",
            Body = """
Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.   

Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.   

Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.   

Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer
""",
            CategoryUuid = "35dbaec3-6738-42e5-bfd8-79e5877e3ffd",
            CreatedOn = (long)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds,
            ModifiedOn = (long)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds,
            AuthorUuid = "110b9079-a902-4e6c-9544-15a7ce7e01dc",
            BannerImageBase64 = null
        });

        modelBuilder.Entity<NookpostBackend.Models.Post>().HasData(new Models.Post()
        {
            Uuid = "7ccaaed4-a63d-4654-bfdc-ee5ef79c615a",
            Title = "Test Post 2",
            Body = """
Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.   

Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.   

Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.   

Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer
This is also a text for testing the search.
""",
            CategoryUuid = "b2ad2f84-8a8f-4006-ab62-35b9a09cb6d7",
            CreatedOn = (long)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds,
            ModifiedOn = (long)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds,
            AuthorUuid = "110b9079-a902-4e6c-9544-15a7ce7e01dc",
            BannerImageBase64 = null
        });

        modelBuilder.Entity<NookpostBackend.Models.Post>().HasData(new Models.Post()
        {
            Uuid = "7534b031-7aa2-4847-b14a-f7ad25572b74",
            Title = "Test Post 3",
            Body = """
Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.   

Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.   

Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.   

Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer
This is a text for testing the search.
""",
            CategoryUuid = "56a1fa66-afde-4041-8e80-96b794bafdef",
            CreatedOn = (long)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds,
            ModifiedOn = (long)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds,
            AuthorUuid = "110b9079-a902-4e6c-9544-15a7ce7e01dc",
            BannerImageBase64 = null
        });
    }

    private static void SeedUsers(this ModelBuilder modelBuilder)
    {
        Models.UserSettings userSettings = new();
        userSettings.Uuid = "4663d82b-fd14-4e6c-8e94-2e5c821f7e16";

        modelBuilder.Entity<NookpostBackend.Models.UserSettings>().HasData(userSettings);

        string passwordSalt = Cryptography.Generators.NewRandomString(Configuration.Settings.UserPasswordSaltLength);
        Models.User user = new Models.User()
        {
            Uuid = "110b9079-a902-4e6c-9544-15a7ce7e01dc",
            Username = "Test123",
            PasswordSalt = passwordSalt,
            PasswordHash = Cryptography.PasswordHashing.HashPassword("Test123", passwordSalt),
            UserSettingsUuid = userSettings.Uuid
        };

        modelBuilder.Entity<NookpostBackend.Models.User>().HasData(user);
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
