using LP3.Blazor.Domain.Entities;

namespace LP3.Blazor.Data.Repositories;

public interface IEstudianteRepository : IRepository<Estudiante>
{
	Task<Estudiante?> GetByMatriculaAsync(string matricula);
}