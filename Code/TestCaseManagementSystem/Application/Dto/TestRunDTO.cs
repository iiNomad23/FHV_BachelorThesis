using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;

namespace Application.Dto;

public class TestRunDTO
{
    public string Id { get; init; } = "";
    
    [Required]
    public string State { get; init; } = "";
    
    [Required]
    public string TestSystemId { get; init; } = "";

    [Required]
    public Dictionary<string, ResultDetails> ResultDetailsMap { get; init; } = new Dictionary<string, ResultDetails>();

    [Required] 
    public List<DeviceDetails> DeviceDetailsCollection { get; init; } = new List<DeviceDetails>();
}