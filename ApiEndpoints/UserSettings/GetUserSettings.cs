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
        databaseHandle.Database.EnsureCreated();
        if (user.Identity is null || user.Identity.Name is null) return TypedResults.Unauthorized();

        Models.User? userFromDb = databaseHandle.Users.FirstOrDefault(u => u.Username == user.Identity.Name);

        if (userFromDb is null) return TypedResults.Unauthorized();

        Models.UserSettings? userSettings = databaseHandle.UserSettings.FirstOrDefault(s => s.Uuid == userFromDb.UserSettingsUuid);
        ArgumentNullException.ThrowIfNull(userSettings); ;

        return TypedResults.Ok(
           new NookpostBackend.ApiSchemas.UserSettings.UserSettingsData()
           {
               UseDarkMode = userSettings.UseDarkMode,
               DisplayEmailOnProfile = userSettings.DisplayEmailOnProfile
           });
    }
}
