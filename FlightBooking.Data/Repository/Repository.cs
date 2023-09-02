using FlightBooking.Data.Contexts;
using FlightBooking.Data.IRepository;
using FlightBooking.Domain.Commons;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FlightBooking.Data.Repository;
public class Repository<T> : IRepository<T> where T : Auditable
{
    private readonly DbSet<T> dbSet;
    private readonly AppDbContext appDbContext;
    public Repository(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
        this.dbSet = appDbContext.Set<T>();
    }
    public async Task AddAsync(T entity)
    {
        await dbSet.AddAsync(entity);
    }

    public void Detrive(T entity)
    {
        dbSet.Remove(entity);
    }

    public void Remove(T entity)
    {
        entity.IsDeleted = true;
    }

    public void Modify(T entity)
    {
        appDbContext.Entry(entity).State = EntityState.Modified;
    }
    public IEnumerable<T> GetAll(Expression<Func<T, bool>> expression = null, bool isNoTracked = true, string[] includes = null)
    {
        IQueryable<T> query = expression is null ? dbSet.AsQueryable() : dbSet.Where(expression);

        query = isNoTracked ? query.AsNoTracking() : query;

        if (includes is not null)
            foreach (var include in includes)
                query = query.Include(include);

        return query;
    }

    public async Task<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null)
    {
        IQueryable<T> query = dbSet.Where(expression);

        if (includes is not null)
            foreach (var include in includes)
                query = query.Include(include);

        var result = await query.FirstOrDefaultAsync();

        return result;
    }

    public async Task SaveAsync()
    {
        await appDbContext.SaveChangesAsync();
    }
}
