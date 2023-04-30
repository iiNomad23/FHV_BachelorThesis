using System.ComponentModel.DataAnnotations;
using Domain;

namespace Application.dto;

public class TestEnvironmentDTO
{
    public string Id { get; init; } = "";
    
    [Required]
    [StringLength(255)]
    public string ShortDescription { get; init; } = "";
    
    public string LongDescription { get; init; } = "";
    
    [Required]
    public List<TestSystemDTO> TestSystems { get; init; } = new List<TestSystemDTO>();
}