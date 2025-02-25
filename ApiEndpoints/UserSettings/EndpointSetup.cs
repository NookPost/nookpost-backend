namespace NookpostBackend.ApiEndpoints.UserSettings;

/// <summary>
/// Handles setting up the user settings endpoints
/// </summary>
public static class EndpointSetup
{
    /// <summary>
    /// Sets up the user settigns endpoints on the given Webapp
    /// <param name="parentGroup">The parent group which contains the endpoints.</param>
    /// </summary>
    public static void Setup(RouteGroupBuilder parentGroup)
    {
        parentGroup.MapGet("/user/me/settings", GetUserSettings.HandleRequest).WithTags("Users Settings").WithOpenApi().RequireAuthorization("user");
        parentGroup.MapPut("/user/me/settings", PutUserSettings.HandleRequest).WithTags("Users Settings").WithOpenApi().RequireAuthorization("user");
    }
}
