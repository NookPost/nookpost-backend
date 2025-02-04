using System.ComponentModel.DataAnnotations;

namespace NookpostBackend.Models;

/// <summary>
/// A category for posts
/// </summary>
public class Category
{
    /// <summary>
    /// UUID of the category object
    /// </summary>
    [Key]
    public string? Uuid { get; set; }
    /// <summary>
    /// Name of the category
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Icon of the category
    /// </summary>
    public string? Icon { get; set; }
}
