namespace NookpostBackend.ApiEndpoints.Posts;

static class GetPostFiltered
{
    /// <summary>
    /// Gets a filtered set of posts
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<NookpostBackend.ApiSchemas.Posts.GetPost.GetPostResponseBody>,
            BadRequest> HandleRequest(string? uuid, string? category, int? page, int? maxCount, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }
}
