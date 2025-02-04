namespace NookpostBackend.ApiEndpoints;

/// <summary>
/// Handles setting up all API Endpoints
/// </summary>
public static class EndpointSetup
{
    /// <summary>
    /// Sets up all API Endpints on the given webapp
    /// <param name="app">The webapp to set up the endpoints on</param>
    /// </summary>
    public static void Setup(WebApplication app)
    {
        Authentication.EndpointSetup.Setup(app);
        Users.EndpointSetup.Setup(app);
        Posts.EndpointSetup.Setup(app);
        UserSettings.EndpointSetup.Setup(app);
    }
}
