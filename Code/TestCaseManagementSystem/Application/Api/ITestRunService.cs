using Application.Dto;

namespace Application.Api;

public interface ITestRunService
{
    Task<TestRunDTO> FindById(string id);
    Task<List<TestRunDTO>> FindByTestSystemId(string testSystemId);
    Task<List<TestRunDTO>> GetAll();
    Task Create(TestRunDTO testRunDTO);
}