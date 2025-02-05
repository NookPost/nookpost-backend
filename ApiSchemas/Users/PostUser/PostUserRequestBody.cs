namespace NookpostBackend.ApiSchemas.Users.PostUser;

/// <summary>
/// The request body of a user create request
/// </summary>
public sealed class UsersPostRequestBody : NookpostBackend.ApiSchemas.Users.UserData
{
    /// <summary>
    /// The users password
    /// </summary>
    public string? Password { get; set; }
}
