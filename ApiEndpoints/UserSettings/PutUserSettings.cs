namespace NookpostBackend.ApiEndpoints.UserSettings;

static class PutUserSettings
{
    /// <summary>
    /// Updates the user's settings
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok,
            UnauthorizedHttpResult,
            ProblemHttpResult,
            BadRequest> HandleRequest(NookpostBackend.ApiSchemas.UserSettings.UserSettingsData requestBody, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        databaseHandle.Database.EnsureCreated();
        if (user.Identity is null || user.Identity.Name is null) return TypedResults.Unauthorized();

        Models.User? userFromDb = databaseHandle.Users.FirstOrDefault(u => u.Username == user.Identity.Name);

        if (userFromDb is null) return TypedResults.Unauthorized();

        Models.UserSettings? userSettings = databaseHandle.UserSettings.FirstOrDefault(s => s.Uuid == userFromDb.UserSettingsUuid);
        ArgumentNullException.ThrowIfNull(userSettings);

        userSettings.DisplayEmailOnProfile = requestBody.DisplayEmailOnProfile;
        userSettings.UseDarkMode = requestBody.UseDarkMode;

        databaseHandle.SaveChanges();
        return TypedResults.Ok();
    }
}
