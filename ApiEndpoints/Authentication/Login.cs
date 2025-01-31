using NookpostBackend.Models;

namespace NookpostBackend.ApiEndpoints.Authentication;

/// <summary>
/// Handles the authentication login endpoint.
/// </summary>
public static class Login
{

    /// <summary>
    /// Authenticates the user and returns an access token. 
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
        Ok<NookpostBackend.ApiSchemas.Authentication.Login.AuthenticationLoginResponseBody>,
        NotFound,
        BadRequest>
            PostLogin(ApiSchemas.Authentication.Login.AuthenticationLoginRequestBody requestBody, NookpostBackend.Authentication.TokenService tokenService, Data.DatabaseHandle databaseHandle)
    {
        databaseHandle.Database.EnsureCreated();

        if (String.IsNullOrEmpty(requestBody.Username) || String.IsNullOrEmpty(requestBody.Password))
        {
            return TypedResults.BadRequest();
        }

        User? user = databaseHandle.Users.Where(u => u.Username == requestBody.Username).FirstOrDefault();
        if (user is null) { return TypedResults.NotFound(); }

        if (Cryptography.PasswordHashing.isPasswordValid(requestBody.Password, user))
        {
            return TypedResults.Ok(new ApiSchemas.Authentication.Login.AuthenticationLoginResponseBody()
            {
                Token = tokenService.GenerateNewToken(user),
                ExpiryTimestamp = (long)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds + NookpostBackend.Authentication.TokenService.AccessTokenExpiryTimeInSeconds
            });
        }

        return TypedResults.NotFound();

    }
}
