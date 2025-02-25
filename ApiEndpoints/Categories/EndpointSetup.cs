namespace NookpostBackend.ApiEndpoints.Categories;

/// <summary>
/// Handles setting up the post endpoints
/// </summary>
public static class EndpointSetup
{
    /// <summary>
    /// Sets up the post endpoints on the given Webapp
    /// <param name="parentGroup">The parent group which contains the endpoints.</param>
    /// </summary>
    public static void Setup(RouteGroupBuilder parentGroup)
    {
        parentGroup.MapGet("/categories/{uuid}", GetCategory.HandleRequest).WithTags("Categories").WithOpenApi();
        parentGroup.MapGet("/categories", GetAllCategories.HandleRequest).WithTags("Categories").WithOpenApi();
    }
}
