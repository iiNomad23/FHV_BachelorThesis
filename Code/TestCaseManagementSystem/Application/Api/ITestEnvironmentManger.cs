using Application.Dto;

namespace Application.Api;

public interface ITestEnvironmentManger
{
    Task<TestEnvironmentDTO> FindByIdWithTestPlans(string id);
}