namespace NookpostBackend.ApiEndpoints.Posts;

static class DeletePost
{
    /// <summary>
    /// Deletes a post
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            NoContent,
            NotFound,
            UnauthorizedHttpResult,
            BadRequest> HandleRequest(string uuid, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        databaseHandle.Database.EnsureCreated();
        if (user.Identity is null) return TypedResults.Unauthorized();

        Models.User? userFromDb = databaseHandle.Users.FirstOrDefault(u => u.Username == user.Identity.Name);

        if (userFromDb is null) return TypedResults.Unauthorized();

        Models.Post? postToDelete = databaseHandle.Posts.FirstOrDefault(p => p.Uuid == uuid && p.AuthorUuid == userFromDb.Uuid);
        if (postToDelete is null) return TypedResults.NotFound();

        databaseHandle.Posts.Remove(postToDelete);

        databaseHandle.SaveChanges();
        return TypedResults.NoContent();
    }
}
