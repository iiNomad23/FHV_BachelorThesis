using Domain.enums;
using Domain.ids;

namespace Domain;

public class TestCase
{
    private long Id { get; }
    private TestCaseId DomainId { get; }
    
    private string ShortDescription { get; set; }
    private string LongDescription { get; set; }
    private string AuthorDescription { get; }
    private DateTime CreateDate { get; }
    private Priority Priority { get; set; }
    private string ReferenceLink { get; set; }

    public TestCase(long id, TestCaseId domainId, string shortDescription, string longDescription, string authorDescription, DateTime createDate, Priority priority, string referenceLink)
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
        return DomainId.ToString();
    }
}