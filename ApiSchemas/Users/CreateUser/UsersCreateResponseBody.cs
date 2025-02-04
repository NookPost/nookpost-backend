namespace NookpostBackend.ApiSchemas.Users.CreateUser;


/// <summary>
/// Represents a token object in the response to a user create request
/// </summary>
public sealed class UsersCreateResponseBody
{
    /// <summary>
    /// The token that can be used for authentication.
    /// </summary>
    public string? Token { get; set; }
    /// <summary>
    /// The time in seconds the token expires on.
    /// </summary>
    public long ExpiryTimestamp { get; set; }
}
