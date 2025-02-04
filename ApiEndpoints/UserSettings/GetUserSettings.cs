namespace NookpostBackend.ApiEndpoints.UserSettings;

static class GetUserSettings
{
    /// <summary>
    /// Gets the user's settings
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<NookpostBackend.ApiSchemas.UserSettings.UserSettingsData>,
            BadRequest> HandleRequest(ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }
}
