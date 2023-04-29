using Application.dto;

namespace Application.api;

public interface ITestImplementationService
{
    Task<TestImplementationDTO> FindById(string id);
    Task<List<TestImplementationDTO>> FindByShortDescription(string shortDescription);
    Task<List<TestImplementationDTO>> GetAll();
    Task Add(TestImplementationDTO testImplementationDTO);
    Task Remove(TestImplementationDTO testImplementationDTO);
}