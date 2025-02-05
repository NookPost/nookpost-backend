namespace NookpostBackend.ApiEndpoints.Categories;

/// <summary>
/// Handles modifing a category
/// </summary>
static class PutCategory
{
    /// <summary>
    /// Modifies a category 
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok,
            NotFound,
            BadRequest> HandleRequest(NookpostBackend.ApiSchemas.Categories.PutCategory.PutCategoryRequestBody requestBody, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }
}
