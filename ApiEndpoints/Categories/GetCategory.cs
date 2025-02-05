namespace NookpostBackend.ApiEndpoints.Categories;

static class GetCategory
{
    /// <summary>
    /// Gets a category 
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<NookpostBackend.ApiSchemas.Categories.CategoryData>,
            NotFound,
            BadRequest> HandleRequest(string? uuid, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }
}
