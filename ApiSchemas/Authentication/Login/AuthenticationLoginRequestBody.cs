namespace NookpostBackend.ApiSchemas.Authentication.Login;

/// <summary>
/// The body of a login request.
/// </summary>
public class AuthenticationLoginRequestBody
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
