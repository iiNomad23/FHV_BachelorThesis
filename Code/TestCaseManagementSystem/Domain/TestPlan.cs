namespace Domain;

public class TestPlan
{
    public long Id { get; }
    public string DomainId { get; }

    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public DateTime CreateDate { get; }
    public string ReferenceLink { get; set; }

    // EF relationship
    public List<TestEnvironmentPlan> TestEnvironments { get; private set; }

    public TestPlan(string domainId, string shortDescription, string longDescription, DateTime createDate, string referenceLink)
    {
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        CreateDate = createDate;
        ReferenceLink = referenceLink;
        TestEnvironments = new List<TestEnvironmentPlan>();
    }
    
    public TestPlan(string domainId, string shortDescription, string longDescription, DateTime createDate, string referenceLink, List<TestEnvironmentPlan> testEnvironments)
    {
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        CreateDate = createDate;
        ReferenceLink = referenceLink;
        TestEnvironments = testEnvironments;
    }

    public override string ToString()
    {
        return DomainId;
    }
}