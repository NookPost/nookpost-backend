namespace NookpostBackend.ApiSchemas.Authentication.Login;


/// <summary>
/// Represents a token object in the response to a Login request
/// </summary>
public class AuthenticationLoginResponseBody 
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
