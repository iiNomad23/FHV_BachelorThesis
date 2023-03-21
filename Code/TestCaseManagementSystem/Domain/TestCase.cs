﻿using Domain.enums;
using Domain.ids;

namespace Domain;

public class TestCase
{
    public long Id { get; }
    public TestCaseId DomainId { get; }
    
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public string AuthorDescription { get; }
    public DateTime CreateDate { get; }
    public Priority Priority { get; set; }
    public string ReferenceLink { get; set; }

    public TestCase(TestCaseId domainId, string shortDescription, string longDescription, string authorDescription, DateTime createDate, Priority priority, string referenceLink)
    {
        DomainId = domainId;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        AuthorDescription = authorDescription;
        CreateDate = createDate;
        Priority = priority;
        ReferenceLink = referenceLink;
    }
    
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