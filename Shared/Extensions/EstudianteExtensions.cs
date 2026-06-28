using Microsoft.EntityFrameworkCore;
using LP3.Blazor.Domain.Entities;

namespace LP3.Blazor.Data.Repositories;

public class EstudianteRepository(ApplicationDbContext context) : Repository<Estudiante>(context), IEstudianteRepository
{
	public async Task<Estudiante?> GetByMatriculaAsync(string matricula)
	{
		return await context.Estudiantes
			.AsNoTracking()
			.FirstOrDefaultAsync(e => e.Matricula == matricula);
	}
}