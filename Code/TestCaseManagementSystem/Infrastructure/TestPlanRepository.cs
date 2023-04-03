using Domain;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class TestPlanRepository : ITestPlanRepository
{
    private readonly EFContext _context;

    public TestPlanRepository(EFContext context)
    {
        _context = context;
    }

    public string NextIdentity() {
        return Guid.NewGuid().ToString();
    }

    public async Task<TestPlan> GetById(int id)
    {
        var testPlan = await _context.TestPlans.FirstOrDefaultAsync(testCase => testCase.Id == id);

        if (testPlan == null)
        {
            throw new ArgumentNullException(null, "Test case is null: " + id);
        }
        
        return testPlan;
    }

    public async Task<List<TestPlan>> GetAll()
    {
        return await _context.TestPlans.ToListAsync();
    }

    public async Task Add(TestPlan testPlan)
    {
        await _context.TestPlans.AddAsync(testPlan);
        await _context.SaveChangesAsync();
    }

    public async Task Remove(string id)
    {
        // Query the database to retrieve the entity you want to delete
        var testPlan = _context.TestPlans.FirstOrDefault(entity => entity.DomainId == id);
        
        if (testPlan != null)
        {
            // Remove the entity from the DbSet
            _context.TestPlans.Remove(testPlan);

            // Save the changes to the database
            await _context.SaveChangesAsync();
        }
    }
}