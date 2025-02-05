namespace NookpostBackend.ApiSchemas.Posts.PostPost;

/// <summary>
/// The response to a post create message
/// </summary>
public sealed class PostPostResponseBody
{
    /// <summary>
    /// The UUID of the created post.
    /// </summary>
    public string? Uuid { get; set; }
}
