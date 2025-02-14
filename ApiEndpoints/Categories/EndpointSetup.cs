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
        app.MapGet("/categories/{uuid}", GetCategory.HandleRequest).WithTags("Categories").WithOpenApi();
        app.MapGet("/categories", GetAllCategories.HandleRequest).WithTags("Categories").WithOpenApi();
    }
}
