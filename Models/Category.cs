using System.ComponentModel.DataAnnotations;

namespace NookpostBackend.Models;

public class Category
{
    [Key]
    public string? Uuid { get; set; }
    public string? Name { get; set; }
    public string? Icon { get; set; }
}
