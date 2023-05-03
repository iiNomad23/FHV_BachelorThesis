namespace Domain.Repositories;

public interface ITestEnvironmentRepository
{
    string NextIdentity();
    Task<TestEnvironment> FindById(string id);
    Task<List<TestEnvironment>> FindByShortDescription(string shortDescription);
    Task<List<TestEnvironment>> GetAll();
    Task Add(TestEnvironment testEnvironment);
    Task Remove(string id);
    Task Update(TestEnvironment testEnvironment);
}