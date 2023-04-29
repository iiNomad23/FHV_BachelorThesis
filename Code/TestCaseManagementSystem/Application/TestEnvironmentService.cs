using Application.api;
using Application.dto;
using Domain;
using Domain.Repositories;

namespace Application;

public class TestEnvironmentService : ITestEnvironmentService
{
    private readonly ITestEnvironmentRepository _testEnvironmentRepository;
    
    public TestEnvironmentService(ITestEnvironmentRepository testEnvironmentRepository)
    {
        _testEnvironmentRepository = testEnvironmentRepository;
    }
    
    public async Task<TestEnvironmentDTO> FindById(string id)
    {
        var testEnvironment = await _testEnvironmentRepository.FindById(id);

        return new TestEnvironmentDTO {
            Id = testEnvironment.DomainId,
            ShortDescription = testEnvironment.ShortDescription,
            LongDescription = testEnvironment.LongDescription,
            TestSystems = testEnvironment.TestSystems
        };
    }

    public async Task<List<TestEnvironmentDTO>> FindByShortDescription(string shortDescription)
    {
        var testEnvironments = await _testEnvironmentRepository.FindByShortDescription(shortDescription);

        return testEnvironments
            .Select(testEnvironment => new TestEnvironmentDTO {
                Id = testEnvironment.DomainId,
                ShortDescription = testEnvironment.ShortDescription,
                LongDescription = testEnvironment.LongDescription,
                TestSystems = testEnvironment.TestSystems
            })
            .ToList();
    }

    public async Task<List<TestEnvironmentDTO>> GetAll()
    {
        var testEnvironments = await _testEnvironmentRepository.GetAll();

        return testEnvironments
            .Select(testEnvironment => new TestEnvironmentDTO {
                Id = testEnvironment.DomainId,
                ShortDescription = testEnvironment.ShortDescription,
                LongDescription = testEnvironment.LongDescription,
                TestSystems = testEnvironment.TestSystems
            })
            .ToList();
    }

    public async Task Add(TestEnvironmentDTO testEnvironmentDTO)
    {
        await _testEnvironmentRepository.Add(
            new TestEnvironment(
                _testEnvironmentRepository.NextIdentity(),
                testEnvironmentDTO.ShortDescription,
                testEnvironmentDTO.LongDescription,
                testEnvironmentDTO.TestSystems
            )
        );
    }

    public async Task Remove(TestEnvironmentDTO testEnvironmentDTO)
    {
        await _testEnvironmentRepository.Remove(testEnvironmentDTO.Id);
    }
}