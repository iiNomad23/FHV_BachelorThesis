using Domain;
using Domain.enums;
using Domain.ids;

namespace Application.dto;

public class TestCaseDTO
{
    public TestCaseId DomainId { get; private init; }
    public string ShortDescription { get; private init; }
    public string LongDescription { get; private init; }
    public string AuthorDescription { get; private init; }
    public DateTime CreateDate { get; private init; }
    public Priority Priority { get; private init; }
    public string ReferenceLink { get; private init; }

    public static TestCaseDTO FromTestCase(TestCase testCase)
    {
        return new TestCaseDTO
        {
            DomainId = testCase.DomainId,
            ShortDescription = testCase.ShortDescription,
            LongDescription = testCase.LongDescription,
            AuthorDescription = testCase.AuthorDescription,
            CreateDate = testCase.CreateDate,
            Priority = testCase.Priority,
            ReferenceLink = testCase.ReferenceLink
        };
    }
}