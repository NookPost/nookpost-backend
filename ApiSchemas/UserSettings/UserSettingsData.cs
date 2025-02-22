namespace NookpostBackend.ApiSchemas.UserSettings;

/// <summary>
/// Represents user settings objects
/// </summary>
sealed class UserSettingsData
{
    /// <summary>
    /// Whether to use dark mode for the user
    /// </summary>
    public bool? UseDarkMode { get; set; }
    /// <summary>
    /// Whether to display the user's email on the profile page
    /// </summary>
    public bool DisplayEmailOnProfile { get; set; }
}
