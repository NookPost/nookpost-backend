namespace NookpostBackend.ApiEndpoints.Posts;

static class DeletePost
{
    /// <summary>
    /// Deletes a post
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok,
            NotFound,
            BadRequest> HandleRequest(string? uuid, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }
}
