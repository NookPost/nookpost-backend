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
        databaseHandle.Database.EnsureCreated();

        Models.Post? post = databaseHandle.Posts.FirstOrDefault(p => p.Uuid == uuid);

        if (post is null) return TypedResults.NotFound();

        Models.User author = databaseHandle.Users.First(u => u.Uuid == post.AuthorUuid);

        return TypedResults.Ok(new NookpostBackend.ApiSchemas.Posts.GetPost.GetPostResponseBody()
        {
            Uuid = post.Uuid,
            AuthorUsername = author.Username,
            Title = post.Title,
            Body = post.Body,
            CategoryUuid = post.CategoryUuid,
            ModifiedOn = post.ModifiedOn,
            CreatedOn = post.CreatedOn
        });
    }
}

