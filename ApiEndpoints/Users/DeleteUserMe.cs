namespace NookpostBackend.ApiEndpoints.Users;

/// <summary>
/// Handles delete requests for users
/// </summary>
static class DeleteUserMe
{
    /// <summary>
    /// Deletes a user
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            NoContent,
            UnauthorizedHttpResult,
            BadRequest> HandleRequest(ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        databaseHandle.Database.EnsureCreated();
        if (user.Identity is null) return TypedResults.Unauthorized();

        Models.User? userFromDb = databaseHandle.Users.FirstOrDefault(u => u.Username == user.Identity.Name);

        if (userFromDb is null) return TypedResults.Unauthorized();

        Models.UserSettings userSettings = databaseHandle.UserSettings.First(s => s.Uuid == userFromDb.UserSettingsUuid);

        IQueryable<Models.Post> posts = databaseHandle.Posts.Where(p => p.AuthorUuid == userFromDb.Uuid);

        databaseHandle.Posts.RemoveRange(posts);
        databaseHandle.UserSettings.Remove(userSettings);
        databaseHandle.Users.Remove(userFromDb);

        databaseHandle.SaveChanges();
        return TypedResults.NoContent();
    }
}
