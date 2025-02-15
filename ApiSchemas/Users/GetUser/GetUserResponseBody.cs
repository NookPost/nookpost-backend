namespace NookpostBackend.ApiSchemas.Users.GetUser;

/// <summary>
/// The response to a user get request if successful
/// </summary>
public sealed class UsersGetResponseBody : NookpostBackend.ApiSchemas.Users.UserData
{
    /// <summary>
    /// The UUID of the user
    /// </summary>
    public string? Uuid { get; set; }

}
