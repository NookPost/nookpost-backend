namespace NookpostBackend.ApiEndpoints.Posts;

static class PutPost
{
    /// <summary>
    /// Modifies a post
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok,
            NotFound,
            BadRequest> HandleRequest(NookpostBackend.ApiSchemas.Posts.PutPost.PutPostRequestBody requestBody,ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }
}

