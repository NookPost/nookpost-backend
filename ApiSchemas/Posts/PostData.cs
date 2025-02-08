namespace NookpostBackend.ApiSchemas.Posts;

/// <summary>
/// Represents a post created by a user
/// </summary>
public class PostData
{
    /// <summary>
    /// Title of the post
    /// </summary>
    public string? Title { get; set; }
    /// <summary>
    /// Body/content of the post
    /// </summary>
    public string? Body { get; set; }
    /// <summary>
    /// The banner image of the post
    /// </summary>
    public string? BannerImageBase64 { get; set; }
    /// <summary>
    /// UUID of the category of the post
    /// </summary>
    public string? CategoryUuid { get; set; }
}
