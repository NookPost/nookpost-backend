namespace NookpostBackend.ApiEndpoints.Users;

/// <summary>
/// Handles put requests for users
/// </summary>
static class PutUserMe
{
    /// <summary>
    /// Modifies a user
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok,
            UnauthorizedHttpResult,
            BadRequest> HandleRequest(NookpostBackend.ApiSchemas.Users.PutUser.UserPutRequestBody requestBody, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        databaseHandle.Database.EnsureCreated();
        if (user.Identity is null) return TypedResults.Unauthorized();
        Models.User? userFromDb = databaseHandle.Users.FirstOrDefault(u => u.Username == user.Identity.Name);

        if (userFromDb is null) return TypedResults.Unauthorized();

        userFromDb.Email ??= requestBody.Email;
        userFromDb.ProfilePictureBase64 ??= requestBody.ProfilePictureBase64;
        userFromDb.Bio ??= requestBody.Bio;
        userFromDb.TagLine ??= requestBody.TagLine;
        userFromDb.DisplayName ??= requestBody.DisplayName;

        databaseHandle.SaveChanges();
        return TypedResults.Ok();
    }
}
