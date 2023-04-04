using Application.dto;

namespace Application.api;

public interface ITestCaseService
{
    Task<TestCaseDTO> FindById(string id);
    Task<List<TestCaseDTO>> FindByShortDescription(string shortDescription);
    Task<List<TestCaseDTO>> GetAll();
    Task Add(TestCaseDTO testCase);
    Task Remove(TestCaseDTO testCase);
}