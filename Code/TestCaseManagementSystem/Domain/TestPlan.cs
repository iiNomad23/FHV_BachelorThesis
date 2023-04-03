namespace Domain;

public class TestPlan
{
    public long Id { get; }
    public string DomainId { get; }

    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public DateTime CreateDate { get; }
    public string ReferenceLink { get; set; }

    public TestPlan(string domainId, string shortDescription, string longDescription, DateTime createDate, string referenceLink)
    {
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        CreateDate = createDate;
        ReferenceLink = referenceLink;
    }

    public TestPlan(long id, string domainId, string shortDescription, string longDescription, DateTime createDate, string referenceLink)
    {
        Id = id;
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        CreateDate = createDate;
        ReferenceLink = referenceLink;
    }

    public override string ToString()
    {
        return DomainId;
    }
}