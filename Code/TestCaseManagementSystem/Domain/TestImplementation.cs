namespace Domain;

public class TestImplementation
{
    public long Id { get; }
    public string DomainId { get; }
    
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public string AuthorDescription { get; }
    public DateTime CreateDate { get; }
    public string ReferenceLink { get; set; }

    public TestImplementation(string domainId, string shortDescription, string longDescription, string authorDescription, DateTime createDate, string referenceLink)
    {
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        AuthorDescription = authorDescription;
        CreateDate = createDate;
        ReferenceLink = referenceLink;
    }
    
    public TestImplementation(long id, string domainId, string shortDescription, string longDescription, string authorDescription, DateTime createDate, string referenceLink)
    {
        Id = id;
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        AuthorDescription = authorDescription;
        CreateDate = createDate;
        ReferenceLink = referenceLink;
    }

    public override string ToString()
    {
        return DomainId;
    }
}