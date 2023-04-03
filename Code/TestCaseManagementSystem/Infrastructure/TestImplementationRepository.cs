using Domain;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class TestImplementationRepository : ITestImplementationRepository
{
    private readonly EFContext _context;

    public TestImplementationRepository(EFContext context)
    {
        _context = context;
    }
    
    public string NextIdentity()
    {
        return Guid.NewGuid().ToString();
    }

    public async Task<TestImplementation> GetById(int id)
    {
        var testImplementation = await _context.TestImplementations.FirstOrDefaultAsync(testImplementation => testImplementation.Id == id);

        if (testImplementation == null)
        {
            throw new ArgumentNullException(null, "Test case is null: " + id);
        }
        
        return testImplementation;
    }

    public async Task<List<TestImplementation>> GetAll()
    {
        return await _context.TestImplementations.ToListAsync();
    }

    public async Task Add(TestImplementation testImplementation)
    {
        await _context.TestImplementations.AddAsync(testImplementation);
        await _context.SaveChangesAsync();
    }

    public async Task Remove(string id)
    {
        // Query the database to retrieve the entity you want to delete
        var testImplementation = _context.TestImplementations.FirstOrDefault(entity => entity.DomainId == id);
        
        if (testImplementation != null)
        {
            // Remove the entity from the DbSet
            _context.TestImplementations.Remove(testImplementation);

            // Save the changes to the database
            await _context.SaveChangesAsync();
        }
    }
}