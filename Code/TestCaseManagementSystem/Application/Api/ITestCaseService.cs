using Application.Dto;

namespace Application.Api;

public interface ITestCaseService
{
    Task<TestCaseDTO> FindById(string id);
    Task<List<TestCaseDTO>> FindByShortDescription(string shortDescription);
    Task<List<TestCaseDTO>> GetAll();
    Task Create(TestCaseDTO testCaseDTO);
    Task Remove(TestCaseDTO testCaseDTO);
}