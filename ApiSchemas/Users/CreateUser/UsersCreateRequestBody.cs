namespace NookpostBackend.ApiSchemas.Users.CreateUser;

/// <summary>
/// The request body of a user create request
/// </summary>
public sealed class UsersCreateRequestBody : NookpostBackend.ApiSchemas.Users.UserData
{
    /// <summary>
    /// The users password
    /// </summary>
    public string? Password { get; set; }
}
