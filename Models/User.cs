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
}
