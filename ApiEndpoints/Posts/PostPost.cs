namespace NookpostBackend.ApiEndpoints.Posts;

static class PostPost
{
    /// <summary>
    /// Creates a post
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<ApiSchemas.Posts.CreatePost.CreatePostResponseBody>,
            NotFound,
            BadRequest> HandleRequest(ApiSchemas.Posts.PostData requestBody, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }
}

