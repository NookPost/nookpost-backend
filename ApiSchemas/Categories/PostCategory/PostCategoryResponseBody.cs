namespace NookpostBackend.ApiSchemas.Categories.PostCategory;

/// <summary>
/// The body of a response to a POST request to category
/// </summary>
sealed class PostCategoryResponseBody
{
    /// <summary>
    /// The UUID of the created category object
    /// </summary>
    public string? Uuid { get; set; }
}
