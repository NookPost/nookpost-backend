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
        if (requestBody.DisplayEmailOnProfile is null) return TypedResults.BadRequest();

        if (user.Identity is null || user.Identity.Name is null) return TypedResults.Unauthorized();

        Models.User? userFromDb = databaseHandle.Users.FirstOrDefault(u => u.Username == user.Identity.Name);

        if (userFromDb is null) return TypedResults.Unauthorized();

        userFromDb.UserSettings.DisplayEmailOnProfile = requestBody.DisplayEmailOnProfile;
        userFromDb.UserSettings.UseDarkMode = requestBody.UseDarkMode;

        databaseHandle.SaveChanges();
        return TypedResults.Ok();
    }
}
