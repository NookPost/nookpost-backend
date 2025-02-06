namespace NookpostBackend.ApiEndpoints.Users;

/// <summary>
/// Handles get requests for users
/// </summary>
static class GetUser
{
    /// <summary>
    /// Gets a user
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<NookpostBackend.ApiSchemas.Users.GetUser.UsersGetResponseBody>,
            UnauthorizedHttpResult,
            NotFound,
            BadRequest> HandleRequest(string username, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        databaseHandle.Database.EnsureCreated();
        Models.User? userFromDb = databaseHandle.Users.FirstOrDefault(u => u.Username == username);

        if (userFromDb is null) return TypedResults.NotFound();

        Models.UserSettings userSettings = databaseHandle.UserSettings.First(s => s.Uuid == userFromDb.UserSettingsUuid);

        return TypedResults.Ok(new NookpostBackend.ApiSchemas.Users.GetUser.UsersGetResponseBody()
        {

            Username = userFromDb.Username,
            DisplayName = userFromDb.DisplayName,
            TagLine = userFromDb.TagLine,
            Bio = userFromDb.Bio,
            ProfilePictureBase64 = userFromDb.ProfilePictureBase64,
            Email = userSettings.DisplayEmailOnProfile ? userFromDb.Email ?? "" : ""
        });


    }

}
