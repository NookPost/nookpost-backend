namespace NookpostBackend.ApiEndpoints.UserSettings;

static class GetUserSettings
{
    /// <summary>
    /// Gets the user's settings
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<NookpostBackend.ApiSchemas.UserSettings.UserSettingsData>,
            UnauthorizedHttpResult,
            BadRequest> HandleRequest(ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        if (user.Identity is null || user.Identity.Name is null) return TypedResults.Unauthorized();

        Models.User? userFromDb = databaseHandle.Users.FirstOrDefault(u => u.Username == user.Identity.Name);

        if (userFromDb is null) return TypedResults.Unauthorized();

        return TypedResults.Ok(
           new NookpostBackend.ApiSchemas.UserSettings.UserSettingsData()
           {
               UseDarkMode = userFromDb.UserSettings.UseDarkMode,
               DisplayEmailOnProfile = userFromDb.UserSettings.DisplayEmailOnProfile
           });
    }
}
