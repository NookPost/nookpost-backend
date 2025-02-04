namespace NookpostBackend.ApiEndpoints.UserSettings;

static class PutUserSettings
{
    /// <summary>
    /// Updates the user's settings
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok,
            BadRequest> HandleRequest(NookpostBackend.ApiSchemas.UserSettings.UserSettingsData requestBody, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }
}
