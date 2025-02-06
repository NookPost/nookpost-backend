namespace NookpostBackend.ApiEndpoints.Posts;

static class GetPostFiltered
{
    /// <summary>
    /// Gets a filtered set of posts
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<NookpostBackend.ApiSchemas.Posts.GetPostFiltered.GetPostFilteredResponseBody>,
            BadRequest> HandleRequest(string? uuid, string? categoryUuid, int? page, int? maxCount, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        System.Console.WriteLine(uuid is null);
        System.Console.WriteLine(categoryUuid is null);
        databaseHandle.Database.EnsureCreated();

        List<Models.Post> filteredPosts = databaseHandle.Posts.Where(p =>
                    ((categoryUuid == null) || p.CategoryUuid == categoryUuid) &&
                    ((uuid == null) || p.Uuid == uuid)
                ).ToList();

        List<NookpostBackend.ApiSchemas.Posts.GetPostFiltered.GetPostFilteredPost> returnedObjects = new();

        foreach (Models.Post post in filteredPosts)
        {
            returnedObjects.Add(new()
            {
                Uuid = post.Uuid,
                AuthorUsername = databaseHandle.Users.First(u => u.Uuid == post.AuthorUuid).Username,
                Title = post.Title,
                Body = post.Body,
                CategoryUuid = post.CategoryUuid,
                CreatedOn = post.CreatedOn,
                ModifiedOn = post.ModifiedOn
            });
        }

        return TypedResults.Ok(new NookpostBackend.ApiSchemas.Posts.GetPostFiltered.GetPostFilteredResponseBody()
        {
            Posts = returnedObjects
        });
    }
}
