namespace Domain.Repositories;

public interface ITestPlanRepository
{
    string NextIdentity();
    Task<TestPlan> GetById(int id);
    Task<List<TestPlan>> GetAll();
    Task Add(TestPlan testPlan);
    Task Remove(string id);
}