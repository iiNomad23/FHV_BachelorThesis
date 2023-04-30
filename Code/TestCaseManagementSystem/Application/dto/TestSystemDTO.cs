using System.ComponentModel.DataAnnotations;

namespace Application.dto;

public class TestSystemDTO
{
    [Required]
    [StringLength(255)]
    public string Name { get; init; } = "";
    
    public string Description { get; init; } = "";
}