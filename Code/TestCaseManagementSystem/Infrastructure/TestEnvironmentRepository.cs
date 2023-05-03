using Domain;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class TestEnvironmentRepository : ITestEnvironmentRepository
{
    private readonly EFContext _context;
    
    public TestEnvironmentRepository(EFContext context)
    {
        _context = context;
    }
    
    public string NextIdentity()
    {
        return Guid.NewGuid().ToString();
    }

    public async Task<TestEnvironment> FindById(string id)
    {
        var testEnvironment = await _context.TestEnvironments
            .Include(te => te.TestSystems)
            .Include(tp => tp.TestPlans)
            .FirstOrDefaultAsync(testEnvironment => testEnvironment.DomainId == id);

        if (testEnvironment == null)
        {
            throw new ArgumentNullException(null, "Test environment is null: " + id);
        }

        return testEnvironment;
    }

    public async Task<List<TestEnvironment>> FindByShortDescription(string shortDescription)
    {
        return await _context.TestEnvironments
            .Where(testEnvironment => EF.Functions.Like(testEnvironment.ShortDescription, "%" + shortDescription + "%"))
            .ToListAsync();
    }

    public async Task<List<TestEnvironment>> GetAll()
    {
        return await _context.TestEnvironments.ToListAsync();
    }

    public async Task Add(TestEnvironment testEnvironment)
    {
        await _context.TestEnvironments.AddAsync(testEnvironment);
        await _context.SaveChangesAsync();
    }

    public async Task Remove(string id)
    {
        // Query the database to retrieve the entity you want to delete
        var testEnvironment = await _context.TestEnvironments.FirstOrDefaultAsync(entity => entity.DomainId == id);

        if (testEnvironment != null)
        {
            // Remove the entity from the DbSet
            _context.TestEnvironments.Remove(testEnvironment);

            // Save the changes to the database
            await _context.SaveChangesAsync();
        }
    }

    public async Task Update(TestEnvironment testEnvironment)
    {
        _context.Entry(testEnvironment).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}