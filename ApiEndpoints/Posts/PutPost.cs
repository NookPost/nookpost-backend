namespace NookpostBackend.ApiEndpoints.Posts;

static class PutPost
{
    /// <summary>
    /// Modifies a post
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok,
            NotFound,
            UnauthorizedHttpResult,
            BadRequest> HandleRequest(NookpostBackend.ApiSchemas.Posts.PutPost.PutPostRequestBody requestBody, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        databaseHandle.Database.EnsureCreated();

        if (user.Identity is null) return TypedResults.Unauthorized();

        Models.User? userFromDb = databaseHandle.Users.FirstOrDefault(u => u.Username == user.Identity.Name);
        if (userFromDb is null) return TypedResults.Unauthorized();

        Models.Post? postToEdit = databaseHandle.Posts.FirstOrDefault(p => p.Uuid == requestBody.Uuid);
        if (postToEdit is null) return TypedResults.NotFound();

        postToEdit.CategoryUuid = requestBody.CategoryUuid ?? postToEdit.CategoryUuid;
        postToEdit.Title = requestBody.Title ?? postToEdit.Title;
        postToEdit.Body = requestBody.Body ?? postToEdit.Body;
        postToEdit.BannerImageBase64 = requestBody.BannerImageBase64 ?? postToEdit.BannerImageBase64;
        postToEdit.ModifiedOn = (long)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds;

        databaseHandle.SaveChanges();

        return TypedResults.Ok();
    }
}

