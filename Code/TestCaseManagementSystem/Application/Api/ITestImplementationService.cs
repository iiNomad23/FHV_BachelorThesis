using Application.Dto;

namespace Application.Api;

public interface ITestImplementationService
{
    Task<TestImplementationDTO> FindById(string id);
    Task<List<TestImplementationDTO>> FindByShortDescription(string shortDescription);
    Task<List<TestImplementationDTO>> GetAll();
    Task Create(TestImplementationDTO testImplementationDTO);
    Task Remove(TestImplementationDTO testImplementationDTO);
}