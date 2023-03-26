using Application.api;
using Application.dto;
using Domain;
using Domain.ids;
using Domain.Repositories;

namespace Application;

public class TestCaseService : ITestCaseService
{
    private readonly ITestCaseRepository _testCaseRepository;

    public TestCaseService(ITestCaseRepository testCaseRepository)
    {
        _testCaseRepository = testCaseRepository;
    }

    public async Task<TestCaseDTO> GetById(int id)
    {
        var testCase = await _testCaseRepository.GetById(id);

        return TestCaseDTO.FromTestCase(testCase);
    }

    public async Task<List<TestCaseDTO>> GetAll()
    {
        var testCases = await _testCaseRepository.GetAll();

        return testCases
            .Select(testCase => TestCaseDTO.FromTestCase(testCase))
            .ToList();
    }

    public async Task Add(TestCaseDTO testCaseDTO)
    {
        await _testCaseRepository.Add(
            new TestCase(
                new TestCaseId(_testCaseRepository.NextIdentity()),
                testCaseDTO.ShortDescription,
                testCaseDTO.LongDescription,
                testCaseDTO.AuthorDescription,
                new DateTime(),
                testCaseDTO.Priority,
                testCaseDTO.ReferenceLink
            )
        );
    }

    // public async Task Update(TestCaseDTO testCaseDTO)
    // {
    //     await _testCaseRepository.Update(
    //         new TestCase(
    //             new TestCaseId(_testCaseRepository.NextIdentity()),
    //             testCaseDTO.ShortDescription,
    //             testCaseDTO.LongDescription,
    //             testCaseDTO.AuthorDescription,
    //             testCaseDTO.CreateDate,
    //             testCaseDTO.Priority,
    //             testCaseDTO.ReferenceLink
    //         )
    //     );
    // }

    public async Task Remove(TestCaseDTO testCase)
    {
        await _testCaseRepository.Remove(new TestCaseId(testCase.Id));
    }
}