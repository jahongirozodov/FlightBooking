using FlightBooking.Domain.Commons;
using System.Linq.Expressions;

namespace FlightBooking.Data.IRepository;

public interface IRepository<T> where T: Auditable
{
    Task AddAsync(T entity);
    void Modify(T entity);
    void Remove(T entity);
    void Detrive(T  entity);
    Task<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null);
    IEnumerable<T> GetAll(Expression<Func<T, bool>> expression = null, bool isNoTracked = true, string[] includes = null);
    Task SaveAsync();
}
