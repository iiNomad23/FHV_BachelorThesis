using System.ComponentModel.DataAnnotations;

namespace Application.dto;

public class TestImplementationDTO
{
    public string Id { get; init; }
    
    [Required]
    [StringLength(200)]
    public string ShortDescription { get; init; }
    
    public string LongDescription { get; init; }
    
    [Required]
    [StringLength(50)]
    public string AuthorDescription { get; init; }

    public string ReferenceLink { get; init; }
}