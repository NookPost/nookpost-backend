namespace NookpostBackend.ApiEndpoints.Users;

/// <summary>
/// Handles delete requests for users
/// </summary>
static class DeleteUser
{
    /// <summary>
    /// Deletes a user
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok,
            BadRequest> HandleRequest(string? username, ClaimsPrincipal user,NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }
}
