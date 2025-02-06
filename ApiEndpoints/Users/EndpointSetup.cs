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
        app.MapGet("/users", GetUser.HandleRequest).WithTags("Users").WithOpenApi();
        app.MapGet("/users/me", GetUserMe.HandleRequest).WithTags("Users").WithOpenApi().RequireAuthorization("user");
        app.MapPost("/users", PostUser.HandleRequest).WithTags("Users").WithOpenApi();
        app.MapPut("/users/me", PutUserMe.HandleRequest).WithTags("Users").WithOpenApi().RequireAuthorization("user");
        app.MapDelete("/users/me", DeleteUserMe.HandleRequest).WithTags("Users").WithOpenApi().RequireAuthorization("user");
    }
}
