using System.ComponentModel.DataAnnotations;
using Domain.enums;

namespace Application.dto;

public class TestCaseDTO
{
    public string Id { get; init; } = "";
    
    [Required]
    [StringLength(200)]
    public string ShortDescription { get; init; } = "";
    
    public string LongDescription { get; init; } = "";
    
    [Required]
    [StringLength(50)]
    public string AuthorDescription { get; init; } = "";

    [Required] 
    public Priority Priority { get; init; } = Priority.Medium;
    
    public string ReferenceLink { get; init; } = "";
    
}