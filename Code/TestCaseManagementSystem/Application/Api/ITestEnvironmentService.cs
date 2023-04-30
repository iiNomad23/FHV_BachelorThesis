using Application.Dto;

namespace Application.Api;

public interface ITestEnvironmentService
{
    Task<TestEnvironmentDTO> FindById(string id);
    Task<List<TestEnvironmentDTO>> FindByShortDescription(string shortDescription);
    Task<List<TestEnvironmentDTO>> GetAll();
    Task Add(TestEnvironmentDTO testEnvironmentDTO);
    Task Remove(TestEnvironmentDTO testEnvironmentDTO);
}