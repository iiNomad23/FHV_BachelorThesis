using Domain;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class TestCaseRepository : ITestCaseRepository
{
    private readonly EFContext _context;

    public TestCaseRepository(EFContext context)
    {
        _context = context;
    }

    public string NextIdentity()
    {
        return Guid.NewGuid().ToString();
    }

    public async Task<TestCase> FindById(string id)
    {
        var testCase = await _context.TestCases.FirstOrDefaultAsync(testCase => testCase.DomainId == id);

        if (testCase == null)
        {
            throw new ArgumentNullException(null, "Test case is null: " + id);
        }

        return testCase;
    }

    public async Task<List<TestCase>> FindByShortDescription(string shortDescription)
    {
        return await _context.TestCases
            .Where(testCase => EF.Functions.Like(testCase.ShortDescription, "%" + shortDescription + "%"))
            .ToListAsync();
    }

    public async Task<List<TestCase>> GetAll()
    {
        return await _context.TestCases.ToListAsync();
    }

    public async Task Add(TestCase testCase)
    {
        await _context.TestCases.AddAsync(testCase);
        await _context.SaveChangesAsync();
    }

    public async Task Remove(string id)
    {
        // Query the database to retrieve the entity you want to delete
        var testCase = await _context.TestCases.FirstOrDefaultAsync(entity => entity.DomainId == id);

        if (testCase != null)
        {
            // Remove the entity from the DbSet
            _context.TestCases.Remove(testCase);

            // Save the changes to the database
            await _context.SaveChangesAsync();
        }
    }
}