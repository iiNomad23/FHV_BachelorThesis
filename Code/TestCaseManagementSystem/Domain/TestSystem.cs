namespace Domain;

public class TestSystem
{
    public long Id { get; }
    public string DomainId { get; }
    
    public string Name { get; set; }
    public string Description { get; set; }

    public TestSystem(long id, string domainId, string name, string description)
    {
        Id = id;
        DomainId = domainId;
        Name = name;
        Description = description;
    }
    
    public TestSystem(string domainId, string name, string description)
    {
        DomainId = domainId;
        Name = name;
        Description = description;
    }
}