using Application.dto;

namespace Application.api;

public interface ITestPlanService
{
    Task<TestPlanDTO> GetById(int id);
    Task<List<TestPlanDTO>> GetAll();
    Task Add(TestPlanDTO testPlan);
    Task Remove(TestPlanDTO testPlan);
}