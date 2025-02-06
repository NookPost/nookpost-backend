namespace NookpostBackend.ApiSchemas.Posts.GetPostFiltered;

/// <summary>
/// The response to a get posts request with filter
/// </summary>
public sealed class GetPostFilteredResponseBody
{
    /// <summary>
    /// The posts remaining after the filter operation
    /// </summary>
    public List<GetPostFilteredPost>? Posts { get; set; }
}
