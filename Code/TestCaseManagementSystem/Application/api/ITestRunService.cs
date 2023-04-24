using Application.dto;

namespace Application.api;

public interface ITestRunService
{
    Task<TestRunDTO> FindById(string id);
    Task<List<TestRunDTO>> FindByTestSystemId(string testSystemId);
    Task<List<TestRunDTO>> GetAll();
    Task Add(TestRunDTO testRun);
}