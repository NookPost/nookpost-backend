namespace NookpostBackend.ApiEndpoints.Posts;

/// <summary>
/// Handles setting up the post endpoints
/// </summary>
public static class EndpointSetup
{
    /// <summary>
    /// Sets up the post endpoints on the given Webapp
    /// <param name="app">The app to initialize the endpoint on.</param>
    /// </summary>
    public static void Setup(WebApplication app)
    {
        app.MapGet("/posts", GetPost.HandleRequest).WithTags("Posts").WithOpenApi();
        app.MapPost("/posts", PostPost.HandleRequest).WithTags("Posts").WithOpenApi().RequireAuthorization("user");
        app.MapPut("/posts", PutPost.HandleRequest).WithTags("Posts").WithOpenApi().RequireAuthorization("user");
        app.MapDelete("/posts", DeletePost.HandleRequest).WithTags("Posts").WithOpenApi().RequireAuthorization("user");
    }
}
