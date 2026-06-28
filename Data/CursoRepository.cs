using Microsoft.EntityFrameworkCore;
using LP3.Blazor.Domain.Entities;

namespace LP3.Blazor.Data.Repositories;

public class CursoRepository(ApplicationDbContext context) : ICursoRepository
{
    public async Task<ICollection<Curso>> GetAll()
    {
        return await context.Cursos.ToListAsync();
    }

    public async Task<Curso?> GetById(int id)
    {
        return await context.Cursos.FindAsync(id);
    }

    public async Task Add(Curso curso)
    {
        context.Cursos.Add(curso);
        await context.SaveChangesAsync();
    }

    public async Task Update(Curso curso)
    {
        context.Cursos.Update(curso);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var curso = await context.Cursos.FindAsync(id);

        if (curso != null)
        {
            context.Cursos.Remove(curso);
            await context.SaveChangesAsync();
        }
    }
}