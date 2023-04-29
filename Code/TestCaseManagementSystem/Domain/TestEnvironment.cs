namespace Domain;

public class TestEnvironment
{
    public long Id { get; }
    public string DomainId { get; }
    
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public List<TestSystem> TestSystems { get; private set; }

    public TestEnvironment(string domainId, string shortDescription, string longDescription)
    {
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        TestSystems = new List<TestSystem>();
    }
    
    public TestEnvironment(long id, string domainId, string shortDescription, string longDescription)
    {
        Id = id;
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        TestSystems = new List<TestSystem>();
    }
    
    public TestEnvironment(string domainId, string shortDescription, string longDescription, List<TestSystem> testSystems)
    {
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        TestSystems = testSystems;
    }
    
    public TestEnvironment(long id, string domainId, string shortDescription, string longDescription, List<TestSystem> testSystems)
    {
        Id = id;
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        TestSystems = testSystems;
    }
}