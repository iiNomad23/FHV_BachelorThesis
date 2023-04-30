using System.ComponentModel.DataAnnotations;

namespace Application.Dto;

public class TestImplementationDTO
{
    public string Id { get; init; } = "";
    
    [Required]
    [StringLength(255)]
    public string ShortDescription { get; init; } = "";
    
    public string LongDescription { get; init; } = "";
    
    [Required]
    [StringLength(255)]
    public string AuthorDescription { get; init; } = "";

    public string ReferenceLink { get; init; } = "";
}