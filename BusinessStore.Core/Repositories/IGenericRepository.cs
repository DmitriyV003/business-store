using System.Collections.ObjectModel;
using BusinessStore.Data.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BusinessStore.Data.Repositories;

public interface IGenericRepository<T> where T : BaseModel
{
    public Task<ICollection<T>> GetAllAsync();
    public Task SaveAsync();
    public Task<T?> GetById(long id);
    public bool IsExists(Func<T, bool> predicate);
    public Task<EntityEntry<T>> AddAsync(T entity);
}