using Application.Api;
using Application.Dto;
using Domain;
using Domain.Repositories;

namespace Application;

public class TestCaseService : ITestCaseService
{
    private readonly ITestCaseRepository _testCaseRepository;

    public TestCaseService(ITestCaseRepository testCaseRepository)
    {
        _testCaseRepository = testCaseRepository;
    }

    public async Task<TestCaseDTO> FindById(string id)
    {
        var testCase = await _testCaseRepository.FindById(id);

        return new TestCaseDTO {
            Id = testCase.DomainId,
            ShortDescription = testCase.ShortDescription,
            LongDescription = testCase.LongDescription,
            AuthorDescription = testCase.AuthorDescription,
            Priority = testCase.Priority,
            ReferenceLink = testCase.ReferenceLink
        };
    }
    
    public async Task<List<TestCaseDTO>> FindByShortDescription(string shortDescription)
    {
        var testCases = await _testCaseRepository.FindByShortDescription(shortDescription);

        return testCases
            .Select(testCase => new TestCaseDTO {
                Id = testCase.DomainId,
                ShortDescription = testCase.ShortDescription,
                LongDescription = testCase.LongDescription,
                AuthorDescription = testCase.AuthorDescription,
                Priority = testCase.Priority,
                ReferenceLink = testCase.ReferenceLink
            })
            .ToList();
    }

    public async Task<List<TestCaseDTO>> GetAll()
    {
        var testCases = await _testCaseRepository.GetAll();

        return testCases
            .Select(testCase => new TestCaseDTO {
                Id = testCase.DomainId,
                ShortDescription = testCase.ShortDescription,
                LongDescription = testCase.LongDescription,
                AuthorDescription = testCase.AuthorDescription,
                Priority = testCase.Priority,
                ReferenceLink = testCase.ReferenceLink
            })
            .ToList();
    }

    public async Task Add(TestCaseDTO testCaseDTO)
    {
        await _testCaseRepository.Add(
            new TestCase(
                _testCaseRepository.NextIdentity(),
                testCaseDTO.ShortDescription,
                testCaseDTO.LongDescription,
                testCaseDTO.AuthorDescription,
                DateTime.Now.ToUniversalTime(),
                testCaseDTO.Priority,
                testCaseDTO.ReferenceLink
            )
        );
    }

    public async Task Remove(TestCaseDTO testCaseDTO)
    {
        await _testCaseRepository.Remove(testCaseDTO.Id);
    }
}