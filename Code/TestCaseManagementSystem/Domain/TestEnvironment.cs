namespace Domain;

public class TestEnvironment
{
    public long Id { get; }
    public string DomainId { get; }
    
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    
    // EF relationship
    public List<TestSystem> TestSystems { get; private set; }
    public List<TestEnvironmentPlan> TestPlans { get; private set; }

    public TestEnvironment(string domainId, string shortDescription, string longDescription)
    {
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        TestSystems = new List<TestSystem>();
        TestPlans = new List<TestEnvironmentPlan>();
    }
    
    public TestEnvironment(string domainId, string shortDescription, string longDescription, List<TestSystem> testSystems)
    {
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        TestSystems = testSystems;
        TestPlans = new List<TestEnvironmentPlan>();
    }

    public TestEnvironment(string domainId, string shortDescription, string longDescription, List<TestSystem> testSystems, List<TestEnvironmentPlan> testPlans)
    {
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        TestSystems = testSystems;
        TestPlans = testPlans;
    }

    public void AddTestPlan(string testPlanDomainId)
    {
        if (TestPlans.Exists(item => item.TestPlanDomainId == testPlanDomainId))
        {
            return;
        }
        
        TestPlans.Add(new TestEnvironmentPlan(DomainId, testPlanDomainId));
    }
    
    public void RemoveTestPlan(string testPlanDomainId)
    {
        var testPlan = TestPlans.Find(item => item.TestPlanDomainId == testPlanDomainId);
        if (testPlan == null)
        {
            return;
        }
        
        TestPlans.Remove(testPlan);
    }
}