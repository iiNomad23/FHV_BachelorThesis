using Application.dto;

namespace Application.api;

public interface ITestEnvironmentService
{
    Task<TestEnvironmentDTO> FindById(string id);
    Task<List<TestEnvironmentDTO>> FindByShortDescription(string shortDescription);
    Task<List<TestEnvironmentDTO>> GetAll();
    Task Add(TestEnvironmentDTO testEnvironmentDTO);
    Task Remove(TestEnvironmentDTO testEnvironmentDTO);
}