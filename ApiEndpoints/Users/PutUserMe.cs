namespace NookpostBackend.ApiEndpoints.Users;

/// <summary>
/// Handles put requests for users
/// </summary>
static class PutUserMe
{
    /// <summary>
    /// Modifies a user
    /// </summary>
    /// <remarks>Null values are ignored.</remarks>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok,
            UnauthorizedHttpResult,
            BadRequest> HandleRequest(NookpostBackend.ApiSchemas.Users.PutUser.UserPutRequestBody requestBody, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        databaseHandle.Database.EnsureCreated();
        if (user.Identity is null) return TypedResults.Unauthorized();
        Models.User? userFromDb = databaseHandle.Users.FirstOrDefault(u => u.Username == user.Identity.Name);

        if (userFromDb is null) return TypedResults.Unauthorized();

        userFromDb.Email = requestBody.Email ?? userFromDb.Email;
        userFromDb.ProfilePictureBase64 = requestBody.ProfilePictureBase64 ?? userFromDb.ProfilePictureBase64;
        userFromDb.Bio = requestBody.Bio ?? userFromDb.Bio;
        userFromDb.TagLine = requestBody.TagLine ?? userFromDb.TagLine;
        userFromDb.DisplayName = requestBody.DisplayName ?? userFromDb.DisplayName;

        databaseHandle.SaveChanges();
        return TypedResults.Ok();
    }
}
