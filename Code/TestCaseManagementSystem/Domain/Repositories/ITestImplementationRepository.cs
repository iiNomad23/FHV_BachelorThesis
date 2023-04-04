namespace Domain.Repositories;

public interface ITestImplementationRepository
{
    string NextIdentity();
    Task<TestImplementation> FindById(string id);
    Task<List<TestImplementation>> FindByShortDescription(string shortDescription);
    Task<List<TestImplementation>> GetAll();
    Task Add(TestImplementation testImplementation);
    Task Remove(string id);
}