namespace NookpostBackend.ApiSchemas.Posts.GetPost;

/// <summary>
/// Response to a post get request
/// </summary>
public sealed class GetPostResponseBody : NookpostBackend.ApiSchemas.Posts.PostData
{
    /// <summary>
    /// The UUID of the post.
    /// </summary>
    public string? Uuid { get; set; }
}
