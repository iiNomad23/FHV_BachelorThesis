namespace Domain;

public class TestSystem
{
    public long Id { get; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    
    // EF relationship
    public string TestEnvironmentDomainId { get; private set; }
    
    // public TestEnvironment TestEnvironment { get; private set; }

    public TestSystem(string name, string description, string testEnvironmentDomainId)
    {
        Name = name;
        Description = description;
        TestEnvironmentDomainId = testEnvironmentDomainId;
    }
}