namespace NookpostBackend.ApiEndpoints.Users;

/// <summary>
/// Handles get requests for users
/// </summary>
static class GetUserMe
{
    /// <summary>
    /// Gets a user
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<NookpostBackend.ApiSchemas.Users.GetUser.UsersGetResponseBody>,
            UnauthorizedHttpResult,
            BadRequest> HandleRequest(ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        databaseHandle.Database.EnsureCreated();
        if (user.Identity is null) return TypedResults.Unauthorized();
        Models.User? userFromDb = databaseHandle.Users.FirstOrDefault(u => u.Username == user.Identity.Name);

        if (userFromDb is null) return TypedResults.Unauthorized();

        Models.UserSettings userSettings = databaseHandle.UserSettings.First(s => s.Uuid == userFromDb.UserSettingsUuid);

        return TypedResults.Ok(new NookpostBackend.ApiSchemas.Users.GetUser.UsersGetResponseBody()
        {
            Uuid = userFromDb.Uuid,
            Username = userFromDb.Username,
            DisplayName = userFromDb.DisplayName,
            TagLine = userFromDb.TagLine,
            Bio = userFromDb.Bio,
            ProfilePictureBase64 = userFromDb.ProfilePictureBase64,
            Email = userFromDb.Email ?? ""
        });

    }

}
