using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Application.Dto;

public class TestCaseDTO
{
    public string Id { get; init; } = "";
    
    [Required]
    [StringLength(255)]
    public string ShortDescription { get; init; } = "";
    
    public string LongDescription { get; init; } = "";
    
    [Required]
    [StringLength(255)]
    public string AuthorDescription { get; init; } = "";

    [Required] 
    public Priority Priority { get; init; } = Priority.Medium;
    
    public string ReferenceLink { get; init; } = "";
    
}