namespace NookpostBackend.ApiSchemas.Categories.GetCategory;

sealed class GetCategoryResponseBody : NookpostBackend.ApiSchemas.Categories.CategoryData
{
    /// <summary>
    /// UUID of the category object
    /// </summary>
    public string? Uuid { get; set; }
}
