namespace NookpostBackend.ApiEndpoints.Users;

/// <summary>
/// Handles get requests for users
/// </summary>
static class GetUser
{
    /// <summary>
    /// Gets a user
    /// </summary>
    public static Microsoft.AspNetCore.Http.HttpResults.Results<
            Ok<NookpostBackend.ApiSchemas.Users.GetUser.UsersGetResponseBody>,
            BadRequest> HandleRequest(string? username, NookpostBackend.Data.DatabaseHandle databaseHandle)
    {
        throw new NotImplementedException();
    }

}
