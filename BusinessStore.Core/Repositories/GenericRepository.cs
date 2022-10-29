using BusinessStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BusinessStore.Data.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
{
    protected readonly DbSet<T> _dbSet;
    protected readonly ApplicationContext _context;

    public GenericRepository(ApplicationContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<ICollection<T>> GetAllAsync()
    {
        return await _dbSet.AsNoTracking().ToListAsync();
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task<T?> GetById(long id)
    {
        return await _dbSet.FindAsync(id);
    }
    
    public bool IsExists(Func<T, bool> predicate)
    {
        return _dbSet.Where(predicate).Any();
    }
    
    public async Task<EntityEntry<T>> AddAsync(T entity)
    {
        return await _dbSet.AddAsync(entity);
    }
}
