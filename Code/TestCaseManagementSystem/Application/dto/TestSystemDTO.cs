using System.ComponentModel.DataAnnotations;

namespace Application.dto;

public class TestSystemDTO
{
    [Required]
    [StringLength(200)]
    public string Name { get; init; } = "";
    
    public string Description { get; init; } = "";
}