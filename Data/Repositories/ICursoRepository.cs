using LP3.Blazor.Domain.Entities;

namespace LP3.Blazor.Data.Repositories
{
public interface ICursoRepository
{
    Task<ICollection<Curso>> GetAll();
    Task<Curso?> GetById(int id);
    Task Add(Curso curso);
    Task Update(Curso curso);
    Task Delete(int id);
}
}