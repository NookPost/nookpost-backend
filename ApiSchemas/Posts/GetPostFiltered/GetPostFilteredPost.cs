namespace NookpostBackend.ApiSchemas.Posts.GetPostFiltered;

/// <summary>
/// Response to a post get request
/// </summary>
public sealed class GetPostFilteredPost : NookpostBackend.ApiSchemas.Posts.PostGetData
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
