using Application.Dto;

namespace Application.Api;

public interface ITestPlanService
{
    Task<TestPlanDTO> FindById(string id);
    Task<List<TestPlanDTO>> FindByShortDescription(string shortDescription);
    Task<List<TestPlanDTO>> GetAll();
    Task Create(TestPlanDTO testPlanDTO);
    Task Remove(TestPlanDTO testPlanDTO);
}