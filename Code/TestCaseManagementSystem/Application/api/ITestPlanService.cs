using Application.dto;

namespace Application.api;

public interface ITestPlanService
{
    Task<TestPlanDTO> FindById(string id);
    Task<List<TestPlanDTO>> FindByShortDescription(string shortDescription);
    Task<List<TestPlanDTO>> GetAll();
    Task Add(TestPlanDTO testPlan);
    Task Remove(TestPlanDTO testPlan);
}