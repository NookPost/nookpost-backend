namespace NookpostBackend.ApiEndpoints.Users;

/// <summary>
/// Handles setting up the user endpoints
/// </summary>
public static class EndpointSetup
{
    /// <summary>
    /// Sets up the user endpoints on the given Webapp
    /// <param name="app">The app to initialize the endpoint on.</param>
    /// </summary>
    public static void Setup(WebApplication app)
    {
        app.MapPost("/users/create", Create.PostCreate).WithTags("Users");
    }
}
