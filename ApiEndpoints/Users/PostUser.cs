namespace NookpostBackend.ApiEndpoints.Users;


/// <summary>
/// Handles the user create endpoint.
/// </summary>
public class PostUser
{
    /// <summary>
    /// Creates a new user
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Created<ApiSchemas.Users.PostUser.UsersPostResponseBody>,
            Conflict,
            BadRequest> HandleRequest(NookpostBackend.ApiSchemas.Users.PostUser.UsersPostRequestBody requestBody, ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle, NookpostBackend.Authentication.TokenService tokenService)
    {
        databaseHandle.Database.EnsureCreated();
        if (String.IsNullOrEmpty(requestBody.Password) || String.IsNullOrEmpty(requestBody.Username))
        {
            return TypedResults.BadRequest();
        }

        if (databaseHandle.Users.Any(u => u.Username == requestBody.Username)) { return TypedResults.Conflict(); }
        if (requestBody.Username.Equals("me", StringComparison.OrdinalIgnoreCase)) { return TypedResults.Conflict(); }

        Models.UserSettings settings = new Models.UserSettings();

        databaseHandle.UserSettings.Add(settings);

        string passwordSalt = Cryptography.Generators.NewRandomString(Configuration.Settings.UserPasswordSaltLength);
        Models.User newUser = new Models.User()
        {
            Uuid = Guid.NewGuid().ToString(),
            Username = requestBody.Username,
            PasswordSalt = passwordSalt,
            PasswordHash = Cryptography.PasswordHashing.HashPassword(requestBody.Password, passwordSalt),
            UserSettingsUuid = settings.Uuid
        };

        databaseHandle.Users.Add(newUser);
        databaseHandle.SaveChanges();

        return TypedResults.Created("/users/" + newUser.Username, new ApiSchemas.Users.PostUser.UsersPostResponseBody()
        {
            Token = tokenService.GenerateNewToken(newUser),
            ExpiryTimestamp = (long)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds + NookpostBackend.Authentication.TokenService.AccessTokenExpiryTimeInSeconds
        });
    }

}
