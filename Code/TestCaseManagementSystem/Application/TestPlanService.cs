using Application.api;
using Application.dto;
using Domain;
using Domain.Repositories;

namespace Application;

public class TestPlanService : ITestPlanService
{
    private readonly ITestPlanRepository _testPlanRepository;

    public TestPlanService(ITestPlanRepository testCaseRepository)
    {
        _testPlanRepository = testCaseRepository;
    }
    
    public async Task<TestPlanDTO> GetById(int id)
    {
        var testPlan = await _testPlanRepository.GetById(id);

        return new TestPlanDTO {
            Id = testPlan.DomainId,
            ShortDescription = testPlan.ShortDescription,
            LongDescription = testPlan.LongDescription,
            ReferenceLink = testPlan.ReferenceLink
        };
    }

    public async Task<List<TestPlanDTO>> GetAll()
    {
        var testPlans = await _testPlanRepository.GetAll();

        return testPlans
            .Select(testPlan => new TestPlanDTO {
                Id = testPlan.DomainId,
                ShortDescription = testPlan.ShortDescription,
                LongDescription = testPlan.LongDescription,
                ReferenceLink = testPlan.ReferenceLink
            })
            .ToList();
    }

    public async Task Add(TestPlanDTO testPlanDTO)
    {
        await _testPlanRepository.Add(
            new TestPlan(
                _testPlanRepository.NextIdentity(),
                testPlanDTO.ShortDescription,
                testPlanDTO.LongDescription,
                DateTime.Now.ToUniversalTime(),
                testPlanDTO.ReferenceLink
            )
        );
    }

    public async Task Remove(TestPlanDTO testPlanDTO)
    {
        await _testPlanRepository.Remove(testPlanDTO.Id);
    }
}