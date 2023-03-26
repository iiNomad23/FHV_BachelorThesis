using Application.dto;

namespace Application.api;

public interface ITestCaseService
{
    Task<TestCaseDTO> GetById(int id);
    Task<List<TestCaseDTO>> GetAll();
    Task Add(TestCaseDTO testCase);
    // Task Update(TestCaseDTO testCase);
    Task Remove(TestCaseDTO testCase);
}