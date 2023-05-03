using Application.Api;
using Application.Dto;
using Domain.Repositories;

namespace Application;

public class TestEnvironmentManager : ITestEnvironmentManger
{
    private readonly ITestEnvironmentRepository _testEnvironmentRepository;
    private readonly ITestPlanRepository _testPlanRepository;

    public TestEnvironmentManager(ITestEnvironmentRepository testEnvironmentRepository, ITestPlanRepository testPlanRepository)
    {
        _testEnvironmentRepository = testEnvironmentRepository;
        _testPlanRepository = testPlanRepository;
    }

    public async Task<TestEnvironmentDTO> FindByIdWithTestPlans(string id)
    {
        var testEnvironment = await _testEnvironmentRepository.FindById(id);

        var testPlans = await _testPlanRepository.FindById(testEnvironment.TestPlans.ElementAt(0).TestPlanDomainId);

        var test = "";

        return new TestEnvironmentDTO();
    }
}