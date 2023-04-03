namespace Domain.Repositories;

public interface ITestPlanRepository
{
    string NextIdentity();
    Task<TestPlan> GetById(int id);
    Task<List<TestPlan>> GetAll();
    Task Add(TestPlan testCase);
    Task Remove(string id);
}