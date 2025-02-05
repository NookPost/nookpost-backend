namespace NookpostBackend.ApiEndpoints.Categories;

static class PostCategory
{
    /// <summary>
    /// Creates a category 
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok,
            NotFound,
            BadRequest> HandleRequest(NookpostBackend.ApiSchemas.Categories.CategoryData requestBody, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }
}
