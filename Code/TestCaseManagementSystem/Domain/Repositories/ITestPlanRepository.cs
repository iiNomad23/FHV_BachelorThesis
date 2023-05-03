namespace Domain.Repositories;

public interface ITestPlanRepository
{
    string NextIdentity();
    Task<TestPlan> FindById(string id);
    Task<List<TestPlan>> FindByIdSet(string[] ids);
    Task<List<TestPlan>> FindByShortDescription(string shortDescription);
    Task<List<TestPlan>> GetAll();
    Task Add(TestPlan testPlan);
    Task Remove(string id);
}