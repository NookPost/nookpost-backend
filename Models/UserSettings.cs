using System.ComponentModel.DataAnnotations;

namespace NookpostBackend.Models;

/// <summary>
/// Represents user settings
/// </summary>
public class UserSettings
{
    /// <summary>
    /// UUID of the settings object
    /// </summary>
    [Key]
    public string? Uuid { get; set; } = Guid.NewGuid().ToString();
    /// <summary>
    /// Whether to use dark mode for the user
    /// </summary>
    public bool? UseDarkMode { get; set; }
    /// <summary>
    /// Whether to display the user's email on the profile page
    /// </summary>
    public bool DisplayEmailOnProfile { get; set; }

}
