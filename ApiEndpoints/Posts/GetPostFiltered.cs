namespace NookpostBackend.ApiEndpoints.Posts;

static class GetPostFiltered
{
    /// <summary>
    /// Gets a filtered set of posts
    /// </summary>
    /// <remarks>The list will be ordered by date of creation</remarks>
    /// <param name="uuid">The UUID of the post to get</param>
    /// <param name="categoryUuid">The uuid of the category the posts are in</param>
    /// <param name="page">The page the posts should be on (requires pageItemCount)</param>
    /// <param name="pageItemCount">The number of posts per page (requires page)</param>
    /// <param name="databaseHandle">The database handle</param>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<NookpostBackend.ApiSchemas.Posts.GetPostFiltered.GetPostFilteredResponseBody>,
            BadRequest> HandleRequest(string? uuid, string? categoryUuid, int? page, int? pageItemCount, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        databaseHandle.Database.EnsureCreated();

        IQueryable<Models.Post> filteredPosts = databaseHandle.Posts.Where(p =>
                    ((categoryUuid == null) || p.CategoryUuid == categoryUuid) &&
                    ((uuid == null) || p.Uuid == uuid)
                ).OrderByDescending(p => p.CreatedOn);

        if ((!(page is null)) && (!(pageItemCount is null)))
        {
            int start = (int)(pageItemCount * page);
            filteredPosts = filteredPosts.Skip(start).Take((int)pageItemCount);
        }

        List<NookpostBackend.ApiSchemas.Posts.GetPostFiltered.GetPostFilteredPost> returnedObjects = new();

        foreach (Models.Post post in filteredPosts.ToList())
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
