using System.ComponentModel.DataAnnotations;

namespace Application.dto;

public class TestPlanDTO
{
    public string Id { get; init; } = "";
    
    [Required]
    [StringLength(255)]
    public string ShortDescription { get; init; } = "";

    public string LongDescription { get; init; } = "";

    public string ReferenceLink { get; init; } = "";
}