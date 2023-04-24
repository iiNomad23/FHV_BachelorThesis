using Application.api;
using Application.dto;
using Domain;
using Domain.Repositories;

namespace Application;

public class TestRunService : ITestRunService
{
    private readonly ITestRunRepository _testRunRepository;
    
    public TestRunService(ITestRunRepository testRunRepository)
    {
        _testRunRepository = testRunRepository;
    }
    
    public async Task<TestRunDTO> FindById(string id)
    {
        var testRun = await _testRunRepository.FindById(id);

        return new TestRunDTO {
            Id = testRun.DomainId,
            State = testRun.State,
            TestSystemId = testRun.TestSystemId,
            ResultDetailsMap = testRun.ResultDetailsMap,
            DeviceDetailsCollection = testRun.DeviceDetailsList
        };
    }

    public async Task<List<TestRunDTO>> FindByTestSystemId(string testSystemId)
    {
        var testRuns = await _testRunRepository.FindByTestSystemId(testSystemId);

        return testRuns
            .Select(testRun => new TestRunDTO {
                Id = testRun.DomainId,
                State = testRun.State,
                TestSystemId = testRun.TestSystemId,
                ResultDetailsMap = testRun.ResultDetailsMap,
                DeviceDetailsCollection = testRun.DeviceDetailsList
            })
            .ToList();
    }

    public async Task<List<TestRunDTO>> GetAll()
    {
        var testRuns = await _testRunRepository.GetAll();

        return testRuns
            .Select(testRun => new TestRunDTO {
                Id = testRun.DomainId,
                State = testRun.State,
                TestSystemId = testRun.TestSystemId,
                ResultDetailsMap = testRun.ResultDetailsMap,
                DeviceDetailsCollection = testRun.DeviceDetailsList
            })
            .ToList();
    }

    public async Task Add(TestRunDTO testRunDTO)
    {
        await _testRunRepository.Add(
            new TestRun(
                _testRunRepository.NextIdentity(),
                DateTime.Now.ToUniversalTime(),
                DateTime.Now.ToUniversalTime(),
                testRunDTO.State,
                testRunDTO.TestSystemId,
                testRunDTO.ResultDetailsMap,
                testRunDTO.DeviceDetailsCollection
            )
        );
    }
}