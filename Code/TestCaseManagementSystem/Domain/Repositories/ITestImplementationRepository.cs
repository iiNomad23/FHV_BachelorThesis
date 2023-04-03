namespace Domain.Repositories;

public interface ITestImplementationRepository
{
    string NextIdentity();
    Task<TestImplementation> GetById(int id);
    Task<List<TestImplementation>> GetAll();
    Task Add(TestImplementation testImplementation);
    Task Remove(string id);
}