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
    /// <summary>
    /// The total number of pages there are.
    /// </summary>
    /// <remarks>The number of returned posts if no pagination is used.</remarks>
    public int TotalNumberOfPages { get; set; }
}
