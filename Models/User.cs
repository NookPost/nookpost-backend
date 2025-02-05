using System.ComponentModel.DataAnnotations;

namespace NookpostBackend.Models;

/// <summary>
/// User information.
/// </summary>
public class User
{
    /// <summary>
    /// UUID of the User.
    /// </summary>
    [Key]
    public string? Uuid { get; set; }
    /// <summary>
    /// The username of the user.
    /// </summary>
    public string? Username { get; set; }
    /// <summary>
    /// Hash, including Salt and Pepper, of the user's password.
    /// </summary>
    public string? PasswordHash { get; set; }
    /// <summary>
    /// The salt applied to the users's password.
    /// </summary>
    public string? PasswordSalt { get; set; }
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
    /// Email of the user
    /// </summary>
    public string? Email { get; set; }
    /// <summary>
    /// Contains settings for the user
    /// </summary>
    public UserSettings UserSettings { get; set; } = new();
}
