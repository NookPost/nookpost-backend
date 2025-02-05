namespace NookpostBackend.ApiEndpoints.Categories;

static class GetAllCategories
{
    /// <summary>
    /// Gets all categories
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<NookpostBackend.ApiSchemas.Categories.GetAllCategories.GetAllCategoriesResponseBody>,
            NotFound,
            BadRequest> HandleRequest(ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }
}
