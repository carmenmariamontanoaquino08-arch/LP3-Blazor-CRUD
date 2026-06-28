using LP3.BlazorServer.Domain.Entities;

namespace LP3.BlazorServer.Data.Repositories;

public interface ICursoRepository
{
    Task<ICollection<Curso>> GetAll();
    Task<Curso?> GetById(int id);
    Task Add(Curso curso);
    Task Update(Curso curso);
    Task Delete(int id);
}