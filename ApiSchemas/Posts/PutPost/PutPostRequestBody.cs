namespace NookpostBackend.ApiSchemas.Posts.PutPost;

/// <summary>
/// Response to a post get request
/// </summary>
public sealed class PutPostRequestBody : NookpostBackend.ApiSchemas.Posts.PostData
{
    /// <summary>
    /// The UUID of the post.
    /// </summary>
    public string? Uuid { get; set; }
}
