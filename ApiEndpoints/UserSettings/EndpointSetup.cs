namespace NookpostBackend.ApiEndpoints.UserSettings;

/// <summary>
/// Handles setting up the user settings endpoints
/// </summary>
public static class EndpointSetup
{
    /// <summary>
    /// Sets up the user settigns endpoints on the given Webapp
    /// <param name="app">The app to initialize the endpoint on.</param>
    /// </summary>
    public static void Setup(WebApplication app)
    {
        app.MapGet("/userSettings", GetUserSettings.HandleRequest).WithTags("UserSettings").WithOpenApi().RequireAuthorization("user");
        app.MapPut("/userSettings", PutUserSettings.HandleRequest).WithTags("UserSettings").WithOpenApi().RequireAuthorization("user");
    }
}
