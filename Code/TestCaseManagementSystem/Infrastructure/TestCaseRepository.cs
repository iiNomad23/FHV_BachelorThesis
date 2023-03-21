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
    
    public async Task<TestCase> GetById(int id)
    {
        var testCase = await _context.TestCases.FirstOrDefaultAsync(testCase => testCase.Id == id);

        if (testCase == null)
        {
            throw new ArgumentNullException(null, "Test case is null: " + id);
        }
        
        return testCase;
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

    public async Task Update(TestCase testCase)
    {
        _context.TestCases.Update(testCase);
        await _context.SaveChangesAsync();
    }

    public async Task Remove(TestCase testCase)
    {
        _context.TestCases.Remove(testCase);
        await _context.SaveChangesAsync();
    }
}