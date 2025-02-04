namespace NookpostBackend.ApiEndpoints.Users;

/// <summary>
/// Handles put requests for users
/// </summary>
static class PutUser
{
    /// <summary>
    /// Modifies a user
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok,
            BadRequest> HandleRequest(NookpostBackend.ApiSchemas.Users.PutUser.UserPutRequestBody requestBody,ClaimsPrincipal user, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }
}
