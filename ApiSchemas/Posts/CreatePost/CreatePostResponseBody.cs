namespace NookpostBackend.ApiSchemas.Posts.CreatePost;

/// <summary>
/// The response to a post create message
/// </summary>
public sealed class CreatePostResponseBody 
{
    /// <summary>
    /// The UUID of the created post.
    /// </summary>
    public string? Uuid {get; set;}
}
