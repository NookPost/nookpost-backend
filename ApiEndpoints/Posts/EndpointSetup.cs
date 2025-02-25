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
    public static void Setup(RouteGroupBuilder parentGroup)
    {
        parentGroup.MapGet("/posts/{uuid}", GetPost.HandleRequest).WithTags("Posts").WithOpenApi();
        parentGroup.MapPost("/posts", PostPost.HandleRequest).WithTags("Posts").WithOpenApi().RequireAuthorization("user");
        parentGroup.MapPut("/posts/{uuid}", PutPost.HandleRequest).WithTags("Posts").WithOpenApi().RequireAuthorization("user");
        parentGroup.MapDelete("/posts/{uuid}", DeletePost.HandleRequest).WithTags("Posts").WithOpenApi().RequireAuthorization("user");
        parentGroup.MapGet("/posts", GetPostFiltered.HandleRequest).WithTags("Posts").WithOpenApi();
    }
}
