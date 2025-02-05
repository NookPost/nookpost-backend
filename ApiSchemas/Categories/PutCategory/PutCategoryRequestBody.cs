namespace NookpostBackend.ApiSchemas.Categories.PutCategory;

/// <summary>
/// The body of a PUT request to category
/// </summary>
sealed class PutCategoryRequestBody : NookpostBackend.ApiSchemas.Categories.CategoryData
{
    /// <summary>
    /// UUID of the category object
    /// </summary>
    public string? Uuid { get; set; }
}
