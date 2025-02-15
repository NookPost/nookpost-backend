namespace NookpostBackend.ApiSchemas.Posts;

/// <summary>
/// Common data for a psot get response
/// </summary>
public class PostGetData : PostData
{
    /// <summary>
    /// The display name of the author
    /// </summary>
    public string? AuthorDisplayName { get; set; }
}
