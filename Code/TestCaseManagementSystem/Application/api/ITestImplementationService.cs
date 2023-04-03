using Application.dto;

namespace Application.api;

public interface ITestImplementationService
{
    Task<TestImplementationDTO> GetById(int id);
    Task<List<TestImplementationDTO>> GetAll();
    Task Add(TestImplementationDTO testImplementation);
    Task Remove(TestImplementationDTO testImplementation);
}