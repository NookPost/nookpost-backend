using NookpostBackend.Models;

namespace NookpostBackend.ApiEndpoints.Authentication;

/// <summary>
/// Handles the authentication login endpoint.
/// </summary>
public static class ChangePassword
{

    /// <summary>
    /// Changes the password of a user
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
        Ok,
        NotFound,
        UnauthorizedHttpResult,
        StatusCodeHttpResult,
        BadRequest>
            HandleRequest(ApiSchemas.Authentication.ChangePassword.PutChangePasswordRequestBody requestBody, ClaimsPrincipal user, Data.DatabaseHandle databaseHandle)
    {
        databaseHandle.Database.EnsureCreated();

        if (user.Identity is null) return TypedResults.Unauthorized();
        Models.User? userFromDb = databaseHandle.Users.FirstOrDefault(u => u.Username == user.Identity.Name);

        if (userFromDb is null) return TypedResults.Unauthorized();

        if (String.IsNullOrEmpty(requestBody.OldPassword) || String.IsNullOrEmpty(requestBody.NewPassword)) return TypedResults.BadRequest();

        if (!Cryptography.PasswordHashing.isPasswordValid(requestBody.OldPassword, userFromDb)) return TypedResults.Unauthorized();

        if (userFromDb.PasswordSalt is null) return TypedResults.StatusCode(StatusCodes.Status500InternalServerError);

        userFromDb.PasswordHash = Cryptography.PasswordHashing.HashPassword(requestBody.NewPassword, userFromDb.PasswordSalt);

        databaseHandle.SaveChanges();

        return TypedResults.Ok();


    }
}
