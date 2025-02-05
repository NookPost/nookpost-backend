namespace NookpostBackend.ApiSchemas.Categories.GetAllCategories;

/// <summary>
/// The body of a Get request to category/all
/// </summary>
sealed class GetAllCategoriesResponseBody
{
    /// <summary>
    /// The currently present categories
    /// </summary>
    public List<GetAllCategoriesCategory>? categories { get; set; }
}
