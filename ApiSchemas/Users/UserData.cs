namespace NookpostBackend.ApiSchemas.Users;

/// <summary>
/// Common data for the user object
/// </summary>
public abstract class UserData
{
    /// <summary>
    /// The username of the user.
    /// </summary>
    public string? Username { get; set; }
    /// <summary>
    /// User display name
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// User Tagline/Status
    /// </summary>
    public string? TagLine { get; set; }
    /// <summary>
    /// User Bio
    /// </summary>
    public string? Bio { get; set; }
    /// <summary>
    /// Profile picture of the user encoded as b64
    /// </summary>
    public string? ProfilePictureBase64 { get; set; }
    /// <summary>
    /// Email of the user (null if user does not provide contact info)
    /// </summary>
    public string? Email { get; set; }
}
