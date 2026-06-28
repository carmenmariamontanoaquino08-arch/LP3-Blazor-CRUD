namespace LP3.Blazor.Data.Repositories;

public interface IsRepository<T> where T : class
{
	Task<T?> GetByIdAsync(int id);
	Task<IReadOnlyList<T>> ListAsync();
	Task AddAsync(T entity);
	Task Update(T entity);
	Task Remove(T entity);
}