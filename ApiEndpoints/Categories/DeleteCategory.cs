namespace NookpostBackend.ApiEndpoints.Categories;

/// <summary>
/// Handles deleting a category
/// </summary>
static class DeleteCategory
{
    /// <summary>
    /// Deletes a category 
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok,
            NotFound,
            BadRequest> HandleRequest(string? uuid, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }
}
