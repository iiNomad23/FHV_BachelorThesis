using Domain.enums;

namespace Domain;

public class TestCase
{
    public long Id { get; }
    public string DomainId { get; }
    
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public string AuthorDescription { get; }
    public DateTime CreateDate { get; }
    public Priority Priority { get; set; }
    public string ReferenceLink { get; set; }

    public TestCase(string domainId, string shortDescription, string longDescription, string authorDescription, DateTime createDate, Priority priority, string referenceLink)
    {
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        AuthorDescription = authorDescription;
        CreateDate = createDate;
        Priority = priority;
        ReferenceLink = referenceLink;
    }
    
    public TestCase(long id, string domainId, string shortDescription, string longDescription, string authorDescription, DateTime createDate, Priority priority, string referenceLink)
    {
        Id = id;
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        AuthorDescription = authorDescription;
        CreateDate = createDate;
        Priority = priority;
        ReferenceLink = referenceLink;
    }

    public override string ToString()
    {
        return DomainId;
    }
}