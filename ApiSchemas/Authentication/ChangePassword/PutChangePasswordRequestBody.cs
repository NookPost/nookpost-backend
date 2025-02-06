namespace NookpostBackend.ApiSchemas.Authentication.ChangePassword;

/// <summary>
/// Represents the request body of a change password request
/// </summary>
public class PutChangePasswordRequestBody
{
    /// <summary>
    /// The old password of the user
    /// </summary>
    public string? OldPassword { get; set; }
    /// <summary>
    /// The new password of the user
    /// </summary>
    public string? NewPassword { get; set; }
}
