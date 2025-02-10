namespace NookpostBackend.ApiEndpoints.Categories;

/// <summary>
/// Handles getting all categories
/// </summary>
static class GetAllCategories
{
    /// <summary>
    /// Gets all categories
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<NookpostBackend.ApiSchemas.Categories.GetAllCategories.GetAllCategoriesResponseBody>,
            BadRequest> HandleRequest(ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        databaseHandle.Database.EnsureCreated();

        List<Models.Category> categories = databaseHandle.Categories.ToList();
        List<NookpostBackend.ApiSchemas.Categories.GetAllCategories.GetAllCategoriesCategory> categoryReturns = new();

        categories.ForEach(c => categoryReturns.Add(new ApiSchemas.Categories.GetAllCategories.GetAllCategoriesCategory()
        {
            Name = c.Name,
            Uuid = c.Uuid,
            Icon = c.Icon
        }));

        return TypedResults.Ok(new NookpostBackend.ApiSchemas.Categories.GetAllCategories.GetAllCategoriesResponseBody()
        {
            categories = categoryReturns
        });
    }
}
