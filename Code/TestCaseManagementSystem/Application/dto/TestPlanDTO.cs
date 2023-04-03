using System.ComponentModel.DataAnnotations;
using Domain.enums;

namespace Application.dto;

public class TestPlanDTO
{
    public string Id { get; init; }
    
    [Required]
    [StringLength(200)]
    public string ShortDescription { get; init; }
    
    public string LongDescription { get; init; }

    public string ReferenceLink { get; init; }
}