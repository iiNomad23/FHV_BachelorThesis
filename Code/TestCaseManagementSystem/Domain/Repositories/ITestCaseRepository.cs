namespace Domain.Repositories;

public interface ITestCaseRepository
{
    string NextIdentity();
    Task<TestCase> FindById(string id);
    Task<List<TestCase>> FindByShortDescription(string shortDescription);
    Task<List<TestCase>> GetAll();
    Task Add(TestCase testCase);
    Task Remove(string id);
}