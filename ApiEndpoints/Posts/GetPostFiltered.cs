namespace NookpostBackend.ApiEndpoints.Posts;

static class GetPostFiltered
{
    /// <summary>
    /// Gets a filtered set of posts
    /// </summary>
    /// <remarks>The list will be ordered by date of creation</remarks>
    /// <param name="username">The username of the author that created the post</param>
    /// <param name="categoryUuid">The uuid of the category the posts are in</param>
    /// <param name="textSearch">Text to search for in articles (body and title)</param>
    /// <param name="page">The page the posts should be on (requires pageItemCount)</param>
    /// <param name="pageItemCount">The number of posts per page (requires page)</param>
    /// <param name="databaseHandle">The database handle</param>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<NookpostBackend.ApiSchemas.Posts.GetPostFiltered.GetPostFilteredResponseBody>,
            BadRequest> HandleRequest(string? username, string? categoryUuid, string? textSearch, int? page, int? pageItemCount, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        databaseHandle.Database.EnsureCreated();

        Models.User? author = null;
        if (!String.IsNullOrEmpty(username))
        {
            author = databaseHandle.Users.FirstOrDefault(u => u.Username == username);
            // return an empty list if no matching user is found
            if (author is null) return TypedResults.Ok(new NookpostBackend.ApiSchemas.Posts.GetPostFiltered.GetPostFilteredResponseBody() { Posts = new() });
        }

        IQueryable<Models.Post> filteredPosts = databaseHandle.Posts.Where(p =>
                    ((author == null) || p.AuthorUuid == author.Uuid) &&
                    ((categoryUuid == null) || p.CategoryUuid == categoryUuid) &&
                    ((textSearch == null) || (((p.Body != null) && p.Body.Contains(textSearch)) || ((p.Title != null) && p.Title.Contains(textSearch))))
                ).OrderByDescending(p => p.CreatedOn);

        int returnedCount = filteredPosts.Count();
        if ((!(page is null)) && (!(pageItemCount is null)))
        {
            returnedCount = (int)Math.Ceiling(returnedCount / (float)pageItemCount);
            int start = (int)(pageItemCount * page);
            filteredPosts = filteredPosts.Skip(start).Take((int)pageItemCount);
        }

        List<NookpostBackend.ApiSchemas.Posts.GetPostFiltered.GetPostFilteredPost> returnedObjects = new();

        foreach (Models.Post post in filteredPosts.ToList())
        { 
            Models.User currentPostAuthor = databaseHandle.Users.First(u => u.Uuid == post.AuthorUuid);
            returnedObjects.Add(new()
            {
                Uuid = post.Uuid,
                AuthorUsername = currentPostAuthor.Username,
                AuthorDisplayName = currentPostAuthor.DisplayName,
                Title = post.Title,
                Body = post.Body,
                BannerImageBase64 = post.BannerImageBase64,
                CategoryUuid = post.CategoryUuid,
                CreatedOn = post.CreatedOn,
                ModifiedOn = post.ModifiedOn
            });
        }

        return TypedResults.Ok(new NookpostBackend.ApiSchemas.Posts.GetPostFiltered.GetPostFilteredResponseBody()
        {
            Posts = returnedObjects,
            TotalNumberOfPages = returnedCount
        });
    }
}
