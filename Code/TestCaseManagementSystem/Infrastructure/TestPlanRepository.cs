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

    public async Task<TestPlan> FindById(string id)
    {
        var testPlan = await _context.TestPlans.FirstOrDefaultAsync(testPlan => testPlan.DomainId == id);

        if (testPlan == null)
        {
            throw new ArgumentNullException(null, "Test plan is null: " + id);
        }
        
        return testPlan;
    }
    
    public async Task<List<TestPlan>> FindByIdSet(string[] ids)
    {
        var testPlans = await _context.TestPlans
            .Where(p => ids.Contains(p.DomainId))
            .ToListAsync();

        if (testPlans.Count <= 0)
        {
            throw new ArgumentNullException(null, "TestEnvironment: has no TestPlans of ids" + ids);
        }
        
        return testPlans;
    }
    
    public async Task<List<TestPlan>> FindByShortDescription(string shortDescription)
    {
       return await _context.TestPlans
            .Where(testPlan => EF.Functions.Like(testPlan.ShortDescription, "%" + shortDescription + "%"))
            .ToListAsync();
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