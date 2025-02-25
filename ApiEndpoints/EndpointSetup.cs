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
		// Create a route group with the prefix "/api/v1"
    var apiGroup = app.MapGroup("/api/v1");

    // Pass the group to each feature's setup
    Authentication.EndpointSetup.Setup(apiGroup);
    Users.EndpointSetup.Setup(apiGroup);
    Posts.EndpointSetup.Setup(apiGroup);
    UserSettings.EndpointSetup.Setup(apiGroup);
    Categories.EndpointSetup.Setup(apiGroup);
    }
}
