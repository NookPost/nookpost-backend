namespace NookpostBackend.ApiEndpoints.Categories;

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
        app.MapGet("/category", GetCategory.HandleRequest).WithTags("Categories").WithOpenApi();
        app.MapGet("/category/all", GetAllCategories.HandleRequest).WithTags("Categories").WithOpenApi().RequireAuthorization();
    }
}
