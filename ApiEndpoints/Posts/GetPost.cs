namespace NookpostBackend.ApiEndpoints.Posts;

static class GetPost
{
    /// <summary>
    /// Gets a post
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<NookpostBackend.ApiSchemas.Posts.GetPost.GetPostResponseBody>,
            NotFound,
            BadRequest> HandleRequest(string uuid, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }
}

