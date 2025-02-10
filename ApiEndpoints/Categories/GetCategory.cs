namespace NookpostBackend.ApiEndpoints.Categories;

/// <summary>
/// Handles getting a category
/// </summary>
static class GetCategory
{
    /// <summary>
    /// Gets a category 
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<NookpostBackend.ApiSchemas.Categories.GetCategory.GetCategoryResponseBody>,
            NotFound,
            BadRequest> HandleRequest(string uuid, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        databaseHandle.Database.EnsureCreated();

        Models.Category? category = databaseHandle.Categories.Where(c => c.Uuid == uuid).FirstOrDefault();
        if (category is null) return TypedResults.NotFound();

        return TypedResults.Ok(new NookpostBackend.ApiSchemas.Categories.GetCategory.GetCategoryResponseBody()
        {
            Uuid = category.Uuid,
            Name = category.Name,
            Icon = category.Icon
        });
    }
}
