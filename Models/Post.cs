using System.ComponentModel.DataAnnotations;

namespace NookpostBackend.Models;

/// <summary>
/// Represents a post created by a user
/// </summary>
public class Post
{
    /// <summary>
    /// Uuid of the post object
    /// </summary>
    [Key]
    public string? Uuid { get; set; }
    /// <summary>
    /// Title of the post
    /// </summary>
    public string? Title { get; set; }
    /// <summary>
    /// Body/content of the post
    /// </summary>
    public string? Body { get; set; }
    /// <summary>
    /// Author of the post
    /// </summary>
    public string? AuthorUuid { get; set; }
    /// <summary>
    /// Category of the post
    /// </summary>
    public string? CategoryUuid { get; set; }
    /// <summary>
    /// The banner image of the post
    /// </summary>
    public string? BannerImageBase64 { get; set; }
    /// <summary>
    /// Unix timestamp the object was created on
    /// </summary>
    public long CreatedOn { get; set; }
    /// <summary>
    /// Unix timestamp the object was modified on
    /// </summary>
    public long ModifiedOn { get; set; }
}
