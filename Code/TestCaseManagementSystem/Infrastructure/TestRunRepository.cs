using Domain;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class TestRunRepository : ITestRunRepository
{
    private readonly EFContext _context;

    public TestRunRepository(EFContext context)
    {
        _context = context;
    }
    
    public string NextIdentity()
    {
        return Guid.NewGuid().ToString();
    }

    public async Task<TestRun> FindById(string id)
    {
        var testRun = await _context.TestRuns.FirstOrDefaultAsync(testPlan => testPlan.DomainId == id);

        if (testRun == null)
        {
            throw new ArgumentNullException(null, "Test run is null: " + id);
        }
        
        return testRun;
    }

    public async Task<List<TestRun>> FindByTestSystemId(string testSystemId)
    {
        var testRuns = await _context.TestRuns
            .Where(tr => tr.TestSystemId == testSystemId)
            .ToListAsync();

        return testRuns;
    }

    public async Task<List<TestRun>> GetAll()
    {
        return await _context.TestRuns.ToListAsync();
    }

    public async Task Add(TestRun testRun)
    {
        await _context.TestRuns.AddAsync(testRun);
        await _context.SaveChangesAsync();
    }
}