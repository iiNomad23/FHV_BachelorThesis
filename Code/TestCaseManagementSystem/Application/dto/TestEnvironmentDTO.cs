using System.ComponentModel.DataAnnotations;
using Domain;

namespace Application.dto;

public class TestEnvironmentDTO
{
    public string Id { get; init; } = "";
    
    [Required]
    [StringLength(200)]
    public string ShortDescription { get; init; } = "";
    
    public string LongDescription { get; init; } = "";
    
    [Required]
    public List<TestSystem> TestSystems { get; init; } = new List<TestSystem>();
}