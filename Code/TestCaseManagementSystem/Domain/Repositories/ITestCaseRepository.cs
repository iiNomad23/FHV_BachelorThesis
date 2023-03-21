namespace Domain.Repositories;

public interface ITestCaseRepository
{
    Task<TestCase> GetById(int id);
    Task<List<TestCase>> GetAll();
    Task Add(TestCase testCase);
    Task Update(TestCase testCase);
    Task Remove(TestCase testCase);
}