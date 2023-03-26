using System.ComponentModel.DataAnnotations;
using Domain;
using Domain.enums;
using Domain.ids;

namespace Application.dto;

public class TestCaseDTO
{
    [Required]
    public string Id { get; private init; }
    
    [Required]
    [StringLength(200)]
    public string ShortDescription { get; private init; }
    
    public string LongDescription { get; private init; }
    
    [Required]
    [StringLength(50)]
    public string AuthorDescription { get; private init; }
    
    [Required]
    public Priority Priority { get; private init; }
    
    public string ReferenceLink { get; private init; }

    public static TestCaseDTO FromTestCase(TestCase testCase)
    {
        return new TestCaseDTO
        {
            Id = testCase.DomainId.ToString(),
            ShortDescription = testCase.ShortDescription,
            LongDescription = testCase.LongDescription,
            AuthorDescription = testCase.AuthorDescription,
            Priority = testCase.Priority,
            ReferenceLink = testCase.ReferenceLink
        };
    }
}