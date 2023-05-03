using Application.Dto;

namespace Application.Api;

public interface ITestEnvironmentManger
{
    Task<TestEnvironmentWithTestPlansDTO> FindByIdWithTestPlans(string id);
}