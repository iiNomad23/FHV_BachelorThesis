using Application.Api;
using Application.Dto;
using Application.Dto.Child;
using Domain.Repositories;

namespace Application;

public class TestEnvironmentManager : ITestEnvironmentManger
{
    private readonly ITestEnvironmentRepository _testEnvironmentRepository;
    private readonly ITestPlanRepository _testPlanRepository;

    public TestEnvironmentManager(ITestEnvironmentRepository testEnvironmentRepository,
        ITestPlanRepository testPlanRepository)
    {
        _testEnvironmentRepository = testEnvironmentRepository;
        _testPlanRepository = testPlanRepository;
    }

    public async Task<TestEnvironmentWithTestPlansDTO> FindByIdWithTestPlans(string id)
    {
        var testEnvironment = await _testEnvironmentRepository.FindById(id);

        var testPlanIds = testEnvironment.TestPlans
            .Select(item => item.TestPlanDomainId)
            .ToArray();

        var testPlans = await _testPlanRepository.FindByIdSet(testPlanIds);

        var testPlanDTOs = testPlans
            .Select(tp => new TestPlanDTO
                {
                    Id = tp.DomainId,
                    ShortDescription = tp.ShortDescription,
                    LongDescription = tp.LongDescription,
                    ReferenceLink = tp.ReferenceLink
                }
            )
            .ToList();

        var testEnvironmentDTO = new TestEnvironmentDTO
        {
            Id = testEnvironment.DomainId,
            ShortDescription = testEnvironment.ShortDescription,
            LongDescription = testEnvironment.LongDescription,
            TestSystems = testEnvironment.TestSystems
                .Select(ts => new TestSystemDTO
                    {
                        Name = ts.Name,
                        Description = ts.Description,
                    }
                )
                .ToList()
        };

        var testEnvironmentWithTestPlansDTO = new TestEnvironmentWithTestPlansDTO
        {
            TestEnvironmentDTO = testEnvironmentDTO,
            TestPlanDTOs = testPlanDTOs
        };

        return testEnvironmentWithTestPlansDTO;
    }
}