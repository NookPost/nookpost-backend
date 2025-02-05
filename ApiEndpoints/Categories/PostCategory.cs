namespace NookpostBackend.ApiEndpoints.Categories;

/// <summary>
/// Handles creating a category
/// </summary>
static class PostCategory
{
    /// <summary>
    /// Creates a category 
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<NookpostBackend.ApiSchemas.Categories.PostCategory.PostCategoryResponseBody>,
            NotFound,
            Conflict,
            BadRequest> HandleRequest(NookpostBackend.ApiSchemas.Categories.CategoryData requestBody, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }
}
