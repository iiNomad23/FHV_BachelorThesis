using Application.Dto;

namespace Application.Api;

public interface ITestEnvironmentService
{
    Task<TestEnvironmentDTO> FindById(string id);
    Task<List<TestEnvironmentDTO>> FindByShortDescription(string shortDescription);
    Task<List<TestEnvironmentDTO>> GetAll();
    Task Create(TestEnvironmentDTO testEnvironmentDTO);
    Task Remove(TestEnvironmentDTO testEnvironmentDTO);
    Task AddTestPlans(TestEnvironmentUpdateTestPlanIdsDTO testEnvironmentUpdateTestPlanIdsDTO);
    Task RemoveTestPlans(TestEnvironmentUpdateTestPlanIdsDTO testEnvironmentUpdateTestPlanIdsDTO);
}