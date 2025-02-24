namespace NookpostBackend.ApiEndpoints.Posts;

static class PostPost
{
    /// <summary>
    /// Creates a post
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Created<ApiSchemas.Posts.PostPost.PostPostResponseBody>,
            NotFound,
            UnauthorizedHttpResult,
            StatusCodeHttpResult,
            BadRequest> HandleRequest(ApiSchemas.Posts.PostData requestBody, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        databaseHandle.Database.EnsureCreated();

        if (user.Identity is null) return TypedResults.Unauthorized();

        Models.User? userFromDb = databaseHandle.Users.FirstOrDefault(u => u.Username == user.Identity.Name);

        if (userFromDb is null) return TypedResults.Unauthorized();

        if (requestBody.Title is null || requestBody.Body is null || requestBody.CategoryUuid is null) return TypedResults.BadRequest();

        if (requestBody.Title.Length > NookpostBackend.Configuration.Settings.MaxAllowedPostStringSize ||
            requestBody.Body.Length > NookpostBackend.Configuration.Settings.MaxAllowedPostStringSize ||
            requestBody.BannerImageBase64?.Length > NookpostBackend.Configuration.Settings.MaxAllowedPostStringSize)
            return TypedResults.StatusCode(StatusCodes.Status413PayloadTooLarge);

        if (!databaseHandle.Categories.Any(c => c.Uuid == requestBody.CategoryUuid)) return TypedResults.NotFound();

        string uuid = Guid.NewGuid().ToString();
        databaseHandle.Posts.Add(new()
        {
            AuthorUuid = userFromDb.Uuid,
            Title = requestBody.Title,
            Body = requestBody.Body,
            BannerImageBase64 = requestBody.BannerImageBase64,
            CategoryUuid = requestBody.CategoryUuid,
            Uuid = uuid,
            CreatedOn = (long)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds,
            ModifiedOn = (long)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds
        });

        databaseHandle.SaveChanges();

        return TypedResults.Created("/posts/" + uuid, new NookpostBackend.ApiSchemas.Posts.PostPost.PostPostResponseBody()
        {
            Uuid = uuid
        });

    }
}

