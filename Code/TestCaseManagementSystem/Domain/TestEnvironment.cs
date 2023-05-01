namespace Domain;

public class TestEnvironment
{
    public long Id { get; }
    public string DomainId { get; }
    
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public List<TestSystem> TestSystems { get; private set; }
    // public List<TestPlan> TestPlans { get; private set; }

    public TestEnvironment(string domainId, string shortDescription, string longDescription)
    {
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        TestSystems = new List<TestSystem>();
        // TestPlans = new List<TestPlan>();
    }
    
    public TestEnvironment(long id, string domainId, string shortDescription, string longDescription)
    {
        Id = id;
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        TestSystems = new List<TestSystem>();
        // TestPlans = new List<TestPlan>();
    }
    
    public TestEnvironment(string domainId, string shortDescription, string longDescription, List<TestSystem> testSystems)//, List<TestPlan> testPlans)
    {
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        TestSystems = testSystems;
        // TestPlans = testPlans;
    }
    
    public TestEnvironment(long id, string domainId, string shortDescription, string longDescription, List<TestSystem> testSystems)//, List<TestPlan> testPlans)
    {
        Id = id;
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        TestSystems = testSystems;
        // TestPlans = testPlans;
    }
}