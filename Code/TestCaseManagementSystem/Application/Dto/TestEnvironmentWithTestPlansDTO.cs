namespace Application.Dto;

public class TestEnvironmentWithTestPlansDTO
{
    public TestEnvironmentDTO TestEnvironmentDTO { get; init; } = new TestEnvironmentDTO();

    public List<TestPlanDTO> TestPlanDTOs { get; init; } = new List<TestPlanDTO>();
}