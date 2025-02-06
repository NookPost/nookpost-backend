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
    /// <summary>
    /// The username of the author
    /// </summary>
    public string? AuthorUsername { get; set; }
    /// <summary>
    /// Timestamp for the last modification of the post
    /// </summary>
    public long ModifiedOn { get; set; }
    /// <summary>
    /// Timestamp for the creation of the post
    /// </summary>
    public long CreatedOn { get; set; }

}
