namespace NookpostBackend.ApiSchemas.Categories.PutCategory;

class PutCategoryRequestBody : NookpostBackend.ApiSchemas.Categories.CategoryData
{
    /// <summary>
    /// UUID of the category object
    /// </summary>
    public string? Uuid { get; set; }
}
