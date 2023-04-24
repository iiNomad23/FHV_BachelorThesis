using System.ComponentModel.DataAnnotations;
using Domain.valueObjects;

namespace Application.dto;

public class TestRunDTO
{
    public string Id { get; init; }
    
    [Required]
    public string State { get; init; }
    
    [Required]
    public string TestSystemId { get; init; }
    
    [Required]
    public Dictionary<string, ResultDetails> ResultDetailsMap { get; init; }
    
    [Required]
    public List<DeviceDetails> DeviceDetailsCollection { get; init; }
}