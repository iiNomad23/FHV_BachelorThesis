namespace Application.Dto;

public class TestEnvironmentUpdateTestPlanIdsDTO
{
    public string Id { get; init; } = "";
    
    public string[] TestPlansIds { get; init; } = Array.Empty<string>();
}