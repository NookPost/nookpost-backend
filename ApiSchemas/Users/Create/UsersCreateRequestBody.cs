namespace NookpostBackend.ApiSchemas.Users.Create;

/// <summary>
/// The request body of a user create request
/// </summary>
public class UsersCreateRequestBody
{
    /// <summary>
    /// The name of the user to log in.
    /// </summary>
    public string? Username { get; set; }
    /// <summary>
    /// The users password
    /// </summary>
    public string? Password { get; set; }
}
