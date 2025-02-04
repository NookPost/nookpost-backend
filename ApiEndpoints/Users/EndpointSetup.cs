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
        app.MapGet("/users", GetUser.HandleRequest).WithTags("Users");
        app.MapPost("/users", PostUser.HandleRequest).WithTags("Users");
        app.MapPut("/users", PutUser.HandleRequest).WithTags("Users").WithOpenApi().RequireAuthorization("user");
        app.MapDelete("/users", DeleteUser.HandleRequest).WithTags("Users").WithOpenApi().RequireAuthorization("user");
    }
}
