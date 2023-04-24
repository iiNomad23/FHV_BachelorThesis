namespace Domain.Repositories;

public interface ITestRunRepository
{
    string NextIdentity();
    Task<TestRun> FindById(string id);
    Task<List<TestRun>> FindByTestSystemId(string shortDescription);
    Task<List<TestRun>> GetAll();
    Task Add(TestRun testRun);
}