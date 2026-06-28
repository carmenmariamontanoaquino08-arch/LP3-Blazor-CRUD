using Microsoft.EntityFrameworkCore;

namespace LP3.BlazorServer.Data.Repositories;

public class CursoRepositorio : ICursoRepositorio
{
	private readonly ApplicationDbContext _context;
	private readonly DbSet<Curso> _set;

	public CursoRepositorio(ApplicationDbContext context)
	{
		_context = context;
		_set = context.Set<Curso>();
	}

	public async Task<Curso?> GetByIdAsync(int id) => await _set.FindAsync(id);
	
	public async Task<IReadOnlyList<Curso>> ListAsync() => await _set.AsNoTracking().ToListAsync();
	
	public async Task AddAsync(Curso entity)
	{
		await _set.AddAsync(entity);
		await _context.SaveChangesAsync();
	}

	public async Task Update(Curso entity)
	{
		_set.Update(entity);
		await _context.SaveChangesAsync();
	}

	public async Task Remove(Curso entity)
	{
		_set.Remove(entity);
		await _context.SaveChangesAsync();
	}
}